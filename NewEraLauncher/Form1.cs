using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace NewEraLauncher
{
    public partial class defaultWindow : Form
    {
        public string version;
        public string url;
        public defaultWindow()
        {
            InitializeComponent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            startDownload();
            startInstall();
        }

        private void startDownload()
        {
            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(this.url), @"C:\NewEraCache\downloaded.zip");
            });
            thread.Start();
        }

        private void startInstall()
        {
            Thread thread = new Thread(() => {
                try
                {
                    File.Copy(@"C:\Users\akula\AppData\\Roaming\.minecraft\launcher_accounts.json", @"C:\NewEraCache\launcher_accounts.json", true);
                    Directory.Delete(@"C:\Users\akula\AppData\Roaming\.minecraft", true);
                }
                catch (IOException)
                {

                }
            });
            thread.Start();
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                progressLabel.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
                downloadBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                progressLabel.Text = "Completed";
                ZipFile.ExtractToDirectory(@"C:\NewEraCache\downloaded.zip", @"C:\Users\akula\AppData\Roaming\");
                File.Copy(@"C:\NewEraCache\launcher_accounts.json", @"C:\Users\akula\AppData\\Roaming\.minecraft\launcher_accounts.json", true);
            });
        }

        public void defaultWindow_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                string update_data = client.DownloadString("https://raw.githubusercontent.com/Akulav/MinecraftModpackUpdater/main/update.txt");
                var result = Regex.Split(update_data, "\r\n|\r|\n");
                this.version = result[0];
                this.url = result[1];
            }

            string folderPath = @"C:\NewEraCache";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }
    }
}
