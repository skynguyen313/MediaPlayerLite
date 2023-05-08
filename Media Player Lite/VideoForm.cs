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
        #region Field
        public event EventHandler<MyVideoEventArgs> oneVideo;
        private readonly string fullFilePath = DirectoryPath.GetFullPath(@"DataMPLite\dataVideo.dat");
        private int idVideo = 0;
        private ControlItemVideo currentControlVideo = null;
        private List<Video> listVideo;
        private List<ControlItemVideo> listControl;
        private bool sortSelect_AZ;
        #endregion
        public VideoForm()
        {
            InitializeComponent();    
            fpnlListItemVideo.FlowDirection = FlowDirection.LeftToRight;
            fpnlListItemVideo.AutoScroll = true;         
        }
        private void VideoForm_Load(object sender, EventArgs e)
        {
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
            listVideo =GetListVideo();
            btnSortAZ.PerformClick();
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
                            var video = new Video(videoInfo.Title(), videoInfo.Duration(),videoInfo.GetPath(),ImageVideo.DataImage(file),videoInfo.LastModified());
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
        private List<ControlItemVideo> GetListControl(List<Video> lstVideo)
        {
            var lstControl = new List<ControlItemVideo>();
            foreach(var video in lstVideo)
            {            
                var info = new
                {
                    Title=video.Title,
                    Duration=video.Duration,
                    Path=video.Path,
                    PicArt=video.PicArt
                };
                var ct = CreateControl(info);
                lstControl.Add(ct);
            }
            return lstControl;
        }
        private void LoadListControlVideo(List<ControlItemVideo> lstControl)
        {
            idVideo = 0;
            foreach (Control control in fpnlListItemVideo.Controls)
            {
                control.Dispose();
            }
            fpnlListItemVideo.Controls.Clear();
            foreach (var item in lstControl)
            {
                fpnlListItemVideo.Controls.Add(item);
            }
            fpnlListItemVideo.Controls.Add(new Panel() { Width = fpnlListItemVideo.Width, Height = 150 });
        }
        private ControlItemVideo CreateControl(dynamic data)
        {
            ControlItemVideo ctIM = new ControlItemVideo(data);
            ctIM.Tag = idVideo++;
            ctIM.SendMessage = SendDataVideoEvent;
            return ctIM;
        }
        #region Method
        private void SendDataVideoEvent(ControlItemVideo controlItemVideo)
        {
            ActiveControlVideo(controlItemVideo);
            string path = controlItemVideo.Path;
            string title = controlItemVideo.Title;
            oneVideo?.Invoke(this, new MyVideoEventArgs(path, title));
        }
        private void ActiveControlVideo(ControlItemVideo control)
        {
            if (currentControlVideo != null) currentControlVideo.ExchangePicVideo(false);
            control.ExchangePicVideo(true);
            currentControlVideo= control;
        }
        #endregion

        #region Event
        private void btnAddFolderVideo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                WriteLineFileDistic.WriteLine(fullFilePath, folderBrowserDialog.SelectedPath);
                listVideo = GetListVideo();
                if (sortSelect_AZ) btnSortAZ.PerformClick();
                else btnSortDate.PerformClick();
                listControl = GetListControl(listVideo);
                LoadListControlVideo(listControl);
            }
        }
        private void btnSortAZ_Click(object sender, EventArgs e)
        {
            var result=from video in listVideo 
                       orderby video.Title ascending
                       select video;
            listVideo=result.ToList();
            listControl = GetListControl(listVideo);
            LoadListControlVideo(listControl);
            pnlSign1.BackColor = Color.Cyan;
            pnlSign2.BackColor = Color.Black;
            sortSelect_AZ = true;
        }
        private void btnSortDate_Click(object sender, EventArgs e)
        {
            var result = from video in listVideo
                         orderby video.DateModified descending
                         select video;
            listVideo = result.ToList();
            listControl = GetListControl(listVideo);
            LoadListControlVideo(listControl);
            pnlSign2.BackColor = Color.Cyan;
            pnlSign1.BackColor = Color.Black;
            sortSelect_AZ=false;
        }
        #endregion
    }
}
