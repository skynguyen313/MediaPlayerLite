namespace Media_Player_Lite.ViewModels
{
    partial class ControlPath
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
            this.lblDirectoryPath = new System.Windows.Forms.Label();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblDirectoryPath
            // 
            this.lblDirectoryPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDirectoryPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectoryPath.ForeColor = System.Drawing.Color.White;
            this.lblDirectoryPath.Location = new System.Drawing.Point(0, 0);
            this.lblDirectoryPath.Name = "lblDirectoryPath";
            this.lblDirectoryPath.Padding = new System.Windows.Forms.Padding(95, 0, 0, 0);
            this.lblDirectoryPath.Size = new System.Drawing.Size(763, 60);
            this.lblDirectoryPath.TabIndex = 0;
            this.lblDirectoryPath.Text = "Test";
            this.lblDirectoryPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnDelete.IconColor = System.Drawing.Color.White;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 30;
            this.btnDelete.Location = new System.Drawing.Point(642, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ControlPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDirectoryPath);
            this.Name = "ControlPath";
            this.Size = new System.Drawing.Size(763, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDirectoryPath;
        private FontAwesome.Sharp.IconButton btnDelete;
    }
}
