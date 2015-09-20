using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Net;
using System.Management;
using Ionic.Zip;

namespace ServerApp
{
    public partial class fmServerApp : Form
    {
        string[] arg;
        public fmServerApp(string[] args)
        {
            arg = args;
            InitializeComponent();
        }

        class INI
        { 
            public string path;

            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

            public INI(string INIPath)
            {
                path = INIPath;
            }

            public void IniWriteValue(string Section, string Key, string Value)
            {
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                if (!File.Exists(path))
                    using (File.Create(path)) { };
                WritePrivateProfileString(Section, Key, Value, this.path);
            }

            public string IniReadValue(string Section, string Key)
            {
                StringBuilder temp = new StringBuilder(255);
                int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
                return temp.ToString();
            }
        }

        string Diff, Lenght, CopyMap, MapName, MapNameDisc, SFLProp;
        string Pth = "\\kf2_ds\\Binaries\\win64\\kfserver.exe";
        string Host = System.Net.Dns.GetHostName();
        int CPUValue = 0;

        protected PerformanceCounter cpuCounter;
        protected PerformanceCounter ramCounter;

        Process Serv = null;
        Process Upd = null;
        Process SFL = null;

        public static class MemoryHelper
        {
            [StructLayout(LayoutKind.Sequential)]
            internal struct MEMORYSTATUSEX
            {
                internal uint dwLength;
                internal uint dwMemoryLoad;
                internal ulong ullTotalPhys;
                internal ulong ullAvailPhys;
                internal ulong ullTotalPageFile;
                internal ulong ullAvailPageFile;
                internal ulong ullTotalVirtual;
                internal ulong ullAvailVirtual;
                internal ulong ullAvailExtendedVirtual;
            }
            [return: MarshalAs(UnmanagedType.Bool)]
            [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            static extern bool GlobalMemoryStatusEx(ref MEMORYSTATUSEX lpBuffer);

            public static double GetGlobalMemoryStatusEX()
            {
                MEMORYSTATUSEX statEX = new MEMORYSTATUSEX();
                statEX.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
                GlobalMemoryStatusEx(ref statEX);

                return (double)statEX.ullTotalPhys;

            }
        }

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hwnd, int nCmdShow);

        private void PermaServHide()
        {
            IntPtr hwnd = FindWindow(null, Application.StartupPath + Pth);
            if (!hwnd.Equals(IntPtr.Zero))
            {
                ShowWindowAsync(hwnd, 0);
            }
        }

