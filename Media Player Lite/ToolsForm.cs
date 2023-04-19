using FontAwesome.Sharp;
using Media_Player_Lite.MyLib;
using Media_Player_Lite.ViewModels;
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
using System.Windows.Shapes;

namespace Media_Player_Lite
{
    public partial class ToolsForm : Form
    {
        private static string fullFilePathMusic = DirectoryPath.GetFullPath(@"DataMPLite\dataMusic.dat");
        private static string fullFilePathVideo = DirectoryPath.GetFullPath(@"DataMPLite\dataVideo.dat");
        public ToolsForm()
        {
            InitializeComponent();
            pnlListPathMusic.Height = 0;
            pnlListPathVideo.Height = 0;
            AddEventClick();
        }
        private void AddEventClick()
        {

            //pnlMusic
            pnlMusicLibraryLocations.Click += new EventHandler(btnListMusic_Click);
            picFolderMuisc.Click += new EventHandler(btnListMusic_Click);
            lblMusicLib.Click += new EventHandler(btnListMusic_Click);

            //pnlVideo
            pnlVideoLibraryLocations.Click += new EventHandler(btnListVideo_Click);
            picFolderVideo.Click += new EventHandler(btnListVideo_Click);
            lblVideoLib.Click += new EventHandler(btnListVideo_Click);

            //pnlRefresh
            pnlRefreshLib.Click += new EventHandler(btnMessage_Click);
            picRefresh.Click += new EventHandler(btnMessage_Click);
            lblRefreshLib.Click += new EventHandler(btnMessage_Click);
        }
        private void ToolsForm_Load(object sender, EventArgs e)
        {
            HiddenPanel(pnlListPathMusic, btnListMusic);
            HiddenPanel(pnlListPathVideo, btnListVideo);
            HiddenPanel(pnlMessage, btnMessage);
            LoadListPathMusic( fullFilePathMusic);
            LoadListPathVideo(fullFilePathVideo);
        }   
        private void LoadListPathMusic(string path)
        {
            var contents = ReadLineFile.ToListData(path);
            foreach (var line in contents)
            {
                AddLineMusic(line);        
            }
        }
        private void LoadListPathVideo( string path)
        {
            var contents = ReadLineFile.ToListData(path);
            foreach (var line in contents)
            {
                AddLineVideo(line);
            }
        }
        #region Panel List
        private void AddLineMusic(string data)
        {
            ControlPath ctP = new ControlPath(data);
            ctP.SendMessage = RemoveLineMusic; ;
            pnlListPathMusic.Height += 60;
            pnlListPathMusic.Controls.Add(ctP);
            ctP.Dock = DockStyle.Top;
        }
        private void RemoveLineMusic(string data)
        {
            pnlListPathMusic.Height-= 60;
            var contents = ReadLineFile.ToListData(fullFilePathMusic);
            contents.Remove(data);
            File.WriteAllLines(fullFilePathMusic, contents);

        }
        private void AddLineVideo(string data)
        {
            ControlPath ctP = new ControlPath(data);
            ctP.SendMessage = RemoveLineVideo;
            pnlListPathVideo.Height += 60;
            pnlListPathVideo.Controls.Add(ctP);
            ctP.Dock = DockStyle.Top;
        }
        private void RemoveLineVideo(string data)
        {
            pnlListPathVideo.Height -= 60;
            var contents = ReadLineFile.ToListData(fullFilePathVideo);
            contents.Remove(data);
            File.WriteAllLines(fullFilePathVideo, contents);

        }
        private void ShowListPanel(Panel pnl,IconButton btn)
        {
            if (pnl.Visible==true) HiddenPanel(pnl,btn);  
            else
            {
                pnl.Visible = true;
                btn.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            }
        }
        private void HiddenPanel(Panel pnl, IconButton btn)
        {
            if (pnl.Visible == true)
            {
                pnl.Visible = false;
                btn.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            }
        }
        #endregion
        private void btnAddFolderMusic_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string content=WriteLineFileDistic.WriteLine(fullFilePathMusic, folderBrowserDialog.SelectedPath);
                if (content!=null) AddLineMusic(content);
                
            }
        }
        private void btnAddFolderVideo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string content = WriteLineFileDistic.WriteLine(fullFilePathVideo, folderBrowserDialog.SelectedPath);
                if (content != null) AddLineVideo(content);

            }

        }
        private void btnMessage_Click(object sender, EventArgs e)
        {
            ShowListPanel(pnlMessage,btnMessage);
        }

        private void btnListVideo_Click(object sender, EventArgs e)
        {
            ShowListPanel(pnlListPathVideo, btnListVideo);
        }

        private void btnListMusic_Click(object sender, EventArgs e)
        {
            ShowListPanel(pnlListPathMusic, btnListMusic);
        }

       
    }
}
