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
        public string Author { set;get; }
        public string Genre { set; get; }  
        public string Duration { set; get; }
        public string Path { set;get; } 
        public Song(string title,string author,string genre,string duration,string path)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Duration = duration;
            Path = path;

        }
    }
}
