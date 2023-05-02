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
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using TagLib;


namespace Media_Player_Lite.ViewModels
{
    public partial class ControlItemVideo : UserControl
    {
        public delegate void Message(ControlItemVideo controlItemVideo);
        public Message SendMessage;
        private readonly string _path;
        private readonly string _title;
        private readonly string _duration;
        private readonly byte[] _picData;
        public string Path { get { return _path; } }
        public string Title { get { return _title; } }
        public ControlItemVideo(dynamic info)
        {
            InitializeComponent();
            _path = info.Path;
            _title = info.Title;
            _duration = info.Duration;
            _picData = info.PicArt;           
        }
        private void LoadProperty()
        {
            lblTitleVideo.Text = _title;
            lblDuration.Text = _duration;
            if (_picData != null) picVideo.Image = Image.FromStream(new MemoryStream(_picData));
            else picVideo.Image = Image.FromFile(Application.StartupPath + @"\Images\defaultImage.jpg");
        }
        private void SendData(object sender,EventArgs e)
        {
            SendMessage(this);
        }
        private void AddEvent()
        {
            picVideo.DoubleClick += new EventHandler(SendData);
            lblTitleVideo.DoubleClick += new EventHandler(SendData);
            lblDuration.DoubleClick += new EventHandler(SendData);
            picIcon.Click += new EventHandler(SendData);
        }

        private void PicIcon_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ControlItemVideo_Load(object sender, EventArgs e)
        {
            LoadProperty();
            AddEvent();
        }
        public void ExchangePicVideo(bool status)
        {
            if (status == true)
            {
                this.BackColor = Color.FromArgb(76, 76, 76);
                picIcon.IconChar = FontAwesome.Sharp.IconChar.CirclePause;
            }
            else
            {
                this.BackColor = Color.Black;
                picIcon.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
            }
        }
    }
}
