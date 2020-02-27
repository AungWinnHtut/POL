namespace _2020022601CsTestProj
{
    partial class frmPhoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhoto));
            this.btnHello = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnHidePhoto = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(549, 53);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(110, 43);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picPhoto.Image")));
            this.picPhoto.Location = new System.Drawing.Point(30, 25);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(99, 110);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 1;
            this.picPhoto.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(25, 141);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(435, 277);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            // 
            // btnHidePhoto
            // 
            this.btnHidePhoto.Location = new System.Drawing.Point(163, 27);
            this.btnHidePhoto.Name = "btnHidePhoto";
            this.btnHidePhoto.Size = new System.Drawing.Size(110, 43);
            this.btnHidePhoto.TabIndex = 3;
            this.btnHidePhoto.Text = "Hie Photo";
            this.btnHidePhoto.UseVisualStyleBackColor = true;
            this.btnHidePhoto.Click += new System.EventHandler(this.btnHidePhoto_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(163, 82);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(110, 43);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show Photo";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(299, 25);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(135, 99);
            this.btnControl.TabIndex = 5;
            this.btnControl.Text = "Hide Photo";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(516, 143);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(193, 274);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // frmPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHidePhoto);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.btnHello);
            this.Name = "frmPhoto";
            this.Text = "Photo Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnHidePhoto;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnBrowse;
    }
}

