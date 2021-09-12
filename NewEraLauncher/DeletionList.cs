using System;

namespace NewEraLauncher
{
    class DeletionList
    {
        public static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
       
        //Define all folders to be deleted inside .minecraft folder
        public static string[] deletion_list = {
            appdata + @"\.minecraft\libraries",
            appdata + @"\.minecraft\webcache2",
            appdata + @"\.minecraft\mods",
            appdata + @"\.minecraft\versions",
            appdata + @"\.minecraft\config"
        };
    }
}
