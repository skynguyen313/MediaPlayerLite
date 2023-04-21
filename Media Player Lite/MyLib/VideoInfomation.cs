using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Media_Player_Lite.MyLib
{
    public class VideoInfomation
    {
        private readonly string path;
        public VideoInfomation(string fullPath)
        {
            this.path = fullPath;

        }
        
        public string Title()
        {
            return Path.GetFileNameWithoutExtension(path);
        }
        public string Duration()
        {
            var shell = new Shell32.Shell();
            var folder = shell.NameSpace(Path.GetDirectoryName(path));
            var file = folder.ParseName(Path.GetFileName(path));
            var duration = folder.GetDetailsOf(file, 27);
            TimeSpan timeSpan;
            TimeSpan.TryParse(duration, out timeSpan);
            return string.Format("{0} mins {1} secs", (int)timeSpan.TotalMinutes, timeSpan.Seconds);    
            
        }
        public string GetPath() => path;

    }
    public static class ImageVideo
    {
        public static byte[] DataImage(string filePath)
        {
            var converter = new NReco.VideoConverter.FFMpegConverter();

            var output = new MemoryStream();
            converter.GetVideoThumbnail(filePath, output);
            byte[] bytes = output.ToArray();
            return bytes;
        }
    }

}

