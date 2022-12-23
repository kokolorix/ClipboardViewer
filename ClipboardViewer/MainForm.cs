using System;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using FastColoredTextBoxNS;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ClVi
{
    public partial class MainForm : Form
    {
        string lang = "CSharp (custom highlighter)";

        //styles
        TextStyle BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        TextStyle BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
        TextStyle GrayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
        TextStyle MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
        TextStyle GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        TextStyle BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
        TextStyle MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);
        MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitStylesPriority()
        {           
            //add this style explicitly for drawing under other styles
            _textBox.AddStyle(SameWordsStyle);
        }
        
        private void fctb_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (lang)
            {
                case "CSharp (custom highlighter)":
                    //For sample, we will highlight the syntax of C# manually, although could use built-in highlighter
                    CSharpSyntaxHighlight(e);//custom highlighting
                    break;
                default:
                    break;//for highlighting of other languages, we using built-in FastColoredTextBox highlighter
            }

            if (_textBox.Text.Trim().StartsWith("<?xml"))
            {
                _textBox.Language = Language.XML;

                _textBox.ClearStylesBuffer();
                _textBox.Range.ClearStyle(StyleIndex.All);
                InitStylesPriority();
                _textBox.AutoIndentNeeded -= fctb_AutoIndentNeeded;

                _textBox.OnSyntaxHighlight(new TextChangedEventArgs(_textBox.Range));
            }
        }   

        private void CSharpSyntaxHighlight(TextChangedEventArgs e)
        {
            _textBox.LeftBracket = '(';
            _textBox.RightBracket = ')';
            _textBox.LeftBracket2 = '\x0';
            _textBox.RightBracket2 = '\x0';
            //clear style of changed range
            e.ChangedRange.ClearStyle(BlueStyle, BoldStyle, GrayStyle, MagentaStyle, GreenStyle, BrownStyle);

            //string highlighting
            e.ChangedRange.SetStyle(BrownStyle, @"""""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'");
            //comment highlighting
            e.ChangedRange.SetStyle(GreenStyle, @"//.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            e.ChangedRange.SetStyle(GreenStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline|RegexOptions.RightToLeft);
            //number highlighting
            e.ChangedRange.SetStyle(MagentaStyle, @"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b");
            //attribute highlighting
            e.ChangedRange.SetStyle(GrayStyle, @"^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline);
            //class name highlighting
            e.ChangedRange.SetStyle(BoldStyle, @"\b(class|struct|enum|interface)\s+(?<range>\w+?)\b");
            //keyword highlighting
            e.ChangedRange.SetStyle(BlueStyle, @"\b(abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\b|#region\b|#endregion\b");

            //clear folding markers
            e.ChangedRange.ClearFoldingMarkers();

            //set folding markers
            e.ChangedRange.SetFoldingMarkers("{", "}");//allow to collapse brackets block
            e.ChangedRange.SetFoldingMarkers(@"#region\b", @"#endregion\b");//allow to collapse #region blocks
            e.ChangedRange.SetFoldingMarkers(@"/\*", @"\*/");//allow to collapse comment block
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textBox.ShowFindDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textBox.ShowReplaceDialog();
        }

        private void miLanguage_DropDownOpening(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem mi in miLanguage.DropDownItems)
                mi.Checked = mi.Text == lang;
        }

        private void miCSharp_Click(object sender, EventArgs e)
        {
            //set language
            lang = (sender as ToolStripMenuItem).Text;
            _textBox.ClearStylesBuffer();
            _textBox.Range.ClearStyle(StyleIndex.All);
            InitStylesPriority();
            _textBox.AutoIndentNeeded -= fctb_AutoIndentNeeded;
            //
            switch (lang)
            {
                //For example, we will highlight the syntax of C# manually, although could use built-in highlighter
                case "CSharp (custom highlighter)":
                    _textBox.Language = Language.Custom;
                    _textBox.CommentPrefix = "//";
                    _textBox.AutoIndentNeeded += fctb_AutoIndentNeeded;
                    //call OnTextChanged for refresh syntax highlighting
                    _textBox.OnTextChanged();
                    break;
                case "CSharp (built-in highlighter)": _textBox.Language = Language.CSharp; break;
                case "VB": _textBox.Language = Language.VB; break;
                case "HTML": _textBox.Language = Language.HTML; break;
                case "XML": _textBox.Language = Language.XML; break;
                case "SQL": _textBox.Language = Language.SQL; break;
                case "PHP": _textBox.Language = Language.PHP; break;
                case "JS": _textBox.Language = Language.JS; break;
                case "Lua": _textBox.Language = Language.Lua; break;
                case "JSON": _textBox.Language = Language.JSON; break;
            }
            _textBox.OnSyntaxHighlight(new TextChangedEventArgs(_textBox.Range));
            miChangeColors.Enabled = lang != "CSharp (custom highlighter)";
        }

        private void collapseSelectedBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textBox.CollapseBlock(_textBox.Selection.Start.iLine, _textBox.Selection.End.iLine);
        }

        private void collapseAllregionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this example shows how to collapse all #region blocks (C#)
            if (!lang.StartsWith("CSharp")) return;
            for (int iLine = 0; iLine < _textBox.LinesCount; iLine++)
            {
                if (_textBox[iLine].FoldingStartMarker == @"#region\b")//marker @"#region\b" was used in SetFoldingMarkers()
                    _textBox.CollapseFoldingBlock(iLine);
            }
        }

        private void exapndAllregionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this example shows how to expand all #region blocks (C#)
            if (!lang.StartsWith("CSharp")) return;
            for (int iLine = 0; iLine < _textBox.LinesCount; iLine++)
            {
                if (_textBox[iLine].FoldingStartMarker == @"#region\b")//marker @"#region\b" was used in SetFoldingMarkers()
                    _textBox.ExpandFoldedBlock(iLine);
            }
        }

        private void increaseIndentSiftTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textBox.IncreaseIndent();
        }

        private void decreaseIndentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textBox.DecreaseIndent();
        }

        private void hTMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML with <PRE> tag|*.html|HTML without <PRE> tag|*.html";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string html = "";

                if (sfd.FilterIndex == 1)
                {
                    html = _textBox.Html;
                }
                if (sfd.FilterIndex == 2)
                {
                    
                    ExportToHTML exporter = new ExportToHTML();
                    exporter.UseBr = true;
                    exporter.UseNbsp = false;
                    exporter.UseForwardNbsp = true;
                    exporter.UseStyleTag = true;
                    html = exporter.GetHtml(_textBox);
                }
                File.WriteAllText(sfd.FileName, html);
            }
        }

        private void fctb_SelectionChangedDelayed(object sender, EventArgs e)
        {
            _textBox.VisibleRange.ClearStyle(SameWordsStyle);
            if (!_textBox.Selection.IsEmpty)
                return;//user selected diapason

            //get fragment around caret
            var fragment = _textBox.Selection.GetFragment(@"\w");
            string text = fragment.Text;
            if (text.Length == 0)
                return;
            //highlight same words
            var ranges = _textBox.VisibleRange.GetRanges("\\b" + text + "\\b").ToArray();
            if(ranges.Length>1)
            foreach(var r in ranges)
                r.SetStyle(SameWordsStyle);
        }

        private void goForwardCtrlShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textBox.NavigateForward();
        }

        private void goBackwardCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textBox.NavigateBackward();
        }

        private void autoIndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textBox.DoAutoIndent();
        }

        const int maxBracketSearchIterations = 2000;

        void GoLeftBracket(FastColoredTextBox tb, char leftBracket, char rightBracket)
        {
            Range range = tb.Selection.Clone();//need to clone because we will move caret
            int counter = 0;
            int maxIterations = maxBracketSearchIterations;
            while (range.GoLeftThroughFolded())//move caret left
            {
                if (range.CharAfterStart == leftBracket) counter++;
                if (range.CharAfterStart == rightBracket) counter--;
                if (counter == 1)
                {
                    //found
                    tb.Selection.Start = range.Start;
                    tb.DoSelectionVisible();
                    break;
                }
                //
                maxIterations--;
                if (maxIterations <= 0) break;
            }
            tb.Invalidate();
        }

        void GoRightBracket(FastColoredTextBox tb, char leftBracket, char rightBracket)
        {
            var range = tb.Selection.Clone();//need clone because we will move caret
            int counter = 0;
            int maxIterations = maxBracketSearchIterations;
            do
            {
                if (range.CharAfterStart == leftBracket) counter++;
                if (range.CharAfterStart == rightBracket) counter--;
                if (counter == -1)
                {
                    //found
                    tb.Selection.Start = range.Start;
                    tb.Selection.GoRightThroughFolded();
                    tb.DoSelectionVisible();
                    break;
                }
                //
                maxIterations--;
                if (maxIterations <= 0) break;
            } while (range.GoRightThroughFolded());//move caret right

            tb.Invalidate();
        }

        private void goLeftBracketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLeftBracket(_textBox, '{', '}');
        }

        private void goRightBracketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoRightBracket(_textBox, '{', '}');
        }

        private void fctb_AutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            //block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{.*\}[^""']*$"))
                return;
            //start of block {}
            if (Regex.IsMatch(args.LineText, @"^[^""']*\{"))
            {
                args.ShiftNextLines = args.TabLength;
                return;
            }
            //end of block {}
            if (Regex.IsMatch(args.LineText, @"}[^""']*$"))
            {
                args.Shift = -args.TabLength;
                args.ShiftNextLines = -args.TabLength;
                return;
            }
            //label
            if (Regex.IsMatch(args.LineText, @"^\s*\w+\s*:\s*($|//)") &&
                !Regex.IsMatch(args.LineText, @"^\s*default\s*:"))
            {
                args.Shift = -args.TabLength;
                return;
            }
            //some statements: case, default
            if (Regex.IsMatch(args.LineText, @"^\s*(case|default)\b.*:\s*($|//)"))
            {
                args.Shift = -args.TabLength / 2;
                return;
            }
            //is unclosed operator in previous line ?
            if (Regex.IsMatch(args.PrevLineText, @"^\s*(if|for|foreach|while|[\}\s]*else)\b[^{]*$"))
                if (!Regex.IsMatch(args.PrevLineText, @"(;\s*$)|(;\s*//)"))//operator is unclosed
                {
                    args.Shift = args.TabLength;
                    return;
                }
        }

        private void miPrint_Click(object sender, EventArgs e)
        {
            _textBox.Print(new PrintDialogSettings() { ShowPrintPreviewDialog = true });
        }

        Random rnd = new Random();

        private void miChangeColors_Click(object sender, EventArgs e)
        {
            var styles = new Style[] { _textBox.SyntaxHighlighter.BlueBoldStyle, _textBox.SyntaxHighlighter.BlueStyle, _textBox.SyntaxHighlighter.BoldStyle, _textBox.SyntaxHighlighter.BrownStyle, _textBox.SyntaxHighlighter.GrayStyle, _textBox.SyntaxHighlighter.GreenStyle, _textBox.SyntaxHighlighter.MagentaStyle, _textBox.SyntaxHighlighter.MaroonStyle, _textBox.SyntaxHighlighter.RedStyle };
            _textBox.SyntaxHighlighter.AttributeStyle = styles[rnd.Next(styles.Length)];
            _textBox.SyntaxHighlighter.ClassNameStyle = styles[rnd.Next(styles.Length)];
            _textBox.SyntaxHighlighter.CommentStyle = styles[rnd.Next(styles.Length)];
            _textBox.SyntaxHighlighter.CommentTagStyle = styles[rnd.Next(styles.Length)];
            _textBox.SyntaxHighlighter.KeywordStyle = styles[rnd.Next(styles.Length)];
            _textBox.SyntaxHighlighter.NumberStyle = styles[rnd.Next(styles.Length)];
            _textBox.SyntaxHighlighter.StringStyle = styles[rnd.Next(styles.Length)];

            _textBox.OnSyntaxHighlight(new TextChangedEventArgs(_textBox.Range));
        }

        private void setSelectedAsReadonlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textBox.Selection.ReadOnly = true;
        }

        private void setSelectedAsWritableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textBox.Selection.ReadOnly = false;
        }

        private void startStopMacroRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textBox.MacrosManager.IsRecording = !_textBox.MacrosManager.IsRecording;
        }

        private void executeMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textBox.MacrosManager.ExecuteMacros();
        }

        private void changeHotkeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HotkeysEditorForm(_textBox.HotkeysMapping);
            if(form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                _textBox.HotkeysMapping = form.GetHotkeys();
        }

        private void rTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "RTF|*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string rtf = _textBox.Rtf;
                File.WriteAllText(sfd.FileName, rtf);
            }
        }

        private void fctb_CustomAction(object sender, CustomActionEventArgs e)
        {
            MessageBox.Show(e.Action.ToString());
        }

        private void commentSelectedLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textBox.InsertLinePrefix(_textBox.CommentPrefix);
        }

        private void uncommentSelectedLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _textBox.RemoveLinePrefix(_textBox.CommentPrefix);
        }

		private void fctb_Load(object sender, EventArgs e)
		{
         Text = _textBox.Text;
		}
	}
}
