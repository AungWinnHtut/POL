namespace WindowsFormsApp5
{
    partial class frmPhotoUploadDownload
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
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPicFname = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnPicDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(17, 12);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(421, 288);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(453, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(152, 188);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPicFname
            // 
            this.txtPicFname.Location = new System.Drawing.Point(15, 386);
            this.txtPicFname.Name = "txtPicFname";
            this.txtPicFname.Size = new System.Drawing.Size(423, 26);
            this.txtPicFname.TabIndex = 2;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(453, 206);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(152, 72);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(17, 354);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(423, 26);
            this.txtPath.TabIndex = 4;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(17, 322);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(423, 26);
            this.txtSize.TabIndex = 5;
            // 
            // btnPicDownload
            // 
            this.btnPicDownload.Location = new System.Drawing.Point(453, 340);
            this.btnPicDownload.Name = "btnPicDownload";
            this.btnPicDownload.Size = new System.Drawing.Size(152, 72);
            this.btnPicDownload.TabIndex = 6;
            this.btnPicDownload.Text = "Download";
            this.btnPicDownload.UseVisualStyleBackColor = true;
            this.btnPicDownload.Click += new System.EventHandler(this.btnPicDownload_Click);
            // 
            // frmPhotoUploadDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 440);
            this.Controls.Add(this.btnPicDownload);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtPicFname);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picPhoto);
            this.Name = "frmPhotoUploadDownload";
            this.Text = "frmPhotoUploadDownload";
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPicFname;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnPicDownload;
    }
}