﻿namespace Fo76ini
{
    partial class FormMods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMods));
            this.labelModName = new System.Windows.Forms.Label();
            this.textBoxModName = new System.Windows.Forms.TextBox();
            this.groupBoxModInstallType = new System.Windows.Forms.GroupBox();
            this.radioButtonModBA2ArchiveTextures = new System.Windows.Forms.RadioButton();
            this.radioButtonModSeparateBA2 = new System.Windows.Forms.RadioButton();
            this.radioButtonModBA2Archive = new System.Windows.Forms.RadioButton();
            this.radioButtonModLoose = new System.Windows.Forms.RadioButton();
            this.groupBoxGamePaths = new System.Windows.Forms.GroupBox();
            this.labelGamePath = new System.Windows.Forms.Label();
            this.textBoxArchive2Path = new System.Windows.Forms.TextBox();
            this.buttonPickArchive2Path = new System.Windows.Forms.Button();
            this.labelArchive2Path = new System.Windows.Forms.Label();
            this.textBoxGamePath = new System.Windows.Forms.TextBox();
            this.buttonPickGamePath = new System.Windows.Forms.Button();
            this.progressBarMods = new System.Windows.Forms.ProgressBar();
            this.buttonModsDeploy = new System.Windows.Forms.Button();
            this.labelModsDeploy = new System.Windows.Forms.Label();
            this.buttonModRemove = new System.Windows.Forms.Button();
            this.checkBoxModsCheckAll = new System.Windows.Forms.CheckBox();
            this.buttonModMoveUp = new System.Windows.Forms.Button();
            this.checkedListBoxMods = new System.Windows.Forms.CheckedListBox();
            this.buttonModMoveDown = new System.Windows.Forms.Button();
            this.groupBoxModEdit = new System.Windows.Forms.GroupBox();
            this.groupBoxBA2 = new System.Windows.Forms.GroupBox();
            this.radioButtonModBA2DDSFormat = new System.Windows.Forms.RadioButton();
            this.checkBoxModBA2Compression = new System.Windows.Forms.CheckBox();
            this.radioButtonModBA2GeneralFormat = new System.Windows.Forms.RadioButton();
            this.buttonModPickRootDir = new System.Windows.Forms.Button();
            this.textBoxModRootDir = new System.Windows.Forms.TextBox();
            this.labelModInstallInto = new System.Windows.Forms.Label();
            this.buttonModOpenFolder = new System.Windows.Forms.Button();
            this.groupBoxMods = new System.Windows.Forms.GroupBox();
            this.openFileDialogArchive2Path = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogGamePath = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogMod = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogMod = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxModsNWMode = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialogPickRootDir = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addModarchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deployToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showConflictingFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showREADMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxModsBundledBA2 = new System.Windows.Forms.GroupBox();
            this.checkBoxModsBundledTexturesBA2Compression = new System.Windows.Forms.CheckBox();
            this.checkBoxModsBundledBA2Compression = new System.Windows.Forms.CheckBox();
            this.labelModArchiveName = new System.Windows.Forms.Label();
            this.textBoxModArchiveName = new System.Windows.Forms.TextBox();
            this.labelModWarning = new System.Windows.Forms.Label();
            this.groupBoxModInstallType.SuspendLayout();
            this.groupBoxGamePaths.SuspendLayout();
            this.groupBoxModEdit.SuspendLayout();
            this.groupBoxBA2.SuspendLayout();
            this.groupBoxMods.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxModsBundledBA2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelModName
            // 
            this.labelModName.AutoSize = true;
            this.labelModName.Location = new System.Drawing.Point(6, 25);
            this.labelModName.Name = "labelModName";
            this.labelModName.Size = new System.Drawing.Size(60, 13);
            this.labelModName.TabIndex = 25;
            this.labelModName.Text = "Mod name:";
            // 
            // textBoxModName
            // 
            this.textBoxModName.Location = new System.Drawing.Point(82, 22);
            this.textBoxModName.Name = "textBoxModName";
            this.textBoxModName.Size = new System.Drawing.Size(230, 20);
            this.textBoxModName.TabIndex = 26;
            // 
            // groupBoxModInstallType
            // 
            this.groupBoxModInstallType.Controls.Add(this.radioButtonModBA2ArchiveTextures);
            this.groupBoxModInstallType.Controls.Add(this.radioButtonModSeparateBA2);
            this.groupBoxModInstallType.Controls.Add(this.radioButtonModBA2Archive);
            this.groupBoxModInstallType.Controls.Add(this.radioButtonModLoose);
            this.groupBoxModInstallType.Location = new System.Drawing.Point(9, 76);
            this.groupBoxModInstallType.Name = "groupBoxModInstallType";
            this.groupBoxModInstallType.Size = new System.Drawing.Size(302, 114);
            this.groupBoxModInstallType.TabIndex = 30;
            this.groupBoxModInstallType.TabStop = false;
            this.groupBoxModInstallType.Text = "Install as";
            // 
            // radioButtonModBA2ArchiveTextures
            // 
            this.radioButtonModBA2ArchiveTextures.AutoSize = true;
            this.radioButtonModBA2ArchiveTextures.Location = new System.Drawing.Point(6, 42);
            this.radioButtonModBA2ArchiveTextures.Name = "radioButtonModBA2ArchiveTextures";
            this.radioButtonModBA2ArchiveTextures.Size = new System.Drawing.Size(231, 17);
            this.radioButtonModBA2ArchiveTextures.TabIndex = 30;
            this.radioButtonModBA2ArchiveTextures.TabStop = true;
            this.radioButtonModBA2ArchiveTextures.Text = "Bundled *.ba2 archive (Textures, *.dds files)";
            this.radioButtonModBA2ArchiveTextures.UseVisualStyleBackColor = true;
            this.radioButtonModBA2ArchiveTextures.CheckedChanged += new System.EventHandler(this.radioButtonModBA2ArchiveTextures_CheckedChanged);
            // 
            // radioButtonModSeparateBA2
            // 
            this.radioButtonModSeparateBA2.AutoSize = true;
            this.radioButtonModSeparateBA2.Location = new System.Drawing.Point(6, 65);
            this.radioButtonModSeparateBA2.Name = "radioButtonModSeparateBA2";
            this.radioButtonModSeparateBA2.Size = new System.Drawing.Size(134, 17);
            this.radioButtonModSeparateBA2.TabIndex = 29;
            this.radioButtonModSeparateBA2.TabStop = true;
            this.radioButtonModSeparateBA2.Text = "Separate *.ba2 archive";
            this.radioButtonModSeparateBA2.UseVisualStyleBackColor = true;
            this.radioButtonModSeparateBA2.CheckedChanged += new System.EventHandler(this.radioButtonModSeparateBA2_CheckedChanged);
            // 
            // radioButtonModBA2Archive
            // 
            this.radioButtonModBA2Archive.AutoSize = true;
            this.radioButtonModBA2Archive.Location = new System.Drawing.Point(6, 19);
            this.radioButtonModBA2Archive.Name = "radioButtonModBA2Archive";
            this.radioButtonModBA2Archive.Size = new System.Drawing.Size(176, 17);
            this.radioButtonModBA2Archive.TabIndex = 27;
            this.radioButtonModBA2Archive.TabStop = true;
            this.radioButtonModBA2Archive.Text = "Bundled *.ba2 archive (General)";
            this.radioButtonModBA2Archive.UseVisualStyleBackColor = true;
            this.radioButtonModBA2Archive.CheckedChanged += new System.EventHandler(this.radioButtonModBA2Archive_CheckedChanged);
            // 
            // radioButtonModLoose
            // 
            this.radioButtonModLoose.AutoSize = true;
            this.radioButtonModLoose.Location = new System.Drawing.Point(6, 88);
            this.radioButtonModLoose.Name = "radioButtonModLoose";
            this.radioButtonModLoose.Size = new System.Drawing.Size(75, 17);
            this.radioButtonModLoose.TabIndex = 28;
            this.radioButtonModLoose.TabStop = true;
            this.radioButtonModLoose.Text = "Loose files";
            this.radioButtonModLoose.UseVisualStyleBackColor = true;
            this.radioButtonModLoose.CheckedChanged += new System.EventHandler(this.radioButtonModLoose_CheckedChanged);
            // 
            // groupBoxGamePaths
            // 
            this.groupBoxGamePaths.Controls.Add(this.labelGamePath);
            this.groupBoxGamePaths.Controls.Add(this.textBoxArchive2Path);
            this.groupBoxGamePaths.Controls.Add(this.buttonPickArchive2Path);
            this.groupBoxGamePaths.Controls.Add(this.labelArchive2Path);
            this.groupBoxGamePaths.Controls.Add(this.textBoxGamePath);
            this.groupBoxGamePaths.Controls.Add(this.buttonPickGamePath);
            this.groupBoxGamePaths.Location = new System.Drawing.Point(12, 360);
            this.groupBoxGamePaths.Name = "groupBoxGamePaths";
            this.groupBoxGamePaths.Size = new System.Drawing.Size(337, 77);
            this.groupBoxGamePaths.TabIndex = 38;
            this.groupBoxGamePaths.TabStop = false;
            this.groupBoxGamePaths.Text = "Paths";
            // 
            // labelGamePath
            // 
            this.labelGamePath.AutoSize = true;
            this.labelGamePath.Location = new System.Drawing.Point(6, 20);
            this.labelGamePath.Name = "labelGamePath";
            this.labelGamePath.Size = new System.Drawing.Size(78, 13);
            this.labelGamePath.TabIndex = 14;
            this.labelGamePath.Text = "Game location:";
            // 
            // textBoxArchive2Path
            // 
            this.textBoxArchive2Path.Location = new System.Drawing.Point(115, 46);
            this.textBoxArchive2Path.Name = "textBoxArchive2Path";
            this.textBoxArchive2Path.Size = new System.Drawing.Size(184, 20);
            this.textBoxArchive2Path.TabIndex = 17;
            this.textBoxArchive2Path.TextChanged += new System.EventHandler(this.textBoxArchive2Path_TextChanged);
            // 
            // buttonPickArchive2Path
            // 
            this.buttonPickArchive2Path.Location = new System.Drawing.Point(305, 44);
            this.buttonPickArchive2Path.Name = "buttonPickArchive2Path";
            this.buttonPickArchive2Path.Size = new System.Drawing.Size(26, 23);
            this.buttonPickArchive2Path.TabIndex = 18;
            this.buttonPickArchive2Path.Text = "...";
            this.buttonPickArchive2Path.UseVisualStyleBackColor = true;
            // 
            // labelArchive2Path
            // 
            this.labelArchive2Path.AutoSize = true;
            this.labelArchive2Path.Location = new System.Drawing.Point(6, 50);
            this.labelArchive2Path.Name = "labelArchive2Path";
            this.labelArchive2Path.Size = new System.Drawing.Size(92, 13);
            this.labelArchive2Path.TabIndex = 19;
            this.labelArchive2Path.Text = "Archive2 location:";
            // 
            // textBoxGamePath
            // 
            this.textBoxGamePath.Location = new System.Drawing.Point(115, 17);
            this.textBoxGamePath.Name = "textBoxGamePath";
            this.textBoxGamePath.Size = new System.Drawing.Size(184, 20);
            this.textBoxGamePath.TabIndex = 15;
            this.textBoxGamePath.TextChanged += new System.EventHandler(this.textBoxGamePath_TextChanged);
            // 
            // buttonPickGamePath
            // 
            this.buttonPickGamePath.Location = new System.Drawing.Point(305, 15);
            this.buttonPickGamePath.Name = "buttonPickGamePath";
            this.buttonPickGamePath.Size = new System.Drawing.Size(26, 23);
            this.buttonPickGamePath.TabIndex = 16;
            this.buttonPickGamePath.Text = "...";
            this.buttonPickGamePath.UseVisualStyleBackColor = true;
            // 
            // progressBarMods
            // 
            this.progressBarMods.Location = new System.Drawing.Point(12, 506);
            this.progressBarMods.Name = "progressBarMods";
            this.progressBarMods.Size = new System.Drawing.Size(500, 23);
            this.progressBarMods.TabIndex = 39;
            // 
            // buttonModsDeploy
            // 
            this.buttonModsDeploy.Location = new System.Drawing.Point(521, 506);
            this.buttonModsDeploy.Name = "buttonModsDeploy";
            this.buttonModsDeploy.Size = new System.Drawing.Size(154, 23);
            this.buttonModsDeploy.TabIndex = 31;
            this.buttonModsDeploy.Text = "Deploy";
            this.buttonModsDeploy.UseVisualStyleBackColor = true;
            this.buttonModsDeploy.Click += new System.EventHandler(this.buttonModsDeploy_Click);
            // 
            // labelModsDeploy
            // 
            this.labelModsDeploy.AutoSize = true;
            this.labelModsDeploy.ForeColor = System.Drawing.Color.Crimson;
            this.labelModsDeploy.Location = new System.Drawing.Point(12, 490);
            this.labelModsDeploy.Name = "labelModsDeploy";
            this.labelModsDeploy.Size = new System.Drawing.Size(114, 13);
            this.labelModsDeploy.TabIndex = 40;
            this.labelModsDeploy.Text = "Deployment necessary";
            // 
            // buttonModRemove
            // 
            this.buttonModRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonModRemove.Location = new System.Drawing.Point(187, 318);
            this.buttonModRemove.Name = "buttonModRemove";
            this.buttonModRemove.Size = new System.Drawing.Size(124, 23);
            this.buttonModRemove.TabIndex = 35;
            this.buttonModRemove.Text = "Delete mod";
            this.buttonModRemove.UseVisualStyleBackColor = true;
            this.buttonModRemove.Click += new System.EventHandler(this.buttonModRemove_Click);
            // 
            // checkBoxModsCheckAll
            // 
            this.checkBoxModsCheckAll.AutoSize = true;
            this.checkBoxModsCheckAll.Location = new System.Drawing.Point(6, 303);
            this.checkBoxModsCheckAll.Name = "checkBoxModsCheckAll";
            this.checkBoxModsCheckAll.Size = new System.Drawing.Size(117, 17);
            this.checkBoxModsCheckAll.TabIndex = 34;
            this.checkBoxModsCheckAll.Text = "Check/uncheck all";
            this.checkBoxModsCheckAll.UseVisualStyleBackColor = true;
            // 
            // buttonModMoveUp
            // 
            this.buttonModMoveUp.Location = new System.Drawing.Point(149, 299);
            this.buttonModMoveUp.Name = "buttonModMoveUp";
            this.buttonModMoveUp.Size = new System.Drawing.Size(88, 23);
            this.buttonModMoveUp.TabIndex = 36;
            this.buttonModMoveUp.Text = "Move up";
            this.buttonModMoveUp.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxMods
            // 
            this.checkedListBoxMods.FormattingEnabled = true;
            this.checkedListBoxMods.Location = new System.Drawing.Point(6, 19);
            this.checkedListBoxMods.Name = "checkedListBoxMods";
            this.checkedListBoxMods.ScrollAlwaysVisible = true;
            this.checkedListBoxMods.Size = new System.Drawing.Size(325, 274);
            this.checkedListBoxMods.TabIndex = 32;
            // 
            // buttonModMoveDown
            // 
            this.buttonModMoveDown.Location = new System.Drawing.Point(243, 299);
            this.buttonModMoveDown.Name = "buttonModMoveDown";
            this.buttonModMoveDown.Size = new System.Drawing.Size(88, 23);
            this.buttonModMoveDown.TabIndex = 37;
            this.buttonModMoveDown.Text = "Move down";
            this.buttonModMoveDown.UseVisualStyleBackColor = true;
            // 
            // groupBoxModEdit
            // 
            this.groupBoxModEdit.Controls.Add(this.groupBoxBA2);
            this.groupBoxModEdit.Controls.Add(this.buttonModPickRootDir);
            this.groupBoxModEdit.Controls.Add(this.textBoxModRootDir);
            this.groupBoxModEdit.Controls.Add(this.labelModInstallInto);
            this.groupBoxModEdit.Controls.Add(this.buttonModOpenFolder);
            this.groupBoxModEdit.Controls.Add(this.labelModName);
            this.groupBoxModEdit.Controls.Add(this.textBoxModName);
            this.groupBoxModEdit.Controls.Add(this.groupBoxModInstallType);
            this.groupBoxModEdit.Controls.Add(this.buttonModRemove);
            this.groupBoxModEdit.Location = new System.Drawing.Point(358, 27);
            this.groupBoxModEdit.Name = "groupBoxModEdit";
            this.groupBoxModEdit.Size = new System.Drawing.Size(317, 347);
            this.groupBoxModEdit.TabIndex = 42;
            this.groupBoxModEdit.TabStop = false;
            this.groupBoxModEdit.Text = "Edit mod details";
            // 
            // groupBoxBA2
            // 
            this.groupBoxBA2.Controls.Add(this.textBoxModArchiveName);
            this.groupBoxBA2.Controls.Add(this.labelModArchiveName);
            this.groupBoxBA2.Controls.Add(this.radioButtonModBA2DDSFormat);
            this.groupBoxBA2.Controls.Add(this.checkBoxModBA2Compression);
            this.groupBoxBA2.Controls.Add(this.radioButtonModBA2GeneralFormat);
            this.groupBoxBA2.Location = new System.Drawing.Point(9, 196);
            this.groupBoxBA2.Name = "groupBoxBA2";
            this.groupBoxBA2.Size = new System.Drawing.Size(302, 116);
            this.groupBoxBA2.TabIndex = 40;
            this.groupBoxBA2.TabStop = false;
            this.groupBoxBA2.Text = "BA2 settings";
            // 
            // radioButtonModBA2DDSFormat
            // 
            this.radioButtonModBA2DDSFormat.AutoSize = true;
            this.radioButtonModBA2DDSFormat.Location = new System.Drawing.Point(6, 91);
            this.radioButtonModBA2DDSFormat.Name = "radioButtonModBA2DDSFormat";
            this.radioButtonModBA2DDSFormat.Size = new System.Drawing.Size(163, 17);
            this.radioButtonModBA2DDSFormat.TabIndex = 2;
            this.radioButtonModBA2DDSFormat.TabStop = true;
            this.radioButtonModBA2DDSFormat.Text = "Use DDS format (for textures)";
            this.radioButtonModBA2DDSFormat.UseVisualStyleBackColor = true;
            this.radioButtonModBA2DDSFormat.CheckedChanged += new System.EventHandler(this.radioButtonModBA2DDSFormat_CheckedChanged);
            // 
            // checkBoxModBA2Compression
            // 
            this.checkBoxModBA2Compression.AutoSize = true;
            this.checkBoxModBA2Compression.Location = new System.Drawing.Point(6, 45);
            this.checkBoxModBA2Compression.Name = "checkBoxModBA2Compression";
            this.checkBoxModBA2Compression.Size = new System.Drawing.Size(110, 17);
            this.checkBoxModBA2Compression.TabIndex = 0;
            this.checkBoxModBA2Compression.Text = "Compress archive";
            this.checkBoxModBA2Compression.UseVisualStyleBackColor = true;
            this.checkBoxModBA2Compression.CheckedChanged += new System.EventHandler(this.checkBoxModBA2Compression_CheckedChanged);
            // 
            // radioButtonModBA2GeneralFormat
            // 
            this.radioButtonModBA2GeneralFormat.AutoSize = true;
            this.radioButtonModBA2GeneralFormat.Location = new System.Drawing.Point(6, 68);
            this.radioButtonModBA2GeneralFormat.Name = "radioButtonModBA2GeneralFormat";
            this.radioButtonModBA2GeneralFormat.Size = new System.Drawing.Size(114, 17);
            this.radioButtonModBA2GeneralFormat.TabIndex = 1;
            this.radioButtonModBA2GeneralFormat.TabStop = true;
            this.radioButtonModBA2GeneralFormat.Text = "Use general format";
            this.radioButtonModBA2GeneralFormat.UseVisualStyleBackColor = true;
            this.radioButtonModBA2GeneralFormat.CheckedChanged += new System.EventHandler(this.radioButtonModBA2GeneralFormat_CheckedChanged);
            // 
            // buttonModPickRootDir
            // 
            this.buttonModPickRootDir.Location = new System.Drawing.Point(286, 48);
            this.buttonModPickRootDir.Name = "buttonModPickRootDir";
            this.buttonModPickRootDir.Size = new System.Drawing.Size(26, 23);
            this.buttonModPickRootDir.TabIndex = 20;
            this.buttonModPickRootDir.Text = "...";
            this.buttonModPickRootDir.UseVisualStyleBackColor = true;
            this.buttonModPickRootDir.Click += new System.EventHandler(this.buttonModPickRootDir_Click);
            // 
            // textBoxModRootDir
            // 
            this.textBoxModRootDir.Location = new System.Drawing.Point(82, 50);
            this.textBoxModRootDir.Name = "textBoxModRootDir";
            this.textBoxModRootDir.Size = new System.Drawing.Size(201, 20);
            this.textBoxModRootDir.TabIndex = 39;
            this.textBoxModRootDir.TextChanged += new System.EventHandler(this.textBoxModRootDir_TextChanged);
            // 
            // labelModInstallInto
            // 
            this.labelModInstallInto.AutoSize = true;
            this.labelModInstallInto.Location = new System.Drawing.Point(7, 53);
            this.labelModInstallInto.Name = "labelModInstallInto";
            this.labelModInstallInto.Size = new System.Drawing.Size(57, 13);
            this.labelModInstallInto.TabIndex = 38;
            this.labelModInstallInto.Text = "Install into:";
            // 
            // buttonModOpenFolder
            // 
            this.buttonModOpenFolder.Location = new System.Drawing.Point(9, 318);
            this.buttonModOpenFolder.Name = "buttonModOpenFolder";
            this.buttonModOpenFolder.Size = new System.Drawing.Size(173, 23);
            this.buttonModOpenFolder.TabIndex = 36;
            this.buttonModOpenFolder.Text = "Open folder";
            this.buttonModOpenFolder.UseVisualStyleBackColor = true;
            this.buttonModOpenFolder.Click += new System.EventHandler(this.buttonModOpenFolder_Click);
            // 
            // groupBoxMods
            // 
            this.groupBoxMods.Controls.Add(this.checkedListBoxMods);
            this.groupBoxMods.Controls.Add(this.buttonModMoveUp);
            this.groupBoxMods.Controls.Add(this.buttonModMoveDown);
            this.groupBoxMods.Controls.Add(this.checkBoxModsCheckAll);
            this.groupBoxMods.Location = new System.Drawing.Point(12, 27);
            this.groupBoxMods.Name = "groupBoxMods";
            this.groupBoxMods.Size = new System.Drawing.Size(337, 327);
            this.groupBoxMods.TabIndex = 43;
            this.groupBoxMods.TabStop = false;
            this.groupBoxMods.Text = "Mod order";
            // 
            // openFileDialogArchive2Path
            // 
            this.openFileDialogArchive2Path.FileName = "Archive2.exe";
            this.openFileDialogArchive2Path.Filter = "Archive2.exe|Archive2.exe";
            // 
            // openFileDialogGamePath
            // 
            this.openFileDialogGamePath.FileName = "Fallout76.exe";
            this.openFileDialogGamePath.Filter = "Fallout76.exe|Fallout76.exe";
            // 
            // openFileDialogMod
            // 
            this.openFileDialogMod.AddExtension = false;
            this.openFileDialogMod.Filter = "All Archives|*.zip;*.rar;*.7z;*.tar;*.tar.gz;*.gz;*.xz;*.lz;*.bz2|Archive2|*.ba2";
            this.openFileDialogMod.Title = "Add *.ba2 or any other archive.";
            // 
            // checkBoxModsNWMode
            // 
            this.checkBoxModsNWMode.AutoSize = true;
            this.checkBoxModsNWMode.Location = new System.Drawing.Point(521, 486);
            this.checkBoxModsNWMode.Name = "checkBoxModsNWMode";
            this.checkBoxModsNWMode.Size = new System.Drawing.Size(126, 17);
            this.checkBoxModsNWMode.TabIndex = 45;
            this.checkBoxModsNWMode.Text = "Nuclear Winter mode";
            this.toolTip.SetToolTip(this.checkBoxModsNWMode, "If checked, all mods will be removed upon deploy.\r\nUseful if you want to play a N" +
        "uclear Winter match, hence the name.");
            this.checkBoxModsNWMode.UseVisualStyleBackColor = true;
            this.checkBoxModsNWMode.CheckedChanged += new System.EventHandler(this.checkBoxModsNWMode_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addModarchiveToolStripMenuItem,
            this.toolStripMenuItemModsImport,
            this.toolStripSeparator1,
            this.deployToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addModarchiveToolStripMenuItem
            // 
            this.addModarchiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromArchiveToolStripMenuItem,
            this.fromFolderToolStripMenuItem});
            this.addModarchiveToolStripMenuItem.Name = "addModarchiveToolStripMenuItem";
            this.addModarchiveToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addModarchiveToolStripMenuItem.Text = "Add mod";
            // 
            // fromArchiveToolStripMenuItem
            // 
            this.fromArchiveToolStripMenuItem.Name = "fromArchiveToolStripMenuItem";
            this.fromArchiveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.fromArchiveToolStripMenuItem.Text = "From archive";
            this.fromArchiveToolStripMenuItem.Click += new System.EventHandler(this.fromArchiveToolStripMenuItem_Click);
            // 
            // fromFolderToolStripMenuItem
            // 
            this.fromFolderToolStripMenuItem.Name = "fromFolderToolStripMenuItem";
            this.fromFolderToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.fromFolderToolStripMenuItem.Text = "From folder";
            this.fromFolderToolStripMenuItem.Click += new System.EventHandler(this.fromFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItemModsImport
            // 
            this.toolStripMenuItemModsImport.Name = "toolStripMenuItemModsImport";
            this.toolStripMenuItemModsImport.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemModsImport.Text = "Import installed mods";
            this.toolStripMenuItemModsImport.Click += new System.EventHandler(this.toolStripMenuItemModsImport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // deployToolStripMenuItem
            // 
            this.deployToolStripMenuItem.Name = "deployToolStripMenuItem";
            this.deployToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.deployToolStripMenuItem.Text = "Deploy";
            this.deployToolStripMenuItem.Click += new System.EventHandler(this.deployToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showConflictingFilesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.editToolStripMenuItem.Text = "View";
            // 
            // showConflictingFilesToolStripMenuItem
            // 
            this.showConflictingFilesToolStripMenuItem.Name = "showConflictingFilesToolStripMenuItem";
            this.showConflictingFilesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.showConflictingFilesToolStripMenuItem.Text = "Show conflicting files";
            this.showConflictingFilesToolStripMenuItem.Click += new System.EventHandler(this.showConflictingFilesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showREADMEToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // showREADMEToolStripMenuItem
            // 
            this.showREADMEToolStripMenuItem.Name = "showREADMEToolStripMenuItem";
            this.showREADMEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showREADMEToolStripMenuItem.Text = "Show README";
            this.showREADMEToolStripMenuItem.Click += new System.EventHandler(this.showREADMEToolStripMenuItem_Click);
            // 
            // groupBoxModsBundledBA2
            // 
            this.groupBoxModsBundledBA2.Controls.Add(this.checkBoxModsBundledBA2Compression);
            this.groupBoxModsBundledBA2.Controls.Add(this.checkBoxModsBundledTexturesBA2Compression);
            this.groupBoxModsBundledBA2.Location = new System.Drawing.Point(358, 380);
            this.groupBoxModsBundledBA2.Name = "groupBoxModsBundledBA2";
            this.groupBoxModsBundledBA2.Size = new System.Drawing.Size(317, 77);
            this.groupBoxModsBundledBA2.TabIndex = 49;
            this.groupBoxModsBundledBA2.TabStop = false;
            this.groupBoxModsBundledBA2.Text = "Bundled *.ba2 settings";
            // 
            // checkBoxModsBundledTexturesBA2Compression
            // 
            this.checkBoxModsBundledTexturesBA2Compression.AutoSize = true;
            this.checkBoxModsBundledTexturesBA2Compression.Location = new System.Drawing.Point(5, 42);
            this.checkBoxModsBundledTexturesBA2Compression.Name = "checkBoxModsBundledTexturesBA2Compression";
            this.checkBoxModsBundledTexturesBA2Compression.Size = new System.Drawing.Size(177, 17);
            this.checkBoxModsBundledTexturesBA2Compression.TabIndex = 0;
            this.checkBoxModsBundledTexturesBA2Compression.Text = "Compress bundled_textures.ba2";
            this.checkBoxModsBundledTexturesBA2Compression.UseVisualStyleBackColor = true;
            this.checkBoxModsBundledTexturesBA2Compression.CheckedChanged += new System.EventHandler(this.checkBoxModsBundledTexturesBA2Compression_CheckedChanged);
            // 
            // checkBoxModsBundledBA2Compression
            // 
            this.checkBoxModsBundledBA2Compression.AutoSize = true;
            this.checkBoxModsBundledBA2Compression.Location = new System.Drawing.Point(5, 19);
            this.checkBoxModsBundledBA2Compression.Name = "checkBoxModsBundledBA2Compression";
            this.checkBoxModsBundledBA2Compression.Size = new System.Drawing.Size(134, 17);
            this.checkBoxModsBundledBA2Compression.TabIndex = 1;
            this.checkBoxModsBundledBA2Compression.Text = "Compress bundled.ba2";
            this.checkBoxModsBundledBA2Compression.UseVisualStyleBackColor = true;
            this.checkBoxModsBundledBA2Compression.CheckedChanged += new System.EventHandler(this.checkBoxModsBundledBA2Compression_CheckedChanged);
            // 
            // labelModArchiveName
            // 
            this.labelModArchiveName.AutoSize = true;
            this.labelModArchiveName.Location = new System.Drawing.Point(6, 22);
            this.labelModArchiveName.Name = "labelModArchiveName";
            this.labelModArchiveName.Size = new System.Drawing.Size(75, 13);
            this.labelModArchiveName.TabIndex = 41;
            this.labelModArchiveName.Text = "Archive name:";
            // 
            // textBoxModArchiveName
            // 
            this.textBoxModArchiveName.Location = new System.Drawing.Point(87, 19);
            this.textBoxModArchiveName.Name = "textBoxModArchiveName";
            this.textBoxModArchiveName.Size = new System.Drawing.Size(209, 20);
            this.textBoxModArchiveName.TabIndex = 41;
            this.textBoxModArchiveName.TextChanged += new System.EventHandler(this.textBoxModArchiveName_TextChanged);
            // 
            // labelModWarning
            // 
            this.labelModWarning.AutoSize = true;
            this.labelModWarning.ForeColor = System.Drawing.Color.Red;
            this.labelModWarning.Location = new System.Drawing.Point(12, 440);
            this.labelModWarning.Name = "labelModWarning";
            this.labelModWarning.Size = new System.Drawing.Size(281, 26);
            this.labelModWarning.TabIndex = 44;
            this.labelModWarning.Text = "The use of mods can break your game or get you banned!\r\nWhen you install mods, yo" +
    "u accept full responsibility!";
            // 
            // FormMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 541);
            this.Controls.Add(this.groupBoxModsBundledBA2);
            this.Controls.Add(this.checkBoxModsNWMode);
            this.Controls.Add(this.labelModWarning);
            this.Controls.Add(this.groupBoxMods);
            this.Controls.Add(this.groupBoxModEdit);
            this.Controls.Add(this.groupBoxGamePaths);
            this.Controls.Add(this.progressBarMods);
            this.Controls.Add(this.buttonModsDeploy);
            this.Controls.Add(this.labelModsDeploy);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 580);
            this.MinimumSize = new System.Drawing.Size(700, 445);
            this.Name = "FormMods";
            this.Text = "Manage mods";
            this.groupBoxModInstallType.ResumeLayout(false);
            this.groupBoxModInstallType.PerformLayout();
            this.groupBoxGamePaths.ResumeLayout(false);
            this.groupBoxGamePaths.PerformLayout();
            this.groupBoxModEdit.ResumeLayout(false);
            this.groupBoxModEdit.PerformLayout();
            this.groupBoxBA2.ResumeLayout(false);
            this.groupBoxBA2.PerformLayout();
            this.groupBoxMods.ResumeLayout(false);
            this.groupBoxMods.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxModsBundledBA2.ResumeLayout(false);
            this.groupBoxModsBundledBA2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModName;
        private System.Windows.Forms.TextBox textBoxModName;
        private System.Windows.Forms.GroupBox groupBoxModInstallType;
        private System.Windows.Forms.RadioButton radioButtonModBA2Archive;
        private System.Windows.Forms.RadioButton radioButtonModLoose;
        private System.Windows.Forms.GroupBox groupBoxGamePaths;
        private System.Windows.Forms.Label labelGamePath;
        private System.Windows.Forms.TextBox textBoxArchive2Path;
        private System.Windows.Forms.Button buttonPickArchive2Path;
        private System.Windows.Forms.Label labelArchive2Path;
        private System.Windows.Forms.TextBox textBoxGamePath;
        private System.Windows.Forms.Button buttonPickGamePath;
        private System.Windows.Forms.ProgressBar progressBarMods;
        private System.Windows.Forms.Button buttonModsDeploy;
        private System.Windows.Forms.Label labelModsDeploy;
        private System.Windows.Forms.Button buttonModRemove;
        private System.Windows.Forms.CheckBox checkBoxModsCheckAll;
        private System.Windows.Forms.Button buttonModMoveUp;
        private System.Windows.Forms.CheckedListBox checkedListBoxMods;
        private System.Windows.Forms.Button buttonModMoveDown;
        private System.Windows.Forms.GroupBox groupBoxModEdit;
        private System.Windows.Forms.GroupBox groupBoxMods;
        private System.Windows.Forms.OpenFileDialog openFileDialogArchive2Path;
        private System.Windows.Forms.OpenFileDialog openFileDialogGamePath;
        private System.Windows.Forms.OpenFileDialog openFileDialogMod;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogMod;
        private System.Windows.Forms.Button buttonModOpenFolder;
        private System.Windows.Forms.CheckBox checkBoxModsNWMode;
        public System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonModPickRootDir;
        private System.Windows.Forms.TextBox textBoxModRootDir;
        private System.Windows.Forms.Label labelModInstallInto;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPickRootDir;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addModarchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showREADMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deployToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showConflictingFilesToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonModBA2ArchiveTextures;
        private System.Windows.Forms.RadioButton radioButtonModSeparateBA2;
        private System.Windows.Forms.GroupBox groupBoxBA2;
        private System.Windows.Forms.RadioButton radioButtonModBA2DDSFormat;
        private System.Windows.Forms.CheckBox checkBoxModBA2Compression;
        private System.Windows.Forms.RadioButton radioButtonModBA2GeneralFormat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModsImport;
        private System.Windows.Forms.GroupBox groupBoxModsBundledBA2;
        private System.Windows.Forms.CheckBox checkBoxModsBundledBA2Compression;
        private System.Windows.Forms.CheckBox checkBoxModsBundledTexturesBA2Compression;
        private System.Windows.Forms.TextBox textBoxModArchiveName;
        private System.Windows.Forms.Label labelModArchiveName;
        private System.Windows.Forms.Label labelModWarning;
    }
}