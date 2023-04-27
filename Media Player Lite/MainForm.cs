using AxWMPLib;
using FontAwesome.Sharp;
using Media_Player_Lite.Models;
using Media_Player_Lite.MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;

namespace Media_Player_Lite
{
    public partial class MainForm : Form
    {
        //Fields 
        private Panel leftBorderBtn;
        private MusicForm musicForm;
        private VideoForm videoForm;

        //Config lib [user32.dll]
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public MainForm()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(boderSize);
            this.BackColor = Color.FromArgb(98, 102, 144);
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(8, 80);
            pnlMenu.Controls.Add(leftBorderBtn);

            //Player
            Slider.Height = 30;
            SliderVolume.Height = 30;
            AddEvent();

            //Loading Forms
            LoadingForm(null, null);
        }
        private void LoadingForm(object sender,EventArgs e)
        {
            //LoadForm
            musicForm = new MusicForm();
            {
                musicForm.oneMusic += LoadPlayingMusic;
                btnNextWard.Click += new EventHandler(musicForm.NextItem);
                btnBackWard.Click += new EventHandler(musicForm.PrevItem);
            }
            videoForm = new VideoForm();
            {
                videoForm.oneVideo += LoadPlayingVideo;
            }
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();

            //Load MediaPlayer-UI
            wMediaPlayer.uiMode = "none";
            

            //LblTiTle Player
            lblTitlePlayer.Left = lblTitlePlayer.Width;
            lblTitlePlayer.AutoSize = true;
            timerPlayer.Enabled = true;

            //Panel Volume
            HidenPanelVolume();

            //
            StatusPlaying();

        }

        #region Custome Menu
        private void CollapseMenu()
        {
            if (this.pnlMenu.Width >= 300)
            {
                pnlMenu.Width = 100;
                picLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (System.Windows.Forms.Button menuButton in pnlMenu.Controls.OfType<System.Windows.Forms.Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { 
                //Expand menu
                pnlMenu.Width = 300;
                picLogo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (System.Windows.Forms.Button menuButton in pnlMenu.Controls.OfType<System.Windows.Forms.Button>())
                {
                    menuButton.Text = "  " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(15, 0, 0, 0);
                }
            }
        }
        #endregion

        #region Custom Button
        //Method
        private IconButton currentBtn;
        //Active Button
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(15, 5, 47);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Current Child Form Icon
                picChildForm.IconChar = currentBtn.IconChar;
                picChildForm.IconColor = Color.White;
                lblTitleChildForm.Text = currentBtn.Tag as string;

            }
        }

        //Disable Button
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(15, 5, 47);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        #endregion

        #region Close-Maximize-Minimize
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Move Window


