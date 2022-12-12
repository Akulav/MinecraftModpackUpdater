using System;
using System.ComponentModel;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace NewEraLauncher
{
    public partial class defaultWindow : Form
    {
        public string[] result;
        public static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public defaultWindow()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //Disable button to prevent errors during install
            updateBtn.Enabled = false;

            //Select the modpack
            int index = modpackList.SelectedIndex;

            //Prevent error if no modpack is selected
            if (index == -1)
            {
                MessageBox.Show("Check a modpack to install");
                updateBtn.Enabled = true;
                goto updateBtnEnd;
            }

            //Starts the download and installation on different threads
            StartDownload(result[index+index+1]);
            Functionality.StartInstall();

        updateBtnEnd:;
        }

        private void StartDownload(string url)
        {
            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(Client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(url), @"C:\NewEraCache\downloaded.zip");
            });
            thread.Start();
        }

        void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                progressLabel.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
                downloadBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

        void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                progressLabel.Text = "Downloading";

                DirectoryLib.DeleteFolder(@"C:\NewEraCache\extracted");
                Functionality.ExtractInstall();

                updateBtn.Enabled = true;
                progressLabel.Text = "Success";
                DirectoryLib.DeleteFolder(@"C:\NewEraCache");

            });
        }

        public void DefaultWindow_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            using (WebClient client = new WebClient())
            {
                string update_data = client.DownloadString("https://raw.githubusercontent.com/Akulav/MinecraftModpackUpdater/main/modpack_list.txt");
                result = Regex.Split(update_data, "\r\n|\r|\n");
                for (int i = 0; i < result.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        modpackList.Items.Add(result[i]);
                    }
                }
                modpackList.Items.Remove("");
            }
            DirectoryLib.CreateFolder(@"C:\NewEraCache");
        }

        private void modpackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = modpackList.SelectedIndex;
            for (int ix = 0; ix < modpackList.Items.Count; ++ix)
                if (ix != index) modpackList.SetItemChecked(ix, false);
        }
    }
}
