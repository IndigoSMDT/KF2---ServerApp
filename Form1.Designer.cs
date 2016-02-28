namespace ServerApp
{
    partial class fmServerApp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmServerApp));
            this.notifyIconSA = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemStartServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStopServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemOWA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExt = new System.Windows.Forms.ToolStripMenuItem();
            this.openMapDir = new System.Windows.Forms.OpenFileDialog();
            this.timerUsage = new System.Windows.Forms.Timer(this.components);
            this.tabSett = new System.Windows.Forms.TabPage();
            this.buttonSaveKF = new System.Windows.Forms.Button();
            this.groupBoxMap = new System.Windows.Forms.GroupBox();
            this.buttonBrowsMap = new System.Windows.Forms.Button();
            this.buttonAddMap = new System.Windows.Forms.Button();
            this.labelRedirect = new System.Windows.Forms.Label();
            this.richTextBoxMap = new System.Windows.Forms.RichTextBox();
            this.textBoxRedirect = new System.Windows.Forms.TextBox();
            this.groupBoxKFWeb = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSrvName = new System.Windows.Forms.TextBox();
            this.labelMxPl = new System.Windows.Forms.Label();
            this.textBoxMxPl = new System.Windows.Forms.TextBox();
            this.groupBoxKFGame = new System.Windows.Forms.GroupBox();
            this.comboBoxWAE = new System.Windows.Forms.ComboBox();
            this.labelWAE = new System.Windows.Forms.Label();
            this.comboBoxAdmPause = new System.Windows.Forms.ComboBox();
            this.textBoxAdmCont = new System.Windows.Forms.TextBox();
            this.textBoxAdmPass = new System.Windows.Forms.TextBox();
            this.labelAdPass = new System.Windows.Forms.Label();
            this.labelAdmPause = new System.Windows.Forms.Label();
            this.labelAdmCont = new System.Windows.Forms.Label();
            this.InsUpdCon = new System.Windows.Forms.TabPage();
            this.SAConsole = new System.Windows.Forms.TextBox();
            this.ConsoleComands = new System.Windows.Forms.ListBox();
            this.buttonDcmd = new System.Windows.Forms.Button();
            this.richTextBoxUpd = new System.Windows.Forms.RichTextBox();
            this.labelUP = new System.Windows.Forms.Label();
            this.comboBoxUpd = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.labelCPUu = new System.Windows.Forms.Label();
            this.labelRamU = new System.Windows.Forms.Label();
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.groupBoxGame = new System.Windows.Forms.GroupBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.comboBoxLen = new System.Windows.Forms.ComboBox();
            this.comboBoxDiff = new System.Windows.Forms.ComboBox();
            this.comboBoxMap = new System.Windows.Forms.ComboBox();
            this.labelMap = new System.Windows.Forms.Label();
            this.labelLen = new System.Windows.Forms.Label();
            this.labelDiff = new System.Windows.Forms.Label();
            this.buttonWebAdmin = new System.Windows.Forms.Button();
            this.groupBoxPorts = new System.Windows.Forms.GroupBox();
            this.textBoxWB = new System.Windows.Forms.TextBox();
            this.textBoxQP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelWebAdminPort = new System.Windows.Forms.Label();
            this.labelQueryPort = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.richTextBoxWrap = new System.Windows.Forms.RichTextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.tabSA = new System.Windows.Forms.TabControl();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            this.tabSett.SuspendLayout();
            this.groupBoxMap.SuspendLayout();
            this.groupBoxKFWeb.SuspendLayout();
            this.groupBoxKFGame.SuspendLayout();
            this.InsUpdCon.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.groupBoxGame.SuspendLayout();
            this.groupBoxPorts.SuspendLayout();
            this.tabSA.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconSA
            // 
            this.notifyIconSA.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIconSA.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSA.Icon")));
            this.notifyIconSA.Text = "KF 2 -ServerApp";
            this.notifyIconSA.Visible = true;
            this.notifyIconSA.DoubleClick += new System.EventHandler(this.notifyIconSA_DoubleClick);
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStartServer,
            this.toolStripMenuItemStopServer,
            this.toolStripSeparator1,
            this.toolStripMenuItemOWA,
            this.toolStripSeparator2,
            this.toolStripMenuItemExt});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(170, 104);
            // 
            // toolStripMenuItemStartServer
            // 
            this.toolStripMenuItemStartServer.Name = "toolStripMenuItemStartServer";
            this.toolStripMenuItemStartServer.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItemStartServer.Text = "Start Server";
            this.toolStripMenuItemStartServer.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // toolStripMenuItemStopServer
            // 
            this.toolStripMenuItemStopServer.Enabled = false;
            this.toolStripMenuItemStopServer.Name = "toolStripMenuItemStopServer";
            this.toolStripMenuItemStopServer.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItemStopServer.Text = "Stop Server";
            this.toolStripMenuItemStopServer.Click += new System.EventHandler(this.Stop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // toolStripMenuItemOWA
            // 
            this.toolStripMenuItemOWA.Enabled = false;
            this.toolStripMenuItemOWA.Name = "toolStripMenuItemOWA";
            this.toolStripMenuItemOWA.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItemOWA.Text = "Open Web Admin";
            this.toolStripMenuItemOWA.Click += new System.EventHandler(this.buttonWebAdmin_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // toolStripMenuItemExt
            // 
            this.toolStripMenuItemExt.Name = "toolStripMenuItemExt";
            this.toolStripMenuItemExt.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItemExt.Text = "Exit";
            this.toolStripMenuItemExt.Click += new System.EventHandler(this.toolStripMenuItemExt_Click);
            // 
            // openMapDir
            // 
            this.openMapDir.FileName = "openFileDialog1";
            // 
            // timerUsage
            // 
            this.timerUsage.Interval = 1000;
            this.timerUsage.Tick += new System.EventHandler(this.timerUsage_Tick);
            // 
            // tabSett
            // 
            this.tabSett.Controls.Add(this.buttonSaveKF);
            this.tabSett.Controls.Add(this.groupBoxMap);
            this.tabSett.Controls.Add(this.groupBoxKFWeb);
            this.tabSett.Controls.Add(this.groupBoxKFGame);
            this.tabSett.Location = new System.Drawing.Point(4, 22);
            this.tabSett.Name = "tabSett";
            this.tabSett.Padding = new System.Windows.Forms.Padding(3);
            this.tabSett.Size = new System.Drawing.Size(608, 318);
            this.tabSett.TabIndex = 2;
            this.tabSett.Text = "Options";
            this.tabSett.UseVisualStyleBackColor = true;
            // 
            // buttonSaveKF
            // 
            this.buttonSaveKF.Location = new System.Drawing.Point(519, 288);
            this.buttonSaveKF.Name = "buttonSaveKF";
            this.buttonSaveKF.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveKF.TabIndex = 3;
            this.buttonSaveKF.Text = "Save";
            this.buttonSaveKF.UseVisualStyleBackColor = true;
            this.buttonSaveKF.Click += new System.EventHandler(this.buttonSaveKF_Click);
            // 
            // groupBoxMap
            // 
            this.groupBoxMap.Controls.Add(this.buttonBrowsMap);
            this.groupBoxMap.Controls.Add(this.buttonAddMap);
            this.groupBoxMap.Controls.Add(this.labelRedirect);
            this.groupBoxMap.Controls.Add(this.richTextBoxMap);
            this.groupBoxMap.Controls.Add(this.textBoxRedirect);
            this.groupBoxMap.Location = new System.Drawing.Point(8, 145);
            this.groupBoxMap.Name = "groupBoxMap";
            this.groupBoxMap.Size = new System.Drawing.Size(592, 134);
            this.groupBoxMap.TabIndex = 3;
            this.groupBoxMap.TabStop = false;
            this.groupBoxMap.Text = "Map";
            // 
            // buttonBrowsMap
            // 
            this.buttonBrowsMap.Location = new System.Drawing.Point(291, 100);
            this.buttonBrowsMap.Name = "buttonBrowsMap";
            this.buttonBrowsMap.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowsMap.TabIndex = 4;
            this.buttonBrowsMap.Text = "Browse Map";
            this.buttonBrowsMap.UseVisualStyleBackColor = true;
            this.buttonBrowsMap.Visible = false;
            this.buttonBrowsMap.Click += new System.EventHandler(this.buttonBrowsMap_Click);
            // 
            // buttonAddMap
            // 
            this.buttonAddMap.Enabled = false;
            this.buttonAddMap.Location = new System.Drawing.Point(511, 100);
            this.buttonAddMap.Name = "buttonAddMap";
            this.buttonAddMap.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMap.TabIndex = 3;
            this.buttonAddMap.Text = "Add Map";
            this.buttonAddMap.UseVisualStyleBackColor = true;
            this.buttonAddMap.Click += new System.EventHandler(this.buttonAddMap_Click);
            // 
            // labelRedirect
            // 
            this.labelRedirect.AutoSize = true;
            this.labelRedirect.Location = new System.Drawing.Point(6, 105);
            this.labelRedirect.Name = "labelRedirect";
            this.labelRedirect.Size = new System.Drawing.Size(50, 13);
            this.labelRedirect.TabIndex = 0;
            this.labelRedirect.Text = "Redirect:";
            // 
            // richTextBoxMap
            // 
            this.richTextBoxMap.Location = new System.Drawing.Point(9, 19);
            this.richTextBoxMap.Name = "richTextBoxMap";
            this.richTextBoxMap.Size = new System.Drawing.Size(577, 75);
            this.richTextBoxMap.TabIndex = 0;
            this.richTextBoxMap.Text = "[KF-Exmpl KFMapSummary]\nMapName = KF-Exmpl \nScreenshotPathName = UI_MapPreview_TE" +
    "X.UI_MapPreview_Placeholder\n";
            // 
            // textBoxRedirect
            // 
            this.textBoxRedirect.Location = new System.Drawing.Point(62, 102);
            this.textBoxRedirect.Name = "textBoxRedirect";
            this.textBoxRedirect.Size = new System.Drawing.Size(223, 20);
            this.textBoxRedirect.TabIndex = 1;
            // 
            // groupBoxKFWeb
            // 
            this.groupBoxKFWeb.Controls.Add(this.labelName);
            this.groupBoxKFWeb.Controls.Add(this.textBoxSrvName);
            this.groupBoxKFWeb.Controls.Add(this.labelMxPl);
            this.groupBoxKFWeb.Controls.Add(this.textBoxMxPl);
            this.groupBoxKFWeb.Location = new System.Drawing.Point(8, 6);
            this.groupBoxKFWeb.Name = "groupBoxKFWeb";
            this.groupBoxKFWeb.Size = new System.Drawing.Size(592, 54);
            this.groupBoxKFWeb.TabIndex = 2;
            this.groupBoxKFWeb.TabStop = false;
            this.groupBoxKFWeb.Text = "PCServer-KFGame";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Server Name:";
            // 
            // textBoxSrvName
            // 
            this.textBoxSrvName.Location = new System.Drawing.Point(84, 21);
            this.textBoxSrvName.Name = "textBoxSrvName";
            this.textBoxSrvName.Size = new System.Drawing.Size(328, 20);
            this.textBoxSrvName.TabIndex = 1;
            // 
            // labelMxPl
            // 
            this.labelMxPl.AutoSize = true;
            this.labelMxPl.Location = new System.Drawing.Point(418, 24);
            this.labelMxPl.Name = "labelMxPl";
            this.labelMxPl.Size = new System.Drawing.Size(67, 13);
            this.labelMxPl.TabIndex = 0;
            this.labelMxPl.Text = "Max Players:";
            // 
            // textBoxMxPl
            // 
            this.textBoxMxPl.Location = new System.Drawing.Point(491, 21);
            this.textBoxMxPl.Name = "textBoxMxPl";
            this.textBoxMxPl.Size = new System.Drawing.Size(95, 20);
            this.textBoxMxPl.TabIndex = 1;
            this.textBoxMxPl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMxPl_KeyPress);
            // 
            // groupBoxKFGame
            // 
            this.groupBoxKFGame.Controls.Add(this.comboBoxWAE);
            this.groupBoxKFGame.Controls.Add(this.labelWAE);
            this.groupBoxKFGame.Controls.Add(this.comboBoxAdmPause);
            this.groupBoxKFGame.Controls.Add(this.textBoxAdmCont);
            this.groupBoxKFGame.Controls.Add(this.textBoxAdmPass);
            this.groupBoxKFGame.Controls.Add(this.labelAdPass);
            this.groupBoxKFGame.Controls.Add(this.labelAdmPause);
            this.groupBoxKFGame.Controls.Add(this.labelAdmCont);
            this.groupBoxKFGame.Location = new System.Drawing.Point(8, 66);
            this.groupBoxKFGame.Name = "groupBoxKFGame";
            this.groupBoxKFGame.Size = new System.Drawing.Size(592, 73);
            this.groupBoxKFGame.TabIndex = 1;
            this.groupBoxKFGame.TabStop = false;
            this.groupBoxKFGame.Text = "Other";
            // 
            // comboBoxWAE
            // 
            this.comboBoxWAE.FormattingEnabled = true;
            this.comboBoxWAE.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxWAE.Location = new System.Drawing.Point(106, 41);
            this.comboBoxWAE.Name = "comboBoxWAE";
            this.comboBoxWAE.Size = new System.Drawing.Size(143, 21);
            this.comboBoxWAE.TabIndex = 2;
            // 
            // labelWAE
            // 
            this.labelWAE.AutoSize = true;
            this.labelWAE.Location = new System.Drawing.Point(6, 44);
            this.labelWAE.Name = "labelWAE";
            this.labelWAE.Size = new System.Drawing.Size(65, 13);
            this.labelWAE.TabIndex = 0;
            this.labelWAE.Text = "Web Admin:";
            // 
            // comboBoxAdmPause
            // 
            this.comboBoxAdmPause.FormattingEnabled = true;
            this.comboBoxAdmPause.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxAdmPause.Location = new System.Drawing.Point(106, 19);
            this.comboBoxAdmPause.Name = "comboBoxAdmPause";
            this.comboBoxAdmPause.Size = new System.Drawing.Size(143, 21);
            this.comboBoxAdmPause.TabIndex = 2;
            // 
            // textBoxAdmCont
            // 
            this.textBoxAdmCont.Location = new System.Drawing.Point(340, 41);
            this.textBoxAdmCont.Name = "textBoxAdmCont";
            this.textBoxAdmCont.Size = new System.Drawing.Size(246, 20);
            this.textBoxAdmCont.TabIndex = 1;
            // 
            // textBoxAdmPass
            // 
            this.textBoxAdmPass.Location = new System.Drawing.Point(340, 19);
            this.textBoxAdmPass.Name = "textBoxAdmPass";
            this.textBoxAdmPass.Size = new System.Drawing.Size(246, 20);
            this.textBoxAdmPass.TabIndex = 1;
            // 
            // labelAdPass
            // 
            this.labelAdPass.AutoSize = true;
            this.labelAdPass.Location = new System.Drawing.Point(255, 22);
            this.labelAdPass.Name = "labelAdPass";
            this.labelAdPass.Size = new System.Drawing.Size(88, 13);
            this.labelAdPass.TabIndex = 0;
            this.labelAdPass.Text = "Admin Password:";
            // 
            // labelAdmPause
            // 
            this.labelAdmPause.AutoSize = true;
            this.labelAdmPause.Location = new System.Drawing.Point(6, 22);
            this.labelAdmPause.Name = "labelAdmPause";
            this.labelAdmPause.Size = new System.Drawing.Size(94, 13);
            this.labelAdmPause.TabIndex = 0;
            this.labelAdmPause.Text = "Admin Can Pause:";
            // 
            // labelAdmCont
            // 
            this.labelAdmCont.AutoSize = true;
            this.labelAdmCont.Location = new System.Drawing.Point(255, 44);
            this.labelAdmCont.Name = "labelAdmCont";
            this.labelAdmCont.Size = new System.Drawing.Size(79, 13);
            this.labelAdmCont.TabIndex = 0;
            this.labelAdmCont.Text = "Admin Contact:";
            // 
            // InsUpdCon
            // 
            this.InsUpdCon.Controls.Add(this.SAConsole);
            this.InsUpdCon.Controls.Add(this.ConsoleComands);
            this.InsUpdCon.Controls.Add(this.buttonDcmd);
            this.InsUpdCon.Controls.Add(this.richTextBoxUpd);
            this.InsUpdCon.Controls.Add(this.labelUP);
            this.InsUpdCon.Controls.Add(this.comboBoxUpd);
            this.InsUpdCon.Controls.Add(this.buttonUpdate);
            this.InsUpdCon.Location = new System.Drawing.Point(4, 22);
            this.InsUpdCon.Name = "InsUpdCon";
            this.InsUpdCon.Padding = new System.Windows.Forms.Padding(3);
            this.InsUpdCon.Size = new System.Drawing.Size(608, 318);
            this.InsUpdCon.TabIndex = 1;
            this.InsUpdCon.Text = "Install/Update";
            this.InsUpdCon.UseVisualStyleBackColor = true;
            // 
            // SAConsole
            // 
            this.SAConsole.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SAConsole.Location = new System.Drawing.Point(6, 263);
            this.SAConsole.Name = "SAConsole";
            this.SAConsole.Size = new System.Drawing.Size(596, 20);
            this.SAConsole.TabIndex = 9;
            this.SAConsole.Text = "Use with cautions";
            this.SAConsole.Visible = false;
            this.SAConsole.Enter += new System.EventHandler(this.SAConsole_Enter);
            this.SAConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SAConsole_KeyDown);
            this.SAConsole.Leave += new System.EventHandler(this.SAConsole_Leave);
            // 
            // ConsoleComands
            // 
            this.ConsoleComands.FormattingEnabled = true;
            this.ConsoleComands.Items.AddRange(new object[] {
            "All.Active",
            "All.Inactive",
            "DownloadSteamCMD",
            "Exit",
            "Save.Info",
            "Server.FirstLaunch",
            "Server.Install",
            "Server.Start",
            "Server.Stop",
            "Server.Update",
            "Update.Info"});
            this.ConsoleComands.Location = new System.Drawing.Point(6, 282);
            this.ConsoleComands.Name = "ConsoleComands";
            this.ConsoleComands.Size = new System.Drawing.Size(120, 30);
            this.ConsoleComands.Sorted = true;
            this.ConsoleComands.TabIndex = 10;
            this.ConsoleComands.Visible = false;
            // 
            // buttonDcmd
            // 
            this.buttonDcmd.Location = new System.Drawing.Point(134, 287);
            this.buttonDcmd.Name = "buttonDcmd";
            this.buttonDcmd.Size = new System.Drawing.Size(120, 23);
            this.buttonDcmd.TabIndex = 7;
            this.buttonDcmd.Text = "Download SteamCMD";
            this.buttonDcmd.UseVisualStyleBackColor = true;
            this.buttonDcmd.Visible = false;
            this.buttonDcmd.Click += new System.EventHandler(this.buttonDcmd_Click);
            // 
            // richTextBoxUpd
            // 
            this.richTextBoxUpd.Location = new System.Drawing.Point(6, 3);
            this.richTextBoxUpd.Name = "richTextBoxUpd";
            this.richTextBoxUpd.Size = new System.Drawing.Size(596, 254);
            this.richTextBoxUpd.TabIndex = 0;
            this.richTextBoxUpd.Text = "";
            this.richTextBoxUpd.TextChanged += new System.EventHandler(this.richTextBoxUpd_TextChanged);
            // 
            // labelUP
            // 
            this.labelUP.AutoSize = true;
            this.labelUP.Location = new System.Drawing.Point(260, 292);
            this.labelUP.Name = "labelUP";
            this.labelUP.Size = new System.Drawing.Size(90, 13);
            this.labelUP.TabIndex = 3;
            this.labelUP.Text = "Update Parametr:";
            // 
            // comboBoxUpd
            // 
            this.comboBoxUpd.FormattingEnabled = true;
            this.comboBoxUpd.Items.AddRange(new object[] {
            "",
            "validate ",
            "-beta \"branch name\" "});
            this.comboBoxUpd.Location = new System.Drawing.Point(356, 289);
            this.comboBoxUpd.Name = "comboBoxUpd";
            this.comboBoxUpd.Size = new System.Drawing.Size(165, 21);
            this.comboBoxUpd.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(525, 287);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.labelCPUu);
            this.tabMain.Controls.Add(this.labelRamU);
            this.tabMain.Controls.Add(this.progressBarRAM);
            this.tabMain.Controls.Add(this.progressBarCPU);
            this.tabMain.Controls.Add(this.groupBoxGame);
            this.tabMain.Controls.Add(this.buttonWebAdmin);
            this.tabMain.Controls.Add(this.groupBoxPorts);
            this.tabMain.Controls.Add(this.richTextBoxWrap);
            this.tabMain.Controls.Add(this.buttonStart);
            this.tabMain.Controls.Add(this.buttonStop);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(608, 318);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Server Info";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // labelCPUu
            // 
            this.labelCPUu.AutoSize = true;
            this.labelCPUu.Location = new System.Drawing.Point(324, 285);
            this.labelCPUu.Name = "labelCPUu";
            this.labelCPUu.Size = new System.Drawing.Size(83, 13);
            this.labelCPUu.TabIndex = 6;
            this.labelCPUu.Text = "CPU Usage: 0%";
            // 
            // labelRamU
            // 
            this.labelRamU.AutoSize = true;
            this.labelRamU.Location = new System.Drawing.Point(324, 300);
            this.labelRamU.Name = "labelRamU";
            this.labelRamU.Size = new System.Drawing.Size(113, 13);
            this.labelRamU.TabIndex = 6;
            this.labelRamU.Text = "RAM Usage: 0 / 0 MB";
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.Location = new System.Drawing.Point(6, 300);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(312, 12);
            this.progressBarRAM.TabIndex = 5;
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(6, 286);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(312, 12);
            this.progressBarCPU.Step = 1;
            this.progressBarCPU.TabIndex = 5;
            // 
            // groupBoxGame
            // 
            this.groupBoxGame.Controls.Add(this.labelPass);
            this.groupBoxGame.Controls.Add(this.textBoxPass);
            this.groupBoxGame.Controls.Add(this.comboBoxLen);
            this.groupBoxGame.Controls.Add(this.comboBoxDiff);
            this.groupBoxGame.Controls.Add(this.comboBoxMap);
            this.groupBoxGame.Controls.Add(this.labelMap);
            this.groupBoxGame.Controls.Add(this.labelLen);
            this.groupBoxGame.Controls.Add(this.labelDiff);
            this.groupBoxGame.Location = new System.Drawing.Point(6, 6);
            this.groupBoxGame.Name = "groupBoxGame";
            this.groupBoxGame.Size = new System.Drawing.Size(593, 67);
            this.groupBoxGame.TabIndex = 0;
            this.groupBoxGame.TabStop = false;
            this.groupBoxGame.Text = "Game";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(479, 14);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(53, 13);
            this.labelPass.TabIndex = 9;
            this.labelPass.Text = "Password";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(482, 30);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 8;
            // 
            // comboBoxLen
            // 
            this.comboBoxLen.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ServerApp.Properties.Settings.Default, "Lenght", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxLen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLen.FormattingEnabled = true;
            this.comboBoxLen.Items.AddRange(new object[] {
            "4 Wave - Short Game",
            "7 Wave - Normal game",
            "10 Waves - Long game"});
            this.comboBoxLen.Location = new System.Drawing.Point(338, 30);
            this.comboBoxLen.Name = "comboBoxLen";
            this.comboBoxLen.Size = new System.Drawing.Size(138, 21);
            this.comboBoxLen.TabIndex = 7;
            this.comboBoxLen.Text = global::ServerApp.Properties.Settings.Default.Lenght;
            // 
            // comboBoxDiff
            // 
            this.comboBoxDiff.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ServerApp.Properties.Settings.Default, "Diff", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiff.FormattingEnabled = true;
            this.comboBoxDiff.Items.AddRange(new object[] {
            "Normal",
            "Hard",
            "Suicidal",
            "Hell on Earth"});
            this.comboBoxDiff.Location = new System.Drawing.Point(200, 30);
            this.comboBoxDiff.Name = "comboBoxDiff";
            this.comboBoxDiff.Size = new System.Drawing.Size(132, 21);
            this.comboBoxDiff.TabIndex = 6;
            this.comboBoxDiff.Text = global::ServerApp.Properties.Settings.Default.Diff;
            // 
            // comboBoxMap
            // 
            this.comboBoxMap.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ServerApp.Properties.Settings.Default, "Map", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxMap.FormattingEnabled = true;
            this.comboBoxMap.Location = new System.Drawing.Point(6, 30);
            this.comboBoxMap.Name = "comboBoxMap";
            this.comboBoxMap.Size = new System.Drawing.Size(188, 21);
            this.comboBoxMap.TabIndex = 5;
            this.comboBoxMap.Text = global::ServerApp.Properties.Settings.Default.Map;
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Location = new System.Drawing.Point(3, 14);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(28, 13);
            this.labelMap.TabIndex = 4;
            this.labelMap.Text = "Map";
            // 
            // labelLen
            // 
            this.labelLen.AutoSize = true;
            this.labelLen.Location = new System.Drawing.Point(335, 14);
            this.labelLen.Name = "labelLen";
            this.labelLen.Size = new System.Drawing.Size(40, 13);
            this.labelLen.TabIndex = 3;
            this.labelLen.Text = "Length";
            // 
            // labelDiff
            // 
            this.labelDiff.AutoSize = true;
            this.labelDiff.Location = new System.Drawing.Point(197, 14);
            this.labelDiff.Name = "labelDiff";
            this.labelDiff.Size = new System.Drawing.Size(47, 13);
            this.labelDiff.TabIndex = 2;
            this.labelDiff.Text = "Difficulty";
            // 
            // buttonWebAdmin
            // 
            this.buttonWebAdmin.Enabled = false;
            this.buttonWebAdmin.Location = new System.Drawing.Point(483, 290);
            this.buttonWebAdmin.Name = "buttonWebAdmin";
            this.buttonWebAdmin.Size = new System.Drawing.Size(116, 23);
            this.buttonWebAdmin.TabIndex = 4;
            this.buttonWebAdmin.Text = "WebAdmin";
            this.buttonWebAdmin.UseVisualStyleBackColor = true;
            this.buttonWebAdmin.Click += new System.EventHandler(this.buttonWebAdmin_Click);
            // 
            // groupBoxPorts
            // 
            this.groupBoxPorts.Controls.Add(this.textBoxWB);
            this.groupBoxPorts.Controls.Add(this.textBoxQP);
            this.groupBoxPorts.Controls.Add(this.textBoxPort);
            this.groupBoxPorts.Controls.Add(this.labelWebAdminPort);
            this.groupBoxPorts.Controls.Add(this.labelQueryPort);
            this.groupBoxPorts.Controls.Add(this.labelPort);
            this.groupBoxPorts.Location = new System.Drawing.Point(483, 79);
            this.groupBoxPorts.Name = "groupBoxPorts";
            this.groupBoxPorts.Size = new System.Drawing.Size(116, 147);
            this.groupBoxPorts.TabIndex = 1;
            this.groupBoxPorts.TabStop = false;
            this.groupBoxPorts.Text = "Ports";
            // 
            // textBoxWB
            // 
            this.textBoxWB.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ServerApp.Properties.Settings.Default, "WAPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxWB.Location = new System.Drawing.Point(5, 110);
            this.textBoxWB.Name = "textBoxWB";
            this.textBoxWB.Size = new System.Drawing.Size(100, 20);
            this.textBoxWB.TabIndex = 5;
            this.textBoxWB.Text = global::ServerApp.Properties.Settings.Default.WAPort;
            this.textBoxWB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbers_KeyPress);
            // 
            // textBoxQP
            // 
            this.textBoxQP.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ServerApp.Properties.Settings.Default, "QPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxQP.Location = new System.Drawing.Point(7, 70);
            this.textBoxQP.Name = "textBoxQP";
            this.textBoxQP.Size = new System.Drawing.Size(98, 20);
            this.textBoxQP.TabIndex = 4;
            this.textBoxQP.Text = global::ServerApp.Properties.Settings.Default.QPort;
            this.textBoxQP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbers_KeyPress);
            // 
            // textBoxPort
            // 
            this.textBoxPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ServerApp.Properties.Settings.Default, "Port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPort.Location = new System.Drawing.Point(7, 31);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(98, 20);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.Text = global::ServerApp.Properties.Settings.Default.Port;
            this.textBoxPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbers_KeyPress);
            // 
            // labelWebAdminPort
            // 
            this.labelWebAdminPort.AutoSize = true;
            this.labelWebAdminPort.Location = new System.Drawing.Point(7, 94);
            this.labelWebAdminPort.Name = "labelWebAdminPort";
            this.labelWebAdminPort.Size = new System.Drawing.Size(84, 13);
            this.labelWebAdminPort.TabIndex = 2;
            this.labelWebAdminPort.Text = "Web Admin Port";
            // 
            // labelQueryPort
            // 
            this.labelQueryPort.AutoSize = true;
            this.labelQueryPort.Location = new System.Drawing.Point(7, 54);
            this.labelQueryPort.Name = "labelQueryPort";
            this.labelQueryPort.Size = new System.Drawing.Size(57, 13);
            this.labelQueryPort.TabIndex = 1;
            this.labelQueryPort.Text = "Query Port";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(7, 15);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Port";
            // 
            // richTextBoxWrap
            // 
            this.richTextBoxWrap.Location = new System.Drawing.Point(6, 79);
            this.richTextBoxWrap.Name = "richTextBoxWrap";
            this.richTextBoxWrap.Size = new System.Drawing.Size(471, 205);
            this.richTextBoxWrap.TabIndex = 3;
            this.richTextBoxWrap.Text = "";
            this.richTextBoxWrap.TextChanged += new System.EventHandler(this.richTextBoxWrap_TextChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(483, 232);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(116, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(483, 261);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(116, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // tabSA
            // 
            this.tabSA.Controls.Add(this.tabMain);
            this.tabSA.Controls.Add(this.InsUpdCon);
            this.tabSA.Controls.Add(this.tabSett);
            this.tabSA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSA.Location = new System.Drawing.Point(0, 0);
            this.tabSA.Name = "tabSA";
            this.tabSA.SelectedIndex = 0;
            this.tabSA.Size = new System.Drawing.Size(616, 344);
            this.tabSA.TabIndex = 5;
            // 
            // fmServerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 344);
            this.Controls.Add(this.tabSA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmServerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KF 2 - ServerApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerApp_FormClosing);
            this.Load += new System.EventHandler(this.ServerApp_Load);
            this.Resize += new System.EventHandler(this.ServerApp_Resize);
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            this.tabSett.ResumeLayout(false);
            this.groupBoxMap.ResumeLayout(false);
            this.groupBoxMap.PerformLayout();
            this.groupBoxKFWeb.ResumeLayout(false);
            this.groupBoxKFWeb.PerformLayout();
            this.groupBoxKFGame.ResumeLayout(false);
            this.groupBoxKFGame.PerformLayout();
            this.InsUpdCon.ResumeLayout(false);
            this.InsUpdCon.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.groupBoxGame.ResumeLayout(false);
            this.groupBoxGame.PerformLayout();
            this.groupBoxPorts.ResumeLayout(false);
            this.groupBoxPorts.PerformLayout();
            this.tabSA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIconSA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStartServer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStopServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOWA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExt;
        private System.Windows.Forms.OpenFileDialog openMapDir;
        private System.Windows.Forms.Timer timerUsage;
        private System.Windows.Forms.TabPage tabSett;
        private System.Windows.Forms.Button buttonSaveKF;
        private System.Windows.Forms.GroupBox groupBoxMap;
        private System.Windows.Forms.Button buttonBrowsMap;
        private System.Windows.Forms.Button buttonAddMap;
        private System.Windows.Forms.Label labelRedirect;
        private System.Windows.Forms.RichTextBox richTextBoxMap;
        private System.Windows.Forms.TextBox textBoxRedirect;
        private System.Windows.Forms.GroupBox groupBoxKFWeb;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSrvName;
        private System.Windows.Forms.Label labelMxPl;
        private System.Windows.Forms.TextBox textBoxMxPl;
        private System.Windows.Forms.GroupBox groupBoxKFGame;
        private System.Windows.Forms.ComboBox comboBoxWAE;
        private System.Windows.Forms.Label labelWAE;
        private System.Windows.Forms.ComboBox comboBoxAdmPause;
        private System.Windows.Forms.TextBox textBoxAdmCont;
        private System.Windows.Forms.TextBox textBoxAdmPass;
        private System.Windows.Forms.Label labelAdPass;
        private System.Windows.Forms.Label labelAdmPause;
        private System.Windows.Forms.Label labelAdmCont;
        private System.Windows.Forms.TabPage InsUpdCon;
        private System.Windows.Forms.Button buttonDcmd;
        private System.Windows.Forms.RichTextBox richTextBoxUpd;
        private System.Windows.Forms.Label labelUP;
        private System.Windows.Forms.ComboBox comboBoxUpd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.Label labelCPUu;
        private System.Windows.Forms.Label labelRamU;
        private System.Windows.Forms.ProgressBar progressBarRAM;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.GroupBox groupBoxGame;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.ComboBox comboBoxLen;
        private System.Windows.Forms.ComboBox comboBoxDiff;
        private System.Windows.Forms.ComboBox comboBoxMap;
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.Label labelLen;
        private System.Windows.Forms.Label labelDiff;
        private System.Windows.Forms.Button buttonWebAdmin;
        private System.Windows.Forms.GroupBox groupBoxPorts;
        private System.Windows.Forms.TextBox textBoxWB;
        private System.Windows.Forms.TextBox textBoxQP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelWebAdminPort;
        private System.Windows.Forms.Label labelQueryPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.RichTextBox richTextBoxWrap;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TabControl tabSA;
        private System.Windows.Forms.TextBox SAConsole;
        private System.Windows.Forms.ListBox ConsoleComands;
    }
}