        private void pnlTitle_MouseDown(object sender, MouseEventArgs e) => MoveWindow();
        private void lblTitleChildForm_MouseDown(object sender, MouseEventArgs e) => MoveWindow();
        private void pnlLogo_MouseDown(object sender, MouseEventArgs e) => MoveWindow();
        private void picChildForm_MouseDown(object sender, MouseEventArgs e) => MoveWindow();
        private void picLogo_MouseDown(object sender, MouseEventArgs e)=>MoveWindow();
        private void MoveWindow()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Method  
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 30;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1) return;
            base.WndProc(ref m);
        }
        #endregion

        #region Form Boder
        private int boderSize = 2;
        private void MainForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != boderSize)
                        this.Padding = new Padding(boderSize);
                    
                    break;
            }
        }

        #endregion

        #region Sub Menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(81, 236, 193));
            ShowMediaPlayer();  
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(81, 236, 193)); 
            openChildForm(musicForm);       
            HidenMediaPlayer();        
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(81, 236, 193));
            openChildForm(videoForm);    
            HidenMediaPlayer();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(81, 236, 193));
            ToolsForm toolsForm=new ToolsForm();
            openChildForm(toolsForm);
            toolsForm.btnRefresh.Click += new EventHandler(LoadingForm);
            HidenMediaPlayer();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(81, 236, 193));
            openChildForm(new AboutForm());
            HidenMediaPlayer();
        }
        #endregion

        #region Current ChildForm
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Visible = false; 
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChidlForm.Controls.Add(childForm);
            pnlChidlForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Visible=true;
            pnlChidlForm.Text = childForm.Text;
              
        }
        #endregion
  
        #region SliderBar
        float Default_value = 0.0f, Min = 0.0f, Max = 1.0f;
        public float Bar(float value)
        {
            return (Slider.Width - 24) * (value - Min) / (float)(Max - Min);
        }
        public float Slider_width(int x)
        {
            return Min + (Max - Min) * x / (float)(Slider.Width);
        }

        public void thumb(float value)//thay doi gia tri khi gia tri cua Slider thay doi
        {
            if (value < Min)
                value = Min;
            if (value > Max) value = Max;
            Default_value = value;
            Slider.Refresh();
        }
        bool mouse = false;
        private void Slider_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            thumb(Slider_width(e.X));
            if (wMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying || wMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                wMediaPlayer.Ctlcontrols.currentPosition = wMediaPlayer.currentMedia.duration * e.X / Slider.Width;
                lblTimeStart.Text = wMediaPlayer.Ctlcontrols.currentPositionString;
            }
        }

        private void Slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse) return;
            thumb(Slider_width(e.X));
            if (wMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying || wMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                wMediaPlayer.Ctlcontrols.currentPosition = wMediaPlayer.currentMedia.duration * e.X / Slider.Width;
                lblTimeStart.Text = wMediaPlayer.Ctlcontrols.currentPositionString;
            }
        }

        private void Slider_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
        private void Slider_Paint(object sender, PaintEventArgs e)
        {
            float bar_size = 0.4f;
            float x = Bar(Default_value);
            int y = (int)(Slider.Height * bar_size);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.DimGray, 0, y, Slider.Width, y / 2);

            //hanh trinh
            e.Graphics.FillRectangle(Brushes.Cyan, 0, y, x, Slider.Height - 2 * y);
            using (Pen pen = new Pen(Brushes.DimGray, 10))//Vong ngoai
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, Slider.Height / 2, Slider.Height / 2);
                e.Graphics.FillEllipse(Brushes.Cyan, x + 4, y - 6, Slider.Height / 2, Slider.Height / 2);//Cham tron trung tam
            }
            using (Pen pen = new Pen(Brushes.DimGray, 5))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, Slider.Height / 2, Slider.Height / 2);//Vong giua
            }
        }
        private void timerPlayer_Tick(object sender, EventArgs e)
        {
            if(wMediaPlayer.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                
                Max = (int)wMediaPlayer.Ctlcontrols.currentItem.duration;
                Default_value = (int)wMediaPlayer.Ctlcontrols.currentPosition;
                Slider.Invalidate();
                lblTimeStart.Text = wMediaPlayer.Ctlcontrols.currentPositionString;
                lblTimeEnd.Text = wMediaPlayer.Ctlcontrols.currentItem.durationString;

                //Lable Title
                RunWordTiTle();
            }
        }
        private void RunWordTiTle()
        {
              
            if (lblTitlePlayer.Text.Length>=40)
            {
                lblTitlePlayer.Left -= 3;
                if (lblTitlePlayer.Left + lblTitlePlayer.Width < 0)
                {
                    lblTitlePlayer.Left = pnlTitlePlayer.Width;
                }
            }
            
        }
        private void SettingRunWordTitle()
        {
            lblTitlePlayer.AutoSize = true;
            lblTitlePlayer.Dock = DockStyle.None;   
            if (lblTitlePlayer.Text.Length < 40)
            {
                lblTitlePlayer.AutoSize = false;
                lblTitlePlayer.TextAlign = ContentAlignment.MiddleCenter;
                lblTitlePlayer.Dock = DockStyle.Fill;
            }

            
        }
        #endregion

        #region Volume

        float Default_valueV = 100, MinV = 0.0f, MaxV = 100;
        public float BarV(float value)
        {
            return (SliderVolume.Width - 24) * (value - MinV) / (float)(MaxV - MinV);
        }
        public float SliderVolume_width(int x)
        {
            return MinV + (MaxV - MinV) * x / (float)(SliderVolume.Width);
        }
        public void thumbV(float value)//thay doi gia tri khi gia tri cua Slider thay doi
        {
            if (value < MinV)
                value = MinV;
            if (value > MaxV) value = MaxV;
            Default_valueV = value;
            SliderVolume.Refresh();
        }

        bool mouseV = false;
       
        private void SliderVolume_MouseDown(object sender, MouseEventArgs e)
        {
            mouseV = true;
            thumbV(SliderVolume_width(e.X));
            int index = Convert.ToInt32(Default_valueV);
            wMediaPlayer.settings.volume =index;
            lblIndexVolume.Text = String.Format("{0}%", index.ToString());
            ChangeIconVolume(index);
        }
        private void ChangeIconVolume(int index)
        {
            if (index == 0)
            {
                this.btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;
                this.btnVolume.IconSize = 36;

            }

            else
            {
                this.btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeHigh;
                this.btnVolume.IconSize = 40;

            }
        }
        private void SliderVolume_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseV) return;
            thumbV(SliderVolume_width(e.X));
            int index = Convert.ToInt32(Default_valueV);
            wMediaPlayer.settings.volume = index;
            lblIndexVolume.Text = String.Format("{0}%",index.ToString());
            ChangeIconVolume(index);
        }

        private void SliderVolume_MouseUp(object sender, MouseEventArgs e)
        {
            mouseV=false;  
        } 
        private void SliderVolume_Paint(object sender, PaintEventArgs e)
        {
            float bar_size = 0.4f;
            float x = BarV(Default_valueV);
            int y = (int)(SliderVolume.Height * bar_size);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.DimGray, 0, y, SliderVolume.Width, y / 2);

            //hanh trinh
            e.Graphics.FillRectangle(Brushes.Cyan, 0, y, x, SliderVolume.Height - 2 * y);
            using (Pen pen = new Pen(Brushes.DimGray, 10))//Vong ngoai
            {
                e.Graphics.DrawEllipse(pen, x +4, y - 6, SliderVolume.Height / 2, SliderVolume.Height / 2);
                e.Graphics.FillEllipse(Brushes.Cyan, x + 4, y - 6, SliderVolume.Height / 2, SliderVolume.Height / 2);//Cham tron trung tam
            }
            using (Pen pen = new Pen(Brushes.DimGray, 5))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, SliderVolume.Height / 2, SliderVolume.Height / 2);//Vong giua
            }
        }
        #region Support->Volume
        #region Show/Hiden PanelVolume
        private void HidenPanelVolume()
        {
            if (pnlVolume.Visible == true)
                pnlVolume.Visible = false;
        }
        private void ShowPanelVolume()
        {
            if (pnlVolume.Visible == false)
                pnlVolume.Visible = true;
            else
                HidenPanelVolume();
        }
        private void btnVolume_Click(object sender, EventArgs e)
        {
            ShowPanelVolume();
        }
        private void panel_MouseDown(object sender, MouseEventArgs e) => HidenPanelVolume();
        private void button_Click(object sender, EventArgs e) => HidenPanelVolume();
        List<Panel> panels;
        List<IconButton> buttons;
        List<PictureBox> pictureBoxes;
        List<Label> labels;
        private void AddEvent()
        {
            panels = new List<Panel>() { pnlTopPlayer,pnlBottomPlayer,pnlLefPlayer,pnlPlayer,pnlPlaying,pnlRightPlayer,pnlMenu,pnlTitle,pnlLogo};
            buttons = new List<IconButton>() {btnMenu,btnHome,btnMusic,btnVideo,btnTools,btnAbout,
            btnPlayPause,btnBackWard,btnNextWard,btnfullScreen};
            pictureBoxes=new List<PictureBox>() {picArtPlayer,picLogo,Slider};
            labels = new List<Label>() { lblTitlePlayer,lblTimeStart,lblTimeEnd,lblIndexVolume,lblTitleChildForm};
            

            panels.ForEach(item => item.MouseDown += new MouseEventHandler(panel_MouseDown));
            buttons.ForEach(item => item.Click += new EventHandler(button_Click));
            pictureBoxes.ForEach(item => item.Click += new EventHandler(button_Click));
            labels.ForEach(item => item.Click += new EventHandler(button_Click));
            
            Slider.MouseDown += new MouseEventHandler(panel_MouseDown);
            
        }
        #endregion
        #endregion
        #endregion

        #region Player
        private void btnPlay()
        {
            this.btnPlayPause.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
            btnPlayPause.Tag = "Play";
        }
        private void btnPause()
        {
            this.btnPlayPause.IconChar = FontAwesome.Sharp.IconChar.CirclePause;
            btnPlayPause.Tag = "Pause";
        }
        private void StatusPlaying()
        {
            if (!String.IsNullOrEmpty(wMediaPlayer.URL))
            {
                Slider.Enabled = true;
                if (btnPlayPause.Tag.ToString() == "Play")
                {
                    wMediaPlayer.Ctlcontrols.play();
                    btnPause();
                }
                else
                {
                    wMediaPlayer.Ctlcontrols.pause();
                    btnPlay();

                }
            }
            else
            {
                Slider.Enabled=false;
            }
        }
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            StatusPlaying();      
        }
          
        private void LoadPlayingMusic(object sender, MyMusicEventArgs e)
        {
            wMediaPlayer.URL= e.Path;// Config URL
            wMediaPlayer.Ctlcontrols.play();// Start wMeidaPlayer
            StatusPlaying();
            btnPause();// Showbutton Play/Pause

            // Label TitlePlayer
            lblTitlePlayer.Text = e.Title;
            SettingRunWordTitle();

            //
            btnBackWard.Enabled = true;
            btnNextWard.Enabled = true;

        }
        private void LoadPlayingVideo(object sender, MyVideoEventArgs e)
        {
            wMediaPlayer.URL = e.Path;// Config URL
            wMediaPlayer.Ctlcontrols.play();// Start wMeidaPlayer
            StatusPlaying();
            btnPause();// Showbutton Play/Pause
            // Label TitlePlayer
            lblTitlePlayer.Text = e.Title;
            SettingRunWordTitle();
            btnHome.PerformClick();

            //
            btnBackWard.Enabled=false;
            btnNextWard.Enabled=false;

        }
        #endregion

        #region MediaPlayer
        private void ShowMediaPlayer()
        {
            if (pnlPlaying.Visible == false) pnlPlaying.Visible = true;
            if (activeForm != null) activeForm.Visible = false;


        }
        private void HidenMediaPlayer()
        {
            if (pnlPlaying.Visible == true) pnlPlaying.Visible = false;
        }
        private void btnfullScreen_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(wMediaPlayer.URL)) 
                wMediaPlayer.fullScreen = true;

        }
        private void btnProperty_Click(object sender, EventArgs e)
        {

        }
        private void wMediaPlayer_DoubleClickEvent(object sender, _WMPOCXEvents_DoubleClickEvent e)
        {
            if (wMediaPlayer.fullScreen == false)
                wMediaPlayer.fullScreen = true;
            else
                wMediaPlayer.fullScreen = false;
        }
        #endregion


    }
}
