using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TagLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Media_Player_Lite.MyLib
{
    public class SongInfomation
    {
        private readonly string path;
        private readonly TagLib.File tagFile;
        public SongInfomation(string Path)
        {
            path = Path;
            tagFile = TagLib.File.Create(path);
        }
        public string Title() 
        {
            string tt = tagFile.Tag.Title;
            if (tt == null) tt=Path.GetFileNameWithoutExtension(path);
            return tt;
        }
        public string Author()
        {
            string at = tagFile.Tag.FirstPerformer;
            if (at == null) at = "Unknow artist";
            return at;
        }
        public string Genre()
        {
            string gr=tagFile.Tag.FirstGenre;
            if (gr == null) gr = "Unknow genre";
            return gr;

        }
        public string Duration() => tagFile.Properties.Duration.ToString(@"mm\:ss");
        //public string Duration()
        //{
        //    var time = tagFile.Properties.Duration;
        //    string timeString = string.Format("{0} min {1} second", (int)time.TotalMinutes, time.Seconds);
        //    return timeString;
        //}

    }
    public static class PicArtSong
    {
        public static byte[] PicData(string path)
        {
            try
            {
                var file = TagLib.File.Create(path);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                return bin;
            }
            catch { return null; }
        }
    }
}
