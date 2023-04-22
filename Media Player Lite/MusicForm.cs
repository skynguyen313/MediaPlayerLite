using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Media_Player_Lite.MyLib;
using Media_Player_Lite.Models;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Media_Player_Lite.ViewModels;

namespace Media_Player_Lite
{
    public partial class MusicForm : Form
    {

        public event EventHandler<MyMusicEventArgs> oneMusic;
        private List<Song> listSong;
        private List<ControlItemMusic> listControl;
        private ControlItemMusic currentControlMusic = null;
        private static int current_IndexMusic=-1;
        private static int idMuic = 0;
        private readonly string fullFilePath = DirectoryPath.GetFullPath(@"DataMPLite\dataMusic.dat");
      
        public MusicForm()
        {
            InitializeComponent();
            txtSearch.Font = new Font("Arial", 15);
            pnlListMusic.AutoScroll = true;
            
        }
        public void MusicForm_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"DataMPLite\dataMusic.dat");
            string directoryPath = Path.GetDirectoryName(path);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            listSong = GetListSong();
            listControl = GetListControl(listSong);
            LoadAllProperty();
            LoadListMusic(listControl);           
            
        }
        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                WriteLineFileDistic.WriteLine(fullFilePath, folderBrowserDialog.SelectedPath);
                listSong = GetListSong();
                listControl=GetListControl(listSong);
                LoadAllProperty();
                LoadListMusic(listControl);

            }
        }
        private List<Song> GetListSong()
        {
            var lst = new List<Song>();
            var tmpLine = new List<string>();
            var contents = ReadLineFile.ToListData(fullFilePath);
            contents.ForEach(directory =>
            {
                if (Directory.Exists(directory))
                {
                    String[] files = System.IO.Directory.GetFiles(directory);
                    foreach (var file in files)
                    {
                        string extension = Path.GetExtension(file);
                        if (extension == ".mp3" || extension == ".wma" || extension == ".wav" || extension == ".flac" || extension == ".aac")
                        {
                            var songInfo = new SongInfomation(file);
                            var song = new Song(songInfo.Title(), songInfo.Author(), songInfo.Genre(), songInfo.Duration(), file,PicArtSong.PicData(file));
                            lst.Add(song);
                        }
                    }
                }
                else
                {
                    tmpLine.Add(directory);
                }
            });

            tmpLine.ForEach(i => contents.Remove(i));//Remove file not exists
            File.WriteAllLines(fullFilePath, contents);
            return lst;
        }

        private void LoadListMusic(List<ControlItemMusic> lstControl)
        {
            current_IndexMusic = -1;
            idMuic = 0;
            foreach (Control control in pnlListMusic.Controls)
            {
                control.Dispose();
            }
            pnlListMusic.Controls.Clear();
            foreach (var item in lstControl)
            {
                var pnl = new Panel();
                pnl.Dock = DockStyle.Top;
                pnl.Height = 30;  
                pnlListMusic.Controls.Add(item);
                pnlListMusic.Controls.Add(pnl);
                
            }
            
        }
        private List<ControlItemMusic> GetListControl(List<Song> lstSong)
        {
            lstSong.Reverse();
            var lstControl = new List<ControlItemMusic>();
            foreach (var song in lstSong)
            {
                var info = new
                {
                    Title = song.Title,
                    Artist = song.Artist,
                    Genre = song.Genre,
                    Duration = song.Duration,
                    Path = song.Path,
                    Image = song.Image,
                };
                var ct = CreateControl(info);
                lstControl.Add(ct);
                
            };
            return lstControl;
        }
        private ControlItemMusic CreateControl(dynamic data)
        {
            ControlItemMusic ctIM=new ControlItemMusic(data);
            ctIM.Tag = idMuic;
            idMuic += 1;
            ctIM.SendMessage = SendDataMusicEvent;
            return ctIM;
        }
        private void SendDataMusicEvent(ControlItemMusic controlItemMusic)
        {
            ActiveControlMusic(controlItemMusic);
            string path = controlItemMusic.Path;
            string title=controlItemMusic.Title;
            current_IndexMusic = Convert.ToInt32(controlItemMusic.Tag);
            oneMusic?.Invoke(this, new MyMusicEventArgs(path, title));        
        }
        private void ActiveControlMusic(ControlItemMusic control)
        {
            if (currentControlMusic != null)
            {
                currentControlMusic.BackColor = Color.Black;
                currentControlMusic.ExchangePicMusic(false);
            }
            control.BackColor = Color.FromArgb(36, 36, 36);
            control.ExchangePicMusic(true);
            currentControlMusic = control;
            
        }
        public void NextItem(object sender, EventArgs e)
        {

            if (current_IndexMusic >0)
            {
                current_IndexMusic -= 1;
                var nextItem = listControl[current_IndexMusic];
                SendDataMusicEvent(nextItem);
                pnlListMusic.VerticalScroll.Value +=350;//Auto Scroll 
            }
        }
        public void PrevItem(object sender, EventArgs e)
        {
            if (current_IndexMusic <listControl.Count-1)
            {
                current_IndexMusic += 1;
                var prevItem = listControl[current_IndexMusic];
                SendDataMusicEvent(prevItem);
                if(pnlListMusic.VerticalScroll.Value>350) pnlListMusic.VerticalScroll.Value -= 350;//Auto Scroll
            }
        }
        private void CurrentItem(ListViewItem item)
        {
            //string pathData = item.Tag as string;
            //string titleData = item.SubItems[colTitle.Index].Text;
            //var picData = PicArtSong.PicData(pathData);
            //oneMusic?.Invoke(this, new MyMusicEventArgs(pathData, titleData, picData));
        }

        private void listviewMusic_DoubleClick(object sender, EventArgs e)
        {
            //if (listviewMusic.SelectedItems.Count > 0)
            //{
            //    var item = listviewMusic.SelectedItems[0];
            //    index = item.Index;
            //    CurrentItem(item);
                
            //}
        }
        private void LoadAllProperty()
        {
            var arrangeList = from song in listSong
                              orderby song.Title ascending
                              select song;
            listSong = arrangeList.ToList();

            var arrArtist = (from song in listSong
                             orderby song.Artist ascending
                             select song.Artist).Distinct().ToArray();
            CmbLoadArtist(arrArtist);

            var arrGenre = (from song in listSong
                            orderby song.Genre ascending
                            select song.Genre).Distinct().ToArray();
            CmbLoadGenre(arrGenre);

            tmpSong = listSong.ToList();

        }
        private List<Song> tmpSong;
        
        private void CmbLoadArtist(string[] arrArtist)
        {

            cmbGenre.Texts = "All genres";
            cmbArtist.Items.Clear();

            cmbArtist.Items.Add("All artist");
            cmbArtist.Items.AddRange(arrArtist);

        }
        private void CmbLoadGenre(string[] arrGenre)
        {
            cmbArtist.Texts = "All artist";
            cmbGenre.Items.Clear();

            cmbGenre.Items.Add("All genres");
            cmbGenre.Items.AddRange(arrGenre);

        }
        private void txtSearch__TextChanged(object sender, EventArgs e)
        {

            if (txtSearch.PlaceholderText != "Search")
            {
                var result = from song in listSong
                             where ChangeStringVN.Change_AV(song.Title.ToLower()).Contains(ChangeStringVN.Change_AV(txtSearch.Texts.ToLower().Trim()))
                             select song;
                listControl = GetListControl(result.ToList());
                LoadListMusic(listControl);
            }
            else
            {

                txtSearch.PlaceholderText = "";
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.PlaceholderText = "";
        }

        private void cmbArtist_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArtist.SelectedIndex != -1)
            {
                if (cmbArtist.SelectedIndex == 0)
                {
                    LoadAllProperty();
                    listControl = GetListControl(listSong);
                    LoadListMusic(listControl);
                }
                else
                {

                    var resultSong = from song in tmpSong
                                     where song.Artist == cmbArtist.SelectedItem.ToString()
                                     select song;
                    listControl = GetListControl(resultSong.ToList());
                    LoadListMusic(listControl);

                    var arrGenre = (from song in resultSong
                                    select song.Genre).Distinct().ToArray();
                    CmbLoadGenre(arrGenre);
                }
            }
        }

        private void cmbGenre_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbGenre.SelectedIndex != -1)
            {
                if (cmbGenre.SelectedIndex == 0)
                {
                    LoadAllProperty();
                    listControl = GetListControl(listSong);
                    LoadListMusic(listControl);
                }
                else
                {

                    var resultSong = from song in tmpSong
                                     where song.Genre == cmbGenre.SelectedItem.ToString()
                                     select song;
                    listControl = GetListControl(resultSong.ToList());
                    LoadListMusic(listControl);

                    var arrArtist = (from song in resultSong
                                     select song.Artist).Distinct().ToArray();
                    CmbLoadArtist(arrArtist);
                }


            }
        }
    }
}
