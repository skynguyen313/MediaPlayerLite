using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_Lite.Models
{
    public class Song
    {
        public string Title { set; get; }
        public string Artist { set;get; }
        public string Genre { set; get; }  
        public string Duration { set; get; }
        public string Path { set;get; }
        public byte[] Image { set; get; }
        public Song(string title,string artist, string genre, string duration, string path, byte[] image)
        {
            Title = title;
            Artist = artist;
            Genre = genre;
            Duration = duration;
            Path = path;
            Image = image;
        }
    }
}
