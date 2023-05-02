﻿namespace Media_Player_Lite.ViewModels
{
    partial class ControlItemVideo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picVideo = new System.Windows.Forms.PictureBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.pnlTitleVideo = new System.Windows.Forms.Panel();
            this.lblTitleVideo = new System.Windows.Forms.Label();
            this.picIcon = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).BeginInit();
            this.pnlTitleVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picVideo
            // 
            this.picVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picVideo.Location = new System.Drawing.Point(0, 0);
            this.picVideo.Name = "picVideo";
            this.picVideo.Size = new System.Drawing.Size(392, 232);
            this.picVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVideo.TabIndex = 0;
            this.picVideo.TabStop = false;
            // 
            // lblDuration
            // 
            this.lblDuration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.LightGray;
            this.lblDuration.Location = new System.Drawing.Point(0, 270);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDuration.Size = new System.Drawing.Size(392, 30);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Text";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTitleVideo
            // 
            this.pnlTitleVideo.Controls.Add(this.lblTitleVideo);
            this.pnlTitleVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleVideo.Location = new System.Drawing.Point(0, 232);
            this.pnlTitleVideo.Name = "pnlTitleVideo";
            this.pnlTitleVideo.Size = new System.Drawing.Size(392, 40);
            this.pnlTitleVideo.TabIndex = 3;
            // 
            // lblTitleVideo
            // 
            this.lblTitleVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleVideo.ForeColor = System.Drawing.Color.White;
            this.lblTitleVideo.Location = new System.Drawing.Point(0, 0);
            this.lblTitleVideo.Name = "lblTitleVideo";
            this.lblTitleVideo.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitleVideo.Size = new System.Drawing.Size(400, 38);
            this.lblTitleVideo.TabIndex = 0;
            this.lblTitleVideo.Text = "Text";
            this.lblTitleVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picIcon
            // 
            this.picIcon.ForeColor = System.Drawing.Color.LightGray;
            this.picIcon.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
            this.picIcon.IconColor = System.Drawing.Color.LightGray;
            this.picIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picIcon.IconSize = 30;
            this.picIcon.Location = new System.Drawing.Point(362, 270);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(30, 30);
            this.picIcon.TabIndex = 4;
            this.picIcon.TabStop = false;
            // 
            // ControlItemVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.pnlTitleVideo);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.picVideo);
            this.Name = "ControlItemVideo";
            this.Size = new System.Drawing.Size(392, 300);
            this.Load += new System.EventHandler(this.ControlItemVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).EndInit();
            this.pnlTitleVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picVideo;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Panel pnlTitleVideo;
        private System.Windows.Forms.Label lblTitleVideo;
        private FontAwesome.Sharp.IconPictureBox picIcon;
    }
}
