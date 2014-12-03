namespace CodeUtility
{
	partial class Form1
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbRepoLoc = new System.Windows.Forms.TextBox();
			this.btnRepoLoc = new System.Windows.Forms.Button();
			this.cmbRange = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbDlls = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ddlRepoType = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ddlFileFilterType = new System.Windows.Forms.ComboBox();
			this.tbFilters = new System.Windows.Forms.TextBox();
			this.btnZipLoc = new System.Windows.Forms.Button();
			this.tbZipLoc = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnVersionRelease = new System.Windows.Forms.Button();
			this.tbOutput = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnGitExe = new System.Windows.Forms.Button();
			this.tbGitExe = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnSvnExe = new System.Windows.Forms.Button();
			this.tbSvnExe = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.ddlBackupType = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbBackupFiles = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnBackupZipLoc = new System.Windows.Forms.Button();
			this.tbBackupZipLoc = new System.Windows.Forms.TextBox();
			this.tbBackupRootLoc = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btnBackupStart = new System.Windows.Forms.Button();
			this.btnRestoreZipFile = new System.Windows.Forms.Button();
			this.tbRestoreZipFile = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.btnRestoreLoc = new System.Windows.Forms.Button();
			this.tbRestoreLoc = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.btnRestoreStart = new System.Windows.Forms.Button();
			this.btnSettingsSave = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tbBackupFolder = new System.Windows.Forms.TextBox();
			this.btnBackupFolder = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(390, 340);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnVersionRelease);
			this.tabPage1.Controls.Add(this.btnZipLoc);
			this.tabPage1.Controls.Add(this.tbZipLoc);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.tbFilters);
			this.tabPage1.Controls.Add(this.ddlFileFilterType);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.ddlRepoType);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.cbDlls);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.cmbRange);
			this.tabPage1.Controls.Add(this.btnRepoLoc);
			this.tabPage1.Controls.Add(this.tbRepoLoc);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(382, 314);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Version Release";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.btnBackupFolder);
			this.tabPage3.Controls.Add(this.tbBackupFolder);
			this.tabPage3.Controls.Add(this.btnBackupStart);
			this.tabPage3.Controls.Add(this.tbBackupRootLoc);
			this.tabPage3.Controls.Add(this.label12);
			this.tabPage3.Controls.Add(this.btnBackupZipLoc);
			this.tabPage3.Controls.Add(this.tbBackupZipLoc);
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Controls.Add(this.tbBackupFiles);
			this.tabPage3.Controls.Add(this.ddlBackupType);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(382, 314);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Backup";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.btnRestoreStart);
			this.tabPage4.Controls.Add(this.btnRestoreLoc);
			this.tabPage4.Controls.Add(this.tbRestoreLoc);
			this.tabPage4.Controls.Add(this.label14);
			this.tabPage4.Controls.Add(this.btnRestoreZipFile);
			this.tabPage4.Controls.Add(this.tbRestoreZipFile);
			this.tabPage4.Controls.Add(this.label13);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(382, 314);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Restore";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Repo Loc: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Range: ";
			// 
			// tbRepoLoc
			// 
			this.tbRepoLoc.Location = new System.Drawing.Point(93, 38);
			this.tbRepoLoc.Name = "tbRepoLoc";
			this.tbRepoLoc.Size = new System.Drawing.Size(236, 20);
			this.tbRepoLoc.TabIndex = 2;
			// 
			// btnRepoLoc
			// 
			this.btnRepoLoc.Location = new System.Drawing.Point(335, 37);
			this.btnRepoLoc.Name = "btnRepoLoc";
			this.btnRepoLoc.Size = new System.Drawing.Size(28, 23);
			this.btnRepoLoc.TabIndex = 3;
			this.btnRepoLoc.Text = "...";
			this.btnRepoLoc.UseVisualStyleBackColor = true;
			this.btnRepoLoc.Click += new System.EventHandler(this.btnRepoLoc_Click);
			// 
			// cmbRange
			// 
			this.cmbRange.FormattingEnabled = true;
			this.cmbRange.Location = new System.Drawing.Point(93, 98);
			this.cmbRange.Name = "cmbRange";
			this.cmbRange.Size = new System.Drawing.Size(169, 21);
			this.cmbRange.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Include dlls: ";
			// 
			// cbDlls
			// 
			this.cbDlls.AutoSize = true;
			this.cbDlls.Location = new System.Drawing.Point(93, 131);
			this.cbDlls.Name = "cbDlls";
			this.cbDlls.Size = new System.Drawing.Size(15, 14);
			this.cbDlls.TabIndex = 7;
			this.cbDlls.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Repo type: ";
			// 
			// ddlRepoType
			// 
			this.ddlRepoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlRepoType.FormattingEnabled = true;
			this.ddlRepoType.Items.AddRange(new object[] {
            "Git",
            "SVN"});
			this.ddlRepoType.Location = new System.Drawing.Point(93, 8);
			this.ddlRepoType.Name = "ddlRepoType";
			this.ddlRepoType.Size = new System.Drawing.Size(169, 21);
			this.ddlRepoType.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "File Filter:  ";
			// 
			// ddlFileFilterType
			// 
			this.ddlFileFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlFileFilterType.FormattingEnabled = true;
			this.ddlFileFilterType.Items.AddRange(new object[] {
            "Inclusion",
            "Exclusion"});
			this.ddlFileFilterType.Location = new System.Drawing.Point(93, 158);
			this.ddlFileFilterType.Name = "ddlFileFilterType";
			this.ddlFileFilterType.Size = new System.Drawing.Size(169, 21);
			this.ddlFileFilterType.TabIndex = 8;
			// 
			// tbFilters
			// 
			this.tbFilters.Location = new System.Drawing.Point(93, 188);
			this.tbFilters.Multiline = true;
			this.tbFilters.Name = "tbFilters";
			this.tbFilters.Size = new System.Drawing.Size(236, 75);
			this.tbFilters.TabIndex = 9;
			// 
			// btnZipLoc
			// 
			this.btnZipLoc.Location = new System.Drawing.Point(335, 67);
			this.btnZipLoc.Name = "btnZipLoc";
			this.btnZipLoc.Size = new System.Drawing.Size(28, 23);
			this.btnZipLoc.TabIndex = 5;
			this.btnZipLoc.Text = "...";
			this.btnZipLoc.UseVisualStyleBackColor = true;
			this.btnZipLoc.Click += new System.EventHandler(this.btnZipLoc_Click);
			// 
			// tbZipLoc
			// 
			this.tbZipLoc.Location = new System.Drawing.Point(93, 68);
			this.tbZipLoc.Name = "tbZipLoc";
			this.tbZipLoc.Size = new System.Drawing.Size(236, 20);
			this.tbZipLoc.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Zip Loc: ";
			// 
			// btnVersionRelease
			// 
			this.btnVersionRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnVersionRelease.Location = new System.Drawing.Point(288, 279);
			this.btnVersionRelease.Name = "btnVersionRelease";
			this.btnVersionRelease.Size = new System.Drawing.Size(75, 23);
			this.btnVersionRelease.TabIndex = 10;
			this.btnVersionRelease.Text = "Start";
			this.btnVersionRelease.UseVisualStyleBackColor = true;
			this.btnVersionRelease.Click += new System.EventHandler(this.btnVersionRelease_Click);
			// 
			// tbOutput
			// 
			this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbOutput.Location = new System.Drawing.Point(12, 380);
			this.tbOutput.Multiline = true;
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.ReadOnly = true;
			this.tbOutput.Size = new System.Drawing.Size(386, 137);
			this.tbOutput.TabIndex = 100;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 361);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "&Output: ";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnSettingsSave);
			this.tabPage2.Controls.Add(this.btnSvnExe);
			this.tabPage2.Controls.Add(this.tbSvnExe);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.btnGitExe);
			this.tabPage2.Controls.Add(this.tbGitExe);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(382, 314);
			this.tabPage2.TabIndex = 4;
			this.tabPage2.Text = "Settings";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnGitExe
			// 
			this.btnGitExe.Location = new System.Drawing.Point(338, 9);
			this.btnGitExe.Name = "btnGitExe";
			this.btnGitExe.Size = new System.Drawing.Size(28, 23);
			this.btnGitExe.TabIndex = 6;
			this.btnGitExe.Text = "...";
			this.btnGitExe.UseVisualStyleBackColor = true;
			this.btnGitExe.Click += new System.EventHandler(this.btnGitExe_Click);
			// 
			// tbGitExe
			// 
			this.tbGitExe.Location = new System.Drawing.Point(96, 12);
			this.tbGitExe.Name = "tbGitExe";
			this.tbGitExe.Size = new System.Drawing.Size(236, 20);
			this.tbGitExe.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(9, 14);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Git.exe: ";
			// 
			// btnSvnExe
			// 
			this.btnSvnExe.Location = new System.Drawing.Point(338, 35);
			this.btnSvnExe.Name = "btnSvnExe";
			this.btnSvnExe.Size = new System.Drawing.Size(28, 23);
			this.btnSvnExe.TabIndex = 9;
			this.btnSvnExe.Text = "...";
			this.btnSvnExe.UseVisualStyleBackColor = true;
			this.btnSvnExe.Click += new System.EventHandler(this.btnSvnExe_Click);
			// 
			// tbSvnExe
			// 
			this.tbSvnExe.Location = new System.Drawing.Point(96, 38);
			this.tbSvnExe.Name = "tbSvnExe";
			this.tbSvnExe.Size = new System.Drawing.Size(236, 20);
			this.tbSvnExe.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(9, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 13);
			this.label9.TabIndex = 7;
			this.label9.Text = "SVN.exe: ";
			// 
			// ddlBackupType
			// 
			this.ddlBackupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlBackupType.FormattingEnabled = true;
			this.ddlBackupType.Items.AddRange(new object[] {
            "Folder",
            "File List"});
			this.ddlBackupType.Location = new System.Drawing.Point(93, 8);
			this.ddlBackupType.Name = "ddlBackupType";
			this.ddlBackupType.Size = new System.Drawing.Size(169, 21);
			this.ddlBackupType.TabIndex = 1;
			this.ddlBackupType.SelectedIndexChanged += new System.EventHandler(this.ddlBackupType_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 12);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "Type: ";
			// 
			// tbBackupFiles
			// 
			this.tbBackupFiles.Location = new System.Drawing.Point(93, 61);
			this.tbBackupFiles.Multiline = true;
			this.tbBackupFiles.Name = "tbBackupFiles";
			this.tbBackupFiles.Size = new System.Drawing.Size(234, 120);
			this.tbBackupFiles.TabIndex = 2;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 193);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(49, 13);
			this.label11.TabIndex = 11;
			this.label11.Text = "Zip Loc: ";
			// 
			// btnBackupZipLoc
			// 
			this.btnBackupZipLoc.Location = new System.Drawing.Point(335, 188);
			this.btnBackupZipLoc.Name = "btnBackupZipLoc";
			this.btnBackupZipLoc.Size = new System.Drawing.Size(28, 23);
			this.btnBackupZipLoc.TabIndex = 4;
			this.btnBackupZipLoc.Text = "...";
			this.btnBackupZipLoc.UseVisualStyleBackColor = true;
			this.btnBackupZipLoc.Click += new System.EventHandler(this.btnBackupZipLoc_Click);
			// 
			// tbBackupZipLoc
			// 
			this.tbBackupZipLoc.Location = new System.Drawing.Point(93, 189);
			this.tbBackupZipLoc.Name = "tbBackupZipLoc";
			this.tbBackupZipLoc.Size = new System.Drawing.Size(236, 20);
			this.tbBackupZipLoc.TabIndex = 3;
			// 
			// tbBackupRootLoc
			// 
			this.tbBackupRootLoc.Location = new System.Drawing.Point(93, 216);
			this.tbBackupRootLoc.Name = "tbBackupRootLoc";
			this.tbBackupRootLoc.Size = new System.Drawing.Size(236, 20);
			this.tbBackupRootLoc.TabIndex = 5;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 220);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(57, 13);
			this.label12.TabIndex = 14;
			this.label12.Text = "Root Loc: ";
			// 
			// btnBackupStart
			// 
			this.btnBackupStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBackupStart.Location = new System.Drawing.Point(288, 276);
			this.btnBackupStart.Name = "btnBackupStart";
			this.btnBackupStart.Size = new System.Drawing.Size(75, 23);
			this.btnBackupStart.TabIndex = 6;
			this.btnBackupStart.Text = "Start";
			this.btnBackupStart.UseVisualStyleBackColor = true;
			this.btnBackupStart.Click += new System.EventHandler(this.btnBackupStart_Click);
			// 
			// btnRestoreZipFile
			// 
			this.btnRestoreZipFile.Location = new System.Drawing.Point(338, 8);
			this.btnRestoreZipFile.Name = "btnRestoreZipFile";
			this.btnRestoreZipFile.Size = new System.Drawing.Size(28, 23);
			this.btnRestoreZipFile.TabIndex = 2;
			this.btnRestoreZipFile.Text = "...";
			this.btnRestoreZipFile.UseVisualStyleBackColor = true;
			this.btnRestoreZipFile.Click += new System.EventHandler(this.btnRestoreZipFile_Click);
			// 
			// tbRestoreZipFile
			// 
			this.tbRestoreZipFile.Location = new System.Drawing.Point(96, 9);
			this.tbRestoreZipFile.Name = "tbRestoreZipFile";
			this.tbRestoreZipFile.Size = new System.Drawing.Size(236, 20);
			this.tbRestoreZipFile.TabIndex = 1;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(9, 13);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(47, 13);
			this.label13.TabIndex = 14;
			this.label13.Text = "Zip File: ";
			// 
			// btnRestoreLoc
			// 
			this.btnRestoreLoc.Location = new System.Drawing.Point(338, 36);
			this.btnRestoreLoc.Name = "btnRestoreLoc";
			this.btnRestoreLoc.Size = new System.Drawing.Size(28, 23);
			this.btnRestoreLoc.TabIndex = 4;
			this.btnRestoreLoc.Text = "...";
			this.btnRestoreLoc.UseVisualStyleBackColor = true;
			this.btnRestoreLoc.Click += new System.EventHandler(this.btnRestoreLoc_Click);
			// 
			// tbRestoreLoc
			// 
			this.tbRestoreLoc.Location = new System.Drawing.Point(96, 37);
			this.tbRestoreLoc.Name = "tbRestoreLoc";
			this.tbRestoreLoc.Size = new System.Drawing.Size(236, 20);
			this.tbRestoreLoc.TabIndex = 3;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(9, 41);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(71, 13);
			this.label14.TabIndex = 17;
			this.label14.Text = "Restore Loc: ";
			// 
			// btnRestoreStart
			// 
			this.btnRestoreStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRestoreStart.Location = new System.Drawing.Point(291, 278);
			this.btnRestoreStart.Name = "btnRestoreStart";
			this.btnRestoreStart.Size = new System.Drawing.Size(75, 23);
			this.btnRestoreStart.TabIndex = 18;
			this.btnRestoreStart.Text = "Start";
			this.btnRestoreStart.UseVisualStyleBackColor = true;
			this.btnRestoreStart.Click += new System.EventHandler(this.btnRestoreStart_Click);
			// 
			// btnSettingsSave
			// 
			this.btnSettingsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSettingsSave.Location = new System.Drawing.Point(291, 277);
			this.btnSettingsSave.Name = "btnSettingsSave";
			this.btnSettingsSave.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsSave.TabIndex = 19;
			this.btnSettingsSave.Text = "Save";
			this.btnSettingsSave.UseVisualStyleBackColor = true;
			this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// tbBackupFolder
			// 
			this.tbBackupFolder.Location = new System.Drawing.Point(93, 35);
			this.tbBackupFolder.Name = "tbBackupFolder";
			this.tbBackupFolder.Size = new System.Drawing.Size(236, 20);
			this.tbBackupFolder.TabIndex = 15;
			// 
			// btnBackupFolder
			// 
			this.btnBackupFolder.Location = new System.Drawing.Point(335, 34);
			this.btnBackupFolder.Name = "btnBackupFolder";
			this.btnBackupFolder.Size = new System.Drawing.Size(28, 23);
			this.btnBackupFolder.TabIndex = 16;
			this.btnBackupFolder.Text = "...";
			this.btnBackupFolder.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 529);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbOutput);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Code Utility";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ComboBox ddlRepoType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cbDlls;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbRange;
		private System.Windows.Forms.Button btnRepoLoc;
		private System.Windows.Forms.TextBox tbRepoLoc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TextBox tbFilters;
		private System.Windows.Forms.ComboBox ddlFileFilterType;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnZipLoc;
		private System.Windows.Forms.TextBox tbZipLoc;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnVersionRelease;
		private System.Windows.Forms.TextBox tbOutput;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnSvnExe;
		private System.Windows.Forms.TextBox tbSvnExe;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnGitExe;
		private System.Windows.Forms.TextBox tbGitExe;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox ddlBackupType;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tbBackupRootLoc;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnBackupZipLoc;
		private System.Windows.Forms.TextBox tbBackupZipLoc;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox tbBackupFiles;
		private System.Windows.Forms.Button btnBackupStart;
		private System.Windows.Forms.Button btnRestoreZipFile;
		private System.Windows.Forms.TextBox tbRestoreZipFile;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnRestoreLoc;
		private System.Windows.Forms.TextBox tbRestoreLoc;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button btnRestoreStart;
		private System.Windows.Forms.Button btnSettingsSave;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnBackupFolder;
		private System.Windows.Forms.TextBox tbBackupFolder;
	}
}

