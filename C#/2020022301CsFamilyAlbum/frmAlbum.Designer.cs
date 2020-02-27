namespace _2020022301CsFamilyAlbum
{
    partial class frmAlbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlbum));
            this.picAlbum = new System.Windows.Forms.PictureBox();
            this.btnAWH = new System.Windows.Forms.Button();
            this.btnKKL = new System.Windows.Forms.Button();
            this.btnPyone = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // picAlbum
            // 
            this.picAlbum.Image = ((System.Drawing.Image)(resources.GetObject("picAlbum.Image")));
            this.picAlbum.Location = new System.Drawing.Point(12, 34);
            this.picAlbum.Name = "picAlbum";
            this.picAlbum.Size = new System.Drawing.Size(560, 327);
            this.picAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlbum.TabIndex = 0;
            this.picAlbum.TabStop = false;
            // 
            // btnAWH
            // 
            this.btnAWH.Location = new System.Drawing.Point(606, 37);
            this.btnAWH.Name = "btnAWH";
            this.btnAWH.Size = new System.Drawing.Size(189, 37);
            this.btnAWH.TabIndex = 1;
            this.btnAWH.Text = "Aung Win Htut";
            this.btnAWH.UseVisualStyleBackColor = true;
            this.btnAWH.Click += new System.EventHandler(this.btnAWH_Click);
            // 
            // btnKKL
            // 
            this.btnKKL.Location = new System.Drawing.Point(606, 80);
            this.btnKKL.Name = "btnKKL";
            this.btnKKL.Size = new System.Drawing.Size(189, 37);
            this.btnKKL.TabIndex = 2;
            this.btnKKL.Text = "Kaung Kaung Latt";
            this.btnKKL.UseVisualStyleBackColor = true;
            this.btnKKL.Click += new System.EventHandler(this.btnKKL_Click);
            // 
            // btnPyone
            // 
            this.btnPyone.Location = new System.Drawing.Point(606, 123);
            this.btnPyone.Name = "btnPyone";
            this.btnPyone.Size = new System.Drawing.Size(189, 37);
            this.btnPyone.TabIndex = 3;
            this.btnPyone.Text = "Pyone";
            this.btnPyone.UseVisualStyleBackColor = true;
            this.btnPyone.Click += new System.EventHandler(this.btnPyone_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(606, 166);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(189, 37);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPyone);
            this.Controls.Add(this.btnKKL);
            this.Controls.Add(this.btnAWH);
            this.Controls.Add(this.picAlbum);
            this.Name = "frmAlbum";
            this.Text = "Family Album";
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAlbum;
        private System.Windows.Forms.Button btnAWH;
        private System.Windows.Forms.Button btnKKL;
        private System.Windows.Forms.Button btnPyone;
        private System.Windows.Forms.Button btnClear;
    }
}

