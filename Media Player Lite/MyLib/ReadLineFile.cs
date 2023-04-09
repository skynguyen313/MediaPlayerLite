using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_Lite.MyLib
{
    public static class ReadLineFile
    {
        public static List<string> ToListData(string fullPath)
        {
            var listData=new List<string>();
            if (File.Exists(fullPath))
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    string line;
                    while (!String.IsNullOrEmpty(line = sr.ReadLine()))
                    {
                        listData.Add(line);
                    }
                }
            }
            return listData;
        }
    }
}
