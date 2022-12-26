using ClVi.Properties;
using FastColoredTextBoxNS;
using System;
using WK.Libraries.SharpClipboardNS;

namespace ClVi
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this._sharpClipboard = new WK.Libraries.SharpClipboardNS.SharpClipboard(this.components);
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.textBox = new FastColoredTextBoxNS.FastColoredTextBox();
			this.splitter = new System.Windows.Forms.Splitter();
			this.documentMap = new FastColoredTextBoxNS.DocumentMap();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.setSelectedAsReadonlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setSelectedAsWritableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
			this.collapseSelectedBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.collapseAllregionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exapndAllregionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.increaseIndentSiftTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.decreaseIndentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
			this.commentSelectedLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uncommentSelectedLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.goBackwardCtrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.goForwardCtrlShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.autoIndentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.goLeftBracketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.goRightBracketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.miPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
			this.startStopMacroRecordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.executeMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miLanguage = new System.Windows.Forms.ToolStripMenuItem();
			this.cSharpbuiltinHighlighterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miVB = new System.Windows.Forms.ToolStripMenuItem();
			this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.luaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.foldingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unfoldAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.foldAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fold1LayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fold2LayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fold3LayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fold4LayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMain = new System.Windows.Forms.ToolStrip();
			this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.btInvisibleChars = new System.Windows.Forms.ToolStripButton();
			this.btHighlightCurrentLine = new System.Windows.Forms.ToolStripButton();
			this.btShowFoldingLines = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.undoStripButton = new System.Windows.Forms.ToolStripButton();
			this.redoStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.backStripButton = new System.Windows.Forms.ToolStripButton();
			this.forwardStripButton = new System.Windows.Forms.ToolStripButton();
			this.tbFind = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.bookmarkPlusButton = new System.Windows.Forms.ToolStripButton();
			this.bookmarkMinusButton = new System.Windows.Forms.ToolStripButton();
			this.gotoButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textBox)).BeginInit();
			this.menuStrip.SuspendLayout();
			this.tsMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// _sharpClipboard
			// 
			this._sharpClipboard.MonitorClipboard = true;
			this._sharpClipboard.ObservableFormats.All = true;
			this._sharpClipboard.ObservableFormats.Files = true;
			this._sharpClipboard.ObservableFormats.Images = true;
			this._sharpClipboard.ObservableFormats.Others = true;
			this._sharpClipboard.ObservableFormats.Texts = true;
			this._sharpClipboard.ObserveLastEntry = true;
			this._sharpClipboard.Tag = null;
			this._sharpClipboard.ClipboardChanged += new System.EventHandler<WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs>(this.clipboardChanged);
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.textBox);
			this.toolStripContainer.ContentPanel.Controls.Add(this.splitter);
			this.toolStripContainer.ContentPanel.Controls.Add(this.documentMap);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(544, 412);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(544, 461);
			this.toolStripContainer.TabIndex = 6;
			this.toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.tsMain);
			// 
			// textBox
			// 
			this.textBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
			this.textBox.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
			this.textBox.AutoIndentExistingLines = false;
			this.textBox.AutoScrollMinSize = new System.Drawing.Size(501, 1890);
			this.textBox.AutoSize = true;
			this.textBox.BackBrush = null;
			this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox.CharHeight = 15;
			this.textBox.CharWidth = 7;
			this.textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox.DefaultMarkerSize = 10;
			this.textBox.DelayedEventsInterval = 200;
			this.textBox.DelayedTextChangedInterval = 500;
			this.textBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox.Font = new System.Drawing.Font("Consolas", 9.75F);
			this.textBox.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.textBox.IsReplaceMode = false;
			this.textBox.Location = new System.Drawing.Point(0, 0);
			this.textBox.Margin = new System.Windows.Forms.Padding(4);
			this.textBox.Name = "textBox";
			this.textBox.Paddings = new System.Windows.Forms.Padding(0);
			this.textBox.ReservedCountOfLineNumberChars = 3;
			this.textBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.textBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("textBox.ServiceColors")));
			this.textBox.Size = new System.Drawing.Size(461, 412);
			this.textBox.TabIndex = 8;
			this.textBox.Text = resources.GetString("textBox.Text");
			this.textBox.Zoom = 100;
			this.textBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.textBox_TextChanged);
			this.textBox.SelectionChangedDelayed += new System.EventHandler(this.fctb_SelectionChangedDelayed);
			this.textBox.AutoIndentNeeded += new System.EventHandler<FastColoredTextBoxNS.AutoIndentEventArgs>(this.textBox_AutoIndentNeeded);
			this.textBox.CustomAction += new System.EventHandler<FastColoredTextBoxNS.CustomActionEventArgs>(this.fctb_CustomAction);
			// 
			// splitter
			// 
			this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter.Location = new System.Drawing.Point(461, 0);
			this.splitter.Name = "splitter";
			this.splitter.Size = new System.Drawing.Size(3, 412);
			this.splitter.TabIndex = 9;
			this.splitter.TabStop = false;
			// 
			// documentMap
			// 
			this.documentMap.Dock = System.Windows.Forms.DockStyle.Right;
			this.documentMap.ForeColor = System.Drawing.Color.Maroon;
			this.documentMap.Location = new System.Drawing.Point(464, 0);
			this.documentMap.Name = "documentMap";
			this.documentMap.Scale = 0.2F;
			this.documentMap.Size = new System.Drawing.Size(80, 412);
			this.documentMap.TabIndex = 10;
			this.documentMap.Target = this.textBox;
			this.documentMap.Text = "documentMap";
			this.documentMap.Resize += new System.EventHandler(this.documentMap1_Resize);
			// 
			// menuStrip
			// 
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.miLanguage,
            this.foldingToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip.Size = new System.Drawing.Size(544, 24);
			this.menuStrip.TabIndex = 10;
			this.menuStrip.Text = "menuStrip";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.toolStripMenuItem1,
            this.setSelectedAsReadonlyToolStripMenuItem,
            this.setSelectedAsWritableToolStripMenuItem,
            this.toolStripMenuItem8,
            this.collapseSelectedBlockToolStripMenuItem,
            this.toolStripMenuItem3,
            this.collapseAllregionToolStripMenuItem,
            this.exapndAllregionToolStripMenuItem,
            this.toolStripMenuItem2,
            this.increaseIndentSiftTabToolStripMenuItem,
            this.decreaseIndentTabToolStripMenuItem,
            this.toolStripMenuItem10,
            this.commentSelectedLinesToolStripMenuItem,
            this.uncommentSelectedLinesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.goBackwardCtrlToolStripMenuItem,
            this.goForwardCtrlShiftToolStripMenuItem,
            this.toolStripMenuItem5,
            this.autoIndentToolStripMenuItem,
            this.toolStripMenuItem6,
            this.goLeftBracketToolStripMenuItem,
            this.goRightBracketToolStripMenuItem,
            this.toolStripMenuItem7,
            this.miPrint,
            this.toolStripMenuItem9,
            this.startStopMacroRecordingToolStripMenuItem,
            this.executeMacroToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(264, 6);
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.findToolStripMenuItem.Text = "&Find [Ctrl+F]";
			this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
			// 
			// replaceToolStripMenuItem
			// 
			this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
			this.replaceToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.replaceToolStripMenuItem.Text = "&Replace [Ctrl+H]";
			this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(264, 6);
			// 
			// setSelectedAsReadonlyToolStripMenuItem
			// 
			this.setSelectedAsReadonlyToolStripMenuItem.Name = "setSelectedAsReadonlyToolStripMenuItem";
			this.setSelectedAsReadonlyToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.setSelectedAsReadonlyToolStripMenuItem.Text = "Set selected as readonly";
			this.setSelectedAsReadonlyToolStripMenuItem.Click += new System.EventHandler(this.setSelectedAsReadonlyToolStripMenuItem_Click);
			// 
			// setSelectedAsWritableToolStripMenuItem
			// 
			this.setSelectedAsWritableToolStripMenuItem.Name = "setSelectedAsWritableToolStripMenuItem";
			this.setSelectedAsWritableToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.setSelectedAsWritableToolStripMenuItem.Text = "Set selected as writable";
			this.setSelectedAsWritableToolStripMenuItem.Click += new System.EventHandler(this.setSelectedAsWritableToolStripMenuItem_Click);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(264, 6);
			// 
			// collapseSelectedBlockToolStripMenuItem
			// 
			this.collapseSelectedBlockToolStripMenuItem.Name = "collapseSelectedBlockToolStripMenuItem";
			this.collapseSelectedBlockToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.collapseSelectedBlockToolStripMenuItem.Text = "Collapse selected block";
			this.collapseSelectedBlockToolStripMenuItem.Click += new System.EventHandler(this.collapseSelectedBlockToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(264, 6);
			// 
			// collapseAllregionToolStripMenuItem
			// 
			this.collapseAllregionToolStripMenuItem.Name = "collapseAllregionToolStripMenuItem";
			this.collapseAllregionToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.collapseAllregionToolStripMenuItem.Text = "Collapse all #region";
			this.collapseAllregionToolStripMenuItem.Click += new System.EventHandler(this.collapseAllregionToolStripMenuItem_Click);
			// 
			// exapndAllregionToolStripMenuItem
			// 
			this.exapndAllregionToolStripMenuItem.Name = "exapndAllregionToolStripMenuItem";
			this.exapndAllregionToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.exapndAllregionToolStripMenuItem.Text = "Exapnd all #region";
			this.exapndAllregionToolStripMenuItem.Click += new System.EventHandler(this.exapndAllregionToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(264, 6);
			// 
			// increaseIndentSiftTabToolStripMenuItem
			// 
			this.increaseIndentSiftTabToolStripMenuItem.Name = "increaseIndentSiftTabToolStripMenuItem";
			this.increaseIndentSiftTabToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.increaseIndentSiftTabToolStripMenuItem.Text = "Increase Indent [Tab]";
			this.increaseIndentSiftTabToolStripMenuItem.Click += new System.EventHandler(this.increaseIndentSiftTabToolStripMenuItem_Click);
			// 
			// decreaseIndentTabToolStripMenuItem
			// 
			this.decreaseIndentTabToolStripMenuItem.Name = "decreaseIndentTabToolStripMenuItem";
			this.decreaseIndentTabToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.decreaseIndentTabToolStripMenuItem.Text = "Decrease Indent [Shift + Tab]";
			this.decreaseIndentTabToolStripMenuItem.Click += new System.EventHandler(this.decreaseIndentTabToolStripMenuItem_Click);
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(264, 6);
			// 
			// commentSelectedLinesToolStripMenuItem
			// 
			this.commentSelectedLinesToolStripMenuItem.Name = "commentSelectedLinesToolStripMenuItem";
			this.commentSelectedLinesToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.commentSelectedLinesToolStripMenuItem.Text = "Comment selected lines";
			this.commentSelectedLinesToolStripMenuItem.Click += new System.EventHandler(this.commentSelectedLinesToolStripMenuItem_Click);
			// 
			// uncommentSelectedLinesToolStripMenuItem
			// 
			this.uncommentSelectedLinesToolStripMenuItem.Name = "uncommentSelectedLinesToolStripMenuItem";
			this.uncommentSelectedLinesToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.uncommentSelectedLinesToolStripMenuItem.Text = "Uncomment selected lines";
			this.uncommentSelectedLinesToolStripMenuItem.Click += new System.EventHandler(this.uncommentSelectedLinesToolStripMenuItem_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(264, 6);
			// 
			// goBackwardCtrlToolStripMenuItem
			// 
			this.goBackwardCtrlToolStripMenuItem.Name = "goBackwardCtrlToolStripMenuItem";
			this.goBackwardCtrlToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.goBackwardCtrlToolStripMenuItem.Text = "Go Backward [Ctrl+ -]";
			this.goBackwardCtrlToolStripMenuItem.Click += new System.EventHandler(this.goBackwardCtrlToolStripMenuItem_Click);
			// 
			// goForwardCtrlShiftToolStripMenuItem
			// 
			this.goForwardCtrlShiftToolStripMenuItem.Name = "goForwardCtrlShiftToolStripMenuItem";
			this.goForwardCtrlShiftToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.goForwardCtrlShiftToolStripMenuItem.Text = "Go Forward [Ctrl+Shift+ -]";
			this.goForwardCtrlShiftToolStripMenuItem.Click += new System.EventHandler(this.goForwardCtrlShiftToolStripMenuItem_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(264, 6);
			// 
			// autoIndentToolStripMenuItem
			// 
			this.autoIndentToolStripMenuItem.Name = "autoIndentToolStripMenuItem";
			this.autoIndentToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.autoIndentToolStripMenuItem.Text = "Auto Indent selected text";
			this.autoIndentToolStripMenuItem.Click += new System.EventHandler(this.autoIndentToolStripMenuItem_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(264, 6);
			// 
			// goLeftBracketToolStripMenuItem
			// 
			this.goLeftBracketToolStripMenuItem.Name = "goLeftBracketToolStripMenuItem";
			this.goLeftBracketToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.goLeftBracketToolStripMenuItem.Text = "Go Left Bracket";
			this.goLeftBracketToolStripMenuItem.Click += new System.EventHandler(this.goLeftBracketToolStripMenuItem_Click);
			// 
			// goRightBracketToolStripMenuItem
			// 
			this.goRightBracketToolStripMenuItem.Name = "goRightBracketToolStripMenuItem";
			this.goRightBracketToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.goRightBracketToolStripMenuItem.Text = "Go Right Bracket";
			this.goRightBracketToolStripMenuItem.Click += new System.EventHandler(this.goRightBracketToolStripMenuItem_Click);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(264, 6);
			// 
			// miPrint
			// 
			this.miPrint.Name = "miPrint";
			this.miPrint.Size = new System.Drawing.Size(267, 22);
			this.miPrint.Text = "Print...";
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(264, 6);
			// 
			// startStopMacroRecordingToolStripMenuItem
			// 
			this.startStopMacroRecordingToolStripMenuItem.Name = "startStopMacroRecordingToolStripMenuItem";
			this.startStopMacroRecordingToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.startStopMacroRecordingToolStripMenuItem.Text = "Start/Stop macro recording [Ctrl+M]";
			this.startStopMacroRecordingToolStripMenuItem.Click += new System.EventHandler(this.startStopMacroRecordingToolStripMenuItem_Click);
			// 
			// executeMacroToolStripMenuItem
			// 
			this.executeMacroToolStripMenuItem.Name = "executeMacroToolStripMenuItem";
			this.executeMacroToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
			this.executeMacroToolStripMenuItem.Text = "Execute macro [Ctrl+E]";
			this.executeMacroToolStripMenuItem.Click += new System.EventHandler(this.executeMacroToolStripMenuItem_Click);
			// 
			// miLanguage
			// 
			this.miLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSharpbuiltinHighlighterToolStripMenuItem,
            this.miVB,
            this.hTMLToolStripMenuItem,
            this.xmlToolStripMenuItem,
            this.sQLToolStripMenuItem,
            this.pHPToolStripMenuItem,
            this.jSToolStripMenuItem,
            this.luaToolStripMenuItem,
            this.jSONToolStripMenuItem});
			this.miLanguage.Name = "miLanguage";
			this.miLanguage.Size = new System.Drawing.Size(71, 20);
			this.miLanguage.Text = "Language";
			this.miLanguage.DropDownOpening += new System.EventHandler(this.miLanguage_DropDownOpening);
			// 
			// cSharpbuiltinHighlighterToolStripMenuItem
			// 
			this.cSharpbuiltinHighlighterToolStripMenuItem.Name = "cSharpbuiltinHighlighterToolStripMenuItem";
			this.cSharpbuiltinHighlighterToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.cSharpbuiltinHighlighterToolStripMenuItem.Text = "CSharp";
			this.cSharpbuiltinHighlighterToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
			// 
			// miVB
			// 
			this.miVB.Name = "miVB";
			this.miVB.Size = new System.Drawing.Size(112, 22);
			this.miVB.Text = "VB";
			this.miVB.Click += new System.EventHandler(this.miCSharp_Click);
			// 
			// hTMLToolStripMenuItem
			// 
			this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
			this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.hTMLToolStripMenuItem.Text = "HTML";
			this.hTMLToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
			// 
			// xmlToolStripMenuItem
			// 
			this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
			this.xmlToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.xmlToolStripMenuItem.Text = "XML";
			this.xmlToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
			// 
			// sQLToolStripMenuItem
			// 
			this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
			this.sQLToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.sQLToolStripMenuItem.Text = "SQL";
			this.sQLToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
			// 
			// pHPToolStripMenuItem
			// 
			this.pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
			this.pHPToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.pHPToolStripMenuItem.Text = "PHP";
			this.pHPToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
			// 
			// jSToolStripMenuItem
			// 
			this.jSToolStripMenuItem.Name = "jSToolStripMenuItem";
			this.jSToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.jSToolStripMenuItem.Text = "JS";
			this.jSToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
			// 
			// luaToolStripMenuItem
			// 
			this.luaToolStripMenuItem.Name = "luaToolStripMenuItem";
			this.luaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.luaToolStripMenuItem.Text = "Lua";
			this.luaToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
			// 
			// jSONToolStripMenuItem
			// 
			this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
			this.jSONToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.jSONToolStripMenuItem.Text = "JSON";
			this.jSONToolStripMenuItem.Click += new System.EventHandler(this.miCSharp_Click);
			// 
			// foldingToolStripMenuItem
			// 
			this.foldingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unfoldAllToolStripMenuItem,
            this.foldAllToolStripMenuItem,
            this.fold1LayerToolStripMenuItem,
            this.fold2LayerToolStripMenuItem,
            this.fold3LayerToolStripMenuItem,
            this.fold4LayerToolStripMenuItem});
			this.foldingToolStripMenuItem.Name = "foldingToolStripMenuItem";
			this.foldingToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.foldingToolStripMenuItem.Text = "Folding";
			// 
			// unfoldAllToolStripMenuItem
			// 
			this.unfoldAllToolStripMenuItem.Name = "unfoldAllToolStripMenuItem";
			this.unfoldAllToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.unfoldAllToolStripMenuItem.Text = "Unfold All";
			this.unfoldAllToolStripMenuItem.Click += new System.EventHandler(this.unfoldAllToolStripMenuItem_Click);
			// 
			// foldAllToolStripMenuItem
			// 
			this.foldAllToolStripMenuItem.Name = "foldAllToolStripMenuItem";
			this.foldAllToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.foldAllToolStripMenuItem.Text = "Fold All";
			this.foldAllToolStripMenuItem.Click += new System.EventHandler(this.foldAllToolStripMenuItem_Click);
			// 
			// fold1LayerToolStripMenuItem
			// 
			this.fold1LayerToolStripMenuItem.Name = "fold1LayerToolStripMenuItem";
			this.fold1LayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.fold1LayerToolStripMenuItem.Text = "Fold 1 layer";
			this.fold1LayerToolStripMenuItem.Click += new System.EventHandler(this.fold1LayerToolStripMenuItem_Click);
			// 
			// fold2LayerToolStripMenuItem
			// 
			this.fold2LayerToolStripMenuItem.Name = "fold2LayerToolStripMenuItem";
			this.fold2LayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.fold2LayerToolStripMenuItem.Text = "Fold 2 layer";
			this.fold2LayerToolStripMenuItem.Click += new System.EventHandler(this.fold2LayerToolStripMenuItem_Click);
			// 
			// fold3LayerToolStripMenuItem
			// 
			this.fold3LayerToolStripMenuItem.Name = "fold3LayerToolStripMenuItem";
			this.fold3LayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.fold3LayerToolStripMenuItem.Text = "Fold 3 layer";
			this.fold3LayerToolStripMenuItem.Click += new System.EventHandler(this.fold3LayerToolStripMenuItem_Click);
			// 
			// fold4LayerToolStripMenuItem
			// 
			this.fold4LayerToolStripMenuItem.Name = "fold4LayerToolStripMenuItem";
			this.fold4LayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.fold4LayerToolStripMenuItem.Text = "Fold 4 layer";
			this.fold4LayerToolStripMenuItem.Click += new System.EventHandler(this.fold4LayerToolStripMenuItem_Click);
			// 
			// tsMain
			// 
			this.tsMain.Dock = System.Windows.Forms.DockStyle.None;
			this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripButton,
            this.toolStripSeparator3,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.btInvisibleChars,
            this.btHighlightCurrentLine,
            this.btShowFoldingLines,
            this.toolStripSeparator4,
            this.undoStripButton,
            this.redoStripButton,
            this.toolStripSeparator5,
            this.backStripButton,
            this.forwardStripButton,
            this.tbFind,
            this.toolStripLabel1,
            this.toolStripSeparator6,
            this.bookmarkPlusButton,
            this.bookmarkMinusButton,
            this.gotoButton});
			this.tsMain.Location = new System.Drawing.Point(3, 24);
			this.tsMain.Name = "tsMain";
			this.tsMain.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.tsMain.Size = new System.Drawing.Size(529, 25);
			this.tsMain.TabIndex = 9;
			this.tsMain.Text = "toolStrip1";
			// 
			// printToolStripButton
			// 
			this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
			this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripButton.Name = "printToolStripButton";
			this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.printToolStripButton.Text = "&Print";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// cutToolStripButton
			// 
			this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
			this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cutToolStripButton.Name = "cutToolStripButton";
			this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.cutToolStripButton.Text = "C&ut";
			// 
			// copyToolStripButton
			// 
			this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
			this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripButton.Name = "copyToolStripButton";
			this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.copyToolStripButton.Text = "&Copy";
			// 
			// pasteToolStripButton
			// 
			this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
			this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteToolStripButton.Name = "pasteToolStripButton";
			this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.pasteToolStripButton.Text = "&Paste";
			// 
			// btInvisibleChars
			// 
			this.btInvisibleChars.CheckOnClick = true;
			this.btInvisibleChars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btInvisibleChars.Image = ((System.Drawing.Image)(resources.GetObject("btInvisibleChars.Image")));
			this.btInvisibleChars.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btInvisibleChars.Name = "btInvisibleChars";
			this.btInvisibleChars.Size = new System.Drawing.Size(23, 22);
			this.btInvisibleChars.Text = "¶";
			this.btInvisibleChars.ToolTipText = "Show invisible chars";
			// 
			// btHighlightCurrentLine
			// 
			this.btHighlightCurrentLine.Checked = true;
			this.btHighlightCurrentLine.CheckOnClick = true;
			this.btHighlightCurrentLine.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.btHighlightCurrentLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btHighlightCurrentLine.Image = global::ClVi.Properties.Resources.edit_padding_top;
			this.btHighlightCurrentLine.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btHighlightCurrentLine.Name = "btHighlightCurrentLine";
			this.btHighlightCurrentLine.Size = new System.Drawing.Size(23, 22);
			this.btHighlightCurrentLine.Text = "Highlight current line";
			this.btHighlightCurrentLine.ToolTipText = "Highlight current line";
			// 
			// btShowFoldingLines
			// 
			this.btShowFoldingLines.Checked = true;
			this.btShowFoldingLines.CheckOnClick = true;
			this.btShowFoldingLines.CheckState = System.Windows.Forms.CheckState.Checked;
			this.btShowFoldingLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btShowFoldingLines.Image = ((System.Drawing.Image)(resources.GetObject("btShowFoldingLines.Image")));
			this.btShowFoldingLines.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btShowFoldingLines.Name = "btShowFoldingLines";
			this.btShowFoldingLines.Size = new System.Drawing.Size(23, 22);
			this.btShowFoldingLines.Text = "Show folding lines";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// undoStripButton
			// 
			this.undoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.undoStripButton.Image = global::ClVi.Properties.Resources.undo_16x16;
			this.undoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.undoStripButton.Name = "undoStripButton";
			this.undoStripButton.Size = new System.Drawing.Size(23, 22);
			this.undoStripButton.Text = "Undo (Ctrl+Z)";
			// 
			// redoStripButton
			// 
			this.redoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.redoStripButton.Image = global::ClVi.Properties.Resources.redo_16x16;
			this.redoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.redoStripButton.Name = "redoStripButton";
			this.redoStripButton.Size = new System.Drawing.Size(23, 22);
			this.redoStripButton.Text = "Redo (Ctrl+R)";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// backStripButton
			// 
			this.backStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.backStripButton.Image = global::ClVi.Properties.Resources.backward0_16x16;
			this.backStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.backStripButton.Name = "backStripButton";
			this.backStripButton.Size = new System.Drawing.Size(23, 22);
			this.backStripButton.Text = "Navigate Backward (Ctrl+ -)";
			// 
			// forwardStripButton
			// 
			this.forwardStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.forwardStripButton.Image = global::ClVi.Properties.Resources.forward_16x16;
			this.forwardStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.forwardStripButton.Name = "forwardStripButton";
			this.forwardStripButton.Size = new System.Drawing.Size(23, 22);
			this.forwardStripButton.Text = "Navigate Forward (Ctrl+Shift+ -)";
			// 
			// tbFind
			// 
			this.tbFind.AcceptsReturn = true;
			this.tbFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tbFind.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbFind.Name = "tbFind";
			this.tbFind.Size = new System.Drawing.Size(100, 25);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
			this.toolStripLabel1.Text = "Find: ";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// bookmarkPlusButton
			// 
			this.bookmarkPlusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bookmarkPlusButton.Image = global::ClVi.Properties.Resources.layer__plus;
			this.bookmarkPlusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.bookmarkPlusButton.Name = "bookmarkPlusButton";
			this.bookmarkPlusButton.Size = new System.Drawing.Size(23, 22);
			this.bookmarkPlusButton.Text = "Add bookmark (Ctrl-B)";
			// 
			// bookmarkMinusButton
			// 
			this.bookmarkMinusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bookmarkMinusButton.Image = global::ClVi.Properties.Resources.layer__minus;
			this.bookmarkMinusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.bookmarkMinusButton.Name = "bookmarkMinusButton";
			this.bookmarkMinusButton.Size = new System.Drawing.Size(23, 22);
			this.bookmarkMinusButton.Text = "Remove bookmark (Ctrl-Shift-B)";
			// 
			// gotoButton
			// 
			this.gotoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.gotoButton.Image = ((System.Drawing.Image)(resources.GetObject("gotoButton.Image")));
			this.gotoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.gotoButton.Name = "gotoButton";
			this.gotoButton.Size = new System.Drawing.Size(55, 22);
			this.gotoButton.Text = "Goto...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(544, 461);
			this.Controls.Add(this.toolStripContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.Name = "MainForm";
			this.Text = "ClipboardViewer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ContentPanel.PerformLayout();
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.textBox)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.tsMain.ResumeLayout(false);
			this.tsMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private FastColoredTextBox textBox;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem setSelectedAsReadonlyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setSelectedAsWritableToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem collapseSelectedBlockToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem collapseAllregionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exapndAllregionToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem increaseIndentSiftTabToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem decreaseIndentTabToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem commentSelectedLinesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem uncommentSelectedLinesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem goBackwardCtrlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem goForwardCtrlShiftToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem autoIndentToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem goLeftBracketToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem goRightBracketToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem miPrint;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem startStopMacroRecordingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem executeMacroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miLanguage;
		private System.Windows.Forms.ToolStripMenuItem cSharpbuiltinHighlighterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miVB;
		private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pHPToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem jSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem luaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem foldingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem unfoldAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem foldAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fold1LayerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fold2LayerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fold3LayerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fold4LayerToolStripMenuItem;
		private System.Windows.Forms.ToolStrip tsMain;
		private System.Windows.Forms.ToolStripButton printToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton cutToolStripButton;
		private System.Windows.Forms.ToolStripButton copyToolStripButton;
		private System.Windows.Forms.ToolStripButton pasteToolStripButton;
		private System.Windows.Forms.ToolStripButton btInvisibleChars;
		private System.Windows.Forms.ToolStripButton btHighlightCurrentLine;
		private System.Windows.Forms.ToolStripButton btShowFoldingLines;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton undoStripButton;
		private System.Windows.Forms.ToolStripButton redoStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton backStripButton;
		private System.Windows.Forms.ToolStripButton forwardStripButton;
		private System.Windows.Forms.ToolStripTextBox tbFind;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton bookmarkPlusButton;
		private System.Windows.Forms.ToolStripButton bookmarkMinusButton;
		private System.Windows.Forms.ToolStripDropDownButton gotoButton;
		private System.Windows.Forms.Splitter splitter;
		private DocumentMap documentMap;
	}
}