        private void SServ()
        {
            Serv.Start();
            using (StreamReader reader = Serv.StandardOutput)
            {
                while (!reader.EndOfStream)
                {
                    var text = reader.ReadLine();
                    this.AppendLine(text);
                    PermaServHide();
                    Thread.Sleep(1);
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Serv = new Process();
            Serv.StartInfo.UseShellExecute = false;
            Serv.StartInfo.CreateNoWindow = true;
            Serv.StartInfo.RedirectStandardInput = true;
            Serv.StartInfo.RedirectStandardOutput = true;
            Serv.StartInfo.FileName = ".\\kf2_ds\\Binaries\\win64\\kfserver.exe";
            Serv.StartInfo.Arguments = comboBoxMap.Text + "?Difficulty=" + Diff + "?GameLength=" + Lenght +
                    "?GamePassword=" + textBoxPass.Text + "?Port=" + textBoxPort.Text +
                    "?QueryPort=" + textBoxQP.Text +
                    "?WebAdminPort=" + textBoxWB.Text;

            switch (comboBoxDiff.Text)
            {
                case "Normal":
                    Diff = "0";
                    break;
                case "Hard":
                    Diff = "1";
                    break;
                case "Suicidal":
                    Diff = "2";
                    break;
                case "Hell on Earth":
                    Diff = "3";
                    break;
                default:
                    Diff = "0";
                    break;
            }
            switch (comboBoxLen.Text)
            {
                case "4 Wave - Short Game":
                    Lenght = "0";
                    break;
                case "7 Wave - Normal game":
                    Lenght = "1";
                    break;
                case "10 Waves - Long game":
                    Lenght = "2";
                    break;
                default:
                    Lenght = "0";
                    break;
            }
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            buttonWebAdmin.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonAddMap.Enabled = false;
            buttonSaveKF.Enabled = false;
            buttonBrowsMap.Enabled = false;

            toolStripMenuItemStartServer.Enabled = false;
            toolStripMenuItemStopServer.Enabled = true;
            toolStripMenuItemOWA.Enabled = true;

            SaveInfo();

            richTextBoxWrap.Clear();
            this.Text = "KF 2 - ServerApp - "   + textBoxSrvName.Text+" ("
                                                +comboBoxDiff.Text+") ("
                                                +comboBoxLen.Text+")";
            Thread ServThread = new Thread(SServ);
            ServThread.Start();     

            timerUsage.Enabled = true;
        }

        private delegate void AppendLineDelegate(string text);

        private void AppendLine(string text)
        {
            if (!this.InvokeRequired)
            {
                richTextBoxWrap.AppendText(text + Environment.NewLine);
            }
            else
            {
                this.Invoke(new AppendLineDelegate(this.AppendLine), new object[] { text });
            }
        }

        private void AppendLineUpd(string text)
        {
            if (!this.InvokeRequired)
            {
                richTextBoxUpd.AppendText(text + Environment.NewLine);
            }
            else
            {
                this.Invoke(new AppendLineDelegate(this.AppendLineUpd), new object[] { text });
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (!Serv.HasExited)
            {
                foreach (Process Serv in System.Diagnostics.Process.GetProcessesByName("KFServer"))
                {
                    {
                        Serv.Kill();
                        Serv.WaitForExit();
                    }
                }
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
                buttonWebAdmin.Enabled = false;
                buttonUpdate.Enabled = true;
                buttonBrowsMap.Enabled = true;
                buttonSaveKF.Enabled = true;

                toolStripMenuItemStartServer.Enabled = true;
                toolStripMenuItemStopServer.Enabled = false;
                toolStripMenuItemOWA.Enabled = false;

                this.Text = "KF 2 - ServerApp";

                timerUsage.Enabled = false;
                progressBarCPU.Value = 0;
                progressBarRAM.Value = 0;

                labelCPUu.Text = "CPU Usage: 0%";
                labelRamU.Text = "RAM Usage: 0 / " + Convert.ToString(Convert.ToInt32((MemoryHelper.GetGlobalMemoryStatusEX() / 1024 / 1024)))+" MB";
            }
        }

        private void buttonWebAdmin_Click(object sender, EventArgs e)
        {
            string IP = System.Net.Dns.GetHostByName(Host).AddressList[0].ToString();
            Process.Start("http://"+IP + ":" + textBoxWB.Text);
        }

        private void ServerApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Process Serv in System.Diagnostics.Process.GetProcessesByName("KFServer"))
            {
                Serv.Kill();
                Serv.WaitForExit();
            }
            Properties.Settings.Default.Map = comboBoxMap.Text;
            Properties.Settings.Default.Diff = comboBoxDiff.Text;
            Properties.Settings.Default.Lenght = comboBoxLen.Text;
            Properties.Settings.Default.QPort = textBoxQP.Text;
            Properties.Settings.Default.Port = textBoxPort.Text;
            Properties.Settings.Default.WAPort = textBoxWB.Text;
            Properties.Settings.Default.Save();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            richTextBoxUpd.Clear();
            if (!File.Exists("steamcmd.exe")) buttonDcmd_Click(this, EventArgs.Empty);
            Upd = new Process();
            Upd.StartInfo.UseShellExecute = false;
            Upd.StartInfo.CreateNoWindow = true;
            Upd.StartInfo.RedirectStandardInput = true;
            Upd.StartInfo.RedirectStandardOutput = true;
            Upd.StartInfo.FileName = "steamcmd.exe";
            Upd.StartInfo.Arguments ="+login anonymous +force_install_dir ./kf2_ds +app_update 232130 "+comboBoxUpd.Text+" +exit";
            Thread UpdThread = new Thread(UpdateServ);
            UpdThread.Start();
            SFLProp = comboBoxUpd.Text;
            buttonStart.Enabled = true;
        }

        private void richTextBoxWrap_TextChanged(object sender, EventArgs e)
        {
            richTextBoxWrap.SelectionStart = richTextBoxWrap.Text.Length;
            richTextBoxWrap.ScrollToCaret();
        }

        private void LoadInfo()
        {
        INI KFGameini = new INI(".\\kf2_ds\\KFGame\\Config\\PCServer-KFGame.ini");
            textBoxSrvName.Text = KFGameini.IniReadValue("Engine.GameReplicationInfo", "ServerName");
            textBoxMxPl.Text = KFGameini.IniReadValue("Engine.GameInfo", "MaxPlayers");
            textBoxAdmPass.Text = KFGameini.IniReadValue("Engine.AccessControl", "AdminPassword");
            textBoxAdmCont.Text = KFGameini.IniReadValue("Engine.GameReplicationInfo", "AdminContact");
            comboBoxAdmPause.Text = KFGameini.IniReadValue("Engine.GameInfo", "bAdminCanPause");
            textBoxPass.Text = KFGameini.IniReadValue("Engine.AccessControl", "GamePassword");
        INI KFWebini = new INI(".\\kf2_ds\\KFGame\\Config\\KFWeb.ini");
            comboBoxWAE.Text = KFWebini.IniReadValue("IpDrv.WebServer", "bEnabled");
        INI KFEngineini = new INI(".\\kf2_ds\\KFGame\\Config\\PCServer-KFEngine.ini");
            textBoxRedirect.Text = KFEngineini.IniReadValue("IpDrv.HTTPDownload", "RedirectToURL");
        }

        private void SaveInfo()
        {
        INI KFGameini = new INI(".\\kf2_ds\\KFGame\\Config\\PCServer-KFGame.ini");
            KFGameini.IniWriteValue("Engine.GameReplicationInfo", "ServerName", textBoxSrvName.Text);
            KFGameini.IniWriteValue("Engine.GameInfo", "MaxPlayers", textBoxMxPl.Text);
            KFGameini.IniWriteValue("Engine.AccessControl", "AdminPassword", textBoxAdmPass.Text);
            KFGameini.IniWriteValue("Engine.GameReplicationInfo", "AdminContact", textBoxAdmCont.Text);
            KFGameini.IniWriteValue("Engine.GameInfo", "bAdminCanPause", comboBoxAdmPause.Text);
            KFGameini.IniWriteValue("Engine.AccessControl", "GamePassword", textBoxPass.Text);
        INI KFWebini = new INI(".\\kf2_ds\\KFGame\\Config\\KFWeb.ini");
            KFWebini.IniWriteValue("IpDrv.WebServer", "bEnabled", comboBoxWAE.Text);
            KFWebini.IniWriteValue("IpDrv.WebServer", "ListenPort", textBoxWB.Text);
        INI KFEngineini = new INI(".\\kf2_ds\\KFGame\\Config\\PCServer-KFEngine.ini");
            KFEngineini.IniWriteValue("IpDrv.HTTPDownload", "RedirectToURL", textBoxRedirect.Text);
            KFEngineini.IniWriteValue("URL", "Port", textBoxPort.Text);
        }

        private void ServerApp_Load(object sender, EventArgs e)
        {
            progressBarRAM.Maximum = Convert.ToInt32((MemoryHelper.GetGlobalMemoryStatusEX() / 1024 / 1024));
            labelRamU.Text = "RAM Usage: 0 / " + Convert.ToString(Convert.ToInt32((MemoryHelper.GetGlobalMemoryStatusEX() / 1024 / 1024)))+" MB";
            if (File.Exists("kf2_ds\\KFGame\\Config\\PCServer-KFGame.ini"))
            {
                LoadInfo();
            }
            else buttonStart.Enabled = false;
            if (arg.Length == 0)
            {
                SAConsole.Visible = false;
                richTextBoxUpd.Height = 275;
            }
            else if (arg[0] == "-console")
            {
                SAConsole.Visible = true;
                richTextBoxUpd.Height = 255;
            }
            else if (arg[0] == "-start")
            {
                buttonStart_Click(this, EventArgs.Empty);
                this.WindowState = FormWindowState.Minimized;
            }
            else if (arg[0] == "-firststart")
            {
                comboBoxUpd.Text = "validate ";
                buttonUpdate_Click(this, EventArgs.Empty);
            }
        }

        private void buttonSaveKF_Click(object sender, EventArgs e)
        {
            SaveInfo();
            Properties.Settings.Default.Map = comboBoxMap.Text;
            Properties.Settings.Default.Diff = comboBoxDiff.Text;
            Properties.Settings.Default.Lenght = comboBoxLen.Text;
            Properties.Settings.Default.QPort = textBoxQP.Text;
            Properties.Settings.Default.Port = textBoxPort.Text;
            Properties.Settings.Default.WAPort = textBoxWB.Text;
            Properties.Settings.Default.Save();
        }

        private void buttonAddMap_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(".\\kf2_ds\\KFGame\\Config\\PCServer-KFGame.ini", true);
            writer.WriteLine(richTextBoxMap.Lines[0]);
            writer.WriteLine(richTextBoxMap.Lines[1]);
            writer.WriteLine(richTextBoxMap.Lines[2]);
            writer.WriteLine(richTextBoxMap.Lines[3]);
            writer.Close();
            comboBoxMap.Items.Add(MapName);
            CopyFile(CopyMap, Application.StartupPath + "\\kf2_ds\\KFGame\\BrewedPC\\Maps\\" + MapNameDisc);
        }

