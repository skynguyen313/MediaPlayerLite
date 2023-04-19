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

namespace Media_Player_Lite
{
    public partial class MusicForm : Form
    {

        public event EventHandler<MyMusicEventArgs> oneMusic;
        private List<Song> listSong;
        private int index = 0;
        private readonly string fullFilePath = DirectoryPath.GetFullPath(@"DataMPLite\dataMusic.dat");

        public MusicForm()
        {
            InitializeComponent();
            txtSearch.Font = new Font("Arial", 15);
            
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
            LoadAllProperty();
            LoadListView(listSong);           
            
        }
        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                WriteLineFileDistic.WriteLine(fullFilePath, folderBrowserDialog.SelectedPath);
                listSong = GetListSong();
                LoadAllProperty();
                LoadListView(listSong);

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
                            var song = new Song(songInfo.Title(), songInfo.Author(), songInfo.Genre(), songInfo.Duration(), file);
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

        private void LoadListView(List<Song> lst)
        {
            listviewMusic.Items.Clear();
            lst.ForEach(s =>
            {
                var item = new ListViewItem(new[] { s.Title, s.Artist, s.Genre, s.Duration });
                item.Tag = s.Path;
                listviewMusic.Items.Add(item);
            });

        }

        public void NextItem(object sender, EventArgs e)
        {
            if (index < listviewMusic.Items.Count - 1)
            {
                index += 1;
                var nextItem = listviewMusic.Items[index];
                CurrentItem(nextItem);
            }
        }
        public void PrevItem(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index -= 1;
                var prevtItem = listviewMusic.Items[index];
                CurrentItem(prevtItem);
            }
        }
        private void CurrentItem(ListViewItem item)
        {
            string pathData = item.Tag as string;
            string titleData = item.SubItems[colTitle.Index].Text;
            var picData = PicArtSong.PicData(pathData);
            oneMusic?.Invoke(this, new MyMusicEventArgs(pathData, titleData, picData));
        }

        private void listviewMusic_DoubleClick(object sender, EventArgs e)
        {
            if (listviewMusic.SelectedItems.Count > 0)
            {
                var item = listviewMusic.SelectedItems[0];
                index = item.Index;
                CurrentItem(item);
                
            }
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
                LoadListView(result.ToList());
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

                    LoadListView(listSong);
                }
                else
                {

                    var resultSong = from song in tmpSong
                                     where song.Artist == cmbArtist.SelectedItem.ToString()
                                     select song;
                    LoadListView(resultSong.ToList());

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

                    LoadListView(listSong);
                }
                else
                {

                    var resultSong = from song in tmpSong
                                     where song.Genre == cmbGenre.SelectedItem.ToString()
                                     select song;
                    LoadListView(resultSong.ToList());

                    var arrArtist = (from song in resultSong
                                     select song.Artist).Distinct().ToArray();
                    CmbLoadArtist(arrArtist);
                }


            }
        }
    }
}
