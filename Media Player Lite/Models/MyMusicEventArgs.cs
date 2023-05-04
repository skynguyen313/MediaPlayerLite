using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_Lite.Models
{
    public class MyMusicEventArgs:EventArgs
    {
        public string Path { get; }
        public string Title { get; }
        public string Artist { get; }
        public string Genre { get; }
        public byte[] Image { get; }
        public MyMusicEventArgs(string path, string title,string artist,string genre, byte[] picData)
        {
            Path = path;
            Title = title;
            Artist = artist;
            Genre = genre;
            Image=picData;
        }
    }
}
