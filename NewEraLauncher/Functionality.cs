using System;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace NewEraLauncher
{
    class Functionality
    {
        public static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static void StartInstall()
        {
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < DeletionList.deletion_list.Length; i++)
                {
                    DirectoryLib.DeleteFolder(DeletionList.deletion_list[i]);
                }

            });
            thread.Start();
        }

        public static void ExtractInstall()
        {
            try
            {
                ZipFile.ExtractToDirectory(@"C:\NewEraCache\downloaded.zip", @"C:\NewEraCache\extracted\");
                DirectoryLib.CopyFilesRecursively(@"C:\NewEraCache\extracted\", appdata + @"\.minecraft\");
            }
            catch (IOException)
            {

            }
        }

    }
}
