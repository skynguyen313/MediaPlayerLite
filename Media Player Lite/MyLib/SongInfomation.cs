using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TagLib;

namespace Media_Player_Lite.MyLib
{
    public class SongInfomation
    {
        private string path;
        private TagLib.File tagFile;
        public SongInfomation(string Path)
        {
            path = Path;
            tagFile = TagLib.File.Create(path);
        }
        public string title() 
        {
            string tt = tagFile.Tag.Title;
            if (tt == null) tt=Path.GetFileNameWithoutExtension(path);
            return tt;
        }
        public string author()
        {
            string at = tagFile.Tag.FirstPerformer;
            if (at == null) at = "Unknow artist";
            return at;
        }
        public string genre()
        {
            string gr=tagFile.Tag.FirstGenre;
            if (gr == null) gr = "Unknow genre";
            return gr;

        }
        public string duration() => tagFile.Properties.Duration.ToString(@"hh\:mm\:ss");
        
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
