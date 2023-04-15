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
            this.btnAddFolder = new FontAwesome.Sharp.IconButton();
            this.cmbGenre = new LW_PhanMemBaoGia.MyControls.ComboBoxT();
            this.cmbArtist = new LW_PhanMemBaoGia.MyControls.ComboBoxT();
            this.pnlListMusic = new System.Windows.Forms.Panel();
            this.listviewMusic = new System.Windows.Forms.ListView();
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGenres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTitleMusic.SuspendLayout();
            this.pnlListMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleMusic
            // 
            this.pnlTitleMusic.Controls.Add(this.txtSearch);
            this.pnlTitleMusic.Controls.Add(this.btnAddFolder);
            this.pnlTitleMusic.Controls.Add(this.cmbGenre);
            this.pnlTitleMusic.Controls.Add(this.cmbArtist);
            this.pnlTitleMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleMusic.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleMusic.Name = "pnlTitleMusic";
            this.pnlTitleMusic.Size = new System.Drawing.Size(1108, 120);
            this.pnlTitleMusic.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Black;
            this.txtSearch.BorderColor = System.Drawing.Color.White;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.Fuchsia;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Cyan;
            this.txtSearch.Location = new System.Drawing.Point(3, 55);
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
            // btnAddFolder
            // 
            this.btnAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFolder.AutoSize = true;
            this.btnAddFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddFolder.FlatAppearance.BorderSize = 0;
            this.btnAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolder.ForeColor = System.Drawing.Color.White;
            this.btnAddFolder.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.btnAddFolder.IconColor = System.Drawing.Color.White;
            this.btnAddFolder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFolder.IconSize = 40;
            this.btnAddFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFolder.Location = new System.Drawing.Point(900, 10);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(176, 46);
            this.btnAddFolder.TabIndex = 7;
            this.btnAddFolder.Text = "Add folder";
            this.btnAddFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFolder.UseVisualStyleBackColor = false;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
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
            this.pnlListMusic.Controls.Add(this.listviewMusic);
            this.pnlListMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListMusic.Location = new System.Drawing.Point(0, 120);
            this.pnlListMusic.Name = "pnlListMusic";
            this.pnlListMusic.Size = new System.Drawing.Size(1108, 388);
            this.pnlListMusic.TabIndex = 5;
            // 
            // listviewMusic
            // 
            this.listviewMusic.BackColor = System.Drawing.Color.Black;
            this.listviewMusic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listviewMusic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle,
            this.colArtist,
            this.colGenres,
            this.colDuration});
            this.listviewMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listviewMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewMusic.ForeColor = System.Drawing.Color.White;
            this.listviewMusic.FullRowSelect = true;
            this.listviewMusic.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listviewMusic.HideSelection = false;
            this.listviewMusic.Location = new System.Drawing.Point(0, 0);
            this.listviewMusic.Name = "listviewMusic";
            this.listviewMusic.Size = new System.Drawing.Size(1108, 388);
            this.listviewMusic.TabIndex = 0;
            this.listviewMusic.UseCompatibleStateImageBehavior = false;
            this.listviewMusic.View = System.Windows.Forms.View.Details;
            this.listviewMusic.DoubleClick += new System.EventHandler(this.listviewMusic_DoubleClick);
            // 
            // colTitle
            // 
            this.colTitle.Text = "";
            this.colTitle.Width = 1000;
            // 
            // colArtist
            // 
            this.colArtist.Text = "";
            this.colArtist.Width = 300;
            // 
            // colGenres
            // 
            this.colGenres.Text = "";
            this.colGenres.Width = 300;
            // 
            // colDuration
            // 
            this.colDuration.Text = "";
            this.colDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDuration.Width = 200;
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
            this.pnlListMusic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitleMusic;
        private System.Windows.Forms.Panel pnlListMusic;
        private LW_PhanMemBaoGia.MyControls.ComboBoxT cmbArtist;
        private LW_PhanMemBaoGia.MyControls.ComboBoxT cmbGenre;
        private System.Windows.Forms.ListView listviewMusic;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colArtist;
        private System.Windows.Forms.ColumnHeader colGenres;
        private System.Windows.Forms.ColumnHeader colDuration;
        private FontAwesome.Sharp.IconButton btnAddFolder;
        private LW_PhanMemBaoGia.MyControls.TextBoxT txtSearch;
    }
}