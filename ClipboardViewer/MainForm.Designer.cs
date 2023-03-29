using ClpView.Properties;
using FastColoredTextBoxNS;
using System;
using WK.Libraries.SharpClipboardNS;

namespace ClpView
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
			this.sharpClipboard = new WK.Libraries.SharpClipboardNS.SharpClipboard(this.components);
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.textBox = new FastColoredTextBoxNS.FastColoredTextBox();
			this.splitter = new System.Windows.Forms.Splitter();
			this.documentMap = new FastColoredTextBoxNS.DocumentMap();
			this.tbContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.foldingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
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
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem_main = new System.Windows.Forms.ToolStripMenuItem();
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
			this.foldingToolStripMenuItem_main = new System.Windows.Forms.ToolStripMenuItem();
			this.bookmarksToolStripMenuItem_main = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMain = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.tbFind = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.tsView = new System.Windows.Forms.ToolStrip();
			this.tsBookmark = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsFolding = new System.Windows.Forms.ToolStrip();
			this.fileSystemWatcher = new System.IO.FileSystemWatcher();
			this.zoomNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unfoldAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.foldAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fold1LayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fold2LayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fold3LayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fold4LayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fold5LayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fold6LayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fold7LayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fold8LayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fold8LayerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.btShowFoldingLines = new System.Windows.Forms.ToolStripButton();
			this.btHighlightCurrentLine = new System.Windows.Forms.ToolStripButton();
			this.btInvisibleChars = new System.Windows.Forms.ToolStripButton();
			this.toolObserveClipboard = new System.Windows.Forms.ToolStripButton();
			this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.undoStripButton = new System.Windows.Forms.ToolStripButton();
			this.redoStripButton = new System.Windows.Forms.ToolStripButton();
			this.backStripButton = new System.Windows.Forms.ToolStripButton();
			this.forwardStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
			this.toolFindNext = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
			this.btAddBookmark = new System.Windows.Forms.ToolStripButton();
			this.btRemoveBookmark = new System.Windows.Forms.ToolStripButton();
			this.btNextBookmark = new System.Windows.Forms.ToolStripButton();
			this.btPreviousBookmark = new System.Windows.Forms.ToolStripButton();
			this.btGo = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsClearBookmarks = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textBox)).BeginInit();
			this.tbContextMenu.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.tsMain.SuspendLayout();
			this.tsView.SuspendLayout();
			this.tsBookmark.SuspendLayout();
			this.tsFolding.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
			this.SuspendLayout();
			// 
			// sharpClipboard
			// 
			this.sharpClipboard.MonitorClipboard = true;
			this.sharpClipboard.ObservableFormats.All = true;
			this.sharpClipboard.ObservableFormats.Files = true;
			this.sharpClipboard.ObservableFormats.Images = true;
			this.sharpClipboard.ObservableFormats.Others = true;
			this.sharpClipboard.ObservableFormats.Texts = true;
			this.sharpClipboard.ObserveLastEntry = true;
			this.sharpClipboard.Tag = null;
			this.sharpClipboard.ClipboardChanged += new System.EventHandler<WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs>(this.clipboardChanged);
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.textBox);
			this.toolStripContainer.ContentPanel.Controls.Add(this.splitter);
			this.toolStripContainer.ContentPanel.Controls.Add(this.documentMap);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(642, 705);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(642, 730);
			this.toolStripContainer.TabIndex = 6;
			this.toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.ContextMenuStrip = this.tbContextMenu;
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
			this.textBox.AutoScrollMinSize = new System.Drawing.Size(56, 15);
			this.textBox.AutoSize = true;
			this.textBox.BackBrush = null;
			this.textBox.BookmarkColor = System.Drawing.Color.DeepSkyBlue;
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
			this.textBox.Hotkeys = resources.GetString("textBox.Hotkeys");
			this.textBox.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.textBox.IsReplaceMode = false;
			this.textBox.LeftPadding = 17;
			this.textBox.Location = new System.Drawing.Point(0, 0);
			this.textBox.Margin = new System.Windows.Forms.Padding(4);
			this.textBox.Name = "textBox";
			this.textBox.Paddings = new System.Windows.Forms.Padding(0);
			this.textBox.ReservedCountOfLineNumberChars = 3;
			this.textBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.textBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("textBox.ServiceColors")));
			this.textBox.Size = new System.Drawing.Size(559, 705);
			this.textBox.TabIndex = 8;
			this.textBox.Zoom = 100;
			this.textBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.textBox_TextChanged);
			this.textBox.SelectionChangedDelayed += new System.EventHandler(this.fctb_SelectionChangedDelayed);
			this.textBox.AutoIndentNeeded += new System.EventHandler<FastColoredTextBoxNS.AutoIndentEventArgs>(this.textBox_AutoIndentNeeded);
			this.textBox.CustomAction += new System.EventHandler<FastColoredTextBoxNS.CustomActionEventArgs>(this.textBox_CustomAction);
			this.textBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox_DoubleClick);
			// 
			// splitter
			// 
			this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter.Location = new System.Drawing.Point(559, 0);
			this.splitter.Name = "splitter";
			this.splitter.Size = new System.Drawing.Size(3, 705);
			this.splitter.TabIndex = 9;
			this.splitter.TabStop = false;
			// 
			// documentMap
			// 
			this.documentMap.Dock = System.Windows.Forms.DockStyle.Right;
			this.documentMap.ForeColor = System.Drawing.Color.Maroon;
			this.documentMap.Location = new System.Drawing.Point(562, 0);
			this.documentMap.Name = "documentMap";
			this.documentMap.Scale = 0.2F;
			this.documentMap.Size = new System.Drawing.Size(80, 705);
			this.documentMap.TabIndex = 10;
			this.documentMap.Target = this.textBox;
			this.documentMap.Text = "documentMap";
			this.documentMap.Resize += new System.EventHandler(this.documentMap1_Resize);
			// 
			// tbContextMenu
			// 
			this.tbContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.foldingToolStripMenuItem,
            this.bookmarksToolStripMenuItem,
            this.saveSettingsToolStripMenuItem,
            this.loadSettingsToolStripMenuItem});
			this.tbContextMenu.Name = "contextMenuStrip1";
			this.tbContextMenu.Size = new System.Drawing.Size(145, 136);
			this.tbContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.tbContextMenu_Opening);
			// 
			// mainToolStripMenuItem
			// 
			this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
			this.mainToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.mainToolStripMenuItem.Text = "Main";
			this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.viewToolStripMenuItem.Text = "View";
			this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem1_Click);
			// 
			// foldingToolStripMenuItem
			// 
			this.foldingToolStripMenuItem.Name = "foldingToolStripMenuItem";
			this.foldingToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.foldingToolStripMenuItem.Text = "Folding";
			this.foldingToolStripMenuItem.Click += new System.EventHandler(this.foldingToolStripMenuItem1_Click);
			// 
			// bookmarksToolStripMenuItem
			// 
			this.bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
			this.bookmarksToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.bookmarksToolStripMenuItem.Text = "Bookmarks";
			this.bookmarksToolStripMenuItem.Click += new System.EventHandler(this.bookmarksToolStripMenuItem_Click);
			// 
			// saveSettingsToolStripMenuItem
			// 
			this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
			this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.saveSettingsToolStripMenuItem.Text = "Save settings";
			this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToolStripMenuItem_Click);
			// 
			// loadSettingsToolStripMenuItem
			// 
			this.loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
			this.loadSettingsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.loadSettingsToolStripMenuItem.Text = "Load settings";
			this.loadSettingsToolStripMenuItem.Click += new System.EventHandler(this.loadSettingsToolStripMenuItem_Click);
			// 
			// menuStrip
			// 
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem_main,
            this.miLanguage,
            this.foldingToolStripMenuItem_main,
            this.bookmarksToolStripMenuItem_main});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip.Size = new System.Drawing.Size(304, 24);
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
            this.exitToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(316, 6);
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.findToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.findToolStripMenuItem.Text = "&Find";
			this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
			// 
			// replaceToolStripMenuItem
			// 
			this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
			this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.replaceToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.replaceToolStripMenuItem.Text = "&Replace";
			this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(316, 6);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(316, 6);
			// 
			// collapseSelectedBlockToolStripMenuItem
			// 
			this.collapseSelectedBlockToolStripMenuItem.Name = "collapseSelectedBlockToolStripMenuItem";
			this.collapseSelectedBlockToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.collapseSelectedBlockToolStripMenuItem.Text = "Collapse selected block";
			this.collapseSelectedBlockToolStripMenuItem.Click += new System.EventHandler(this.collapseSelectedBlockToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(316, 6);
			// 
			// collapseAllregionToolStripMenuItem
			// 
			this.collapseAllregionToolStripMenuItem.Name = "collapseAllregionToolStripMenuItem";
			this.collapseAllregionToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.collapseAllregionToolStripMenuItem.Text = "Collapse all #region";
			this.collapseAllregionToolStripMenuItem.Click += new System.EventHandler(this.collapseAllregionToolStripMenuItem_Click);
			// 
			// exapndAllregionToolStripMenuItem
			// 
			this.exapndAllregionToolStripMenuItem.Name = "exapndAllregionToolStripMenuItem";
			this.exapndAllregionToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.exapndAllregionToolStripMenuItem.Text = "Exapnd all #region";
			this.exapndAllregionToolStripMenuItem.Click += new System.EventHandler(this.exapndAllregionToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(316, 6);
			// 
			// increaseIndentSiftTabToolStripMenuItem
			// 
			this.increaseIndentSiftTabToolStripMenuItem.Name = "increaseIndentSiftTabToolStripMenuItem";
			this.increaseIndentSiftTabToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.increaseIndentSiftTabToolStripMenuItem.Text = "Increase Indent [Tab]";
			this.increaseIndentSiftTabToolStripMenuItem.Click += new System.EventHandler(this.increaseIndentSiftTabToolStripMenuItem_Click);
			// 
			// decreaseIndentTabToolStripMenuItem
			// 
			this.decreaseIndentTabToolStripMenuItem.Name = "decreaseIndentTabToolStripMenuItem";
			this.decreaseIndentTabToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.decreaseIndentTabToolStripMenuItem.Text = "Decrease Indent [Shift + Tab]";
			this.decreaseIndentTabToolStripMenuItem.Click += new System.EventHandler(this.decreaseIndentTabToolStripMenuItem_Click);
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(316, 6);
			// 
			// commentSelectedLinesToolStripMenuItem
			// 
			this.commentSelectedLinesToolStripMenuItem.Name = "commentSelectedLinesToolStripMenuItem";
			this.commentSelectedLinesToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.commentSelectedLinesToolStripMenuItem.Text = "Comment selected lines";
			this.commentSelectedLinesToolStripMenuItem.Click += new System.EventHandler(this.commentSelectedLinesToolStripMenuItem_Click);
			// 
			// uncommentSelectedLinesToolStripMenuItem
			// 
			this.uncommentSelectedLinesToolStripMenuItem.Name = "uncommentSelectedLinesToolStripMenuItem";
			this.uncommentSelectedLinesToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.uncommentSelectedLinesToolStripMenuItem.Text = "Uncomment selected lines";
			this.uncommentSelectedLinesToolStripMenuItem.Click += new System.EventHandler(this.uncommentSelectedLinesToolStripMenuItem_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(316, 6);
			// 
			// goBackwardCtrlToolStripMenuItem
			// 
			this.goBackwardCtrlToolStripMenuItem.Name = "goBackwardCtrlToolStripMenuItem";
			this.goBackwardCtrlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
			this.goBackwardCtrlToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.goBackwardCtrlToolStripMenuItem.Text = "Go Backward";
			this.goBackwardCtrlToolStripMenuItem.Click += new System.EventHandler(this.goBackwardCtrlToolStripMenuItem_Click);
			// 
			// goForwardCtrlShiftToolStripMenuItem
			// 
			this.goForwardCtrlShiftToolStripMenuItem.Name = "goForwardCtrlShiftToolStripMenuItem";
			this.goForwardCtrlShiftToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.OemMinus)));
			this.goForwardCtrlShiftToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.goForwardCtrlShiftToolStripMenuItem.Text = "Go Forward";
			this.goForwardCtrlShiftToolStripMenuItem.Click += new System.EventHandler(this.goForwardCtrlShiftToolStripMenuItem_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(316, 6);
			// 
			// autoIndentToolStripMenuItem
			// 
			this.autoIndentToolStripMenuItem.Name = "autoIndentToolStripMenuItem";
			this.autoIndentToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.autoIndentToolStripMenuItem.Text = "Auto Indent selected text";
			this.autoIndentToolStripMenuItem.Click += new System.EventHandler(this.autoIndentToolStripMenuItem_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(316, 6);
			// 
			// goLeftBracketToolStripMenuItem
			// 
			this.goLeftBracketToolStripMenuItem.Name = "goLeftBracketToolStripMenuItem";
			this.goLeftBracketToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.OemOpenBrackets)));
			this.goLeftBracketToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.goLeftBracketToolStripMenuItem.Text = "Go Left Bracket";
			this.goLeftBracketToolStripMenuItem.Click += new System.EventHandler(this.goLeftBracketToolStripMenuItem_Click);
			// 
			// goRightBracketToolStripMenuItem
			// 
			this.goRightBracketToolStripMenuItem.Name = "goRightBracketToolStripMenuItem";
			this.goRightBracketToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemOpenBrackets)));
			this.goRightBracketToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.goRightBracketToolStripMenuItem.Text = "Go Right Bracket";
			this.goRightBracketToolStripMenuItem.Click += new System.EventHandler(this.goRightBracketToolStripMenuItem_Click);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(316, 6);
			// 
			// miPrint
			// 
			this.miPrint.Name = "miPrint";
			this.miPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.miPrint.Size = new System.Drawing.Size(319, 22);
			this.miPrint.Text = "Print...";
			this.miPrint.Click += new System.EventHandler(this.miPrint_Click);
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(316, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(319, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem_main
			// 
			this.viewToolStripMenuItem_main.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomNormalToolStripMenuItem,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
			this.viewToolStripMenuItem_main.Name = "viewToolStripMenuItem_main";
			this.viewToolStripMenuItem_main.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem_main.Text = "View";
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
			// foldingToolStripMenuItem_main
			// 
			this.foldingToolStripMenuItem_main.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unfoldAllToolStripMenuItem,
            this.foldAllToolStripMenuItem,
            this.fold1LayerToolStripMenuItem,
            this.fold2LayerToolStripMenuItem,
            this.fold3LayerToolStripMenuItem,
            this.fold4LayerToolStripMenuItem,
            this.fold5LayerToolStripMenuItem,
            this.fold6LayerToolStripMenuItem,
            this.fold7LayerToolStripMenuItem,
            this.fold8LayerToolStripMenuItem,
            this.fold8LayerToolStripMenuItem1});
			this.foldingToolStripMenuItem_main.Name = "foldingToolStripMenuItem_main";
			this.foldingToolStripMenuItem_main.Size = new System.Drawing.Size(59, 20);
			this.foldingToolStripMenuItem_main.Text = "Folding";
			// 
			// bookmarksToolStripMenuItem_main
			// 
			this.bookmarksToolStripMenuItem_main.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.clearToolStripMenuItem});
			this.bookmarksToolStripMenuItem_main.Name = "bookmarksToolStripMenuItem_main";
			this.bookmarksToolStripMenuItem_main.Size = new System.Drawing.Size(78, 20);
			this.bookmarksToolStripMenuItem_main.Text = "Bookmarks";
			// 
			// tsMain
			// 
			this.tsMain.ContextMenuStrip = this.tbContextMenu;
			this.tsMain.Dock = System.Windows.Forms.DockStyle.None;
			this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripButton,
            this.toolStripSeparator3,
            this.btShowFoldingLines,
            this.btHighlightCurrentLine,
            this.btInvisibleChars,
            this.toolStripSeparator2,
            this.toolObserveClipboard,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator7,
            this.undoStripButton,
            this.redoStripButton,
            this.toolStripSeparator5,
            this.backStripButton,
            this.forwardStripButton,
            this.toolStripButton15,
            this.toolFindNext,
            this.tbFind,
            this.toolStripLabel1,
            this.toolStripSeparator6});
			this.tsMain.Location = new System.Drawing.Point(0, 30);
			this.tsMain.Name = "tsMain";
			this.tsMain.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.tsMain.Size = new System.Drawing.Size(520, 25);
			this.tsMain.TabIndex = 9;
			this.tsMain.Text = "toolStrip1";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// tbFind
			// 
			this.tbFind.AcceptsReturn = true;
			this.tbFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tbFind.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbFind.Name = "tbFind";
			this.tbFind.Size = new System.Drawing.Size(140, 25);
			this.tbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFind_KeyPress);
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
			// tsView
			// 
			this.tsView.Dock = System.Windows.Forms.DockStyle.None;
			this.tsView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9});
			this.tsView.Location = new System.Drawing.Point(0, 60);
			this.tsView.Name = "tsView";
			this.tsView.Size = new System.Drawing.Size(81, 25);
			this.tsView.TabIndex = 13;
			// 
			// tsBookmark
			// 
			this.tsBookmark.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tsBookmark.Dock = System.Windows.Forms.DockStyle.None;
			this.tsBookmark.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAddBookmark,
            this.btRemoveBookmark,
            this.btNextBookmark,
            this.btPreviousBookmark,
            this.btGo,
            this.toolStripSeparator4,
            this.tsClearBookmarks});
			this.tsBookmark.Location = new System.Drawing.Point(329, 145);
			this.tsBookmark.Name = "tsBookmark";
			this.tsBookmark.Size = new System.Drawing.Size(194, 25);
			this.tsBookmark.TabIndex = 11;
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// tsFolding
			// 
			this.tsFolding.Dock = System.Windows.Forms.DockStyle.None;
			this.tsFolding.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton14,
            this.toolStripButton13,
            this.toolStripButton12,
            this.toolStripButton11,
            this.toolStripButton10});
			this.tsFolding.Location = new System.Drawing.Point(120, 60);
			this.tsFolding.Name = "tsFolding";
			this.tsFolding.Size = new System.Drawing.Size(265, 25);
			this.tsFolding.TabIndex = 12;
			// 
			// fileSystemWatcher
			// 
			this.fileSystemWatcher.EnableRaisingEvents = true;
			this.fileSystemWatcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
			this.fileSystemWatcher.SynchronizingObject = this;
			this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
			// 
			// zoomNormalToolStripMenuItem
			// 
			this.zoomNormalToolStripMenuItem.Image = global::ClpView.Properties.Resources.view_1_1;
			this.zoomNormalToolStripMenuItem.Name = "zoomNormalToolStripMenuItem";
			this.zoomNormalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
			this.zoomNormalToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.zoomNormalToolStripMenuItem.Text = "Zoom normal";
			this.zoomNormalToolStripMenuItem.Click += new System.EventHandler(this.zoomNormalToolStripMenuItem_Click);
			// 
			// zoomInToolStripMenuItem
			// 
			this.zoomInToolStripMenuItem.Image = global::ClpView.Properties.Resources.zoom_in;
			this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
			this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.zoomInToolStripMenuItem.Text = "Zoom in";
			this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
			// 
			// zoomOutToolStripMenuItem
			// 
			this.zoomOutToolStripMenuItem.Image = global::ClpView.Properties.Resources.zoom_out;
			this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
			this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.zoomOutToolStripMenuItem.Text = "Zoom out";
			this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
			// 
			// unfoldAllToolStripMenuItem
			// 
			this.unfoldAllToolStripMenuItem.Image = global::ClpView.Properties.Resources.arrow_fork;
			this.unfoldAllToolStripMenuItem.Name = "unfoldAllToolStripMenuItem";
			this.unfoldAllToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.unfoldAllToolStripMenuItem.Text = "Unfold all";
			this.unfoldAllToolStripMenuItem.Click += new System.EventHandler(this.unfoldAllToolStripMenuItem_Click);
			// 
			// foldAllToolStripMenuItem
			// 
			this.foldAllToolStripMenuItem.Image = global::ClpView.Properties.Resources.arrow_merge;
			this.foldAllToolStripMenuItem.Name = "foldAllToolStripMenuItem";
			this.foldAllToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.foldAllToolStripMenuItem.Text = "Fold all";
			this.foldAllToolStripMenuItem.Click += new System.EventHandler(this.foldAllToolStripMenuItem_Click);
			// 
			// fold1LayerToolStripMenuItem
			// 
			this.fold1LayerToolStripMenuItem.Image = global::ClpView.Properties.Resources.arrow_merge_1;
			this.fold1LayerToolStripMenuItem.Name = "fold1LayerToolStripMenuItem";
			this.fold1LayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.fold1LayerToolStripMenuItem.Text = "Fold 1 layer";
			this.fold1LayerToolStripMenuItem.Click += new System.EventHandler(this.fold1LayerToolStripMenuItem_Click);
			// 
			// fold2LayerToolStripMenuItem
			// 
			this.fold2LayerToolStripMenuItem.Image = global::ClpView.Properties.Resources.arrow_merge_2;
			this.fold2LayerToolStripMenuItem.Name = "fold2LayerToolStripMenuItem";
			this.fold2LayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.fold2LayerToolStripMenuItem.Text = "Fold 2 layer";
			this.fold2LayerToolStripMenuItem.Click += new System.EventHandler(this.fold2LayerToolStripMenuItem_Click);
			// 
			// fold3LayerToolStripMenuItem
			// 
			this.fold3LayerToolStripMenuItem.Image = global::ClpView.Properties.Resources.arrow_merge_3;
			this.fold3LayerToolStripMenuItem.Name = "fold3LayerToolStripMenuItem";
			this.fold3LayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.fold3LayerToolStripMenuItem.Text = "Fold 3 layer";
			this.fold3LayerToolStripMenuItem.Click += new System.EventHandler(this.fold3LayerToolStripMenuItem_Click);
			// 
			// fold4LayerToolStripMenuItem
			// 
			this.fold4LayerToolStripMenuItem.Image = global::ClpView.Properties.Resources.arrow_merge_4;
			this.fold4LayerToolStripMenuItem.Name = "fold4LayerToolStripMenuItem";
			this.fold4LayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.fold4LayerToolStripMenuItem.Text = "Fold 4 layer";
			this.fold4LayerToolStripMenuItem.Click += new System.EventHandler(this.fold4LayerToolStripMenuItem_Click);
			// 
			// fold5LayerToolStripMenuItem
			// 
			this.fold5LayerToolStripMenuItem.Image = global::ClpView.Properties.Resources.arrow_merge_5;
			this.fold5LayerToolStripMenuItem.Name = "fold5LayerToolStripMenuItem";
			this.fold5LayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.fold5LayerToolStripMenuItem.Text = "Fold 5 layer";
			this.fold5LayerToolStripMenuItem.Click += new System.EventHandler(this.fold5LayerToolStripMenuItem_Click);
			// 
			// fold6LayerToolStripMenuItem
			// 
			this.fold6LayerToolStripMenuItem.Image = global::ClpView.Properties.Resources.arrow_merge_6;
			this.fold6LayerToolStripMenuItem.Name = "fold6LayerToolStripMenuItem";
			this.fold6LayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.fold6LayerToolStripMenuItem.Text = "Fold 6 layer";
			this.fold6LayerToolStripMenuItem.Click += new System.EventHandler(this.fold6LayerToolStripMenuItem_Click);
			// 
			// fold7LayerToolStripMenuItem
			// 
			this.fold7LayerToolStripMenuItem.Image = global::ClpView.Properties.Resources.arrow_merge_7;
			this.fold7LayerToolStripMenuItem.Name = "fold7LayerToolStripMenuItem";
			this.fold7LayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.fold7LayerToolStripMenuItem.Text = "Fold 7 layer";
			this.fold7LayerToolStripMenuItem.Click += new System.EventHandler(this.fold7LayerToolStripMenuItem_Click);
			// 
			// fold8LayerToolStripMenuItem
			// 
			this.fold8LayerToolStripMenuItem.Image = global::ClpView.Properties.Resources.arrow_merge_8;
			this.fold8LayerToolStripMenuItem.Name = "fold8LayerToolStripMenuItem";
			this.fold8LayerToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.fold8LayerToolStripMenuItem.Text = "Fold 8 layer";
			this.fold8LayerToolStripMenuItem.Click += new System.EventHandler(this.fold8LayerToolStripMenuItem_Click);
			// 
			// fold8LayerToolStripMenuItem1
			// 
			this.fold8LayerToolStripMenuItem1.Image = global::ClpView.Properties.Resources.arrow_merge_9;
			this.fold8LayerToolStripMenuItem1.Name = "fold8LayerToolStripMenuItem1";
			this.fold8LayerToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
			this.fold8LayerToolStripMenuItem1.Text = "Fold 9 layer";
			this.fold8LayerToolStripMenuItem1.Click += new System.EventHandler(this.fold9LayerToolStripMenuItem_Click);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Image = global::ClpView.Properties.Resources.navigate_plus;
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.addToolStripMenuItem.Text = "Add";
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Image = global::ClpView.Properties.Resources.navigate_minus;
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			// 
			// nextToolStripMenuItem
			// 
			this.nextToolStripMenuItem.Image = global::ClpView.Properties.Resources.navigate_down;
			this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
			this.nextToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.nextToolStripMenuItem.Text = "Next";
			// 
			// previousToolStripMenuItem
			// 
			this.previousToolStripMenuItem.Image = global::ClpView.Properties.Resources.navigate_up;
			this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
			this.previousToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.previousToolStripMenuItem.Text = "Previous";
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Image = global::ClpView.Properties.Resources.navigate_cross;
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			// 
			// printToolStripButton
			// 
			this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
			this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripButton.Name = "printToolStripButton";
			this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.printToolStripButton.Text = "&Print";
			this.printToolStripButton.Click += new System.EventHandler(this.miPrint_Click);
			// 
			// btShowFoldingLines
			// 
			this.btShowFoldingLines.Checked = true;
			this.btShowFoldingLines.CheckOnClick = true;
			this.btShowFoldingLines.CheckState = System.Windows.Forms.CheckState.Checked;
			this.btShowFoldingLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btShowFoldingLines.Image = global::ClpView.Properties.Resources.text_tree1;
			this.btShowFoldingLines.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btShowFoldingLines.Name = "btShowFoldingLines";
			this.btShowFoldingLines.Size = new System.Drawing.Size(23, 22);
			this.btShowFoldingLines.Text = "Show folding lines";
			this.btShowFoldingLines.Click += new System.EventHandler(this.btShowFoldingLines_Click);
			// 
			// btHighlightCurrentLine
			// 
			this.btHighlightCurrentLine.Checked = true;
			this.btHighlightCurrentLine.CheckOnClick = true;
			this.btHighlightCurrentLine.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.btHighlightCurrentLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btHighlightCurrentLine.Image = global::ClpView.Properties.Resources.code_line;
			this.btHighlightCurrentLine.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btHighlightCurrentLine.Name = "btHighlightCurrentLine";
			this.btHighlightCurrentLine.Size = new System.Drawing.Size(23, 22);
			this.btHighlightCurrentLine.Text = "Highlight current line";
			this.btHighlightCurrentLine.ToolTipText = "Highlight current line";
			this.btHighlightCurrentLine.Click += new System.EventHandler(this.btHighlightCurrentLine_Click);
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
			this.btInvisibleChars.Click += new System.EventHandler(this.btInvisibleChars_Click);
			// 
			// toolObserveClipboard
			// 
			this.toolObserveClipboard.Checked = true;
			this.toolObserveClipboard.CheckOnClick = true;
			this.toolObserveClipboard.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.toolObserveClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolObserveClipboard.Image = global::ClpView.Properties.Resources.eye;
			this.toolObserveClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolObserveClipboard.Name = "toolObserveClipboard";
			this.toolObserveClipboard.Size = new System.Drawing.Size(23, 22);
			this.toolObserveClipboard.Text = "Observe Clipboard";
			this.toolObserveClipboard.ToolTipText = "Observe Clipboard or not";
			this.toolObserveClipboard.Click += new System.EventHandler(this.toolObserveClipboard_Click);
			// 
			// copyToolStripButton
			// 
			this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
			this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripButton.Name = "copyToolStripButton";
			this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.copyToolStripButton.Text = "&Copy";
			this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
			// 
			// pasteToolStripButton
			// 
			this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
			this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteToolStripButton.Name = "pasteToolStripButton";
			this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.pasteToolStripButton.Text = "&Paste";
			this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
			// 
			// undoStripButton
			// 
			this.undoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.undoStripButton.Image = global::ClpView.Properties.Resources.undo_16x16;
			this.undoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.undoStripButton.Name = "undoStripButton";
			this.undoStripButton.Size = new System.Drawing.Size(23, 22);
			this.undoStripButton.Text = "Undo (Ctrl+Z)";
			this.undoStripButton.Click += new System.EventHandler(this.undoStripButton_Click);
			// 
			// redoStripButton
			// 
			this.redoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.redoStripButton.Image = global::ClpView.Properties.Resources.redo_16x16;
			this.redoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.redoStripButton.Name = "redoStripButton";
			this.redoStripButton.Size = new System.Drawing.Size(23, 22);
			this.redoStripButton.Text = "Redo (Ctrl+R)";
			this.redoStripButton.Click += new System.EventHandler(this.redoStripButton_Click);
			// 
			// backStripButton
			// 
			this.backStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.backStripButton.Image = global::ClpView.Properties.Resources.backward0_16x16;
			this.backStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.backStripButton.Name = "backStripButton";
			this.backStripButton.Size = new System.Drawing.Size(23, 22);
			this.backStripButton.Text = "Navigate Backward (Ctrl+ -)";
			this.backStripButton.Click += new System.EventHandler(this.goBackwardCtrlToolStripMenuItem_Click);
			// 
			// forwardStripButton
			// 
			this.forwardStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.forwardStripButton.Image = global::ClpView.Properties.Resources.forward_16x16;
			this.forwardStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.forwardStripButton.Name = "forwardStripButton";
			this.forwardStripButton.Size = new System.Drawing.Size(23, 22);
			this.forwardStripButton.Text = "Navigate Forward (Ctrl+Shift+ -)";
			this.forwardStripButton.Click += new System.EventHandler(this.goForwardCtrlShiftToolStripMenuItem_Click);
			// 
			// toolStripButton15
			// 
			this.toolStripButton15.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton15.Image = global::ClpView.Properties.Resources.view_previous;
			this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton15.Name = "toolStripButton15";
			this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton15.Text = "Find Next";
			this.toolStripButton15.ToolTipText = "Find Next Match of current Pattern in Findbox";
			this.toolStripButton15.Click += new System.EventHandler(this.toolFindPrevious_Click);
			// 
			// toolFindNext
			// 
			this.toolFindNext.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolFindNext.Image = global::ClpView.Properties.Resources.view_next;
			this.toolFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolFindNext.Name = "toolFindNext";
			this.toolFindNext.Size = new System.Drawing.Size(23, 22);
			this.toolFindNext.Text = "Find Next";
			this.toolFindNext.ToolTipText = "Find Next Match of current Pattern in Findbox";
			this.toolFindNext.Click += new System.EventHandler(this.toolFindNext_Click);
			// 
			// toolStripButton7
			// 
			this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton7.Image = global::ClpView.Properties.Resources.view_1_1;
			this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton7.Name = "toolStripButton7";
			this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton7.Text = "toolStripButton7";
			this.toolStripButton7.Click += new System.EventHandler(this.zoomNormalToolStripMenuItem_Click);
			// 
			// toolStripButton8
			// 
			this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton8.Image = global::ClpView.Properties.Resources.zoom_in;
			this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton8.Name = "toolStripButton8";
			this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton8.Text = "Zoom in";
			this.toolStripButton8.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
			// 
			// toolStripButton9
			// 
			this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton9.Image = global::ClpView.Properties.Resources.zoom_out;
			this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton9.Name = "toolStripButton9";
			this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton9.Text = "Zoom out";
			this.toolStripButton9.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::ClpView.Properties.Resources.arrow_fork;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "Unfold all";
			this.toolStripButton1.Click += new System.EventHandler(this.unfoldAllToolStripMenuItem_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = global::ClpView.Properties.Resources.arrow_merge;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "Fold all";
			this.toolStripButton2.Click += new System.EventHandler(this.foldAllToolStripMenuItem_Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = global::ClpView.Properties.Resources.arrow_merge_1;
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "Fold 1 layer";
			this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.toolStripButton3.Click += new System.EventHandler(this.fold1LayerToolStripMenuItem_Click);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = global::ClpView.Properties.Resources.arrow_merge_2;
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton4.Text = "Fold 2 layer";
			this.toolStripButton4.Click += new System.EventHandler(this.fold2LayerToolStripMenuItem_Click);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = global::ClpView.Properties.Resources.arrow_merge_3;
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton5.Text = "Fold 3 layer";
			this.toolStripButton5.Click += new System.EventHandler(this.fold3LayerToolStripMenuItem_Click);
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton6.Image = global::ClpView.Properties.Resources.arrow_merge_4;
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton6.Text = "Fold 4 layer";
			this.toolStripButton6.Click += new System.EventHandler(this.fold4LayerToolStripMenuItem_Click);
			// 
			// toolStripButton14
			// 
			this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
			this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton14.Name = "toolStripButton14";
			this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton14.Text = "toolStripButton10";
			this.toolStripButton14.Click += new System.EventHandler(this.fold5LayerToolStripMenuItem_Click);
			// 
			// toolStripButton13
			// 
			this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
			this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton13.Name = "toolStripButton13";
			this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton13.Text = "toolStripButton10";
			this.toolStripButton13.Click += new System.EventHandler(this.fold6LayerToolStripMenuItem_Click);
			// 
			// toolStripButton12
			// 
			this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
			this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton12.Name = "toolStripButton12";
			this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton12.Text = "toolStripButton10";
			this.toolStripButton12.Click += new System.EventHandler(this.fold7LayerToolStripMenuItem_Click);
			// 
			// toolStripButton11
			// 
			this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
			this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton11.Name = "toolStripButton11";
			this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton11.Text = "toolStripButton10";
			this.toolStripButton11.Click += new System.EventHandler(this.fold8LayerToolStripMenuItem_Click);
			// 
			// toolStripButton10
			// 
			this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
			this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton10.Name = "toolStripButton10";
			this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton10.Text = "toolStripButton10";
			this.toolStripButton10.Click += new System.EventHandler(this.fold9LayerToolStripMenuItem_Click);
			// 
			// btAddBookmark
			// 
			this.btAddBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btAddBookmark.Image = global::ClpView.Properties.Resources.navigate_plus;
			this.btAddBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btAddBookmark.Name = "btAddBookmark";
			this.btAddBookmark.Size = new System.Drawing.Size(23, 22);
			this.btAddBookmark.Text = "Add";
			this.btAddBookmark.ToolTipText = "Add Bookmark";
			this.btAddBookmark.Click += new System.EventHandler(this.btAddBookmark_Click);
			// 
			// btRemoveBookmark
			// 
			this.btRemoveBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btRemoveBookmark.Image = global::ClpView.Properties.Resources.navigate_minus;
			this.btRemoveBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btRemoveBookmark.Name = "btRemoveBookmark";
			this.btRemoveBookmark.Size = new System.Drawing.Size(23, 22);
			this.btRemoveBookmark.Text = "Remove";
			this.btRemoveBookmark.ToolTipText = "Remove Bookmark";
			this.btRemoveBookmark.Click += new System.EventHandler(this.btRemoveBookmark_Click);
			// 
			// btNextBookmark
			// 
			this.btNextBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btNextBookmark.Image = global::ClpView.Properties.Resources.navigate_down;
			this.btNextBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btNextBookmark.Name = "btNextBookmark";
			this.btNextBookmark.Size = new System.Drawing.Size(23, 22);
			this.btNextBookmark.Text = "Next";
			this.btNextBookmark.ToolTipText = "Next Bookmark";
			this.btNextBookmark.Click += new System.EventHandler(this.btNextBookmark_Click);
			// 
			// btPreviousBookmark
			// 
			this.btPreviousBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btPreviousBookmark.Image = global::ClpView.Properties.Resources.navigate_up;
			this.btPreviousBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btPreviousBookmark.Name = "btPreviousBookmark";
			this.btPreviousBookmark.Size = new System.Drawing.Size(23, 22);
			this.btPreviousBookmark.Text = "Previous";
			this.btPreviousBookmark.ToolTipText = "Previous Bookmark";
			this.btPreviousBookmark.Click += new System.EventHandler(this.btPreviousBookmark_Click);
			// 
			// btGo
			// 
			this.btGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btGo.Image = ((System.Drawing.Image)(resources.GetObject("btGo.Image")));
			this.btGo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btGo.Name = "btGo";
			this.btGo.Size = new System.Drawing.Size(61, 22);
			this.btGo.Text = "Go to ...";
			this.btGo.DropDownOpening += new System.EventHandler(this.btGo_DropDownOpening);
			// 
			// tsClearBookmarks
			// 
			this.tsClearBookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsClearBookmarks.Image = global::ClpView.Properties.Resources.navigate_cross;
			this.tsClearBookmarks.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsClearBookmarks.Name = "tsClearBookmarks";
			this.tsClearBookmarks.Size = new System.Drawing.Size(23, 22);
			this.tsClearBookmarks.Text = "Clear Bookmarks";
			this.tsClearBookmarks.Click += new System.EventHandler(this.tsClearBookmarks_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(642, 730);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.tsMain);
			this.Controls.Add(this.tsView);
			this.Controls.Add(this.tsFolding);
			this.Controls.Add(this.tsBookmark);
			this.Controls.Add(this.toolStripContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.Name = "MainForm";
			this.Text = "ClipboardViewer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ContentPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.textBox)).EndInit();
			this.tbContextMenu.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.tsMain.ResumeLayout(false);
			this.tsMain.PerformLayout();
			this.tsView.ResumeLayout(false);
			this.tsView.PerformLayout();
			this.tsBookmark.ResumeLayout(false);
			this.tsBookmark.PerformLayout();
			this.tsFolding.ResumeLayout(false);
			this.tsFolding.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.ToolStripMenuItem foldingToolStripMenuItem_main;
		private System.Windows.Forms.ToolStripMenuItem unfoldAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem foldAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fold1LayerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fold2LayerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fold3LayerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fold4LayerToolStripMenuItem;
		private System.Windows.Forms.ToolStrip tsMain;
		private System.Windows.Forms.ToolStripButton printToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btInvisibleChars;
		private System.Windows.Forms.ToolStripButton btHighlightCurrentLine;
		private System.Windows.Forms.ToolStripButton btShowFoldingLines;
		private System.Windows.Forms.ToolStripButton undoStripButton;
		private System.Windows.Forms.ToolStripButton redoStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton backStripButton;
		private System.Windows.Forms.ToolStripButton forwardStripButton;
		private System.Windows.Forms.ToolStripTextBox tbFind;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.Splitter splitter;
		private DocumentMap documentMap;
		private System.Windows.Forms.ToolStripButton copyToolStripButton;
		private System.Windows.Forms.ToolStripButton pasteToolStripButton;
		private System.Windows.Forms.ToolStripButton toolObserveClipboard;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStrip tsBookmark;
		private System.Windows.Forms.ToolStripButton btAddBookmark;
		private System.Windows.Forms.ToolStripButton btRemoveBookmark;
		private System.Windows.Forms.ToolStripButton btNextBookmark;
		private System.Windows.Forms.ToolStripButton btPreviousBookmark;
		private System.Windows.Forms.ContextMenuStrip tbContextMenu;
		private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton btGo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton tsClearBookmarks;
		private System.Windows.Forms.ToolStripButton toolFindNext;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem_main;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.ToolStrip tsFolding;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem foldingToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.ToolStripButton toolStripButton6;
		private System.Windows.Forms.ToolStrip tsView;
		private System.Windows.Forms.ToolStripButton toolStripButton7;
		private System.Windows.Forms.ToolStripButton toolStripButton8;
		private System.Windows.Forms.ToolStripButton toolStripButton9;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem_main;
		private System.Windows.Forms.ToolStripMenuItem zoomNormalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
		private System.IO.FileSystemWatcher fileSystemWatcher;
		private System.Windows.Forms.ToolStripMenuItem fold5LayerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fold6LayerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fold7LayerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fold8LayerToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton14;
		private System.Windows.Forms.ToolStripButton toolStripButton13;
		private System.Windows.Forms.ToolStripButton toolStripButton12;
		private System.Windows.Forms.ToolStripButton toolStripButton11;
		private System.Windows.Forms.ToolStripButton toolStripButton10;
		private System.Windows.Forms.ToolStripMenuItem fold8LayerToolStripMenuItem1;
		private System.Windows.Forms.ToolStripButton toolStripButton15;
	}
}

