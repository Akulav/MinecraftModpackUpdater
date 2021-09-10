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
        public string[] result;
        public string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public defaultWindow()
        {
            InitializeComponent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            updateBtn.Enabled = false;

            //
            int index = modpackList.SelectedIndex;

            //

            startDownload(result[index+index+1]);
            startInstall();
        }

        private void startDownload(string url)
        {
            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(url), @"C:\NewEraCache\downloaded.zip");
            });
            thread.Start();
        }

        private void startInstall()
        {
            Thread thread = new Thread(() => {
                try
                {
                    File.Copy(appdata+@"\.minecraft\launcher_accounts.json", @"C:\NewEraCache\launcher_accounts.json", true);
                }
                catch (IOException)
                {
                    
                }

                try
                {             
                    Directory.Delete(appdata + @"\.minecraft", true);
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
                progressLabel.Text = "Downloaded.";
                try
                {
                    ZipFile.ExtractToDirectory(@"C:\NewEraCache\downloaded.zip", appdata);
                    File.Copy(@"C:\NewEraCache\launcher_accounts.json", appdata+@"\.minecraft\launcher_accounts.json", true);
                }
                catch (IOException)
                {

                }
                updateBtn.Enabled = true;
                progressLabel.Text = "Successfully installed.";
            });
        }

        public void defaultWindow_Load(object sender, EventArgs e)
        {
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
            }

            string folderPath = @"C:\NewEraCache";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }
    }
}
