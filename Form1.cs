using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Security;
using System.Security.Permissions;

using System.Net;
using System.Threading;
using System.Runtime.InteropServices; //for moving form1

namespace Launcher_WoW_Addicts
{
    public partial class Form_wow_addicts : Form
    {
        public string Version;
        public string CurrentVersion;
        public int VersionNumber;
        public int CurrentVersionNumber;
        public Form_wow_addicts()
        {
            InitializeComponent();
        }

        //for moving form1
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form_wow_addicts_Load(object sender, EventArgs e)//When Form first loads up
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebClient client1 = new WebClient();
            client1.DownloadFile("https://drive.google.com/u/0/uc?id=1Je1DhwSdqNhiGp4X9VKrwXd-a7s3zeTN&export=download", "valikyria 4.3.4 minimal.rar");
        }
        private void Button_play_Click(object sender, EventArgs e)
        {
            string browserpath_legion = Application.StartupPath + "/Client_path.txt";
            string Client_path = File.ReadLines(browserpath_legion).First();

            Process.Start(Client_path + "/Covenant_64.exe");
        }

        private void Button_browse_Click(object sender, EventArgs e)
        {
            string setpath = "";

            FolderBrowserDialog browse = new FolderBrowserDialog();
            browse.Description = "Choose your instalation folder: ";
            if (browse.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                setpath = browse.SelectedPath;

                string savepathfile = Application.StartupPath + "/Client_path.txt";
                File.WriteAllText(savepathfile, setpath);
                MessageBox.Show("The client path is saved correctly");
        }

        private void Label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox_logo_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/@wow_addicts/videos");
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            MethodInvoker Max = delegate
            {
                try
                {
                    ProgressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
                }
                catch (Exception)
                {

                }
            };
            MethodInvoker Value = delegate
            {
                try
                {
                    ProgressBar1.Value = (int)e.BytesReceived / 100;
                }
                catch (Exception)
                {

                }
            };
            MethodInvoker Labelhelp = delegate
            {
                try
                {
                    Label_ready.Text = (int)e.BytesReceived / 1000 + " KB/" + (int)e.TotalBytesToReceive / 1000 + " KB";
                }
                catch (Exception)
                {

                }
            };


            //Show download Progress
            ProgressBar1.Invoke(Max);
            ProgressBar1.Invoke(Value);
            Label_ready.Invoke(Labelhelp);

        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MethodInvoker DownloadComplete = delegate
            {
                try
                {
                    Label_ready.Text = "Download Complete.";
                }
                catch (Exception)
                {

                }
            };
            MethodInvoker Ready = delegate
            {
                try
                {
                    Label_ready.Text = "Ready to Play.";
                }
                catch (Exception)
                {

                }
            };
            MethodInvoker Upgrade = delegate
            {
                try
                {
                    ProgressBar1.Value += 20;
                }
                catch (Exception)
                {

                }
            };
            MethodInvoker Done = delegate
            {
                try
                {
                    ProgressBar1.Value = 100;
                    ProgressBar1.Maximum = 100;
                }
                catch (Exception)
                {

                }
            };
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            Label_ready.Text = "Starting Check";
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebClient client2 = new WebClient();
            client2.DownloadFile("https://drive.google.com/u/0/uc?id=1Je1DhwSdqNhiGp4X9VKrwXd-a7s3zeTN&export=download", "valikyria 4.3.4 minimal.rar");
            Thread th = new Thread(Updater);
            th.IsBackground = true;
            th.Start();
        }

        public void Updater() //Thread to make Updater Run smoothly
        {
            MethodInvoker Updating = delegate
            {
                try
                {
                    Label_ready.Text = "Update Found. Downloading Now.";
                }
                catch (Exception)
                {

                }
            };

            MethodInvoker NoUpdate = delegate
            {
                try
                {
                    Label_ready.Text = "No Update Found.";
                }
                catch (Exception)
                {

                }
            };
            MethodInvoker LatestVersion = delegate
            {
                try
                {
                    Label_ready.Text = "Your Files are Up to Date.";
                }
                catch (Exception)
                {

                }
            };
            MethodInvoker Done = delegate
            {
                try
                {
                    ProgressBar1.Value = 100;
                    ProgressBar1.Maximum = 100;
                }
                catch (Exception)
                {

                }
            };



            if (VersionNumber > CurrentVersionNumber)
            {
                //Download Current Update!
                Label_ready.Invoke(Updating);
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebClient client3 = new WebClient();
                client3.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client3.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client3.DownloadFileAsync(new Uri("https://drive.google.com/u/0/uc?id=1Je1DhwSdqNhiGp4X9VKrwXd-a7s3zeTN&export=download"), "valikyria 4.3.4 minimal.rar");
            }
            else if (VersionNumber == CurrentVersionNumber)
            {
                //No update
                Label_ready.Invoke(NoUpdate);
                ProgressBar1.Invoke(Done);
                Label_ready.Invoke(LatestVersion);
            }
        }

        private void Form_wow_addicts_MouseDown(object sender, MouseEventArgs e)
        {
            //for moving form1
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
