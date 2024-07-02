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
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;
using System.Collections.Specialized;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Drawing.Imaging;
using Image = System.Drawing.Image;

namespace ClpView
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

		private Image image;


		public MainForm()
		{
			InitializeComponent();

			textBox.CurrentLineColor = btHighlightCurrentLine.Checked ? currentLineColor : Color.Transparent;
			textBox.ShowFoldingLines = btShowFoldingLines.Checked;
			//copyToolStripButton.Enabled = !toolObserveClipboard.Checked;
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

		private void textBox_SelectionChanged(object sender, EventArgs e)
		{
			setStatusLabel();
		}

		private void setStatusLabel()
		{
			int lnStart = textBox.Selection.Bounds.iStartLine;
			int lnEnd = textBox.Selection.Bounds.iEndLine;
			int chStart = textBox.Selection.Bounds.iStartChar;
			int chEnd = textBox.Selection.Bounds.iEndChar;
			int selLen = textBox.Selection.Length;
			statusLabel.Text = String.Format("Ln: {{{0},{1}}}, Ch: {{{2},{3}}}, Sel: {4}", lnStart, lnEnd, chStart, chEnd, selLen);
		}

		private void fctb_SelectionChangedDelayed(object sender, EventArgs e)
		{
			textBox.VisibleRange.ClearStyle(SameWordsStyle);
			setStatusLabel();
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

		private void textBox_CustomAction(object sender, CustomActionEventArgs e)
		{
			if(e.Action.ToString() == "CustomAction1")
				ToggleBookmark(textBox.Selection.Start.iLine);

			else if (e.Action.ToString() == "CustomAction2")
			{
				toolFindNext_Click(sender, e);
			}

			else if (e.Action.ToString() == "CustomAction3")
			{
				toolFindNextSelected_Click(sender, e);
			}

			else if (e.Action.ToString() == "CustomAction4")
			{
				toolFindPrevious_Click(sender, e);
			}

			else if (e.Action.ToString() == "CustomAction5")
			{
				toolFindPreviousSelected_Click(sender, e);
			}

			//MessageBox.Show(e.Action.ToString());
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

		private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
		{
			//Clipboard.SetFileDropList(new StringCollection{e.FullPath });
			Clipboard.SetFileDropList(Clipboard.GetFileDropList());
		}

		private void pasteFromClipboard(ClipboardType ct)
		{
			switch (ct)
			{
				case ClipboardType.Image:
					{
						pasteImage(Clipboard.GetImage());
						break;
					}
				case ClipboardType.File:
					{
						var cnt = getContentFromClipboardFiles();
						if (!(cnt.txt is null))
							pasteText(cnt.txt);
						if (!(cnt.img is null))
							pasteImage(cnt.img);
						break;
					}
				default:
					{
						string text = getTextFromClipboard(ct);
						pasteText(text);
						break;
					}
			}
		}

		private void clipboardChanged(object sender, SharpClipboard.ClipboardChangedEventArgs e)
		{
			textBox.Bookmarks.Clear();
			fileSystemWatcher.EnableRaisingEvents = false;

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

			pasteFromClipboard(ct);


			if (ct == ClipboardType.File && Clipboard.GetFileDropList().Count == 1)
			{
				var filePath = Clipboard.GetFileDropList().Cast<string>().First();
				var dirPath = Path.GetDirectoryName(filePath);
				fileSystemWatcher.Filter = Path.GetFileName(filePath);
				fileSystemWatcher.Path= dirPath;
				fileSystemWatcher.EnableRaisingEvents = true;
			}
		}

		private (String txt, Image img) getContentFromClipboardFiles()
		{
			String text = null;
			Image image = null;
			List<String> imagePaths = Clipboard.GetFileDropList()
				.OfType<String>()
				.ToList()
				.FindAll(fp => IsImageExtension(Path.GetExtension(fp)));

			if (imagePaths.Any())
			{
				int totalWidth = 0;
				int totalHeight = 0;
				List<Image> images = new List<Image>(imagePaths.Count);
				foreach (string imagePath in imagePaths)
				{
					Image img = Image.FromFile(imagePath);
					if(img.HorizontalResolution != 96)
					{
						var bmp = new Bitmap(img);
						bmp.SetResolution(96,96);
						images.Add(bmp);
					}
					else
					{
						images.Add(img);
					}
					totalHeight += img.Height;
					totalWidth = Math.Max(totalWidth, img.Width);
				}

				// Create a bitmap with the total dimensions
				Bitmap finalImage = new Bitmap(totalWidth, totalHeight);
				using(Graphics graphics = Graphics.FromImage(finalImage))
				{
					//SolidBrush blueBrush = new SolidBrush(Color.Blue);
					//graphics.FillRectangle(blueBrush, 0, 0, totalWidth, totalHeight);
					int currentHeight = 0;

					// Append each image vertically
					foreach (Image img in images)
					{
						//Pen blackPen = new Pen(Color.Black, 3); ;
						//graphics.DrawRectangle(blackPen, 0, currentHeight, img.Width, img.Height);
						graphics.DrawImage(img, 0, currentHeight);
						currentHeight += img.Height;
						img.Dispose();
					}

					image = finalImage;
				}
			}
			else
			{
				foreach (var fp in Clipboard.GetFileDropList())
					text += File.ReadAllText(fp);
			}

			return (text, image);
		}

		static bool IsImageExtension(string extension)
		{
			string[] imageExtensions = { ".bmp", ".gif", ".jpg", ".jpeg", ".png", ".ico" };
			return Array.Exists(imageExtensions, ext => ext.Equals(extension, StringComparison.OrdinalIgnoreCase));
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

						var encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

						var documentOptions = new JsonDocumentOptions { AllowTrailingCommas = true, CommentHandling = JsonCommentHandling.Skip };
						using (JsonDocument doc = System.Text.Json.JsonDocument.Parse(text, documentOptions))
						{
							var writerOptions = new JsonWriterOptions() { Indented = true, Encoder = encoder  };
							using(var stream = new MemoryStream())
							{
								using (var writer = new Utf8JsonWriter(stream, writerOptions))
								{
									doc.WriteTo(writer);
									writer.Flush();
									text = Encoding.UTF8.GetString(stream.ToArray());
								}
							}
						}
						break;
				}
			}
			catch (System.Exception)
			{

			}
			return text;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			//this.textBox.Text = String.Empty;
			//if (Keyboard.IsKeyDown(Key.LeftShift))
			//	return;

			this.documentMap.Size = Properties.Settings.Default.DocumentMapSize;
			this.textBox.Zoom = Properties.Settings.Default.Zoom;

			this.Location = Properties.Settings.Default.AppLocation;
			this.Size = Properties.Settings.Default.AppSize;
			this.WindowState = Properties.Settings.Default.AppState;

			ToolStripManager.LoadSettings(this, "Toolbars");
			// this botch is necessary, because the LoadSettings is little buggy
			if (menuStrip.Parent == this) // first load, without config. Build two lines of toolbars
			{
				menuStrip.Parent = toolStripContainer.TopToolStripPanel;
				tsMain.Parent = toolStripContainer.TopToolStripPanel;
				tsView.Parent = toolStripContainer.TopToolStripPanel;
				tsFolding.Location = new Point(tsView.Location.X + tsView.Size.Width, tsView.Location.Y);
				tsFolding.Parent = toolStripContainer.TopToolStripPanel;
				tsBookmark.Location = new Point(tsFolding.Location.X + tsFolding.Size.Width, tsView.Location.Y);
				tsBookmark.Parent = toolStripContainer.TopToolStripPanel;
				this.toolStripContainer.ResumeLayout(true);
			}
		}

		private void MainForm_Closing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.AppState = this.WindowState;
			Properties.Settings.Default.DocumentMapSize = this.documentMap.Size;
			Properties.Settings.Default.Zoom = this.textBox.Zoom;


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

			ToolStripManager.SaveSettings(this, "Toolbars");
			// don't forget to save the settings
			Properties.Settings.Default.Save();
		}

		private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MainForm_Closing(null, null);
		}

		private void loadSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MainForm_Load(null, null);
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
			fileSystemWatcher.EnableRaisingEvents = false;
			sharpClipboard.MonitorClipboard = toolObserveClipboard.Checked;
			//copyToolStripButton.Enabled = !toolObserveClipboard.Checked;
			pasteToolStripButton.Enabled = !toolObserveClipboard.Checked;

			if (toolObserveClipboard.Checked)
			{
				toolObserveClipboard.Image = global::ClpView.Properties.Resources.eye;
				ClipboardType ct = getClipboardType();
				pasteFromClipboard(ct);
			}
			else
			{
				toolObserveClipboard.Image = global::ClpView.Properties.Resources.eye_blind;
			}
		}

		private ClipboardType getClipboardType()
		{
				ClipboardType ct = ClipboardType.Unknown;
				if (Clipboard.ContainsFileDropList())
					ct = ClipboardType.File;
				else if (Clipboard.ContainsText())
					ct = ClipboardType.Text;
				else if (Clipboard.ContainsImage())
					ct = ClipboardType.Image;
				return ct;
		}

		private void copyToolStripButton_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBox.SelectedText))
			{
				if(!(textBox.Text is null))
					Clipboard.SetText(textBox.Text);
			}
			else
			{
				String text = textBox.SelectedText;
				if (toolObserveClipboard.Checked)
				{
					toolObserveClipboard.Checked = false;
					toolObserveClipboard_Click(null, null);
				}
				Clipboard.SetText(text);
			}
		}

		private void pasteText(string text)
		{
			this.image = null;
			textBox.Text = text;
		}
		private void pasteImage(System.Drawing.Image image)
		{
			this.image = image;
			textBox.Text = null;
			textBox.Invalidate();
		}


		private void pasteToolStripButton_Click(object sender, EventArgs e)
		{
			if(tbFind.Focused && Clipboard.ContainsText())
			{
				tbFind.Text = Clipboard.GetText();
			}
			else
			{
				ClipboardType ct = getClipboardType();
				pasteFromClipboard(ct);
			}
		}

		private void btAddBookmark_Click(object sender, EventArgs e)
		{
			textBox.Bookmarks.Add(textBox.Selection.Start.iLine);
		}

		private void btRemoveBookmark_Click(object sender, EventArgs e)
		{
			textBox.Bookmarks.Remove(textBox.Selection.Start.iLine);
		}

		private void btGo_DropDownOpening(object sender, EventArgs e)
		{
			btGo.DropDownItems.Clear();
			foreach (var bookmark in textBox.Bookmarks)
			{
				string name = textBox.Lines[bookmark.LineIndex];
				ToolStripItem item = btGo.DropDownItems.Add(name.Substring(0, Math.Min(name.Length, 80)));
				item.Tag = bookmark;
				item.Click += (o, a) => ((Bookmark)(o as ToolStripItem).Tag).DoVisible();
			}
		}

		private void textBox_DoubleClick(object sender, MouseEventArgs e)
		{
			if (e.X < textBox.LeftIndent)
			{
				//var place = textBox.PointToPlace(e.Location);
				//var iLine = place.iLine;
				//ToggleBookmark(iLine);
				ToggleBookmark(textBox.Selection.Start.iLine);
			}
		}

		private void ToggleBookmark(int iLine)
		{
			if (textBox.Bookmarks.Contains(iLine))
				textBox.Bookmarks.Remove(iLine);
			else
				textBox.Bookmarks.Add(iLine);
		}

		private void btNextBookmark_Click(object sender, EventArgs e)
		{
			textBox.GotoNextBookmark(textBox.Selection.Start.iLine);
		}

		private void btPreviousBookmark_Click(object sender, EventArgs e)
		{
			textBox.GotoPrevBookmark(textBox.Selection.Start.iLine);
		}

		private void tsClearBookmarks_Click(object sender, EventArgs e)
		{
			textBox.Bookmarks.Clear();
			textBox.Invalidate();
		}

		private bool tbFindChanged = false;
		private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				string findText = tbFind.Text;
				Range range = tbFindChanged ? textBox.Range.Clone() : textBox.Selection.Clone();
				tbFindChanged = false;
				bool found = FindNextPattern(findText, range);
				if (!found)
					MessageBox.Show("Not found.");
			}
			else
				tbFindChanged = true;
		}

		private bool FindNextPattern(string findText, Range range)
		{
			range.End = new Place(textBox[textBox.LinesCount - 1].Count, textBox.LinesCount - 1);
			var pattern = Regex.Escape(findText);
			foreach (var f in range.GetRanges(pattern))
			{
				f.Inverse();
				textBox.Selection = f;
				textBox.DoSelectionVisible();
				return true;
			}

			return false;
		}

		private bool FindPreviousPattern(string findText, Range range)
		{
			 range = new Range(textBox, 0, 0, range.Start.iChar, range.Start.iLine );
			var pattern = Regex.Escape(findText);
			var ranges = range.GetRanges(pattern).ToList();
			ranges.Reverse();
			foreach (var f in ranges)
			{
				f.Inverse();
				textBox.Selection = f;
				textBox.DoSelectionVisible();
				return true;
			}

			return false;
		}

		private void toolFindNext_Click(object sender, EventArgs e)
		{
			string findText = tbFind.Text;

			Range range = textBox.Selection.Clone();
			bool found = FindNextPattern(findText, range);
			if(!found)
			{
				range = textBox.Range.Clone();
				FindNextPattern(findText, range);
			}
		}

		private void toolFindNextSelected_Click(object sender, EventArgs e)
		{
			string findText = tbFind.Text;
			if(findText != textBox.Selection.Text)
				findText = tbFind.Text = textBox.Selection.Text;

			Range range = textBox.Selection.Clone();
			bool found = FindNextPattern(findText, range);
			if(!found)
			{
				range = textBox.Range.Clone();
				FindNextPattern(findText, range);
			}
		}

		private void toolFindPrevious_Click(object sender, EventArgs e)
		{
			string findText = tbFind.Text;

			Range range = textBox.Selection.Clone();
			range.Normalize();
			bool found = FindPreviousPattern(findText, range);
			if(!found)
			{
				range = textBox.Range.Clone();
				range.Normalize();
				range.Start = range.End;
				FindPreviousPattern(findText, range);
			}
		}

		private void toolFindPreviousSelected_Click(object sender, EventArgs e)
		{
			string findText = tbFind.Text;
			if(findText != textBox.Selection.Text)
				findText = tbFind.Text = textBox.Selection.Text;

			Range range = textBox.Selection.Clone();
			range.Normalize();
			bool found = FindPreviousPattern(findText, range);
			if(!found)
			{
				range = textBox.Range.Clone();
				range.Normalize();
				range.Start = range.End;
				FindPreviousPattern(findText, range);
			}
		}

		private void tbContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			mainToolStripMenuItem.Checked = tsMain.Visible;
			bookmarksToolStripMenuItem.Checked = tsBookmark.Visible;
			foldingToolStripMenuItem.Checked = tsFolding.Visible;
			viewToolStripMenuItem.Checked = tsView.Visible;
		}

		private void mainToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tsMain.Visible = !tsMain.Visible;
		}

		private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			tsView.Visible = !tsView.Visible;
		}

		private void bookmarksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tsBookmark.Visible = !tsBookmark.Visible;
		}

		private void foldingToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			tsFolding.Visible = !tsFolding.Visible;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void zoomNormalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.Zoom = 100;
		}

		private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.ChangeFontSize(2);
		}

		private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.ChangeFontSize(-2);
		}

		private void fold5LayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foldNestedLayer(5);

			textBox.OnVisibleRangeChanged();
			textBox.UpdateScrollbars();
		}

		private void fold6LayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foldNestedLayer(6);

			textBox.OnVisibleRangeChanged();
			textBox.UpdateScrollbars();
		}

		private void fold7LayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foldNestedLayer(7);

			textBox.OnVisibleRangeChanged();
			textBox.UpdateScrollbars();
		}

		private void fold8LayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foldNestedLayer(8);

			textBox.OnVisibleRangeChanged();
			textBox.UpdateScrollbars();
		}
	
		private void fold9LayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foldNestedLayer(9);

			textBox.OnVisibleRangeChanged();
			textBox.UpdateScrollbars();
		}

		private void wrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
		{
			ToolStripMenuItem itm = sender as ToolStripMenuItem;
			textBox.WordWrap = itm.Checked;
			textBox.OnVisibleRangeChanged();
			textBox.UpdateScrollbars();
		}

		private void btWordWrap_CheckedChanged(object sender, EventArgs e)
		{
			ToolStripButton btn = sender as ToolStripButton;
			textBox.WordWrap = btn.Checked;
			textBox.OnVisibleRangeChanged();
			textBox.UpdateScrollbars();
		}

		private void textBox_Paint(object sender, PaintEventArgs e)
		{
			if(!(this.image is null))
			{
				var graph = e.Graphics;
				graph.Clear(textBox.BackColor);
				using (var bitmap = new Bitmap(image))
				{
					graph.InterpolationMode = InterpolationMode.HighQualityBicubic;
					bitmap.MakeTransparent();
					graph.DrawImageUnscaled(bitmap, new Point(10, 10));
				}
			}
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
