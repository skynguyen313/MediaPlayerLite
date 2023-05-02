namespace Media_Player_Lite
{
    partial class VideoForm
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
            this.pnlTitleVideo = new System.Windows.Forms.Panel();
            this.btnAddFolderVideo = new FontAwesome.Sharp.IconButton();
            this.fpnlListItemVideo = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSortAZ = new System.Windows.Forms.Button();
            this.btnSortDate = new System.Windows.Forms.Button();
            this.pnlSign1 = new System.Windows.Forms.Panel();
            this.pnlSign2 = new System.Windows.Forms.Panel();
            this.pnlTitleVideo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleVideo
            // 
            this.pnlTitleVideo.BackColor = System.Drawing.Color.Black;
            this.pnlTitleVideo.Controls.Add(this.pnlSign2);
            this.pnlTitleVideo.Controls.Add(this.pnlSign1);
            this.pnlTitleVideo.Controls.Add(this.btnSortDate);
            this.pnlTitleVideo.Controls.Add(this.btnSortAZ);
            this.pnlTitleVideo.Controls.Add(this.btnAddFolderVideo);
            this.pnlTitleVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleVideo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleVideo.Name = "pnlTitleVideo";
            this.pnlTitleVideo.Size = new System.Drawing.Size(1108, 120);
            this.pnlTitleVideo.TabIndex = 0;
            // 
            // btnAddFolderVideo
            // 
            this.btnAddFolderVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFolderVideo.AutoSize = true;
            this.btnAddFolderVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddFolderVideo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddFolderVideo.FlatAppearance.BorderSize = 0;
            this.btnAddFolderVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolderVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolderVideo.ForeColor = System.Drawing.Color.White;
            this.btnAddFolderVideo.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.btnAddFolderVideo.IconColor = System.Drawing.Color.White;
            this.btnAddFolderVideo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFolderVideo.IconSize = 40;
            this.btnAddFolderVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFolderVideo.Location = new System.Drawing.Point(900, 10);
            this.btnAddFolderVideo.Name = "btnAddFolderVideo";
            this.btnAddFolderVideo.Size = new System.Drawing.Size(176, 46);
            this.btnAddFolderVideo.TabIndex = 8;
            this.btnAddFolderVideo.Text = "Add folder";
            this.btnAddFolderVideo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFolderVideo.UseVisualStyleBackColor = false;
            this.btnAddFolderVideo.Click += new System.EventHandler(this.btnAddFolderVideo_Click);
            // 
            // fpnlListItemVideo
            // 
            this.fpnlListItemVideo.AutoScroll = true;
            this.fpnlListItemVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlListItemVideo.Location = new System.Drawing.Point(0, 120);
            this.fpnlListItemVideo.Name = "fpnlListItemVideo";
            this.fpnlListItemVideo.Size = new System.Drawing.Size(1108, 388);
            this.fpnlListItemVideo.TabIndex = 1;
            // 
            // btnSortAZ
            // 
            this.btnSortAZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortAZ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSortAZ.FlatAppearance.BorderSize = 0;
            this.btnSortAZ.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnSortAZ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSortAZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSortAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortAZ.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortAZ.Location = new System.Drawing.Point(570, 21);
            this.btnSortAZ.Name = "btnSortAZ";
            this.btnSortAZ.Size = new System.Drawing.Size(91, 35);
            this.btnSortAZ.TabIndex = 9;
            this.btnSortAZ.Text = "A - Z";
            this.btnSortAZ.UseVisualStyleBackColor = true;
            this.btnSortAZ.Click += new System.EventHandler(this.btnSortAZ_Click);
            // 
            // btnSortDate
            // 
            this.btnSortDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortDate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSortDate.FlatAppearance.BorderSize = 0;
            this.btnSortDate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnSortDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSortDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSortDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortDate.Location = new System.Drawing.Point(667, 21);
            this.btnSortDate.Name = "btnSortDate";
            this.btnSortDate.Size = new System.Drawing.Size(196, 35);
            this.btnSortDate.TabIndex = 9;
            this.btnSortDate.Text = "Date modified";
            this.btnSortDate.UseVisualStyleBackColor = true;
            this.btnSortDate.Click += new System.EventHandler(this.btnSortDate_Click);
            // 
            // pnlSign1
            // 
            this.pnlSign1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSign1.BackColor = System.Drawing.Color.Black;
            this.pnlSign1.Location = new System.Drawing.Point(599, 51);
            this.pnlSign1.Name = "pnlSign1";
            this.pnlSign1.Size = new System.Drawing.Size(30, 5);
            this.pnlSign1.TabIndex = 10;
            // 
            // pnlSign2
            // 
            this.pnlSign2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSign2.BackColor = System.Drawing.Color.Black;
            this.pnlSign2.Location = new System.Drawing.Point(719, 51);
            this.pnlSign2.Name = "pnlSign2";
            this.pnlSign2.Size = new System.Drawing.Size(90, 5);
            this.pnlSign2.TabIndex = 11;
            // 
            // VideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1108, 508);
            this.Controls.Add(this.fpnlListItemVideo);
            this.Controls.Add(this.pnlTitleVideo);
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(900, 10);
            this.Name = "VideoForm";
            this.Text = "VideoForm";
            this.Load += new System.EventHandler(this.VideoForm_Load);
            this.pnlTitleVideo.ResumeLayout(false);
            this.pnlTitleVideo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleVideo;
        private System.Windows.Forms.FlowLayoutPanel fpnlListItemVideo;
        private FontAwesome.Sharp.IconButton btnAddFolderVideo;
        private System.Windows.Forms.Button btnSortDate;
        private System.Windows.Forms.Button btnSortAZ;
        private System.Windows.Forms.Panel pnlSign1;
        private System.Windows.Forms.Panel pnlSign2;
    }
}