namespace _2020052801HGCS_1_HelloWorld
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
            this.picAlbum = new System.Windows.Forms.PictureBox();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // picAlbum
            // 
            this.picAlbum.Image = ((System.Drawing.Image)(resources.GetObject("picAlbum.Image")));
            this.picAlbum.Location = new System.Drawing.Point(9, 12);
            this.picAlbum.Name = "picAlbum";
            this.picAlbum.Size = new System.Drawing.Size(583, 296);
            this.picAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlbum.TabIndex = 0;
            this.picAlbum.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(616, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(144, 62);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 322);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.picAlbum);
            this.Name = "frmPhoto";
            this.Text = "Photo Album";
            this.Load += new System.EventHandler(this.frmPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAlbum;
        private System.Windows.Forms.Button btnShow;
    }
}