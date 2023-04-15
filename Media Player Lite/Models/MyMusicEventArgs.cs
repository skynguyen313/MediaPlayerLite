using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_Lite.Models
{
    public class MyMusicEventArgs:EventArgs
    {
        private string path;
        private string title;
        private byte[] picdata;
        public string Path { get { return path; } }
        public string Title { get { return title; } }
        public byte[] PicData { get { return picdata; } }
        public MyMusicEventArgs(string path, string title, byte[] picdata)
        {
            this.path = path;
            this.title = title;
            this.picdata = picdata;
        }
    }
}
