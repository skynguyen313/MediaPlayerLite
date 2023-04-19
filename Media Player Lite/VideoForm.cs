using Media_Player_Lite.Models;
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

namespace Media_Player_Lite
{
    public partial class VideoForm : Form
    {
        public event EventHandler<MyVideoEventArgs> oneVideo;
        private readonly string fullFilePath = DirectoryPath.GetFullPath(@"DataMPLite\dataVideo.dat");
        
        private List<Video> listVideo;
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
            fpnlListItemVideo.FlowDirection = FlowDirection.LeftToRight;
            fpnlListItemVideo.AutoScroll = true;
        }
        private void VideoForm_Load(object sender, EventArgs e)
        {
            listVideo =GetListVideo();
            LoadListVideo(listVideo);
        }
        private List<Video> GetListVideo()
        {
            var lst = new List<Video>();
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
                        if (extension == ".mp4" || extension == ".wmv" || extension == ".mov" || extension == ".flv" || extension == ".avi")
                        {
                            var videoInfo = new VideoInfomation(file);
                            var video = new Video(videoInfo.Title(), videoInfo.Duration(),videoInfo.GetPath());
                            lst.Add(video);
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
        private void LoadListVideo(List<Video> lstV)
        {
            lstV.ForEach(v =>
            {
                
                AddItemVideo(v.Path,v.Title, v.Duration,ImageVideo.DataImage(v.Path));
                           
            });
        }
        private void AddItemVideo(string path,string title,string duration, byte[] data_image)
        {
            ControlItemVideo ct_IV = new ControlItemVideo(path,title,duration, data_image);
            fpnlListItemVideo.Controls.Add(ct_IV);
            ct_IV.SendMessage = SendDataVideoEvent;
        }
        private void SendDataVideoEvent(string path,string title)
        {
            oneVideo?.Invoke(this, new MyVideoEventArgs(path,title));
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                WriteLineFileDistic.WriteLine(fullFilePath, folderBrowserDialog.SelectedPath);
                listVideo = GetListVideo();
                LoadListVideo(listVideo);

            }
        }
    }
}
