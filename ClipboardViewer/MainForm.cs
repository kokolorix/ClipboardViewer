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
		Style invisibleCharsStyle = new InvisibleCharsRenderer(Pens.Gray);
		Color currentLineColor = Color.Orange;

		private SharpClipboard sharpClipboard;


		public MainForm()
		{
			InitializeComponent();

			textBox.CurrentLineColor = btHighlightCurrentLine.Checked ? currentLineColor : Color.Transparent;
			textBox.ShowFoldingLines = btShowFoldingLines.Checked;
			copyToolStripButton.Enabled = !toolObserveClipboard.Checked;
			pasteToolStripButton.Enabled = !toolObserveClipboard.Checked;
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
			textBox.AddStyle(SameWordsStyle);
		}

		private void findToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.ShowFindDialog();
		}

		private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.ShowReplaceDialog();
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
			if(textBox.Text.Length > 0)
			{
				_lang = getLanguageFromText(textBox.Text.Substring(0, Math.Min(textBox.Text.Length, 500)));
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
			textBox.ClearStylesBuffer();
			textBox.Range.ClearStyle(StyleIndex.All);
			InitStylesPriority();
			textBox.AutoIndentNeeded -= textBox_AutoIndentNeeded;
			//
			switch (_lang)
			{
				case "CSharp": textBox.Language = Language.CSharp; break;
				case "VB": textBox.Language = Language.VB; break;
				case "HTML": textBox.Language = Language.HTML; break;
				case "XML": textBox.Language = Language.XML; break;
				case "SQL": textBox.Language = Language.SQL; break;
				case "PHP": textBox.Language = Language.PHP; break;
				case "JS": textBox.Language = Language.JS; break;
				case "Lua": textBox.Language = Language.Lua; break;
				case "JSON": textBox.Language = Language.JSON; break;
			}
			textBox.OnSyntaxHighlight(new TextChangedEventArgs(textBox.Range));
		}

		private void collapseSelectedBlockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.CollapseBlock(textBox.Selection.Start.iLine, textBox.Selection.End.iLine);
		}

		private void collapseAllregionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//this example shows how to collapse all #region blocks (C#)
			if (!_lang.StartsWith("CSharp")) return;
			for (int iLine = 0; iLine < textBox.LinesCount; iLine++)
			{
				if (textBox[iLine].FoldingStartMarker == @"#region\b")//marker @"#region\b" was used in SetFoldingMarkers()
					textBox.CollapseFoldingBlock(iLine);
			}
		}

		private void exapndAllregionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//this example shows how to expand all #region blocks (C#)
			if (!_lang.StartsWith("CSharp")) return;
			for (int iLine = 0; iLine < textBox.LinesCount; iLine++)
			{
				if (textBox[iLine].FoldingStartMarker == @"#region\b")//marker @"#region\b" was used in SetFoldingMarkers()
					textBox.ExpandFoldedBlock(iLine);
			}
		}

		private void increaseIndentSiftTabToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.IncreaseIndent();
		}

		private void decreaseIndentTabToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.DecreaseIndent();
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
					html = textBox.Html;
				}
				if (sfd.FilterIndex == 2)
				{

					ExportToHTML exporter = new ExportToHTML();
					exporter.UseBr = true;
					exporter.UseNbsp = false;
					exporter.UseForwardNbsp = true;
					exporter.UseStyleTag = true;
					html = exporter.GetHtml(textBox);
				}
				File.WriteAllText(sfd.FileName, html);
			}
		}

		private void fctb_SelectionChangedDelayed(object sender, EventArgs e)
		{
			textBox.VisibleRange.ClearStyle(SameWordsStyle);
			if (!textBox.Selection.IsEmpty)
				return;//user selected diapason

			//get fragment around caret
			var fragment = textBox.Selection.GetFragment(@"\w");
			string text = fragment.Text;
			if (text.Length == 0)
				return;
			//highlight same words
			var ranges = textBox.VisibleRange.GetRanges("\\b" + text + "\\b").ToArray();
			if (ranges.Length > 1)
				foreach (var r in ranges)
					r.SetStyle(SameWordsStyle);
		}

		private void goForwardCtrlShiftToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.NavigateForward();
		}

		private void goBackwardCtrlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.NavigateBackward();
		}

		private void autoIndentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.DoAutoIndent();
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
			GoLeftBracket(textBox, '{', '}');
		}

		private void goRightBracketToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GoRightBracket(textBox, '{', '}');
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
			textBox.Print(new PrintDialogSettings() { ShowPrintPreviewDialog = true });
		}

		Random rnd = new Random();

		private void miChangeColors_Click(object sender, EventArgs e)
		{
			var styles = new Style[] { textBox.SyntaxHighlighter.BlueBoldStyle, textBox.SyntaxHighlighter.BlueStyle, textBox.SyntaxHighlighter.BoldStyle, textBox.SyntaxHighlighter.BrownStyle, textBox.SyntaxHighlighter.GrayStyle, textBox.SyntaxHighlighter.GreenStyle, textBox.SyntaxHighlighter.MagentaStyle, textBox.SyntaxHighlighter.MaroonStyle, textBox.SyntaxHighlighter.RedStyle };
			textBox.SyntaxHighlighter.AttributeStyle = styles[rnd.Next(styles.Length)];
			textBox.SyntaxHighlighter.ClassNameStyle = styles[rnd.Next(styles.Length)];
			textBox.SyntaxHighlighter.CommentStyle = styles[rnd.Next(styles.Length)];
			textBox.SyntaxHighlighter.CommentTagStyle = styles[rnd.Next(styles.Length)];
			textBox.SyntaxHighlighter.KeywordStyle = styles[rnd.Next(styles.Length)];
			textBox.SyntaxHighlighter.NumberStyle = styles[rnd.Next(styles.Length)];
			textBox.SyntaxHighlighter.StringStyle = styles[rnd.Next(styles.Length)];

			textBox.OnSyntaxHighlight(new TextChangedEventArgs(textBox.Range));
		}

		private void setSelectedAsReadonlyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.Selection.ReadOnly = true;
		}

		private void setSelectedAsWritableToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.Selection.ReadOnly = false;
		}

		private void startStopMacroRecordingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.MacrosManager.IsRecording = !textBox.MacrosManager.IsRecording;
		}

		private void executeMacroToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.MacrosManager.ExecuteMacros();
		}

		private void changeHotkeysToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new HotkeysEditorForm(textBox.HotkeysMapping);
			if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				textBox.HotkeysMapping = form.GetHotkeys();
		}

		private void rTFToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "RTF|*.rtf";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				string rtf = textBox.Rtf;
				File.WriteAllText(sfd.FileName, rtf);
			}
		}

		private void fctb_CustomAction(object sender, CustomActionEventArgs e)
		{
			MessageBox.Show(e.Action.ToString());
		}

		private void commentSelectedLinesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.InsertLinePrefix(textBox.CommentPrefix);
		}

		private void uncommentSelectedLinesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.RemoveLinePrefix(textBox.CommentPrefix);
		}

		private enum ClipboardType
		{
			Unknown = 0,
			Text = 1,
			File = 2,
			Image = 3,
		}

		private void clipboardChanged(object sender, SharpClipboard.ClipboardChangedEventArgs e)
		{
			ClipboardType ct = ClipboardType.Unknown;

			switch (e.ContentType)
			{
				case SharpClipboard.ContentTypes.Text:
					ct = ClipboardType.Text;
					break;

				case SharpClipboard.ContentTypes.Files:
					ct = ClipboardType.File;
					break;

				case SharpClipboard.ContentTypes.Image:
					ct = ClipboardType.Image;
					break;
			}

			string text = getTextFromClipboard(ct);
			textBox.Text = text;
		}

		private string getTextFromClipboard(ClipboardType ct)
		{
			string text = String.Empty;
			try
			{

				switch (ct)
				{
					case ClipboardType.Text:
						text = Clipboard.GetText();
						break;

					case ClipboardType.File:
						foreach(var fp in Clipboard.GetFileDropList())
						{
							text += File.ReadAllText(fp);
						}
						
						break;
				}


				_lang = getLanguageFromText(text.Substring(0, Math.Min(text.Length, 500)));

				switch (_lang)
				{
					//case "CSharp": textBox.Language = Language.CSharp;
					//	break;
					//case "VB": textBox.Language = Language.VB;
					//	break;
					//case "HTML": textBox.Language = Language.HTML; 
					//	break;
					case "XML":
						text = System.Xml.Linq.XDocument.Parse(text).ToString();
						break;
					//case "SQL": textBox.Language = Language.SQL; 
					//	break;
					//case "PHP": textBox.Language = Language.PHP; 
					//	break;
					//case "JS": textBox.Language = Language.JS; 
					//	break;
					//case "Lua": textBox.Language = Language.Lua; 
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
			return text;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.textBox.Text = String.Empty;
			//if (Keyboard.IsKeyDown(Key.LeftShift))
			//	return;

			this.WindowState = Properties.Settings.Default.AppState;
			this.Location = Properties.Settings.Default.AppLocation;
			this.Size = Properties.Settings.Default.AppSize;
			this.documentMap.Size = Properties.Settings.Default.DocumentMapSize;
		}

		private void MainForm_Closing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.AppState = this.WindowState;
			Properties.Settings.Default.DocumentMapSize = this.documentMap.Size;
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
			//for (int i = textBox.LinesCount - 1; i >= 0; i--)
			//{
			//	if (textBox.TextSource.LineHasFoldingStartMarker(i))
			//		textBox.CollapseFoldingBlock(i);
			//}
			Dictionary<int, List<int>> nestedFoldingMarkers = getNesteFoldingMarkerDictionary();

			var layers = nestedFoldingMarkers.Keys.ToList();
			layers.RemoveAt(0); // Top layer not
			layers.Reverse();   // Backwards

			foreach (int i in layers)
				foldNestedLayer(i);

			textBox.OnVisibleRangeChanged();
			textBox.UpdateScrollbars();
		}

		private void unfoldAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.ExpandAllFoldingBlocks();
		}

		private void foldNestedLayer(int layer)
		{
			Dictionary<int, List<int>> nestedFoldingMarkers = getNesteFoldingMarkerDictionary();

			if (nestedFoldingMarkers.ContainsKey(layer))
			{
				foreach (int i in nestedFoldingMarkers[layer])
					textBox.CollapseFoldingBlock(i);
			}
		}

		private Dictionary<int, List<int>> getNesteFoldingMarkerDictionary()
		{
			Dictionary<int, List<int>> nestedFoldingMarkers = new Dictionary<int, List<int>>();
			int nesting = 0;
			for (int i = 0; i < textBox.LinesCount; i++)
			{
				if (textBox.TextSource.LineHasFoldingStartMarker(i))
				{
					if (nestedFoldingMarkers.ContainsKey(nesting))
						nestedFoldingMarkers[nesting].Add(i);
					else
						nestedFoldingMarkers.Add(nesting, new List<int> { i });

					nesting++;
				}
				if (textBox.TextSource.LineHasFoldingEndMarker(i))
					nesting--;
			}

			return nestedFoldingMarkers;
		}
		private void fold1LayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foldNestedLayer(1);

			textBox.OnVisibleRangeChanged();
			textBox.UpdateScrollbars();
		}

		private void fold2LayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foldNestedLayer(2);

			textBox.OnVisibleRangeChanged();
			textBox.UpdateScrollbars();
		}

		private void fold3LayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foldNestedLayer(3);

			textBox.OnVisibleRangeChanged();
			textBox.UpdateScrollbars();
		}

		private void fold4LayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foldNestedLayer(4);

			textBox.OnVisibleRangeChanged();
			textBox.UpdateScrollbars();
		}

		private void _documentMap_Click(object sender, EventArgs e)
		{

		}

		private void tbFind_Click(object sender, EventArgs e)
		{

		}

		private void documentMap1_Resize(object sender, EventArgs e)
		{
			documentMap.Scale = ((float)documentMap.Width) / ((float)400);
		}

		private void btInvisibleChars_Click(object sender, EventArgs e)
		{
			HighlightInvisibleChars(this.textBox.Range);
			this.textBox.Invalidate();
		}


		private void HighlightInvisibleChars(Range range)
		{
			range.ClearStyle(invisibleCharsStyle);
			if (btInvisibleChars.Checked)
				range.SetStyle(invisibleCharsStyle, @".$|.\r\n|\s");
		}

		private void btHighlightCurrentLine_Click(object sender, EventArgs e)
		{
			textBox.CurrentLineColor = btHighlightCurrentLine.Checked ? currentLineColor : Color.Transparent;
		}

		private void btShowFoldingLines_Click(object sender, EventArgs e)
		{
			textBox.ShowFoldingLines = btShowFoldingLines.Checked;
		}

		private void undoStripButton_Click(object sender, EventArgs e)
		{
			textBox.Undo();
		}

		private void redoStripButton_Click(object sender, EventArgs e)
		{
			textBox.Redo();
		}

		private void toolObserveClipboard_Click(object sender, EventArgs e)
		{
			sharpClipboard.MonitorClipboard = toolObserveClipboard.Checked;
			copyToolStripButton.Enabled = !toolObserveClipboard.Checked;
			pasteToolStripButton.Enabled = !toolObserveClipboard.Checked;

			if (toolObserveClipboard.Checked)
			{
				toolObserveClipboard.Image = global::ClVi.Properties.Resources.eye;
				textBox.Text = getClipboardText();
			}
			else
			{
				toolObserveClipboard.Image = global::ClVi.Properties.Resources.eye_blind;
			}
		}

		private string getClipboardText()
		{
			ClipboardType ct = ClipboardType.Unknown;
			if (Clipboard.ContainsFileDropList())
				ct = ClipboardType.File;
			else if (Clipboard.ContainsText())
				ct = ClipboardType.Text;
			else if (Clipboard.ContainsImage())
				ct = ClipboardType.Image;
			return getTextFromClipboard(ct);
		}

		private void copyToolStripButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(textBox.Text);
		}

		private void pasteToolStripButton_Click(object sender, EventArgs e)
		{
			textBox.Text = getClipboardText();
		}
	}

	public class InvisibleCharsRenderer : Style
	{
		Pen pen;

		public InvisibleCharsRenderer(Pen pen)
		{
			this.pen = pen;
		}

		public override void Draw(Graphics gr, Point position, Range range)
		{
			var tb = range.tb;
			using (Brush brush = new SolidBrush(pen.Color))
				foreach (var place in range)
				{
					switch (tb[place].c)
					{
						case ' ':
							var point = tb.PlaceToPoint(place);
							point.Offset(tb.CharWidth / 2, tb.CharHeight / 2);
							gr.DrawLine(pen, point.X, point.Y, point.X + 1, point.Y);
							break;
					}

					if (tb[place.iLine].Count - 1 == place.iChar)
					{
						var point = tb.PlaceToPoint(place);
						point.Offset(tb.CharWidth, 0);
						gr.DrawString("¶", tb.Font, brush, point);
					}
				}
		}
	}

}
