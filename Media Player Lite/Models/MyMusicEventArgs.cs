using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_Lite.Models
{
    public class MyMusicEventArgs:EventArgs
    {
        private string _path;
        private string _title;
        public string Path { get { return _path; } }
        public string Title { get { return _title; } }
        public MyMusicEventArgs(string path, string title)
        {
            _path = path;
            _title = title;
        }
    }
}
