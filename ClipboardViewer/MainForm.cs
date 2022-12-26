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
using WK.Libraries.SharpClipboardNS;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Input;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace ClVi
{
	public partial class MainForm : Form
	{
		private string _lang = "CSharp";

		//styles
		TextStyle BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
		TextStyle BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
		TextStyle GrayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
		TextStyle MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
		TextStyle GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
		TextStyle BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
		TextStyle MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);
		MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));

		private SharpClipboard _sharpClipboard;


		public MainForm()
		{
			InitializeComponent();

			//AdjustClientWidthToDPIScale();
		}

		private void AdjustClientWidthToDPIScale()
		{
			double dpiKoef = Graphics.FromHdc(GetDC(IntPtr.Zero)).DpiX / 96f;

			int compansatedWidth = (int)(ClientSize.Width * dpiKoef);


			this.ClientSize = new Size(compansatedWidth, this.ClientSize.Height);
		}

		[DllImport("User32.dll")]
		private static extern IntPtr GetDC(IntPtr hWnd);

		private void InitStylesPriority()
		{
			//add this style explicitly for drawing under other styles
			_textBox.AddStyle(SameWordsStyle);
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
				mi.Checked = mi.Text == _lang;
		}

		private void miCSharp_Click(object sender, EventArgs e)
		{
			//set language
			_lang = (sender as ToolStripMenuItem).Text;
			setLanguage();
		}

		private void textBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			if(_textBox.Text.Length > 0)
			{
				_lang = getLanguageFromText(_textBox.Text.Substring(0, Math.Min(_textBox.Text.Length, 500)));
				setLanguage();
			}
		}

		private static string getLanguageFromText(string text)
		{
			string lang = "CSharp";
			Regex xmlRx = new Regex(@"^<");
			Regex jsonRx = new Regex(@"^[{[]");

			if (xmlRx.Match(text.Trim()).Success)
				{
				lang = "XML";
			}
			else if (jsonRx.Match(text.Trim()).Success)
			{
				lang = "JSON";
			}

			return lang;
		}

		private void setLanguage()
		{
			_textBox.ClearStylesBuffer();
			_textBox.Range.ClearStyle(StyleIndex.All);
			InitStylesPriority();
			_textBox.AutoIndentNeeded -= textBox_AutoIndentNeeded;
			//
			switch (_lang)
			{
				case "CSharp": _textBox.Language = Language.CSharp; break;
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
		}

		private void collapseSelectedBlockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_textBox.CollapseBlock(_textBox.Selection.Start.iLine, _textBox.Selection.End.iLine);
		}

		private void collapseAllregionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//this example shows how to collapse all #region blocks (C#)
			if (!_lang.StartsWith("CSharp")) return;
			for (int iLine = 0; iLine < _textBox.LinesCount; iLine++)
			{
				if (_textBox[iLine].FoldingStartMarker == @"#region\b")//marker @"#region\b" was used in SetFoldingMarkers()
					_textBox.CollapseFoldingBlock(iLine);
			}
		}

		private void exapndAllregionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//this example shows how to expand all #region blocks (C#)
			if (!_lang.StartsWith("CSharp")) return;
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
			if (ranges.Length > 1)
				foreach (var r in ranges)
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

		private void textBox_AutoIndentNeeded(object sender, AutoIndentEventArgs args)
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
			if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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

		private void clipboardChanged(object sender, SharpClipboard.ClipboardChangedEventArgs e)
		{
			string text = String.Empty;
			try
			{

				switch (e.ContentType)
				{
					case SharpClipboard.ContentTypes.Text:
						text = _sharpClipboard.ClipboardText;
						break;

					case SharpClipboard.ContentTypes.Files:

						text = File.ReadAllText(_sharpClipboard.ClipboardFile);
						break;
				}


				_lang = getLanguageFromText(text.Substring(0, Math.Min(text.Length, 500)));
	
				switch (_lang)
				{
					//case "CSharp": _textBox.Language = Language.CSharp;
					//	break;
					//case "VB": _textBox.Language = Language.VB;
					//	break;
					//case "HTML": _textBox.Language = Language.HTML; 
					//	break;
					case "XML":
						text = System.Xml.Linq.XDocument.Parse(text).ToString();
						break;
					//case "SQL": _textBox.Language = Language.SQL; 
					//	break;
					//case "PHP": _textBox.Language = Language.PHP; 
					//	break;
					//case "JS": _textBox.Language = Language.JS; 
					//	break;
					//case "Lua": _textBox.Language = Language.Lua; 
					//	break;
					case "JSON":
						var serializerOptions = new JsonSerializerOptions { WriteIndented = true };
						var documentOptions = new JsonDocumentOptions { AllowTrailingCommas = true };
						using (var doc = System.Text.Json.JsonDocument.Parse(text, documentOptions))
						{
							text = JsonSerializer.Serialize(doc, serializerOptions);
						}
						break;
				}
			}
			catch (System.Exception ex)
			{
				
			}
			finally
			{
				_textBox.Text = text;
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			_textBox.Text = String.Empty;
			//if (Keyboard.IsKeyDown(Key.LeftShift))
			//	return;

			this.WindowState = Properties.Settings.Default.AppState;
			this.Location = Properties.Settings.Default.AppLocation;
			this.Size = Properties.Settings.Default.AppSize;
		}

		private void MainForm_Closing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.AppState = this.WindowState;
			if (this.WindowState == FormWindowState.Normal)
			{
				// save location and size if the state is normal
				Properties.Settings.Default.AppLocation = this.Location;
				Properties.Settings.Default.AppSize = this.Size;
			}
			else
			{
				// save the RestoreBounds if the form is minimized or maximized!
				Properties.Settings.Default.AppLocation = this.RestoreBounds.Location;
				Properties.Settings.Default.AppSize = this.RestoreBounds.Size;
			}

			// don't forget to save the settings
			Properties.Settings.Default.Save();
		}

		private void foldAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//for (int i = _textBox.LinesCount - 1; i >= 0; i--)
			//{
			//	if (_textBox.TextSource.LineHasFoldingStartMarker(i))
			//		_textBox.CollapseFoldingBlock(i);
			//}
			Dictionary<int, List<int>> nestedFoldingMarkers = getNesteFoldingMarkerDictionary();

			var layers = nestedFoldingMarkers.Keys.ToList();
			layers.RemoveAt(0); // Top layer not
			layers.Reverse();   // Backwards

			foreach (int i in layers)
				foldNestedLayer(i);

			_textBox.OnVisibleRangeChanged();
			_textBox.UpdateScrollbars();
		}

		private void unfoldAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_textBox.ExpandAllFoldingBlocks();
		}

		private void foldNestedLayer(int layer)
		{
			Dictionary<int, List<int>> nestedFoldingMarkers = getNesteFoldingMarkerDictionary();

			if (nestedFoldingMarkers.ContainsKey(layer))
			{
				foreach (int i in nestedFoldingMarkers[layer])
					_textBox.CollapseFoldingBlock(i);
			}
		}

		private Dictionary<int, List<int>> getNesteFoldingMarkerDictionary()
		{
			Dictionary<int, List<int>> nestedFoldingMarkers = new Dictionary<int, List<int>>();
			int nesting = 0;
			for (int i = 0; i < _textBox.LinesCount; i++)
			{
				if (_textBox.TextSource.LineHasFoldingStartMarker(i))
				{
					if (nestedFoldingMarkers.ContainsKey(nesting))
						nestedFoldingMarkers[nesting].Add(i);
					else
						nestedFoldingMarkers.Add(nesting, new List<int> { i });

					nesting++;
				}
				if (_textBox.TextSource.LineHasFoldingEndMarker(i))
					nesting--;
			}

			return nestedFoldingMarkers;
		}
		private void fold1LayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foldNestedLayer(1);

			_textBox.OnVisibleRangeChanged();
			_textBox.UpdateScrollbars();
		}

		private void fold2LayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foldNestedLayer(2);

			_textBox.OnVisibleRangeChanged();
			_textBox.UpdateScrollbars();
		}

		private void fold3LayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foldNestedLayer(3);

			_textBox.OnVisibleRangeChanged();
			_textBox.UpdateScrollbars();
		}

		private void fold4LayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foldNestedLayer(4);

			_textBox.OnVisibleRangeChanged();
			_textBox.UpdateScrollbars();
		}

		private void _documentMap_Click(object sender, EventArgs e)
		{

		}

		private void tbFind_Click(object sender, EventArgs e)
		{

		}
	}
}
