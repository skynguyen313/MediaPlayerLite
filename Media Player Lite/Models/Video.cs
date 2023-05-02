using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_Lite.Models
{
    public class Video
    {
        public string Title { set; get; }
        public string Duration { set; get; }
        public string Path { set;get; }
        public byte[] PicArt { set; get; }
        public DateTime DateModified { set; get; }
        public Video(string title,string duration,string path, byte[] picArt,DateTime dateModified) 
        {
            Title=title;
            Duration=duration;
            Path = path;
            PicArt=picArt;
            DateModified = dateModified;
        }
    }
}
