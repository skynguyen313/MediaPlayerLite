using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_Lite.ViewModels
{
    public partial class ControlPath : UserControl
    {
        public delegate void Message(string message);
        public Message SendMessage;
        public ControlPath(string content)
        {
            InitializeComponent();
            lblDirectoryPath.Text = content;
        }
    
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SendMessage(lblDirectoryPath.Text);
            this.Dispose();
        }
    }
}