        private void toolStripMenuItemExt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ServerApp_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
            }
        }

        private void notifyIconSA_DoubleClick(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                this.Hide();
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void UpdateServ()
        {
            Upd.Start();

            using (StreamReader reader = Upd.StandardOutput)
            {
                while (!reader.EndOfStream)
                {
                    var text = reader.ReadLine();
                    this.AppendLineUpd(text);
                    Thread.Sleep(1);
                }
            }
            if (SFLProp == "validate " || SFLProp == "validate" || SFLProp == "Validate" || SFLProp == "Validate ")
                SFLaunch();
            LoadInfo();
        }

        private void SFLaunch()
        {
            SFL = new Process();
            SFL.StartInfo.UseShellExecute = false;
            SFL.StartInfo.CreateNoWindow = true;
            SFL.StartInfo.RedirectStandardInput = true;
            SFL.StartInfo.RedirectStandardOutput = true;
            SFL.StartInfo.FileName = ".\\kf2_ds\\Binaries\\win64\\kfserver.exe";
            SFL.StartInfo.Arguments = "kf-bioticslab?adminpassword=123";

            Thread SFLThread = new Thread(FirstDownLoad);
            SFLThread.Start();
            Thread SFLWaitThread = new Thread(SFLWait);
            SFLWaitThread.Start();
        }

        private void FirstDownLoad()
        {
            SFL.Start();
            using (StreamReader reader = SFL.StandardOutput)
            {
                while (!reader.EndOfStream)
                {
                    var text = reader.ReadLine();
                    this.AppendLineUpd(text);
                    PermaServHide();
                    Thread.Sleep(1);
                }
            }
        }

        private void SAConsole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (SAConsole.Text)
                {
                    case "Server.Start":
                        this.richTextBoxUpd.AppendText(SAConsole.Text + ": server is on\n\n");
                        buttonStart_Click(this, EventArgs.Empty);
                        break;
                    case "Server.Stop":
                        Stop_Click(this, EventArgs.Empty);
                        this.richTextBoxUpd.AppendText(SAConsole.Text + ": server stoped\n\n");
                        break;
                    case "Server.Update":
                        buttonUpdate_Click(this, EventArgs.Empty);
                        this.richTextBoxUpd.AppendText(SAConsole.Text + ": server updating in progress\n\n");
                        break;
                    case "Server.Install":
                        comboBoxUpd.Text = "validate ";
                        this.richTextBoxUpd.AppendText(SAConsole.Text + ": server instalation in progress\n\n");
                        buttonUpdate_Click(this, EventArgs.Empty);
                        break;
                    case "Server.FirstLaunch":
                        this.richTextBoxUpd.AppendText(SAConsole.Text + ": First launch server for creating all data\n\n");
                        SFLaunch();
                        break;
                    case "Update.Info":
                        this.richTextBoxUpd.AppendText(SAConsole.Text + ": Update all info\n\n");
                        LoadInfo();
                        break;
                    case "Save.Info":
                        this.richTextBoxUpd.AppendText(SAConsole.Text + ": Save all info\n\n");
                        buttonSaveKF_Click(this, EventArgs.Empty);
                        break;
                    case "All.Active":
                        this.richTextBoxUpd.AppendText(SAConsole.Text + ": All button are enabled\n\n");
                        this.buttonStart.Enabled = true;
                        this.buttonStop.Enabled = true;
                        this.buttonWebAdmin.Enabled = true;
                        this.buttonUpdate.Enabled = true;
                        this.buttonBrowsMap.Enabled = true;
                        this.buttonAddMap.Enabled = true;
                        this.buttonSaveKF.Enabled = true;
                        break;
                    case "All.Inactive":
                        this.richTextBoxUpd.AppendText(SAConsole.Text + ": All button are disabled\n\n");
                        this.buttonStart.Enabled = false;
                        this.buttonStop.Enabled = false;
                        this.buttonWebAdmin.Enabled = false;
                        this.buttonUpdate.Enabled = false;
                        this.buttonBrowsMap.Enabled = false;
                        this.buttonAddMap.Enabled = false;
                        this.buttonSaveKF.Enabled = false;
                        break;
                    case "DownloadSteamCMD":
                    buttonDcmd_Click(this, EventArgs.Empty);
                        break;
                    case "Exit":
                        this.richTextBoxUpd.AppendText(SAConsole.Text + ": Bye\n\n");
                        Application.Exit();
                        break;
                    default:
                        this.richTextBoxUpd.AppendText(SAConsole.Text + ": Unknown command\n\n");
                        break;
                }
                SAConsole.Text = null;
            }
        }

        private void SAConsole_Leave(object sender, EventArgs e)
        {
            ConsoleComands.Visible = false;
        }

        private void SAConsole_Enter(object sender, EventArgs e)
        {
            ConsoleComands.Visible = true;
            SAConsole.Text = null;
            SAConsole.ForeColor = Color.Black;
        }

        private void timerUsage_Tick(object sender, EventArgs e)
        {
            Process[] SerRam = Process.GetProcessesByName("KFServer");
            foreach (Process process in SerRam)
            {
                int memory = Convert.ToInt32(process.WorkingSet64 / 1024 / 1024);
                if (memory >= progressBarRAM.Maximum) memory = 0;
                progressBarRAM.Value = memory;
                labelRamU.Text = "RAM Usage: " + memory + " / " + Convert.ToString(Convert.ToInt32((MemoryHelper.GetGlobalMemoryStatusEX() / 1024 / 1024)))+ " MB";
                labelCPUu.Text = "CPU Usage: " + CPUValue + "%";
                if (CPUValue >= progressBarCPU.Maximum) CPUValue = 0;
                progressBarCPU.Value = CPUValue;
                Thread CPUUseThThread = new Thread(CPUUseTh);
                CPUUseThThread.Start();
            }
        }

        private void CPUUseTh()
        {
            Process[] SerCPU = Process.GetProcessesByName("KFServer");
            foreach (Process proces in SerCPU)
            {
                using (PerformanceCounter pcProcess = new PerformanceCounter("Process", "% Processor Time", proces.ProcessName))
                {
                    try
                    {
                        pcProcess.NextValue();
                        System.Threading.Thread.Sleep(1000);
                        CPUValue = Convert.ToInt32(Math.Round(pcProcess.NextValue(), 1));
                    } catch (Exception) { }
                }
            }
        }

        private void textBoxMxPl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void buttonDcmd_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            string link = @"http://media.steampowered.com/installer/steamcmd.zip";
            string downloadFileName = System.IO.Path.GetFileName("steamcmd.zip");
            webClient.DownloadFileAsync(new Uri(link), Application.StartupPath+"\\" + downloadFileName);
            this.richTextBoxUpd.AppendText("SteamCMD download complete\n\n");
            System.IO.WaitForChangedResult result;
            System.IO.FileSystemWatcher watcher =
        new System.IO.FileSystemWatcher(Application.StartupPath + "\\", "steamcmd.zip");
            result = watcher.WaitForChanged(System.IO.WatcherChangeTypes.Changed);
            using ( ZipFile zip = ZipFile.Read("steamcmd.zip"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\");
                zip.ExtractAll(Application.StartupPath + "\\", ExtractExistingFileAction.OverwriteSilently);
                this.richTextBoxUpd.AppendText("SteamCMD extract complete\n\n");
            }
            File.Delete("steamcmd.zip");
        }

        private void SFLWait()
        {
            System.IO.WaitForChangedResult result;
            System.IO.FileSystemWatcher watcher =
        new System.IO.FileSystemWatcher(Application.StartupPath + "\\kf2_ds\\KFGame\\Config\\", "PCServer-KFSystemSettings.ini");
            result = watcher.WaitForChanged(System.IO.WatcherChangeTypes.Created);
            Thread.Sleep(20000);
            foreach (Process Serv in System.Diagnostics.Process.GetProcessesByName("KFServer"))
            {
                Serv.Kill();
                Serv.WaitForExit();
            }
            LoadInfo();
        }

        void CopyFile(string sourcefn, string destinfn)
        {
            FileInfo CopeMapName = new FileInfo(sourcefn);
            CopeMapName.CopyTo(destinfn, true);
        }

        private void buttonBrowsMap_Click(object sender, EventArgs e)
        {
            openMapDir.Filter = "KF2 map file (*.kfm)|*.kfm";
            if (openMapDir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CopyMap = openMapDir.FileName;
                MapName = Path.GetFileNameWithoutExtension(openMapDir.FileName);
                MapNameDisc = Path.GetFileName(openMapDir.FileName);
            }
            richTextBoxMap.Clear();
            richTextBoxMap.Text = "[" + MapName + " KFMapSummary]" +
                                  "\nMapName = " + MapName +
                                  "\nScreenshotPathName = UI_MapPreview_TEX.UI_MapPreview_Placeholder" +
                                  "\n";
            buttonAddMap.Enabled = true;
        }

        private void richTextBoxUpd_TextChanged(object sender, EventArgs e)
        {
            richTextBoxUpd.SelectionStart = richTextBoxUpd.Text.Length;
            richTextBoxUpd.ScrollToCaret();
        }

        private void textBoxNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}