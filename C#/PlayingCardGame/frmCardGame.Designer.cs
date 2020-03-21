namespace PlayingCard1
{
    partial class frmCardGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCardGame));
            this.picCards = new System.Windows.Forms.PictureBox();
            this.picDrawCard = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.IL = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPlayPhoto = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawCard)).BeginInit();
            this.SuspendLayout();
            // 
            // picCards
            // 
            this.picCards.Image = ((System.Drawing.Image)(resources.GetObject("picCards.Image")));
            this.picCards.Location = new System.Drawing.Point(25, 44);
            this.picCards.Name = "picCards";
            this.picCards.Size = new System.Drawing.Size(264, 323);
            this.picCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCards.TabIndex = 0;
            this.picCards.TabStop = false;
            // 
            // picDrawCard
            // 
            this.picDrawCard.Location = new System.Drawing.Point(345, 44);
            this.picDrawCard.Name = "picDrawCard";
            this.picDrawCard.Size = new System.Drawing.Size(264, 323);
            this.picDrawCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDrawCard.TabIndex = 1;
            this.picDrawCard.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(630, 47);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(151, 46);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Draw a Card";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // IL
            // 
            this.IL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL.ImageStream")));
            this.IL.TransparentColor = System.Drawing.Color.Transparent;
            this.IL.Images.SetKeyName(0, "1.jpg");
            this.IL.Images.SetKeyName(1, "2.png");
            this.IL.Images.SetKeyName(2, "3.png");
            this.IL.Images.SetKeyName(3, "4.png");
            this.IL.Images.SetKeyName(4, "5.jpg");
            this.IL.Images.SetKeyName(5, "6.png");
            this.IL.Images.SetKeyName(6, "7.png");
            this.IL.Images.SetKeyName(7, "8.jpg");
            this.IL.Images.SetKeyName(8, "8.png");
            this.IL.Images.SetKeyName(9, "9.png");
            this.IL.Images.SetKeyName(10, "64fe3aaedd0cd7e7a89f15127bbcc3f4.png");
            this.IL.Images.SetKeyName(11, "1200px-Playing_card_diamond_10.svg.png");
            this.IL.Images.SetKeyName(12, "9780594688143_p3_v4_s550x406.jpg");
            this.IL.Images.SetKeyName(13, "bicycle-rider-red-back-550x550.jpg");
            this.IL.Images.SetKeyName(14, "j.png");
            this.IL.Images.SetKeyName(15, "k.jpg");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPlayPhoto
            // 
            this.btnPlayPhoto.Location = new System.Drawing.Point(630, 118);
            this.btnPlayPhoto.Name = "btnPlayPhoto";
            this.btnPlayPhoto.Size = new System.Drawing.Size(150, 43);
            this.btnPlayPhoto.TabIndex = 3;
            this.btnPlayPhoto.Text = "Play Photo";
            this.btnPlayPhoto.UseVisualStyleBackColor = true;
            this.btnPlayPhoto.Click += new System.EventHandler(this.btnPlayPhoto_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(642, 196);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(137, 26);
            this.txtValue.TabIndex = 4;
            // 
            // frmCardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 439);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnPlayPhoto);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.picDrawCard);
            this.Controls.Add(this.picCards);
            this.Name = "frmCardGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCardGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCards;
        private System.Windows.Forms.PictureBox picDrawCard;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ImageList IL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPlayPhoto;
        private System.Windows.Forms.TextBox txtValue;
    }
}

