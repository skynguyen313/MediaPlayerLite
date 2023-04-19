using Media_Player_Lite.Models;
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


namespace Media_Player_Lite.ViewModels
{
    public partial class ControlItemVideo : UserControl
    {
        public delegate void Message(string path,string title);
        public Message SendMessage;
        private readonly string pathVideo;
        public ControlItemVideo(string path,string title,string duration, byte[] dataImage)
        {
            InitializeComponent();
            pathVideo = path;
            picVideo.Image = Image.FromStream(new MemoryStream(dataImage));
            lblTitleVideo.Text = title;
            lblDuration.Text = duration;
            
        }
        private void SendData(object sender,EventArgs e)
        {
            SendMessage(pathVideo, lblTitleVideo.Text);
        }
        private void ControlItemVideo_Load(object sender, EventArgs e)
        {
            picVideo.DoubleClick += new EventHandler(SendData);
            lblTitleVideo.DoubleClick += new EventHandler(SendData);
            lblDuration.DoubleClick += new EventHandler(SendData);
        }
    }
}
