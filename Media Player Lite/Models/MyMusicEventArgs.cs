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
        private byte[] _picdata;
        public string Path { get { return _path; } }
        public string Title { get { return _title; } }
        public byte[] PicData { get { return _picdata; } }
        public MyMusicEventArgs(string path, string title, byte[] picdata)
        {
            _path = path;
            _title = title;
            _picdata = picdata;
        }
    }
}
