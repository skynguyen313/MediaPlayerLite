namespace Media_Player_Lite.ViewModels
{
    partial class ControlItemMusic
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.picMusic = new FontAwesome.Sharp.IconPictureBox();
            this.picArt = new System.Windows.Forms.PictureBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(176, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(547, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Hóa tương tư";
            // 
            // lblArtist
            // 
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.Color.Silver;
            this.lblArtist.Location = new System.Drawing.Point(176, 71);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.lblArtist.Size = new System.Drawing.Size(278, 30);
            this.lblArtist.TabIndex = 2;
            this.lblArtist.Text = "Anh Rồng";
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picMusic
            // 
            this.picMusic.Dock = System.Windows.Forms.DockStyle.Left;
            this.picMusic.ForeColor = System.Drawing.Color.DarkGray;
            this.picMusic.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
            this.picMusic.IconColor = System.Drawing.Color.DarkGray;
            this.picMusic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picMusic.IconSize = 50;
            this.picMusic.Location = new System.Drawing.Point(0, 0);
            this.picMusic.Name = "picMusic";
            this.picMusic.Size = new System.Drawing.Size(50, 150);
            this.picMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMusic.TabIndex = 4;
            this.picMusic.TabStop = false;
            // 
            // picArt
            // 
            this.picArt.Location = new System.Drawing.Point(61, 21);
            this.picArt.Name = "picArt";
            this.picArt.Size = new System.Drawing.Size(110, 110);
            this.picArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArt.TabIndex = 5;
            this.picArt.TabStop = false;
            // 
            // lblGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Silver;
            this.lblGenre.Location = new System.Drawing.Point(176, 101);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.lblGenre.Size = new System.Drawing.Size(278, 30);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Nhạc trẻ / Remix";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(1061, 58);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(121, 35);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "04:02";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControlItemMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.picArt);
            this.Controls.Add(this.picMusic);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ControlItemMusic";
            this.Size = new System.Drawing.Size(1185, 150);
            this.Load += new System.EventHandler(this.ControlItemMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArtist;
        private FontAwesome.Sharp.IconPictureBox picMusic;
        private System.Windows.Forms.PictureBox picArt;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDuration;
    }
}
