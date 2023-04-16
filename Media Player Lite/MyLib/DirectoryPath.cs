using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Media_Player_Lite.MyLib
{
    public static class DirectoryPath
    {
        public static string GetFullPath(string str)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), str);
        }
    }
}
