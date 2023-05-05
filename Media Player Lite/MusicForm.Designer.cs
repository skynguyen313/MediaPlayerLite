namespace Media_Player_Lite
{
    partial class MusicForm
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
            this.pnlTitleMusic = new System.Windows.Forms.Panel();
            this.txtSearch = new LW_PhanMemBaoGia.MyControls.TextBoxT();
            this.btnAddFolderMusic = new FontAwesome.Sharp.IconButton();
            this.cmbGenre = new LW_PhanMemBaoGia.MyControls.ComboBoxT();
            this.cmbArtist = new LW_PhanMemBaoGia.MyControls.ComboBoxT();
            this.pnlListMusic = new System.Windows.Forms.Panel();
            this.pnlTitleMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleMusic
            // 
            this.pnlTitleMusic.Controls.Add(this.txtSearch);
            this.pnlTitleMusic.Controls.Add(this.btnAddFolderMusic);
            this.pnlTitleMusic.Controls.Add(this.cmbGenre);
            this.pnlTitleMusic.Controls.Add(this.cmbArtist);
            this.pnlTitleMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleMusic.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleMusic.Name = "pnlTitleMusic";
            this.pnlTitleMusic.Size = new System.Drawing.Size(1108, 150);
            this.pnlTitleMusic.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.DimGray;
            this.txtSearch.BorderColor = System.Drawing.Color.DimGray;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.DimGray;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(30, 70);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.Size = new System.Drawing.Size(488, 50);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Texts = "Search";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            // 
            // btnAddFolderMusic
            // 
            this.btnAddFolderMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFolderMusic.AutoSize = true;
            this.btnAddFolderMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddFolderMusic.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddFolderMusic.FlatAppearance.BorderSize = 0;
            this.btnAddFolderMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolderMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolderMusic.ForeColor = System.Drawing.Color.White;
            this.btnAddFolderMusic.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.btnAddFolderMusic.IconColor = System.Drawing.Color.White;
            this.btnAddFolderMusic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFolderMusic.IconSize = 40;
            this.btnAddFolderMusic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFolderMusic.Location = new System.Drawing.Point(900, 10);
            this.btnAddFolderMusic.Name = "btnAddFolderMusic";
            this.btnAddFolderMusic.Size = new System.Drawing.Size(176, 46);
            this.btnAddFolderMusic.TabIndex = 7;
            this.btnAddFolderMusic.Text = "Add folder";
            this.btnAddFolderMusic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFolderMusic.UseVisualStyleBackColor = false;
            this.btnAddFolderMusic.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // cmbGenre
            // 
            this.cmbGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGenre.BackColor = System.Drawing.Color.Black;
            this.cmbGenre.BorderColor = System.Drawing.Color.Black;
            this.cmbGenre.BorderSize = 0;
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenre.ForeColor = System.Drawing.Color.White;
            this.cmbGenre.IconColor = System.Drawing.Color.Cyan;
            this.cmbGenre.Items.AddRange(new object[] {
            "All artist"});
            this.cmbGenre.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbGenre.ListTextColor = System.Drawing.Color.White;
            this.cmbGenre.Location = new System.Drawing.Point(573, 18);
            this.cmbGenre.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(286, 30);
            this.cmbGenre.TabIndex = 5;
            this.cmbGenre.Texts = "Genre: All genres";
            this.cmbGenre.OnSelectedIndexChanged += new System.EventHandler(this.cmbGenre_OnSelectedIndexChanged);
            // 
            // cmbArtist
            // 
            this.cmbArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbArtist.BackColor = System.Drawing.Color.Black;
            this.cmbArtist.BorderColor = System.Drawing.Color.Black;
            this.cmbArtist.BorderSize = 0;
            this.cmbArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArtist.ForeColor = System.Drawing.Color.White;
            this.cmbArtist.IconColor = System.Drawing.Color.Cyan;
            this.cmbArtist.Items.AddRange(new object[] {
            "All artist"});
            this.cmbArtist.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbArtist.ListTextColor = System.Drawing.Color.White;
            this.cmbArtist.Location = new System.Drawing.Point(272, 18);
            this.cmbArtist.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbArtist.Name = "cmbArtist";
            this.cmbArtist.Size = new System.Drawing.Size(286, 30);
            this.cmbArtist.TabIndex = 2;
            this.cmbArtist.Texts = "Artist: All artist";
            this.cmbArtist.OnSelectedIndexChanged += new System.EventHandler(this.cmbArtist_OnSelectedIndexChanged);
            // 
            // pnlListMusic
            // 
            this.pnlListMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListMusic.Location = new System.Drawing.Point(0, 150);
            this.pnlListMusic.Name = "pnlListMusic";
            this.pnlListMusic.Size = new System.Drawing.Size(1108, 358);
            this.pnlListMusic.TabIndex = 5;
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1108, 508);
            this.Controls.Add(this.pnlListMusic);
            this.Controls.Add(this.pnlTitleMusic);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MusicForm";
            this.Text = "MusicForm";
            this.Load += new System.EventHandler(this.MusicForm_Load);
            this.pnlTitleMusic.ResumeLayout(false);
            this.pnlTitleMusic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitleMusic;
        private System.Windows.Forms.Panel pnlListMusic;
        private LW_PhanMemBaoGia.MyControls.ComboBoxT cmbArtist;
        private LW_PhanMemBaoGia.MyControls.ComboBoxT cmbGenre;
        private FontAwesome.Sharp.IconButton btnAddFolderMusic;
        private LW_PhanMemBaoGia.MyControls.TextBoxT txtSearch;
    }
}