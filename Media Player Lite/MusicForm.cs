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

namespace Media_Player_Lite
{
    public partial class MusicForm : Form
    {
        public delegate void PlayingCurrent(string path, string title, byte[] picdata);
        public event PlayingCurrent EventPlayingCurent;
           
        private List<Song> listMusic; 
        public MusicForm()
        {
            InitializeComponent();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"DataMPLite\datasongpath.dat");
            string directoryPath = Path.GetDirectoryName(path);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            lvMusic.MultiSelect = true;
           
        }
        private void MusicForm_Load(object sender, EventArgs e)
        {
            LoadListView();
        }
        private void lvMusic_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)//do not allow resizing columns
        {
            e.Cancel = true;
            e.NewWidth = lvMusic.Columns[e.ColumnIndex].Width;
        }
        private static string GetFullPath()
        {
            string directory_mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return Path.Combine(directory_mydoc, @"DataMPLite\datasongpath.dat");
        }
        private void btnImportMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Import Music";
            fileDialog.Filter = "Files (*.mp3, *.wma, *.wav, *.flac, *.aac)|*.mp3;*.wma;*.wav;*.flac;*.aac";
            fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {       
                string[] listPath = fileDialog.FileNames;
                WriteLineFileDistic.WriteLine(GetFullPath(), listPath);
                LoadListView();               
            }
           
        }
        private void LoadListView()
        {
            lvMusic.Items.Clear();
            FormatCmbTexts();
            ListMusic(GetFullPath());
            listMusic.ForEach(m =>
            {
                var item=new ListViewItem(new[] {"",m.Title,m.Author,m.Genre,m.Duration});
                item.Tag = m.Path;
                lvMusic.Items.Add(item);
            });
            // Ngay mai lam
            var listAuthor = from item in listMusic
                             select item.Author;
            cmbArtist.Items.AddRange(listAuthor.Distinct().ToArray());
            var listGenre = from item in listMusic
                             select item.Genre;
            cmbGenre.Items.AddRange(listGenre.Distinct().ToArray());
        }
        private void ListMusic(string path)
        {
            listMusic=new List<Song>();
            ReadLineFile.ToListData(GetFullPath()).ForEach(p =>
            {
                var songInfo = new SongInfomation(p);
                var song=new Song(songInfo.title(),songInfo.author(),songInfo.genre(),songInfo.duration(),p);
                listMusic.Add(song);
            });            
        }
        private void lvMusic_DoubleClick(object sender, EventArgs e)
        {
            if (lvMusic.SelectedItems.Count > 0)
            {
                var lvItem = lvMusic.SelectedItems[0];
                StaticIndex.Index = lvItem.Index;
                CurrentItem(lvItem);
            }
        }
        private void CurrentItem(ListViewItem lvItem)
        {
            string pathData = lvItem.Tag as string;
            string title = lvItem.SubItems[col_song.Index].Text;
            var picdata = PicArtSong.PicData(pathData);
            if (EventPlayingCurent != null) EventPlayingCurent(pathData, title, picdata);
        }
        public void NextItem()
        {
           
            if (StaticIndex.Index < lvMusic.Items.Count - 1)
            {
                StaticIndex.Index+= 1;
                var nextItem = lvMusic.Items[StaticIndex.Index];
                CurrentItem(nextItem);
            }
           
        }
        public void PrevItem()
        {
            if (StaticIndex.Index >0)
            {
                StaticIndex.Index -= 1;
                var prevtItem = lvMusic.Items[StaticIndex.Index];
                CurrentItem(prevtItem);
            }
            
        }

        private void cmbSong_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected=cmbSong.SelectedIndex;
            if (indexSelected != -1)
            {
                
                if (indexSelected == 0)
                {
                    var result = from item in listMusic
                               orderby item.Title ascending
                               select item;
                    lvMusic.Items.Clear();
                    result.ToList().ForEach(m =>
                    {
                        var item = new ListViewItem(new[] { "", m.Title, m.Author, m.Genre, m.Duration });
                        item.Tag = m.Path;
                        lvMusic.Items.Add(item);
                    });
                    

                }
                else if(indexSelected==1)
                {
                    var result = from item in listMusic
                                 orderby item.Title descending
                                 select item;
                    lvMusic.Items.Clear();
                    result.ToList().ForEach(m =>
                    {
                        var item = new ListViewItem(new[] { "", m.Title, m.Author, m.Genre, m.Duration });
                        item.Tag = m.Path;
                        lvMusic.Items.Add(item);
                    });
                   
                }          
            }    
        }
        private void FormatCmbTexts() 
        {
            cmbSong.Texts = "        Song";
            cmbArtist.Texts = "All artist";
            cmbGenre.Texts = "All genres";
        }
        
        
       
    }
}
