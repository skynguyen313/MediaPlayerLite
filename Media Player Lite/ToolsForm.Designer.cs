namespace Media_Player_Lite
{
    partial class ToolsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTiTeLib = new System.Windows.Forms.Panel();
            this.lblTiTleLib = new System.Windows.Forms.Label();
            this.pnlMusicLibraryLocations = new System.Windows.Forms.Panel();
            this.btnListMusic = new FontAwesome.Sharp.IconButton();
            this.btnAddFolderMusic = new FontAwesome.Sharp.IconButton();
            this.lblMusicLib = new System.Windows.Forms.Label();
            this.picFolderMuisc = new FontAwesome.Sharp.IconPictureBox();
            this.pnlSpace = new System.Windows.Forms.Panel();
            this.pnlListPathMusic = new System.Windows.Forms.Panel();
            this.pnlSpace3 = new System.Windows.Forms.Panel();
            this.pnlTiTeLib.SuspendLayout();
            this.pnlMusicLibraryLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFolderMuisc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTiTeLib
            // 
            this.pnlTiTeLib.Controls.Add(this.lblTiTleLib);
            this.pnlTiTeLib.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTiTeLib.Location = new System.Drawing.Point(0, 0);
            this.pnlTiTeLib.Name = "pnlTiTeLib";
            this.pnlTiTeLib.Size = new System.Drawing.Size(856, 85);
            this.pnlTiTeLib.TabIndex = 0;
            // 
            // lblTiTleLib
            // 
            this.lblTiTleLib.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTiTleLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiTleLib.Location = new System.Drawing.Point(0, 0);
            this.lblTiTleLib.Name = "lblTiTleLib";
            this.lblTiTleLib.Size = new System.Drawing.Size(210, 85);
            this.lblTiTleLib.TabIndex = 0;
            this.lblTiTleLib.Text = "Libraries";
            this.lblTiTleLib.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMusicLibraryLocations
            // 
            this.pnlMusicLibraryLocations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.pnlMusicLibraryLocations.Controls.Add(this.btnListMusic);
            this.pnlMusicLibraryLocations.Controls.Add(this.btnAddFolderMusic);
            this.pnlMusicLibraryLocations.Controls.Add(this.lblMusicLib);
            this.pnlMusicLibraryLocations.Controls.Add(this.picFolderMuisc);
            this.pnlMusicLibraryLocations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMusicLibraryLocations.Location = new System.Drawing.Point(0, 85);
            this.pnlMusicLibraryLocations.Name = "pnlMusicLibraryLocations";
            this.pnlMusicLibraryLocations.Size = new System.Drawing.Size(856, 60);
            this.pnlMusicLibraryLocations.TabIndex = 1;
            // 
            // btnListMusic
            // 
            this.btnListMusic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnListMusic.FlatAppearance.BorderSize = 0;
            this.btnListMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListMusic.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.btnListMusic.IconColor = System.Drawing.Color.White;
            this.btnListMusic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListMusic.IconSize = 20;
            this.btnListMusic.Location = new System.Drawing.Point(781, 11);
            this.btnListMusic.Name = "btnListMusic";
            this.btnListMusic.Size = new System.Drawing.Size(30, 35);
            this.btnListMusic.TabIndex = 3;
            this.btnListMusic.UseVisualStyleBackColor = true;
            this.btnListMusic.Click += new System.EventHandler(this.btnListMusic_Click);
            // 
            // btnAddFolderMusic
            // 
            this.btnAddFolderMusic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddFolderMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnAddFolderMusic.FlatAppearance.BorderSize = 0;
            this.btnAddFolderMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolderMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolderMusic.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.btnAddFolderMusic.IconColor = System.Drawing.Color.White;
            this.btnAddFolderMusic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFolderMusic.IconSize = 40;
            this.btnAddFolderMusic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFolderMusic.Location = new System.Drawing.Point(569, 11);
            this.btnAddFolderMusic.Name = "btnAddFolderMusic";
            this.btnAddFolderMusic.Size = new System.Drawing.Size(197, 40);
            this.btnAddFolderMusic.TabIndex = 2;
            this.btnAddFolderMusic.Text = "Add folder";
            this.btnAddFolderMusic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFolderMusic.UseVisualStyleBackColor = false;
            this.btnAddFolderMusic.Click += new System.EventHandler(this.btnAddFolderMusic_Click);
            // 
            // lblMusicLib
            // 
            this.lblMusicLib.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMusicLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicLib.Location = new System.Drawing.Point(92, 6);
            this.lblMusicLib.Name = "lblMusicLib";
            this.lblMusicLib.Size = new System.Drawing.Size(260, 50);
            this.lblMusicLib.TabIndex = 1;
            this.lblMusicLib.Text = "Music library locations";
            this.lblMusicLib.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picFolderMuisc
            // 
            this.picFolderMuisc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picFolderMuisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.picFolderMuisc.IconChar = FontAwesome.Sharp.IconChar.FolderBlank;
            this.picFolderMuisc.IconColor = System.Drawing.Color.White;
            this.picFolderMuisc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picFolderMuisc.IconSize = 50;
            this.picFolderMuisc.Location = new System.Drawing.Point(36, 5);
            this.picFolderMuisc.Name = "picFolderMuisc";
            this.picFolderMuisc.Size = new System.Drawing.Size(50, 50);
            this.picFolderMuisc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFolderMuisc.TabIndex = 0;
            this.picFolderMuisc.TabStop = false;
            // 
            // pnlSpace
            // 
            this.pnlSpace.BackColor = System.Drawing.Color.Black;
            this.pnlSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace.Location = new System.Drawing.Point(0, 145);
            this.pnlSpace.Name = "pnlSpace";
            this.pnlSpace.Size = new System.Drawing.Size(856, 10);
            this.pnlSpace.TabIndex = 2;
            // 
            // pnlListPathMusic
            // 
            this.pnlListPathMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlListPathMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListPathMusic.Location = new System.Drawing.Point(0, 155);
            this.pnlListPathMusic.Name = "pnlListPathMusic";
            this.pnlListPathMusic.Size = new System.Drawing.Size(856, 65);
            this.pnlListPathMusic.TabIndex = 3;
            // 
            // pnlSpace3
            // 
            this.pnlSpace3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace3.Location = new System.Drawing.Point(0, 220);
            this.pnlSpace3.Name = "pnlSpace3";
            this.pnlSpace3.Size = new System.Drawing.Size(856, 10);
            this.pnlSpace3.TabIndex = 4;
            // 
            // ToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(856, 508);
            this.Controls.Add(this.pnlSpace3);
            this.Controls.Add(this.pnlListPathMusic);
            this.Controls.Add(this.pnlSpace);
            this.Controls.Add(this.pnlMusicLibraryLocations);
            this.Controls.Add(this.pnlTiTeLib);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ToolsForm";
            this.Text = "ToolsForm";
            this.Load += new System.EventHandler(this.ToolsForm_Load);
            this.pnlTiTeLib.ResumeLayout(false);
            this.pnlMusicLibraryLocations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFolderMuisc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTiTeLib;
        private System.Windows.Forms.Label lblTiTleLib;
        private System.Windows.Forms.Panel pnlMusicLibraryLocations;
        private FontAwesome.Sharp.IconButton btnListMusic;
        private FontAwesome.Sharp.IconButton btnAddFolderMusic;
        private System.Windows.Forms.Label lblMusicLib;
        private FontAwesome.Sharp.IconPictureBox picFolderMuisc;
        private System.Windows.Forms.Panel pnlSpace;
        private System.Windows.Forms.Panel pnlListPathMusic;
        private System.Windows.Forms.Panel pnlSpace3;
    }
}