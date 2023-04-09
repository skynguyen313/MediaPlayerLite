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
            this.btnImportMusic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitleMusic = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlListMusic = new System.Windows.Forms.Panel();
            this.cmbDuration = new LW_PhanMemBaoGia.MyControls.ComboBoxT();
            this.cmbGenre = new LW_PhanMemBaoGia.MyControls.ComboBoxT();
            this.cmbArtist = new LW_PhanMemBaoGia.MyControls.ComboBoxT();
            this.cmbSong = new LW_PhanMemBaoGia.MyControls.ComboBoxT();
            this.lvMusic = new System.Windows.Forms.ListView();
            this.col_index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_song = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTitleMusic.SuspendLayout();
            this.pnlListMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportMusic
            // 
            this.btnImportMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportMusic.BackColor = System.Drawing.Color.DimGray;
            this.btnImportMusic.FlatAppearance.BorderSize = 5;
            this.btnImportMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportMusic.ForeColor = System.Drawing.Color.White;
            this.btnImportMusic.Location = new System.Drawing.Point(649, 39);
            this.btnImportMusic.Name = "btnImportMusic";
            this.btnImportMusic.Size = new System.Drawing.Size(207, 41);
            this.btnImportMusic.TabIndex = 1;
            this.btnImportMusic.Text = "Import Music";
            this.btnImportMusic.UseVisualStyleBackColor = false;
            this.btnImportMusic.Click += new System.EventHandler(this.btnImportMusic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // pnlTitleMusic
            // 
            this.pnlTitleMusic.Controls.Add(this.textBox1);
            this.pnlTitleMusic.Controls.Add(this.label1);
            this.pnlTitleMusic.Controls.Add(this.btnImportMusic);
            this.pnlTitleMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleMusic.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleMusic.Name = "pnlTitleMusic";
            this.pnlTitleMusic.Size = new System.Drawing.Size(856, 80);
            this.pnlTitleMusic.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(105, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 35);
            this.textBox1.TabIndex = 4;
            // 
            // pnlListMusic
            // 
            this.pnlListMusic.Controls.Add(this.cmbDuration);
            this.pnlListMusic.Controls.Add(this.cmbGenre);
            this.pnlListMusic.Controls.Add(this.cmbArtist);
            this.pnlListMusic.Controls.Add(this.cmbSong);
            this.pnlListMusic.Controls.Add(this.lvMusic);
            this.pnlListMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListMusic.Location = new System.Drawing.Point(0, 80);
            this.pnlListMusic.Name = "pnlListMusic";
            this.pnlListMusic.Size = new System.Drawing.Size(856, 428);
            this.pnlListMusic.TabIndex = 5;
            // 
            // cmbDuration
            // 
            this.cmbDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDuration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDuration.BorderSize = 0;
            this.cmbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDuration.ForeColor = System.Drawing.Color.Navy;
            this.cmbDuration.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbDuration.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDuration.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDuration.Location = new System.Drawing.Point(1480, -1);
            this.cmbDuration.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbDuration.Name = "cmbDuration";
            this.cmbDuration.Size = new System.Drawing.Size(628, 33);
            this.cmbDuration.TabIndex = 4;
            this.cmbDuration.Texts = "Duration";
            // 
            // cmbGenre
            // 
            this.cmbGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGenre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGenre.BorderSize = 0;
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenre.ForeColor = System.Drawing.Color.Navy;
            this.cmbGenre.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbGenre.Items.AddRange(new object[] {
            "All genres"});
            this.cmbGenre.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbGenre.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbGenre.Location = new System.Drawing.Point(1130, -1);
            this.cmbGenre.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(350, 33);
            this.cmbGenre.TabIndex = 3;
            this.cmbGenre.Texts = "All genres";
            // 
            // cmbArtist
            // 
            this.cmbArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbArtist.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbArtist.BorderSize = 0;
            this.cmbArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArtist.ForeColor = System.Drawing.Color.Navy;
            this.cmbArtist.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbArtist.Items.AddRange(new object[] {
            "All artist"});
            this.cmbArtist.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbArtist.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbArtist.Location = new System.Drawing.Point(780, -1);
            this.cmbArtist.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbArtist.Name = "cmbArtist";
            this.cmbArtist.Size = new System.Drawing.Size(350, 33);
            this.cmbArtist.TabIndex = 2;
            this.cmbArtist.Texts = "All artist";
            // 
            // cmbSong
            // 
            this.cmbSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSong.BorderSize = 0;
            this.cmbSong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSong.ForeColor = System.Drawing.Color.Navy;
            this.cmbSong.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.cmbSong.Items.AddRange(new object[] {
            "        Song sort by: A - Z",
            "        Song sort by: Z - A"});
            this.cmbSong.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbSong.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbSong.Location = new System.Drawing.Point(0, -1);
            this.cmbSong.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbSong.Name = "cmbSong";
            this.cmbSong.Size = new System.Drawing.Size(780, 33);
            this.cmbSong.TabIndex = 1;
            this.cmbSong.Texts = "        Song";
            this.cmbSong.OnSelectedIndexChanged += new System.EventHandler(this.cmbSong_OnSelectedIndexChanged);
            // 
            // lvMusic
            // 
            this.lvMusic.AllowDrop = true;
            this.lvMusic.AutoArrange = false;
            this.lvMusic.BackColor = System.Drawing.Color.Black;
            this.lvMusic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMusic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_index,
            this.col_song,
            this.col_artist,
            this.col_genre,
            this.col_duration,
            this.colEmty});
            this.lvMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMusic.ForeColor = System.Drawing.Color.White;
            this.lvMusic.FullRowSelect = true;
            this.lvMusic.HideSelection = false;
            this.lvMusic.Location = new System.Drawing.Point(0, 0);
            this.lvMusic.MultiSelect = false;
            this.lvMusic.Name = "lvMusic";
            this.lvMusic.Scrollable = false;
            this.lvMusic.Size = new System.Drawing.Size(856, 428);
            this.lvMusic.TabIndex = 0;
            this.lvMusic.UseCompatibleStateImageBehavior = false;
            this.lvMusic.View = System.Windows.Forms.View.Details;
            this.lvMusic.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvMusic_ColumnWidthChanging);
            this.lvMusic.DoubleClick += new System.EventHandler(this.lvMusic_DoubleClick);
            // 
            // col_index
            // 
            this.col_index.Text = "";
            // 
            // col_song
            // 
            this.col_song.Text = "";
            this.col_song.Width = 721;
            // 
            // col_artist
            // 
            this.col_artist.Text = "";
            this.col_artist.Width = 350;
            // 
            // col_genre
            // 
            this.col_genre.Text = "";
            this.col_genre.Width = 350;
            // 
            // col_duration
            // 
            this.col_duration.Text = "";
            this.col_duration.Width = 200;
            // 
            // colEmty
            // 
            this.colEmty.Text = "";
            this.colEmty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEmty.Width = 200;
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(856, 508);
            this.Controls.Add(this.pnlListMusic);
            this.Controls.Add(this.pnlTitleMusic);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MusicForm";
            this.Text = "MusicForm";
            this.Load += new System.EventHandler(this.MusicForm_Load);
            this.pnlTitleMusic.ResumeLayout(false);
            this.pnlTitleMusic.PerformLayout();
            this.pnlListMusic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImportMusic;
        private System.Windows.Forms.Panel pnlTitleMusic;
        private System.Windows.Forms.Panel pnlListMusic;
        private System.Windows.Forms.ListView lvMusic;
        private System.Windows.Forms.ColumnHeader col_index;
        private System.Windows.Forms.ColumnHeader col_song;
        private System.Windows.Forms.ColumnHeader col_artist;
        private System.Windows.Forms.ColumnHeader col_genre;
        private System.Windows.Forms.ColumnHeader col_duration;
        private System.Windows.Forms.ColumnHeader colEmty;
        private System.Windows.Forms.TextBox textBox1;
        private LW_PhanMemBaoGia.MyControls.ComboBoxT cmbSong;
        private LW_PhanMemBaoGia.MyControls.ComboBoxT cmbArtist;
        private LW_PhanMemBaoGia.MyControls.ComboBoxT cmbGenre;
        private LW_PhanMemBaoGia.MyControls.ComboBoxT cmbDuration;
    }
}