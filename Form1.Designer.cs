namespace DialogManager {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MnuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrvTreeView = new System.Windows.Forms.TreeView();
            this.LblActiveDlc = new System.Windows.Forms.Label();
            this.CmdAddToDlcList = new System.Windows.Forms.Button();
            this.NumChapterSelect = new System.Windows.Forms.NumericUpDown();
            this.NumSceneSelect = new System.Windows.Forms.NumericUpDown();
            this.NumDlcSelect = new System.Windows.Forms.NumericUpDown();
            this.CmdDeleteFromDlcList = new System.Windows.Forms.Button();
            this.DgvDataBase = new System.Windows.Forms.DataGridView();
            this.CmdAddDialogLine = new System.Windows.Forms.Button();
            this.LblActiveDialogLine = new System.Windows.Forms.Label();
            this.CmdDeleteDialogLine = new System.Windows.Forms.Button();
            this.BoxCharacterName = new System.Windows.Forms.TextBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BoxContentGer = new System.Windows.Forms.RichTextBox();
            this.BoxContentEng = new System.Windows.Forms.RichTextBox();
            this.NumPrevious = new System.Windows.Forms.NumericUpDown();
            this.NumNext0 = new System.Windows.Forms.NumericUpDown();
            this.NumNext1 = new System.Windows.Forms.NumericUpDown();
            this.NumNext2 = new System.Windows.Forms.NumericUpDown();
            this.NumNext3 = new System.Windows.Forms.NumericUpDown();
            this.BoxIsJump = new System.Windows.Forms.CheckBox();
            this.BoxIsEntry = new System.Windows.Forms.CheckBox();
            this.NumEventTrigger = new System.Windows.Forms.NumericUpDown();
            this.BoxRequirements = new System.Windows.Forms.TextBox();
            this.BoxAudioFileGer = new System.Windows.Forms.TextBox();
            this.BoxAudioFileEng = new System.Windows.Forms.TextBox();
            this.NumPause = new System.Windows.Forms.NumericUpDown();
            this.CmdSaveDialogLineContent = new System.Windows.Forms.Button();
            this.LblCharacter = new System.Windows.Forms.Label();
            this.LblChapter = new System.Windows.Forms.Label();
            this.LblScene = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblNext0 = new System.Windows.Forms.Label();
            this.LblNext1 = new System.Windows.Forms.Label();
            this.LblNext2 = new System.Windows.Forms.Label();
            this.LblNext3 = new System.Windows.Forms.Label();
            this.LblRequirements = new System.Windows.Forms.Label();
            this.LblEventTrigger = new System.Windows.Forms.Label();
            this.LblAudioGer = new System.Windows.Forms.Label();
            this.LblAudoEng = new System.Windows.Forms.Label();
            this.LblPause = new System.Windows.Forms.Label();
            this.LblContent = new System.Windows.Forms.Label();
            this.LblTreeHeader = new System.Windows.Forms.Label();
            this.LblDataBaseHeader = new System.Windows.Forms.Label();
            this.BoxPreview = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblPrevious = new System.Windows.Forms.Label();
            this.LblPreview = new System.Windows.Forms.Label();
            this.MnuMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumChapterSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSceneSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDlcSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataBase)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNext0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNext2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNext3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEventTrigger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuMenuStrip
            // 
            this.MnuMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.MnuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MnuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuMenuStrip.Name = "MnuMenuStrip";
            this.MnuMenuStrip.Size = new System.Drawing.Size(1723, 24);
            this.MnuMenuStrip.TabIndex = 0;
            this.MnuMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDataBaseToolStripMenuItem,
            this.openDataBaseToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newDataBaseToolStripMenuItem
            // 
            this.newDataBaseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.newDataBaseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.newDataBaseToolStripMenuItem.Name = "newDataBaseToolStripMenuItem";
            this.newDataBaseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.newDataBaseToolStripMenuItem.Text = "New DataBase";
            this.newDataBaseToolStripMenuItem.Click += new System.EventHandler(this.newDataBaseToolStripMenuItem_Click);
            // 
            // openDataBaseToolStripMenuItem
            // 
            this.openDataBaseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.openDataBaseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.openDataBaseToolStripMenuItem.Name = "openDataBaseToolStripMenuItem";
            this.openDataBaseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openDataBaseToolStripMenuItem.Text = "OpenDataBase...";
            this.openDataBaseToolStripMenuItem.Click += new System.EventHandler(this.openDataBaseToolStripMenuItem_Click);
            // 
            // TrvTreeView
            // 
            this.TrvTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TrvTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrvTreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TrvTreeView.Location = new System.Drawing.Point(15, 44);
            this.TrvTreeView.Name = "TrvTreeView";
            this.TrvTreeView.Size = new System.Drawing.Size(141, 478);
            this.TrvTreeView.TabIndex = 1;
            this.TrvTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvTreeView_AfterSelect);
            // 
            // LblActiveDlc
            // 
            this.LblActiveDlc.AutoSize = true;
            this.LblActiveDlc.Location = new System.Drawing.Point(12, 623);
            this.LblActiveDlc.Name = "LblActiveDlc";
            this.LblActiveDlc.Size = new System.Drawing.Size(61, 13);
            this.LblActiveDlc.TabIndex = 2;
            this.LblActiveDlc.Text = "Active dlc: ";
            // 
            // CmdAddToDlcList
            // 
            this.CmdAddToDlcList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.CmdAddToDlcList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CmdAddToDlcList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAddToDlcList.Location = new System.Drawing.Point(12, 567);
            this.CmdAddToDlcList.Name = "CmdAddToDlcList";
            this.CmdAddToDlcList.Size = new System.Drawing.Size(141, 23);
            this.CmdAddToDlcList.TabIndex = 3;
            this.CmdAddToDlcList.Text = "Add Dialog";
            this.CmdAddToDlcList.UseVisualStyleBackColor = false;
            this.CmdAddToDlcList.Click += new System.EventHandler(this.CmdAddToDlcList_Click);
            // 
            // NumChapterSelect
            // 
            this.NumChapterSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.NumChapterSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumChapterSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumChapterSelect.Location = new System.Drawing.Point(15, 541);
            this.NumChapterSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumChapterSelect.Name = "NumChapterSelect";
            this.NumChapterSelect.Size = new System.Drawing.Size(43, 18);
            this.NumChapterSelect.TabIndex = 4;
            this.NumChapterSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumSceneSelect
            // 
            this.NumSceneSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.NumSceneSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumSceneSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumSceneSelect.Location = new System.Drawing.Point(64, 541);
            this.NumSceneSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumSceneSelect.Name = "NumSceneSelect";
            this.NumSceneSelect.Size = new System.Drawing.Size(43, 18);
            this.NumSceneSelect.TabIndex = 5;
            this.NumSceneSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumDlcSelect
            // 
            this.NumDlcSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.NumDlcSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumDlcSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumDlcSelect.Location = new System.Drawing.Point(113, 541);
            this.NumDlcSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumDlcSelect.Name = "NumDlcSelect";
            this.NumDlcSelect.Size = new System.Drawing.Size(40, 18);
            this.NumDlcSelect.TabIndex = 6;
            this.NumDlcSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CmdDeleteFromDlcList
            // 
            this.CmdDeleteFromDlcList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.CmdDeleteFromDlcList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CmdDeleteFromDlcList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdDeleteFromDlcList.Location = new System.Drawing.Point(12, 596);
            this.CmdDeleteFromDlcList.Name = "CmdDeleteFromDlcList";
            this.CmdDeleteFromDlcList.Size = new System.Drawing.Size(141, 23);
            this.CmdDeleteFromDlcList.TabIndex = 7;
            this.CmdDeleteFromDlcList.Text = "Delete Dialog";
            this.CmdDeleteFromDlcList.UseVisualStyleBackColor = false;
            this.CmdDeleteFromDlcList.Click += new System.EventHandler(this.CmdDeleteFromDlcList_Click);
            // 
            // DgvDataBase
            // 
            this.DgvDataBase.AllowUserToAddRows = false;
            this.DgvDataBase.AllowUserToDeleteRows = false;
            this.DgvDataBase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.DgvDataBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDataBase.EnableHeadersVisualStyles = false;
            this.DgvDataBase.GridColor = System.Drawing.Color.Black;
            this.DgvDataBase.Location = new System.Drawing.Point(214, 44);
            this.DgvDataBase.MultiSelect = false;
            this.DgvDataBase.Name = "DgvDataBase";
            this.DgvDataBase.ReadOnly = true;
            this.DgvDataBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDataBase.Size = new System.Drawing.Size(1462, 478);
            this.DgvDataBase.TabIndex = 8;
            this.DgvDataBase.SelectionChanged += new System.EventHandler(this.DgvDataBase_SelectionChanged);
            // 
            // CmdAddDialogLine
            // 
            this.CmdAddDialogLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.CmdAddDialogLine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CmdAddDialogLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAddDialogLine.Location = new System.Drawing.Point(214, 528);
            this.CmdAddDialogLine.Name = "CmdAddDialogLine";
            this.CmdAddDialogLine.Size = new System.Drawing.Size(92, 23);
            this.CmdAddDialogLine.TabIndex = 9;
            this.CmdAddDialogLine.Text = "Add DialogLine";
            this.CmdAddDialogLine.UseVisualStyleBackColor = false;
            this.CmdAddDialogLine.Click += new System.EventHandler(this.CmdAddDialogLine_Click);
            // 
            // LblActiveDialogLine
            // 
            this.LblActiveDialogLine.AutoSize = true;
            this.LblActiveDialogLine.Location = new System.Drawing.Point(12, 636);
            this.LblActiveDialogLine.Name = "LblActiveDialogLine";
            this.LblActiveDialogLine.Size = new System.Drawing.Size(95, 13);
            this.LblActiveDialogLine.TabIndex = 10;
            this.LblActiveDialogLine.Text = "Active DialogLine";
            // 
            // CmdDeleteDialogLine
            // 
            this.CmdDeleteDialogLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.CmdDeleteDialogLine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CmdDeleteDialogLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdDeleteDialogLine.Location = new System.Drawing.Point(312, 528);
            this.CmdDeleteDialogLine.Name = "CmdDeleteDialogLine";
            this.CmdDeleteDialogLine.Size = new System.Drawing.Size(100, 23);
            this.CmdDeleteDialogLine.TabIndex = 11;
            this.CmdDeleteDialogLine.Text = "DeleteDialogLine";
            this.CmdDeleteDialogLine.UseVisualStyleBackColor = false;
            this.CmdDeleteDialogLine.Click += new System.EventHandler(this.CmdDeleteDialogLine_Click);
            // 
            // BoxCharacterName
            // 
            this.BoxCharacterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BoxCharacterName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxCharacterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BoxCharacterName.Location = new System.Drawing.Point(214, 583);
            this.BoxCharacterName.Name = "BoxCharacterName";
            this.BoxCharacterName.Size = new System.Drawing.Size(198, 15);
            this.BoxCharacterName.TabIndex = 12;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(214, 622);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(426, 177);
            this.TabControl.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.BoxContentGer);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(418, 151);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "German";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BoxContentEng);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 151);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "English";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BoxContentGer
            // 
            this.BoxContentGer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BoxContentGer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BoxContentGer.Location = new System.Drawing.Point(-4, 4);
            this.BoxContentGer.Name = "BoxContentGer";
            this.BoxContentGer.Size = new System.Drawing.Size(426, 151);
            this.BoxContentGer.TabIndex = 0;
            this.BoxContentGer.Text = "";
            // 
            // BoxContentEng
            // 
            this.BoxContentEng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BoxContentEng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BoxContentEng.Location = new System.Drawing.Point(-4, 4);
            this.BoxContentEng.Name = "BoxContentEng";
            this.BoxContentEng.Size = new System.Drawing.Size(426, 151);
            this.BoxContentEng.TabIndex = 0;
            this.BoxContentEng.Text = "";
            // 
            // NumPrevious
            // 
            this.NumPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.NumPrevious.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumPrevious.Location = new System.Drawing.Point(669, 583);
            this.NumPrevious.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.NumPrevious.Name = "NumPrevious";
            this.NumPrevious.Size = new System.Drawing.Size(88, 18);
            this.NumPrevious.TabIndex = 14;
            // 
            // NumNext0
            // 
            this.NumNext0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.NumNext0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumNext0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumNext0.Location = new System.Drawing.Point(763, 584);
            this.NumNext0.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.NumNext0.Name = "NumNext0";
            this.NumNext0.Size = new System.Drawing.Size(89, 18);
            this.NumNext0.TabIndex = 15;
            // 
            // NumNext1
            // 
            this.NumNext1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.NumNext1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumNext1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumNext1.Location = new System.Drawing.Point(763, 610);
            this.NumNext1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.NumNext1.Name = "NumNext1";
            this.NumNext1.Size = new System.Drawing.Size(89, 18);
            this.NumNext1.TabIndex = 16;
            // 
            // NumNext2
            // 
            this.NumNext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.NumNext2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumNext2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumNext2.Location = new System.Drawing.Point(763, 636);
            this.NumNext2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.NumNext2.Name = "NumNext2";
            this.NumNext2.Size = new System.Drawing.Size(89, 18);
            this.NumNext2.TabIndex = 17;
            // 
            // NumNext3
            // 
            this.NumNext3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.NumNext3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumNext3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumNext3.Location = new System.Drawing.Point(763, 662);
            this.NumNext3.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.NumNext3.Name = "NumNext3";
            this.NumNext3.Size = new System.Drawing.Size(89, 18);
            this.NumNext3.TabIndex = 18;
            // 
            // BoxIsJump
            // 
            this.BoxIsJump.AutoSize = true;
            this.BoxIsJump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxIsJump.Location = new System.Drawing.Point(763, 563);
            this.BoxIsJump.Name = "BoxIsJump";
            this.BoxIsJump.Size = new System.Drawing.Size(91, 17);
            this.BoxIsJump.TabIndex = 19;
            this.BoxIsJump.Text = "Is Jump Point";
            this.BoxIsJump.UseVisualStyleBackColor = true;
            // 
            // BoxIsEntry
            // 
            this.BoxIsEntry.AutoSize = true;
            this.BoxIsEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxIsEntry.Location = new System.Drawing.Point(669, 563);
            this.BoxIsEntry.Name = "BoxIsEntry";
            this.BoxIsEntry.Size = new System.Drawing.Size(90, 17);
            this.BoxIsEntry.TabIndex = 20;
            this.BoxIsEntry.Text = "Is Entry Point";
            this.BoxIsEntry.UseVisualStyleBackColor = true;
            // 
            // NumEventTrigger
            // 
            this.NumEventTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.NumEventTrigger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumEventTrigger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumEventTrigger.Location = new System.Drawing.Point(820, 778);
            this.NumEventTrigger.Name = "NumEventTrigger";
            this.NumEventTrigger.Size = new System.Drawing.Size(116, 18);
            this.NumEventTrigger.TabIndex = 21;
            // 
            // BoxRequirements
            // 
            this.BoxRequirements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BoxRequirements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxRequirements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BoxRequirements.Location = new System.Drawing.Point(669, 778);
            this.BoxRequirements.Name = "BoxRequirements";
            this.BoxRequirements.Size = new System.Drawing.Size(145, 15);
            this.BoxRequirements.TabIndex = 22;
            // 
            // BoxAudioFileGer
            // 
            this.BoxAudioFileGer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BoxAudioFileGer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxAudioFileGer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BoxAudioFileGer.Location = new System.Drawing.Point(992, 580);
            this.BoxAudioFileGer.Name = "BoxAudioFileGer";
            this.BoxAudioFileGer.Size = new System.Drawing.Size(145, 15);
            this.BoxAudioFileGer.TabIndex = 23;
            // 
            // BoxAudioFileEng
            // 
            this.BoxAudioFileEng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BoxAudioFileEng.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxAudioFileEng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BoxAudioFileEng.Location = new System.Drawing.Point(992, 619);
            this.BoxAudioFileEng.Name = "BoxAudioFileEng";
            this.BoxAudioFileEng.Size = new System.Drawing.Size(145, 15);
            this.BoxAudioFileEng.TabIndex = 24;
            // 
            // NumPause
            // 
            this.NumPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.NumPause.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumPause.DecimalPlaces = 1;
            this.NumPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.NumPause.Location = new System.Drawing.Point(992, 662);
            this.NumPause.Name = "NumPause";
            this.NumPause.Size = new System.Drawing.Size(145, 18);
            this.NumPause.TabIndex = 25;
            // 
            // CmdSaveDialogLineContent
            // 
            this.CmdSaveDialogLineContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.CmdSaveDialogLineContent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CmdSaveDialogLineContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSaveDialogLineContent.Location = new System.Drawing.Point(214, 801);
            this.CmdSaveDialogLineContent.Name = "CmdSaveDialogLineContent";
            this.CmdSaveDialogLineContent.Size = new System.Drawing.Size(100, 23);
            this.CmdSaveDialogLineContent.TabIndex = 26;
            this.CmdSaveDialogLineContent.Text = "Save DialogLine";
            this.CmdSaveDialogLineContent.UseVisualStyleBackColor = false;
            this.CmdSaveDialogLineContent.Click += new System.EventHandler(this.CmdSaveDialogLineContent_Click);
            // 
            // LblCharacter
            // 
            this.LblCharacter.AutoSize = true;
            this.LblCharacter.Location = new System.Drawing.Point(211, 567);
            this.LblCharacter.Name = "LblCharacter";
            this.LblCharacter.Size = new System.Drawing.Size(59, 13);
            this.LblCharacter.TabIndex = 27;
            this.LblCharacter.Text = "Character:";
            // 
            // LblChapter
            // 
            this.LblChapter.AutoSize = true;
            this.LblChapter.Location = new System.Drawing.Point(12, 525);
            this.LblChapter.Name = "LblChapter";
            this.LblChapter.Size = new System.Drawing.Size(48, 13);
            this.LblChapter.TabIndex = 28;
            this.LblChapter.Text = "Chapter";
            // 
            // LblScene
            // 
            this.LblScene.AutoSize = true;
            this.LblScene.Location = new System.Drawing.Point(61, 525);
            this.LblScene.Name = "LblScene";
            this.LblScene.Size = new System.Drawing.Size(37, 13);
            this.LblScene.TabIndex = 29;
            this.LblScene.Text = "Scene";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Dialog";
            // 
            // LblNext0
            // 
            this.LblNext0.AutoSize = true;
            this.LblNext0.Location = new System.Drawing.Point(858, 584);
            this.LblNext0.Name = "LblNext0";
            this.LblNext0.Size = new System.Drawing.Size(69, 13);
            this.LblNext0.TabIndex = 31;
            this.LblNext0.Text = "Next Line (0)";
            // 
            // LblNext1
            // 
            this.LblNext1.AutoSize = true;
            this.LblNext1.Location = new System.Drawing.Point(858, 610);
            this.LblNext1.Name = "LblNext1";
            this.LblNext1.Size = new System.Drawing.Size(69, 13);
            this.LblNext1.TabIndex = 32;
            this.LblNext1.Text = "Next Line (1)";
            // 
            // LblNext2
            // 
            this.LblNext2.AutoSize = true;
            this.LblNext2.Location = new System.Drawing.Point(858, 636);
            this.LblNext2.Name = "LblNext2";
            this.LblNext2.Size = new System.Drawing.Size(69, 13);
            this.LblNext2.TabIndex = 33;
            this.LblNext2.Text = "Next Line (2)";
            // 
            // LblNext3
            // 
            this.LblNext3.AutoSize = true;
            this.LblNext3.Location = new System.Drawing.Point(858, 662);
            this.LblNext3.Name = "LblNext3";
            this.LblNext3.Size = new System.Drawing.Size(69, 13);
            this.LblNext3.TabIndex = 34;
            this.LblNext3.Text = "Next Line (3)";
            // 
            // LblRequirements
            // 
            this.LblRequirements.AutoSize = true;
            this.LblRequirements.Location = new System.Drawing.Point(666, 762);
            this.LblRequirements.Name = "LblRequirements";
            this.LblRequirements.Size = new System.Drawing.Size(152, 13);
            this.LblRequirements.TabIndex = 35;
            this.LblRequirements.Text = "Requirements (if-statement):";
            // 
            // LblEventTrigger
            // 
            this.LblEventTrigger.AutoSize = true;
            this.LblEventTrigger.Location = new System.Drawing.Point(817, 762);
            this.LblEventTrigger.Name = "LblEventTrigger";
            this.LblEventTrigger.Size = new System.Drawing.Size(124, 13);
            this.LblEventTrigger.TabIndex = 36;
            this.LblEventTrigger.Text = "Event Trigger (Event id)";
            // 
            // LblAudioGer
            // 
            this.LblAudioGer.AutoSize = true;
            this.LblAudioGer.Location = new System.Drawing.Point(989, 564);
            this.LblAudioGer.Name = "LblAudioGer";
            this.LblAudioGer.Size = new System.Drawing.Size(119, 13);
            this.LblAudioGer.TabIndex = 37;
            this.LblAudioGer.Text = "Audio File ID German:";
            // 
            // LblAudoEng
            // 
            this.LblAudoEng.AutoSize = true;
            this.LblAudoEng.Location = new System.Drawing.Point(989, 603);
            this.LblAudoEng.Name = "LblAudoEng";
            this.LblAudoEng.Size = new System.Drawing.Size(117, 13);
            this.LblAudoEng.TabIndex = 38;
            this.LblAudoEng.Text = "Audio File ID English:";
            // 
            // LblPause
            // 
            this.LblPause.AutoSize = true;
            this.LblPause.Location = new System.Drawing.Point(989, 643);
            this.LblPause.Name = "LblPause";
            this.LblPause.Size = new System.Drawing.Size(169, 13);
            this.LblPause.TabIndex = 39;
            this.LblPause.Text = "Silence between lines (seconds)";
            // 
            // LblContent
            // 
            this.LblContent.AutoSize = true;
            this.LblContent.Location = new System.Drawing.Point(211, 606);
            this.LblContent.Name = "LblContent";
            this.LblContent.Size = new System.Drawing.Size(155, 13);
            this.LblContent.TabIndex = 40;
            this.LblContent.Text = "What does the character say:";
            // 
            // LblTreeHeader
            // 
            this.LblTreeHeader.AutoSize = true;
            this.LblTreeHeader.Location = new System.Drawing.Point(12, 28);
            this.LblTreeHeader.Name = "LblTreeHeader";
            this.LblTreeHeader.Size = new System.Drawing.Size(132, 13);
            this.LblTreeHeader.TabIndex = 41;
            this.LblTreeHeader.Text = "Chapter / Scene / Dialog";
            // 
            // LblDataBaseHeader
            // 
            this.LblDataBaseHeader.AutoSize = true;
            this.LblDataBaseHeader.Location = new System.Drawing.Point(211, 28);
            this.LblDataBaseHeader.Name = "LblDataBaseHeader";
            this.LblDataBaseHeader.Size = new System.Drawing.Size(108, 13);
            this.LblDataBaseHeader.TabIndex = 42;
            this.LblDataBaseHeader.Text = "DataBase Overview:";
            // 
            // BoxPreview
            // 
            this.BoxPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BoxPreview.Location = new System.Drawing.Point(1173, 544);
            this.BoxPreview.Name = "BoxPreview";
            this.BoxPreview.Size = new System.Drawing.Size(503, 296);
            this.BoxPreview.TabIndex = 43;
            this.BoxPreview.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 764);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 76);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // LblPrevious
            // 
            this.LblPrevious.AutoSize = true;
            this.LblPrevious.Location = new System.Drawing.Point(589, 583);
            this.LblPrevious.Name = "LblPrevious";
            this.LblPrevious.Size = new System.Drawing.Size(77, 13);
            this.LblPrevious.TabIndex = 45;
            this.LblPrevious.Text = "Previous Line:";
            // 
            // LblPreview
            // 
            this.LblPreview.AutoSize = true;
            this.LblPreview.Location = new System.Drawing.Point(1170, 528);
            this.LblPreview.Name = "LblPreview";
            this.LblPreview.Size = new System.Drawing.Size(67, 13);
            this.LblPreview.TabIndex = 46;
            this.LblPreview.Text = "The Reader:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1723, 852);
            this.Controls.Add(this.LblPreview);
            this.Controls.Add(this.LblPrevious);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BoxPreview);
            this.Controls.Add(this.LblDataBaseHeader);
            this.Controls.Add(this.LblTreeHeader);
            this.Controls.Add(this.LblContent);
            this.Controls.Add(this.LblPause);
            this.Controls.Add(this.LblAudoEng);
            this.Controls.Add(this.LblAudioGer);
            this.Controls.Add(this.LblEventTrigger);
            this.Controls.Add(this.LblRequirements);
            this.Controls.Add(this.LblNext3);
            this.Controls.Add(this.LblNext2);
            this.Controls.Add(this.LblNext1);
            this.Controls.Add(this.LblNext0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblScene);
            this.Controls.Add(this.LblChapter);
            this.Controls.Add(this.LblCharacter);
            this.Controls.Add(this.CmdSaveDialogLineContent);
            this.Controls.Add(this.NumPause);
            this.Controls.Add(this.BoxAudioFileEng);
            this.Controls.Add(this.BoxAudioFileGer);
            this.Controls.Add(this.BoxRequirements);
            this.Controls.Add(this.NumEventTrigger);
            this.Controls.Add(this.BoxIsEntry);
            this.Controls.Add(this.BoxIsJump);
            this.Controls.Add(this.NumNext3);
            this.Controls.Add(this.NumNext2);
            this.Controls.Add(this.NumNext1);
            this.Controls.Add(this.NumNext0);
            this.Controls.Add(this.NumPrevious);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.BoxCharacterName);
            this.Controls.Add(this.CmdDeleteDialogLine);
            this.Controls.Add(this.LblActiveDialogLine);
            this.Controls.Add(this.CmdAddDialogLine);
            this.Controls.Add(this.DgvDataBase);
            this.Controls.Add(this.CmdDeleteFromDlcList);
            this.Controls.Add(this.NumDlcSelect);
            this.Controls.Add(this.NumSceneSelect);
            this.Controls.Add(this.NumChapterSelect);
            this.Controls.Add(this.CmdAddToDlcList);
            this.Controls.Add(this.LblActiveDlc);
            this.Controls.Add(this.TrvTreeView);
            this.Controls.Add(this.MnuMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.MainMenuStrip = this.MnuMenuStrip;
            this.Name = "Form1";
            this.Text = "DialogManager v 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MnuMenuStrip.ResumeLayout(false);
            this.MnuMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumChapterSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSceneSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDlcSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataBase)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNext0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNext2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNext3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEventTrigger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDataBaseToolStripMenuItem;
        private System.Windows.Forms.TreeView TrvTreeView;
        private System.Windows.Forms.Label LblActiveDlc;
        private System.Windows.Forms.Button CmdAddToDlcList;
        private System.Windows.Forms.NumericUpDown NumChapterSelect;
        private System.Windows.Forms.NumericUpDown NumSceneSelect;
        private System.Windows.Forms.NumericUpDown NumDlcSelect;
        private System.Windows.Forms.Button CmdDeleteFromDlcList;
        private System.Windows.Forms.DataGridView DgvDataBase;
        private System.Windows.Forms.Button CmdAddDialogLine;
        private System.Windows.Forms.Label LblActiveDialogLine;
        private System.Windows.Forms.Button CmdDeleteDialogLine;
        private System.Windows.Forms.TextBox BoxCharacterName;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox BoxContentGer;
        private System.Windows.Forms.RichTextBox BoxContentEng;
        private System.Windows.Forms.NumericUpDown NumPrevious;
        private System.Windows.Forms.NumericUpDown NumNext0;
        private System.Windows.Forms.NumericUpDown NumNext1;
        private System.Windows.Forms.NumericUpDown NumNext2;
        private System.Windows.Forms.NumericUpDown NumNext3;
        private System.Windows.Forms.CheckBox BoxIsJump;
        private System.Windows.Forms.CheckBox BoxIsEntry;
        private System.Windows.Forms.NumericUpDown NumEventTrigger;
        private System.Windows.Forms.TextBox BoxRequirements;
        private System.Windows.Forms.TextBox BoxAudioFileGer;
        private System.Windows.Forms.TextBox BoxAudioFileEng;
        private System.Windows.Forms.NumericUpDown NumPause;
        private System.Windows.Forms.Button CmdSaveDialogLineContent;
        private System.Windows.Forms.Label LblCharacter;
        private System.Windows.Forms.Label LblChapter;
        private System.Windows.Forms.Label LblScene;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblNext0;
        private System.Windows.Forms.Label LblNext1;
        private System.Windows.Forms.Label LblNext2;
        private System.Windows.Forms.Label LblNext3;
        private System.Windows.Forms.Label LblRequirements;
        private System.Windows.Forms.Label LblEventTrigger;
        private System.Windows.Forms.Label LblAudioGer;
        private System.Windows.Forms.Label LblAudoEng;
        private System.Windows.Forms.Label LblPause;
        private System.Windows.Forms.Label LblContent;
        private System.Windows.Forms.Label LblTreeHeader;
        private System.Windows.Forms.Label LblDataBaseHeader;
        private System.Windows.Forms.RichTextBox BoxPreview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblPrevious;
        private System.Windows.Forms.Label LblPreview;
    }
}

