using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Shapes;

namespace Media_Player_Lite.MyLib
{
    public static class WriteLineFileDistic
    {
        public static string WriteLine(string fullPath, string content)
        {
            string line = null;
            if (File.Exists(fullPath))
            {        
                HashSet<string> uniqueLines = new HashSet<string>();
                var listPath = ReadLineFile.ToListData(fullPath);
                listPath.ForEach(p => uniqueLines.Add(p));
                using (StreamWriter writer =new StreamWriter(fullPath, true))
                {
                    
                        if (!uniqueLines.Contains(content))
                        {
                            writer.WriteLine(content);
                            line = content;
                            uniqueLines.Add(content);
                        }
                    
                }          
            }
            return line;
        }
    }
}
