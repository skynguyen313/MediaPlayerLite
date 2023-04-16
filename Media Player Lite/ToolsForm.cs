using FontAwesome.Sharp;
using Media_Player_Lite.MyLib;
using Media_Player_Lite.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_Lite
{
    public partial class ToolsForm : Form
    {
        private static string fullFilePathMusic = DirectoryPath.GetFullPath(@"DataMPLite\dataMusic.dat");
        public ToolsForm()
        {
            InitializeComponent();
            pnlListPathMusic.Height = 1;
            HiddenPanel(pnlListPathMusic);
        }

        private void ToolsForm_Load(object sender, EventArgs e)
        {
            LoadListPath(pnlListPathMusic, fullFilePathMusic);
        }   
        private void LoadListPath(Panel pnl,string path)
        {
            var contents = ReadLineFile.ToListData(path);
            foreach (var line in contents)
            {
                UserControl ctP = new ControlPath(line);
                pnl.Height += 60;
                pnl.Controls.Add(ctP);
                ctP.Dock = DockStyle.Top;
            }
        }
        private void ShowListPanel(Panel pnl)
        {
            if (pnl.Visible==true) HiddenPanel(pnl);  
            else
            {
                pnl.Visible = true;
                this.btnListMusic.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            }
        }
        private void HiddenPanel(Panel pnl)
        {
            if (pnl.Visible == true)
            {
                pnl.Visible = false;
                this.btnListMusic.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            }
        }
        private void btnListMusic_Click(object sender, EventArgs e)
        {
            ShowListPanel(pnlListPathMusic);
        }

        private void btnAddFolderMusic_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                WriteLineFileDistic.WriteLine(fullFilePathMusic, folderBrowserDialog.SelectedPath);

            }
        }
    }
}
