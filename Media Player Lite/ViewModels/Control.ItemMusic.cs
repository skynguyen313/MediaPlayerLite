using FontAwesome.Sharp;
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
    public partial class ControlItemMusic : UserControl
    {
        public delegate void Message(ControlItemMusic controlItemMusic);
        public Message SendMessage;
        private readonly string _path;
        private readonly string _title;
        private readonly string _artist;
        private readonly string _genre;
        private readonly string _duration;
        private readonly byte[] _picData;
        public string Path { get { return _path; } }
        public string Title { get { return _title; } }
        public ControlItemMusic(dynamic info)
        {
            InitializeComponent();
            _path = info.Path;
            _title = info.Title;
            _artist = info.Artist;
            _genre = info.Genre;
            _duration = info.Duration;
            _picData = info.Image;
            
            
        }
        private void SendData(object sender, EventArgs e)
        {
            SendMessage(this);
        }
        public void ExchangePicMusic(bool status)
        {
            if (status == true)
            {
                this.BackColor = Color.FromArgb(36, 36, 36);
                picMusic.IconChar = FontAwesome.Sharp.IconChar.CirclePause;
            }
            else
            {
                this.BackColor = Color.Black;
                picMusic.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
            }
        }
        private void ControlItemMusic_Load(object sender, EventArgs e)
        {
            LoadProperty();
            AddEvent();         
        }
        private void LoadProperty()
        {
            this.Dock = DockStyle.Top;
            lblTitle.Text = _title;
            lblArtist.Text = _artist;
            lblGenre.Text = _genre;
            lblDuration.Text = _duration;
            if (_picData != null) picArt.Image = Image.FromStream(new MemoryStream(_picData));
            else picArt.Image = Image.FromFile(Application.StartupPath + @"\Images\defaultImage.jpg");
        }
        private void AddEvent()
        {
            picArt.DoubleClick += new EventHandler(SendData);
            picMusic.Click += new EventHandler(SendData);
            lblTitle.DoubleClick += new EventHandler(SendData);
            lblArtist.DoubleClick += new EventHandler(SendData);
            lblGenre.DoubleClick += new EventHandler(SendData);
            this.DoubleClick += new EventHandler(SendData);
        }
       
    }
}
