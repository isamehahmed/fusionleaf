namespace WAMPer
{
    partial class frmMain
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
        	this.chbHide = new System.Windows.Forms.CheckBox();
        	this.msTop = new System.Windows.Forms.MenuStrip();
        	this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.theseOverwriteTheConfigurationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.databaseConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.webServerConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.pHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.theseAreOverwrittenByTemplatesWhenStartIsClickedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsmMySQL = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsmWeb = new System.Windows.Forms.ToolStripMenuItem();
        	this.tsmPHP = new System.Windows.Forms.ToolStripMenuItem();
        	this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.indexphpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.editIndexphpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.exploreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.databaseFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.webServerFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.pHPFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.memcachedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.sessionsAndPHPLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.webRootwwwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.scriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.installPEARForPHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.removePEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.installPHPUnitForPHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.uninstallPHPUnitForPHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.restoreLatestFusionLeafDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.authorJoeSpurrierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.fusionLeafOnSourceForgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.apacheV20LicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.copyright2012ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.niTaskbar = new System.Windows.Forms.NotifyIcon(this.components);
        	this.cmsTaskbar = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.ssStatus = new System.Windows.Forms.StatusStrip();
        	this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
        	this.tabPage2 = new System.Windows.Forms.TabPage();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.numMemcachedPort = new System.Windows.Forms.NumericUpDown();
        	this.label9 = new System.Windows.Forms.Label();
        	this.txtMemcachedStatus = new System.Windows.Forms.Label();
        	this.label11 = new System.Windows.Forms.Label();
        	this.btnMemcachedStop = new System.Windows.Forms.Button();
        	this.btnMemcachedStart = new System.Windows.Forms.Button();
        	this.groupBox4 = new System.Windows.Forms.GroupBox();
        	this.numMySQLPort = new System.Windows.Forms.NumericUpDown();
        	this.label7 = new System.Windows.Forms.Label();
        	this.txtMySQLStatus = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.btnMySQLStop = new System.Windows.Forms.Button();
        	this.btnMySQLStart = new System.Windows.Forms.Button();
        	this.groupBox3 = new System.Windows.Forms.GroupBox();
        	this.numFCGIPort = new System.Windows.Forms.NumericUpDown();
        	this.label6 = new System.Windows.Forms.Label();
        	this.numFCGIRequests = new System.Windows.Forms.NumericUpDown();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.numFCGIThreads = new System.Windows.Forms.NumericUpDown();
        	this.txtFCGIStatus = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.btnFCGIStop = new System.Windows.Forms.Button();
        	this.btnFCGIStart = new System.Windows.Forms.Button();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.numNginxPort = new System.Windows.Forms.NumericUpDown();
        	this.label8 = new System.Windows.Forms.Label();
        	this.txtNginxStatus = new System.Windows.Forms.Label();
        	this.txtNginxStatus2 = new System.Windows.Forms.Label();
        	this.btnNginxStart = new System.Windows.Forms.Button();
        	this.btnNginxReopen = new System.Windows.Forms.Button();
        	this.btnNginxStop = new System.Windows.Forms.Button();
        	this.btnNginxReload = new System.Windows.Forms.Button();
        	this.tabPage1 = new System.Windows.Forms.TabPage();
        	this.btnTest = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.btnStart = new System.Windows.Forms.Button();
        	this.tabControl = new System.Windows.Forms.TabControl();
        	this.tabPage3 = new System.Windows.Forms.TabPage();
        	this.rtxLog = new System.Windows.Forms.RichTextBox();
        	this.tTip = new System.Windows.Forms.ToolTip(this.components);
        	this.msTop.SuspendLayout();
        	this.cmsTaskbar.SuspendLayout();
        	this.ssStatus.SuspendLayout();
        	this.tabPage2.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numMemcachedPort)).BeginInit();
        	this.groupBox4.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numMySQLPort)).BeginInit();
        	this.groupBox3.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numFCGIPort)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.numFCGIRequests)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.numFCGIThreads)).BeginInit();
        	this.groupBox1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numNginxPort)).BeginInit();
        	this.tabPage1.SuspendLayout();
        	this.tabControl.SuspendLayout();
        	this.tabPage3.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// chbHide
        	// 
        	this.chbHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.chbHide.AutoSize = true;
        	this.chbHide.Checked = true;
        	this.chbHide.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.chbHide.Location = new System.Drawing.Point(12, 296);
        	this.chbHide.Name = "chbHide";
        	this.chbHide.Size = new System.Drawing.Size(121, 17);
        	this.chbHide.TabIndex = 1;
        	this.chbHide.Text = "Hide DOS Windows";
        	this.chbHide.UseVisualStyleBackColor = true;
        	// 
        	// msTop
        	// 
        	this.msTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.templatesToolStripMenuItem,
        	        	        	this.editToolStripMenuItem,
        	        	        	this.viewToolStripMenuItem,
        	        	        	this.exploreToolStripMenuItem,
        	        	        	this.scriptsToolStripMenuItem,
        	        	        	this.aboutToolStripMenuItem});
        	this.msTop.Location = new System.Drawing.Point(0, 0);
        	this.msTop.Name = "msTop";
        	this.msTop.Size = new System.Drawing.Size(480, 24);
        	this.msTop.TabIndex = 5;
        	this.msTop.Text = "menuStrip1";
        	// 
        	// templatesToolStripMenuItem
        	// 
        	this.templatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.theseOverwriteTheConfigurationsToolStripMenuItem,
        	        	        	this.databaseConfigToolStripMenuItem,
        	        	        	this.webServerConfigToolStripMenuItem,
        	        	        	this.pHPToolStripMenuItem});
        	this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
        	this.templatesToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
        	this.templatesToolStripMenuItem.Text = "Edit";
        	this.templatesToolStripMenuItem.ToolTipText = "All the templates have variables that are replaced when the application is starte" +
        	"d. They replace the Configurations under the Edit menu.";
        	// 
        	// theseOverwriteTheConfigurationsToolStripMenuItem
        	// 
        	this.theseOverwriteTheConfigurationsToolStripMenuItem.Enabled = false;
        	this.theseOverwriteTheConfigurationsToolStripMenuItem.Name = "theseOverwriteTheConfigurationsToolStripMenuItem";
        	this.theseOverwriteTheConfigurationsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
        	this.theseOverwriteTheConfigurationsToolStripMenuItem.Text = "Startup Configurations";
        	// 
        	// databaseConfigToolStripMenuItem
        	// 
        	this.databaseConfigToolStripMenuItem.Name = "databaseConfigToolStripMenuItem";
        	this.databaseConfigToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
        	this.databaseConfigToolStripMenuItem.Text = "Database";
        	this.databaseConfigToolStripMenuItem.Click += new System.EventHandler(this.DatabaseConfigToolStripMenuItemClick);
        	// 
        	// webServerConfigToolStripMenuItem
        	// 
        	this.webServerConfigToolStripMenuItem.Name = "webServerConfigToolStripMenuItem";
        	this.webServerConfigToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
        	this.webServerConfigToolStripMenuItem.Text = "Web Server";
        	this.webServerConfigToolStripMenuItem.Click += new System.EventHandler(this.WebServerConfigToolStripMenuItemClick);
        	// 
        	// pHPToolStripMenuItem
        	// 
        	this.pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
        	this.pHPToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
        	this.pHPToolStripMenuItem.Text = "PHP";
        	this.pHPToolStripMenuItem.Click += new System.EventHandler(this.PHPToolStripMenuItemClick);
        	// 
        	// editToolStripMenuItem
        	// 
        	this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.theseAreOverwrittenByTemplatesWhenStartIsClickedToolStripMenuItem,
        	        	        	this.tsmMySQL,
        	        	        	this.tsmWeb,
        	        	        	this.tsmPHP});
        	this.editToolStripMenuItem.Name = "editToolStripMenuItem";
        	this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        	this.editToolStripMenuItem.Text = "View";
        	// 
        	// theseAreOverwrittenByTemplatesWhenStartIsClickedToolStripMenuItem
        	// 
        	this.theseAreOverwrittenByTemplatesWhenStartIsClickedToolStripMenuItem.Enabled = false;
        	this.theseAreOverwrittenByTemplatesWhenStartIsClickedToolStripMenuItem.Name = "theseAreOverwrittenByTemplatesWhenStartIsClickedToolStripMenuItem";
        	this.theseAreOverwrittenByTemplatesWhenStartIsClickedToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
        	this.theseAreOverwrittenByTemplatesWhenStartIsClickedToolStripMenuItem.Text = "Running Configurations";
        	// 
        	// tsmMySQL
        	// 
        	this.tsmMySQL.Name = "tsmMySQL";
        	this.tsmMySQL.Size = new System.Drawing.Size(201, 22);
        	this.tsmMySQL.Text = "Database";
        	this.tsmMySQL.Click += new System.EventHandler(this.tsmMySQL_Click);
        	// 
        	// tsmWeb
        	// 
        	this.tsmWeb.Name = "tsmWeb";
        	this.tsmWeb.Size = new System.Drawing.Size(201, 22);
        	this.tsmWeb.Text = "Web Server";
        	this.tsmWeb.Click += new System.EventHandler(this.tsmWeb_Click);
        	// 
        	// tsmPHP
        	// 
        	this.tsmPHP.Name = "tsmPHP";
        	this.tsmPHP.Size = new System.Drawing.Size(201, 22);
        	this.tsmPHP.Text = "PHP";
        	this.tsmPHP.Click += new System.EventHandler(this.tsmPHP_Click);
        	// 
        	// viewToolStripMenuItem
        	// 
        	this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.indexphpToolStripMenuItem,
        	        	        	this.editIndexphpToolStripMenuItem});
        	this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        	this.viewToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
        	this.viewToolStripMenuItem.Text = "Browser";
        	// 
        	// indexphpToolStripMenuItem
        	// 
        	this.indexphpToolStripMenuItem.Name = "indexphpToolStripMenuItem";
        	this.indexphpToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
        	this.indexphpToolStripMenuItem.Text = "http://localhost";
        	this.indexphpToolStripMenuItem.Click += new System.EventHandler(this.indexphpToolStripMenuItem_Click);
        	// 
        	// editIndexphpToolStripMenuItem
        	// 
        	this.editIndexphpToolStripMenuItem.Name = "editIndexphpToolStripMenuItem";
        	this.editIndexphpToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
        	this.editIndexphpToolStripMenuItem.Text = "Edit Index.php";
        	this.editIndexphpToolStripMenuItem.Click += new System.EventHandler(this.EditIndexphpToolStripMenuItemClick);
        	// 
        	// exploreToolStripMenuItem
        	// 
        	this.exploreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.databaseFolderToolStripMenuItem,
        	        	        	this.webServerFolderToolStripMenuItem,
        	        	        	this.pHPFolderToolStripMenuItem,
        	        	        	this.memcachedToolStripMenuItem,
        	        	        	this.sessionsAndPHPLogsToolStripMenuItem,
        	        	        	this.webRootwwwToolStripMenuItem});
        	this.exploreToolStripMenuItem.Name = "exploreToolStripMenuItem";
        	this.exploreToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
        	this.exploreToolStripMenuItem.Text = "Open Folder";
        	// 
        	// databaseFolderToolStripMenuItem
        	// 
        	this.databaseFolderToolStripMenuItem.Name = "databaseFolderToolStripMenuItem";
        	this.databaseFolderToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
        	this.databaseFolderToolStripMenuItem.Text = "Database";
        	this.databaseFolderToolStripMenuItem.Click += new System.EventHandler(this.databaseFolderToolStripMenuItem_Click);
        	// 
        	// webServerFolderToolStripMenuItem
        	// 
        	this.webServerFolderToolStripMenuItem.Name = "webServerFolderToolStripMenuItem";
        	this.webServerFolderToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
        	this.webServerFolderToolStripMenuItem.Text = "Web Server";
        	this.webServerFolderToolStripMenuItem.Click += new System.EventHandler(this.webServerFolderToolStripMenuItem_Click);
        	// 
        	// pHPFolderToolStripMenuItem
        	// 
        	this.pHPFolderToolStripMenuItem.Name = "pHPFolderToolStripMenuItem";
        	this.pHPFolderToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
        	this.pHPFolderToolStripMenuItem.Text = "PHP";
        	this.pHPFolderToolStripMenuItem.Click += new System.EventHandler(this.pHPFolderToolStripMenuItem_Click);
        	// 
        	// memcachedToolStripMenuItem
        	// 
        	this.memcachedToolStripMenuItem.Name = "memcachedToolStripMenuItem";
        	this.memcachedToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
        	this.memcachedToolStripMenuItem.Text = "Memcached";
        	this.memcachedToolStripMenuItem.Click += new System.EventHandler(this.MemcachedToolStripMenuItemClick);
        	// 
        	// sessionsAndPHPLogsToolStripMenuItem
        	// 
        	this.sessionsAndPHPLogsToolStripMenuItem.Name = "sessionsAndPHPLogsToolStripMenuItem";
        	this.sessionsAndPHPLogsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
        	this.sessionsAndPHPLogsToolStripMenuItem.Text = "Sessions, Logs, Temp";
        	this.sessionsAndPHPLogsToolStripMenuItem.Click += new System.EventHandler(this.sessionsAndPHPLogsToolStripMenuItem_Click);
        	// 
        	// webRootwwwToolStripMenuItem
        	// 
        	this.webRootwwwToolStripMenuItem.Name = "webRootwwwToolStripMenuItem";
        	this.webRootwwwToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
        	this.webRootwwwToolStripMenuItem.Text = "Web Root (www)";
        	this.webRootwwwToolStripMenuItem.Click += new System.EventHandler(this.webRootwwwToolStripMenuItem_Click);
        	// 
        	// scriptsToolStripMenuItem
        	// 
        	this.scriptsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.installPEARForPHPToolStripMenuItem,
        	        	        	this.removePEARToolStripMenuItem,
        	        	        	this.installPHPUnitForPHPToolStripMenuItem,
        	        	        	this.uninstallPHPUnitForPHPToolStripMenuItem,
        	        	        	this.restoreLatestFusionLeafDatabaseToolStripMenuItem});
        	this.scriptsToolStripMenuItem.Name = "scriptsToolStripMenuItem";
        	this.scriptsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
        	this.scriptsToolStripMenuItem.Text = "Scripts";
        	// 
        	// installPEARForPHPToolStripMenuItem
        	// 
        	this.installPEARForPHPToolStripMenuItem.Name = "installPEARForPHPToolStripMenuItem";
        	this.installPEARForPHPToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
        	this.installPEARForPHPToolStripMenuItem.Text = "Install PEAR for PHP";
        	this.installPEARForPHPToolStripMenuItem.Click += new System.EventHandler(this.InstallPEARForPHPToolStripMenuItemClick);
        	// 
        	// removePEARToolStripMenuItem
        	// 
        	this.removePEARToolStripMenuItem.Name = "removePEARToolStripMenuItem";
        	this.removePEARToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
        	this.removePEARToolStripMenuItem.Text = "Uninstall PEAR for PHP";
        	this.removePEARToolStripMenuItem.Click += new System.EventHandler(this.RemovePEARToolStripMenuItemClick);
        	// 
        	// installPHPUnitForPHPToolStripMenuItem
        	// 
        	this.installPHPUnitForPHPToolStripMenuItem.Name = "installPHPUnitForPHPToolStripMenuItem";
        	this.installPHPUnitForPHPToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
        	this.installPHPUnitForPHPToolStripMenuItem.Text = "Install PHPUnit for PHP";
        	this.installPHPUnitForPHPToolStripMenuItem.Click += new System.EventHandler(this.InstallPHPUnitForPHPToolStripMenuItemClick);
        	// 
        	// uninstallPHPUnitForPHPToolStripMenuItem
        	// 
        	this.uninstallPHPUnitForPHPToolStripMenuItem.Name = "uninstallPHPUnitForPHPToolStripMenuItem";
        	this.uninstallPHPUnitForPHPToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
        	this.uninstallPHPUnitForPHPToolStripMenuItem.Text = "Uninstall PHPUnit for PHP";
        	this.uninstallPHPUnitForPHPToolStripMenuItem.Click += new System.EventHandler(this.UninstallPHPUnitForPHPToolStripMenuItemClick);
        	// 
        	// restoreLatestFusionLeafDatabaseToolStripMenuItem
        	// 
        	this.restoreLatestFusionLeafDatabaseToolStripMenuItem.Name = "restoreLatestFusionLeafDatabaseToolStripMenuItem";
        	this.restoreLatestFusionLeafDatabaseToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
        	this.restoreLatestFusionLeafDatabaseToolStripMenuItem.Text = "Restore Latest FusionLeaf Database";
        	this.restoreLatestFusionLeafDatabaseToolStripMenuItem.Click += new System.EventHandler(this.RestoreToolStripMenuItemClick);
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.authorJoeSpurrierToolStripMenuItem,
        	        	        	this.fusionLeafOnSourceForgeToolStripMenuItem,
        	        	        	this.apacheV20LicenseToolStripMenuItem,
        	        	        	this.copyright2012ToolStripMenuItem,
        	        	        	this.versionToolStripMenuItem});
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
        	this.aboutToolStripMenuItem.Text = "About";
        	// 
        	// authorJoeSpurrierToolStripMenuItem
        	// 
        	this.authorJoeSpurrierToolStripMenuItem.Name = "authorJoeSpurrierToolStripMenuItem";
        	this.authorJoeSpurrierToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
        	this.authorJoeSpurrierToolStripMenuItem.Text = "FusionLeaf Website";
        	this.authorJoeSpurrierToolStripMenuItem.Click += new System.EventHandler(this.authorJoeSpurrierToolStripMenuItem_Click);
        	// 
        	// fusionLeafOnSourceForgeToolStripMenuItem
        	// 
        	this.fusionLeafOnSourceForgeToolStripMenuItem.Name = "fusionLeafOnSourceForgeToolStripMenuItem";
        	this.fusionLeafOnSourceForgeToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
        	this.fusionLeafOnSourceForgeToolStripMenuItem.Text = "FusionLeaf on Google Code";
        	this.fusionLeafOnSourceForgeToolStripMenuItem.Click += new System.EventHandler(this.FusionLeafOnSourceForgeToolStripMenuItemClick);
        	// 
        	// apacheV20LicenseToolStripMenuItem
        	// 
        	this.apacheV20LicenseToolStripMenuItem.Name = "apacheV20LicenseToolStripMenuItem";
        	this.apacheV20LicenseToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
        	this.apacheV20LicenseToolStripMenuItem.Text = "Licensed Under: Apache v2.0 License";
        	this.apacheV20LicenseToolStripMenuItem.Click += new System.EventHandler(this.ApacheV20LicenseToolStripMenuItemClick);
        	// 
        	// copyright2012ToolStripMenuItem
        	// 
        	this.copyright2012ToolStripMenuItem.Enabled = false;
        	this.copyright2012ToolStripMenuItem.Name = "copyright2012ToolStripMenuItem";
        	this.copyright2012ToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
        	this.copyright2012ToolStripMenuItem.Text = "Copyright 2012 PC Precision LLC";
        	// 
        	// versionToolStripMenuItem
        	// 
        	this.versionToolStripMenuItem.Enabled = false;
        	this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
        	this.versionToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
        	this.versionToolStripMenuItem.Text = "Version:";
        	// 
        	// niTaskbar
        	// 
        	this.niTaskbar.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
        	this.niTaskbar.BalloonTipText = "Test1";
        	this.niTaskbar.BalloonTipTitle = "Test2";
        	this.niTaskbar.ContextMenuStrip = this.cmsTaskbar;
        	this.niTaskbar.Icon = ((System.Drawing.Icon)(resources.GetObject("niTaskbar.Icon")));
        	this.niTaskbar.Text = "FusionLeaf";
        	this.niTaskbar.Visible = true;
        	this.niTaskbar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NiTaskbarMouseDoubleClick);
        	// 
        	// cmsTaskbar
        	// 
        	this.cmsTaskbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.maximizeToolStripMenuItem,
        	        	        	this.exitToolStripMenuItem});
        	this.cmsTaskbar.Name = "cmsTaskbar";
        	this.cmsTaskbar.Size = new System.Drawing.Size(125, 48);
        	// 
        	// maximizeToolStripMenuItem
        	// 
        	this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
        	this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
        	this.maximizeToolStripMenuItem.Text = "Maximize";
        	this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.maximizeToolStripMenuItem_Click);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
        	this.exitToolStripMenuItem.Text = "Exit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
        	// 
        	// ssStatus
        	// 
        	this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.txtStatus});
        	this.ssStatus.Location = new System.Drawing.Point(0, 316);
        	this.ssStatus.Name = "ssStatus";
        	this.ssStatus.Size = new System.Drawing.Size(480, 22);
        	this.ssStatus.TabIndex = 7;
        	this.ssStatus.Text = "statusStrip1";
        	// 
        	// txtStatus
        	// 
        	this.txtStatus.Name = "txtStatus";
        	this.txtStatus.Size = new System.Drawing.Size(60, 17);
        	this.txtStatus.Text = "Welcome!";
        	this.txtStatus.TextChanged += new System.EventHandler(this.TxtStatusTextChanged);
        	// 
        	// tabPage2
        	// 
        	this.tabPage2.Controls.Add(this.groupBox2);
        	this.tabPage2.Controls.Add(this.groupBox4);
        	this.tabPage2.Controls.Add(this.groupBox3);
        	this.tabPage2.Controls.Add(this.groupBox1);
        	this.tabPage2.Location = new System.Drawing.Point(4, 22);
        	this.tabPage2.Name = "tabPage2";
        	this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPage2.Size = new System.Drawing.Size(448, 237);
        	this.tabPage2.TabIndex = 1;
        	this.tabPage2.Text = "Advanced";
        	this.tabPage2.UseVisualStyleBackColor = true;
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Controls.Add(this.numMemcachedPort);
        	this.groupBox2.Controls.Add(this.label9);
        	this.groupBox2.Controls.Add(this.txtMemcachedStatus);
        	this.groupBox2.Controls.Add(this.label11);
        	this.groupBox2.Controls.Add(this.btnMemcachedStop);
        	this.groupBox2.Controls.Add(this.btnMemcachedStart);
        	this.groupBox2.Location = new System.Drawing.Point(311, 104);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(131, 126);
        	this.groupBox2.TabIndex = 8;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "Memcached";
        	// 
        	// numMemcachedPort
        	// 
        	this.numMemcachedPort.Location = new System.Drawing.Point(41, 79);
        	this.numMemcachedPort.Maximum = new decimal(new int[] {
        	        	        	65535,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numMemcachedPort.Minimum = new decimal(new int[] {
        	        	        	1,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numMemcachedPort.Name = "numMemcachedPort";
        	this.numMemcachedPort.Size = new System.Drawing.Size(75, 20);
        	this.numMemcachedPort.TabIndex = 20;
        	this.numMemcachedPort.Value = new decimal(new int[] {
        	        	        	11211,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	// 
        	// label9
        	// 
        	this.label9.AutoSize = true;
        	this.label9.Location = new System.Drawing.Point(6, 81);
        	this.label9.Name = "label9";
        	this.label9.Size = new System.Drawing.Size(29, 13);
        	this.label9.TabIndex = 19;
        	this.label9.Text = "Port:";
        	// 
        	// txtMemcachedStatus
        	// 
        	this.txtMemcachedStatus.AutoSize = true;
        	this.txtMemcachedStatus.Location = new System.Drawing.Point(43, 102);
        	this.txtMemcachedStatus.Name = "txtMemcachedStatus";
        	this.txtMemcachedStatus.Size = new System.Drawing.Size(47, 13);
        	this.txtMemcachedStatus.TabIndex = 18;
        	this.txtMemcachedStatus.Text = "Stopped";
        	// 
        	// label11
        	// 
        	this.label11.AutoSize = true;
        	this.label11.Location = new System.Drawing.Point(6, 102);
        	this.label11.Name = "label11";
        	this.label11.Size = new System.Drawing.Size(40, 13);
        	this.label11.TabIndex = 17;
        	this.label11.Text = "Status:";
        	// 
        	// btnMemcachedStop
        	// 
        	this.btnMemcachedStop.Location = new System.Drawing.Point(6, 48);
        	this.btnMemcachedStop.Name = "btnMemcachedStop";
        	this.btnMemcachedStop.Size = new System.Drawing.Size(75, 23);
        	this.btnMemcachedStop.TabIndex = 16;
        	this.btnMemcachedStop.Text = "Stop";
        	this.btnMemcachedStop.UseVisualStyleBackColor = true;
        	this.btnMemcachedStop.Click += new System.EventHandler(this.BtnMemcachedStopClick);
        	// 
        	// btnMemcachedStart
        	// 
        	this.btnMemcachedStart.Location = new System.Drawing.Point(6, 19);
        	this.btnMemcachedStart.Name = "btnMemcachedStart";
        	this.btnMemcachedStart.Size = new System.Drawing.Size(75, 23);
        	this.btnMemcachedStart.TabIndex = 15;
        	this.btnMemcachedStart.Text = "Start";
        	this.btnMemcachedStart.UseVisualStyleBackColor = true;
        	this.btnMemcachedStart.Click += new System.EventHandler(this.BtnMemcachedStartClick);
        	// 
        	// groupBox4
        	// 
        	this.groupBox4.Controls.Add(this.numMySQLPort);
        	this.groupBox4.Controls.Add(this.label7);
        	this.groupBox4.Controls.Add(this.txtMySQLStatus);
        	this.groupBox4.Controls.Add(this.label5);
        	this.groupBox4.Controls.Add(this.btnMySQLStop);
        	this.groupBox4.Controls.Add(this.btnMySQLStart);
        	this.groupBox4.Location = new System.Drawing.Point(181, 104);
        	this.groupBox4.Name = "groupBox4";
        	this.groupBox4.Size = new System.Drawing.Size(123, 126);
        	this.groupBox4.TabIndex = 7;
        	this.groupBox4.TabStop = false;
        	this.groupBox4.Text = "MySQL";
        	// 
        	// numMySQLPort
        	// 
        	this.numMySQLPort.Location = new System.Drawing.Point(42, 80);
        	this.numMySQLPort.Maximum = new decimal(new int[] {
        	        	        	65535,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numMySQLPort.Minimum = new decimal(new int[] {
        	        	        	1,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numMySQLPort.Name = "numMySQLPort";
        	this.numMySQLPort.Size = new System.Drawing.Size(75, 20);
        	this.numMySQLPort.TabIndex = 14;
        	this.numMySQLPort.Value = new decimal(new int[] {
        	        	        	3306,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(7, 82);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(29, 13);
        	this.label7.TabIndex = 10;
        	this.label7.Text = "Port:";
        	// 
        	// txtMySQLStatus
        	// 
        	this.txtMySQLStatus.AutoSize = true;
        	this.txtMySQLStatus.Location = new System.Drawing.Point(44, 103);
        	this.txtMySQLStatus.Name = "txtMySQLStatus";
        	this.txtMySQLStatus.Size = new System.Drawing.Size(47, 13);
        	this.txtMySQLStatus.TabIndex = 7;
        	this.txtMySQLStatus.Text = "Stopped";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(7, 103);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(40, 13);
        	this.label5.TabIndex = 6;
        	this.label5.Text = "Status:";
        	// 
        	// btnMySQLStop
        	// 
        	this.btnMySQLStop.Location = new System.Drawing.Point(7, 49);
        	this.btnMySQLStop.Name = "btnMySQLStop";
        	this.btnMySQLStop.Size = new System.Drawing.Size(75, 23);
        	this.btnMySQLStop.TabIndex = 1;
        	this.btnMySQLStop.Text = "Stop";
        	this.btnMySQLStop.UseVisualStyleBackColor = true;
        	this.btnMySQLStop.Click += new System.EventHandler(this.BtnMySQLStopClick);
        	// 
        	// btnMySQLStart
        	// 
        	this.btnMySQLStart.Location = new System.Drawing.Point(7, 20);
        	this.btnMySQLStart.Name = "btnMySQLStart";
        	this.btnMySQLStart.Size = new System.Drawing.Size(75, 23);
        	this.btnMySQLStart.TabIndex = 0;
        	this.btnMySQLStart.Text = "Start";
        	this.btnMySQLStart.UseVisualStyleBackColor = true;
        	this.btnMySQLStart.Click += new System.EventHandler(this.BtnMySQLStartClick);
        	// 
        	// groupBox3
        	// 
        	this.groupBox3.Controls.Add(this.numFCGIPort);
        	this.groupBox3.Controls.Add(this.label6);
        	this.groupBox3.Controls.Add(this.numFCGIRequests);
        	this.groupBox3.Controls.Add(this.label4);
        	this.groupBox3.Controls.Add(this.label2);
        	this.groupBox3.Controls.Add(this.numFCGIThreads);
        	this.groupBox3.Controls.Add(this.txtFCGIStatus);
        	this.groupBox3.Controls.Add(this.label3);
        	this.groupBox3.Controls.Add(this.btnFCGIStop);
        	this.groupBox3.Controls.Add(this.btnFCGIStart);
        	this.groupBox3.Location = new System.Drawing.Point(6, 6);
        	this.groupBox3.Name = "groupBox3";
        	this.groupBox3.Size = new System.Drawing.Size(436, 95);
        	this.groupBox3.TabIndex = 6;
        	this.groupBox3.TabStop = false;
        	this.groupBox3.Text = "FastCGI Controls (PHP)";
        	// 
        	// numFCGIPort
        	// 
        	this.numFCGIPort.Location = new System.Drawing.Point(355, 65);
        	this.numFCGIPort.Maximum = new decimal(new int[] {
        	        	        	65535,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numFCGIPort.Minimum = new decimal(new int[] {
        	        	        	1,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numFCGIPort.Name = "numFCGIPort";
        	this.numFCGIPort.Size = new System.Drawing.Size(75, 20);
        	this.numFCGIPort.TabIndex = 13;
        	this.numFCGIPort.Value = new decimal(new int[] {
        	        	        	1880,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(281, 67);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(68, 13);
        	this.label6.TabIndex = 12;
        	this.label6.Text = "Starting Port:";
        	// 
        	// numFCGIRequests
        	// 
        	this.numFCGIRequests.Location = new System.Drawing.Point(355, 39);
        	this.numFCGIRequests.Maximum = new decimal(new int[] {
        	        	        	5000,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numFCGIRequests.Minimum = new decimal(new int[] {
        	        	        	1,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numFCGIRequests.Name = "numFCGIRequests";
        	this.numFCGIRequests.Size = new System.Drawing.Size(75, 20);
        	this.numFCGIRequests.TabIndex = 11;
        	this.numFCGIRequests.Value = new decimal(new int[] {
        	        	        	300,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(274, 41);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(78, 13);
        	this.label4.TabIndex = 10;
        	this.label4.Text = "Max Requests:";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(274, 15);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(49, 13);
        	this.label2.TabIndex = 9;
        	this.label2.Text = "Threads:";
        	// 
        	// numFCGIThreads
        	// 
        	this.numFCGIThreads.Location = new System.Drawing.Point(329, 13);
        	this.numFCGIThreads.Maximum = new decimal(new int[] {
        	        	        	25,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numFCGIThreads.Minimum = new decimal(new int[] {
        	        	        	1,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numFCGIThreads.Name = "numFCGIThreads";
        	this.numFCGIThreads.Size = new System.Drawing.Size(101, 20);
        	this.numFCGIThreads.TabIndex = 8;
        	this.numFCGIThreads.Value = new decimal(new int[] {
        	        	        	2,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	// 
        	// txtFCGIStatus
        	// 
        	this.txtFCGIStatus.AutoSize = true;
        	this.txtFCGIStatus.Location = new System.Drawing.Point(43, 76);
        	this.txtFCGIStatus.Name = "txtFCGIStatus";
        	this.txtFCGIStatus.Size = new System.Drawing.Size(47, 13);
        	this.txtFCGIStatus.TabIndex = 7;
        	this.txtFCGIStatus.Text = "Stopped";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(7, 76);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(40, 13);
        	this.label3.TabIndex = 6;
        	this.label3.Text = "Status:";
        	// 
        	// btnFCGIStop
        	// 
        	this.btnFCGIStop.Location = new System.Drawing.Point(7, 50);
        	this.btnFCGIStop.Name = "btnFCGIStop";
        	this.btnFCGIStop.Size = new System.Drawing.Size(75, 23);
        	this.btnFCGIStop.TabIndex = 1;
        	this.btnFCGIStop.Text = "Stop";
        	this.btnFCGIStop.UseVisualStyleBackColor = true;
        	this.btnFCGIStop.Click += new System.EventHandler(this.BtnFCGIStopClick);
        	// 
        	// btnFCGIStart
        	// 
        	this.btnFCGIStart.Location = new System.Drawing.Point(7, 20);
        	this.btnFCGIStart.Name = "btnFCGIStart";
        	this.btnFCGIStart.Size = new System.Drawing.Size(75, 23);
        	this.btnFCGIStart.TabIndex = 0;
        	this.btnFCGIStart.Text = "Start";
        	this.btnFCGIStart.UseVisualStyleBackColor = true;
        	this.btnFCGIStart.Click += new System.EventHandler(this.BtnFCGIStartClick);
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.numNginxPort);
        	this.groupBox1.Controls.Add(this.label8);
        	this.groupBox1.Controls.Add(this.txtNginxStatus);
        	this.groupBox1.Controls.Add(this.txtNginxStatus2);
        	this.groupBox1.Controls.Add(this.btnNginxStart);
        	this.groupBox1.Controls.Add(this.btnNginxReopen);
        	this.groupBox1.Controls.Add(this.btnNginxStop);
        	this.groupBox1.Controls.Add(this.btnNginxReload);
        	this.groupBox1.Location = new System.Drawing.Point(6, 104);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(169, 126);
        	this.groupBox1.TabIndex = 4;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Nginx Controls";
        	// 
        	// numNginxPort
        	// 
        	this.numNginxPort.Location = new System.Drawing.Point(41, 80);
        	this.numNginxPort.Maximum = new decimal(new int[] {
        	        	        	65535,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numNginxPort.Minimum = new decimal(new int[] {
        	        	        	1,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.numNginxPort.Name = "numNginxPort";
        	this.numNginxPort.Size = new System.Drawing.Size(114, 20);
        	this.numNginxPort.TabIndex = 16;
        	this.numNginxPort.Value = new decimal(new int[] {
        	        	        	80,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	// 
        	// label8
        	// 
        	this.label8.AutoSize = true;
        	this.label8.Location = new System.Drawing.Point(6, 82);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(29, 13);
        	this.label8.TabIndex = 15;
        	this.label8.Text = "Port:";
        	// 
        	// txtNginxStatus
        	// 
        	this.txtNginxStatus.AutoSize = true;
        	this.txtNginxStatus.Location = new System.Drawing.Point(42, 103);
        	this.txtNginxStatus.Name = "txtNginxStatus";
        	this.txtNginxStatus.Size = new System.Drawing.Size(47, 13);
        	this.txtNginxStatus.TabIndex = 5;
        	this.txtNginxStatus.Text = "Stopped";
        	// 
        	// txtNginxStatus2
        	// 
        	this.txtNginxStatus2.AutoSize = true;
        	this.txtNginxStatus2.Location = new System.Drawing.Point(5, 103);
        	this.txtNginxStatus2.Name = "txtNginxStatus2";
        	this.txtNginxStatus2.Size = new System.Drawing.Size(40, 13);
        	this.txtNginxStatus2.TabIndex = 4;
        	this.txtNginxStatus2.Text = "Status:";
        	// 
        	// btnNginxStart
        	// 
        	this.btnNginxStart.Location = new System.Drawing.Point(6, 19);
        	this.btnNginxStart.Name = "btnNginxStart";
        	this.btnNginxStart.Size = new System.Drawing.Size(75, 23);
        	this.btnNginxStart.TabIndex = 0;
        	this.btnNginxStart.Text = "Start";
        	this.btnNginxStart.UseVisualStyleBackColor = true;
        	this.btnNginxStart.Click += new System.EventHandler(this.BtnNginxStartClick);
        	// 
        	// btnNginxReopen
        	// 
        	this.btnNginxReopen.Location = new System.Drawing.Point(87, 49);
        	this.btnNginxReopen.Name = "btnNginxReopen";
        	this.btnNginxReopen.Size = new System.Drawing.Size(75, 23);
        	this.btnNginxReopen.TabIndex = 3;
        	this.btnNginxReopen.Text = "Reopen";
        	this.btnNginxReopen.UseVisualStyleBackColor = true;
        	this.btnNginxReopen.Click += new System.EventHandler(this.BtnNginxReopenClick);
        	// 
        	// btnNginxStop
        	// 
        	this.btnNginxStop.Location = new System.Drawing.Point(6, 49);
        	this.btnNginxStop.Name = "btnNginxStop";
        	this.btnNginxStop.Size = new System.Drawing.Size(75, 23);
        	this.btnNginxStop.TabIndex = 1;
        	this.btnNginxStop.Text = "Stop";
        	this.btnNginxStop.UseVisualStyleBackColor = true;
        	this.btnNginxStop.Click += new System.EventHandler(this.BtnNginxStopClick);
        	// 
        	// btnNginxReload
        	// 
        	this.btnNginxReload.Location = new System.Drawing.Point(87, 19);
        	this.btnNginxReload.Name = "btnNginxReload";
        	this.btnNginxReload.Size = new System.Drawing.Size(75, 23);
        	this.btnNginxReload.TabIndex = 2;
        	this.btnNginxReload.Text = "Reload";
        	this.btnNginxReload.UseVisualStyleBackColor = true;
        	this.btnNginxReload.Click += new System.EventHandler(this.BtnNginxReloadClick);
        	// 
        	// tabPage1
        	// 
        	this.tabPage1.Controls.Add(this.btnTest);
        	this.tabPage1.Controls.Add(this.label1);
        	this.tabPage1.Controls.Add(this.btnStart);
        	this.tabPage1.Location = new System.Drawing.Point(4, 22);
        	this.tabPage1.Name = "tabPage1";
        	this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPage1.Size = new System.Drawing.Size(448, 237);
        	this.tabPage1.TabIndex = 0;
        	this.tabPage1.Text = "Basic";
        	this.tabPage1.UseVisualStyleBackColor = true;
        	// 
        	// btnTest
        	// 
        	this.btnTest.Location = new System.Drawing.Point(367, 208);
        	this.btnTest.Name = "btnTest";
        	this.btnTest.Size = new System.Drawing.Size(75, 23);
        	this.btnTest.TabIndex = 3;
        	this.btnTest.Text = "Test";
        	this.btnTest.UseVisualStyleBackColor = true;
        	this.btnTest.Visible = false;
        	this.btnTest.Click += new System.EventHandler(this.BtnTestClick);
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(6, 3);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(436, 202);
        	this.label1.TabIndex = 2;
        	this.label1.Text = resources.GetString("label1.Text");
        	// 
        	// btnStart
        	// 
        	this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.btnStart.Location = new System.Drawing.Point(6, 208);
        	this.btnStart.Name = "btnStart";
        	this.btnStart.Size = new System.Drawing.Size(75, 23);
        	this.btnStart.TabIndex = 0;
        	this.btnStart.Text = "Start";
        	this.btnStart.UseVisualStyleBackColor = true;
        	this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
        	// 
        	// tabControl
        	// 
        	this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.tabControl.Controls.Add(this.tabPage1);
        	this.tabControl.Controls.Add(this.tabPage2);
        	this.tabControl.Controls.Add(this.tabPage3);
        	this.tabControl.Location = new System.Drawing.Point(12, 27);
        	this.tabControl.Name = "tabControl";
        	this.tabControl.SelectedIndex = 0;
        	this.tabControl.Size = new System.Drawing.Size(456, 263);
        	this.tabControl.TabIndex = 6;
        	// 
        	// tabPage3
        	// 
        	this.tabPage3.Controls.Add(this.rtxLog);
        	this.tabPage3.Location = new System.Drawing.Point(4, 22);
        	this.tabPage3.Name = "tabPage3";
        	this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPage3.Size = new System.Drawing.Size(448, 237);
        	this.tabPage3.TabIndex = 2;
        	this.tabPage3.Text = "Log";
        	this.tabPage3.UseVisualStyleBackColor = true;
        	// 
        	// rtxLog
        	// 
        	this.rtxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.rtxLog.Location = new System.Drawing.Point(7, 7);
        	this.rtxLog.Name = "rtxLog";
        	this.rtxLog.ReadOnly = true;
        	this.rtxLog.Size = new System.Drawing.Size(435, 224);
        	this.rtxLog.TabIndex = 0;
        	this.rtxLog.Text = "";
        	// 
        	// frmMain
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(480, 338);
        	this.ContextMenuStrip = this.cmsTaskbar;
        	this.Controls.Add(this.ssStatus);
        	this.Controls.Add(this.msTop);
        	this.Controls.Add(this.chbHide);
        	this.Controls.Add(this.tabControl);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MainMenuStrip = this.msTop;
        	this.Name = "frmMain";
        	this.Text = "FusionLeaf Studio";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
        	this.Load += new System.EventHandler(this.FrmMainLoad);
        	this.Resize += new System.EventHandler(this.FrmMainResize);
        	this.msTop.ResumeLayout(false);
        	this.msTop.PerformLayout();
        	this.cmsTaskbar.ResumeLayout(false);
        	this.ssStatus.ResumeLayout(false);
        	this.ssStatus.PerformLayout();
        	this.tabPage2.ResumeLayout(false);
        	this.groupBox2.ResumeLayout(false);
        	this.groupBox2.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numMemcachedPort)).EndInit();
        	this.groupBox4.ResumeLayout(false);
        	this.groupBox4.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numMySQLPort)).EndInit();
        	this.groupBox3.ResumeLayout(false);
        	this.groupBox3.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numFCGIPort)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.numFCGIRequests)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.numFCGIThreads)).EndInit();
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.numNginxPort)).EndInit();
        	this.tabPage1.ResumeLayout(false);
        	this.tabControl.ResumeLayout(false);
        	this.tabPage3.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem restoreLatestFusionLeafDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editIndexphpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theseAreOverwrittenByTemplatesWhenStartIsClickedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uninstallPHPUnitForPHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installPHPUnitForPHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installPEARForPHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memcachedToolStripMenuItem;
        private System.Windows.Forms.Button btnMemcachedStart;
        private System.Windows.Forms.Button btnMemcachedStop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtMemcachedStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numMemcachedPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem fusionLeafOnSourceForgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apacheV20LicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theseOverwriteTheConfigurationsToolStripMenuItem;
        private System.Windows.Forms.ToolTip tTip;
        private System.Windows.Forms.ToolStripMenuItem databaseConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webServerConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numNginxPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numMySQLPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numFCGIPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numFCGIRequests;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.RichTextBox rtxLog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtMySQLStatus;
        private System.Windows.Forms.Button btnMySQLStart;
        private System.Windows.Forms.Button btnMySQLStop;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtFCGIStatus;
        private System.Windows.Forms.Button btnFCGIStop;
        private System.Windows.Forms.Button btnFCGIStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numFCGIThreads;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtNginxStatus2;
        private System.Windows.Forms.Label txtNginxStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNginxReload;
        private System.Windows.Forms.Button btnNginxReopen;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.Button btnNginxStart;
        private System.Windows.Forms.Button btnNginxStop;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl;

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chbHide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip msTop;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmMySQL;
        private System.Windows.Forms.ToolStripMenuItem tsmWeb;
        private System.Windows.Forms.ToolStripMenuItem tsmPHP;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexphpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exploreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webServerFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionsAndPHPLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webRootwwwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorJoeSpurrierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyright2012ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon niTaskbar;
        private System.Windows.Forms.ContextMenuStrip cmsTaskbar;
        private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

