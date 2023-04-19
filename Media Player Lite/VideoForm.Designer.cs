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
            this.btnAddFolder = new FontAwesome.Sharp.IconButton();
            this.fpnlListItemVideo = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTitleVideo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleVideo
            // 
            this.pnlTitleVideo.BackColor = System.Drawing.Color.Black;
            this.pnlTitleVideo.Controls.Add(this.btnAddFolder);
            this.pnlTitleVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleVideo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleVideo.Name = "pnlTitleVideo";
            this.pnlTitleVideo.Size = new System.Drawing.Size(1108, 120);
            this.pnlTitleVideo.TabIndex = 0;
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
            this.btnAddFolder.TabIndex = 8;
            this.btnAddFolder.Text = "Add folder";
            this.btnAddFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFolder.UseVisualStyleBackColor = false;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
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
        private FontAwesome.Sharp.IconButton btnAddFolder;
    }
}