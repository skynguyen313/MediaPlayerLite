using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_Lite.Models
{
    public class MyVideoEventArgs:EventArgs
    {
        private string _path;
        private string _title;
        public string Path { get { return _path; } }
        public string Title { get { return _title; } }
        public MyVideoEventArgs(string path, string title)
        {
            _path = path;
            _title = title;
        }
    }
}
