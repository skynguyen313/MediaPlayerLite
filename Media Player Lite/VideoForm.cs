using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_Lite
{
    public partial class VideoForm : Form
    {
        public VideoForm()
        {
            InitializeComponent();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"DataMPLite\dataVideo.dat");
            string directoryPath = Path.GetDirectoryName(path);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
           
        }
    }
}
