namespace _2019121401CsRuHelloWorld
{
    partial class frmHello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHello));
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.picGf = new System.Windows.Forms.PictureBox();
            this.btnHide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picGf)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(569, 13);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(212, 55);
            this.btnSayHello.TabIndex = 0;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(569, 72);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(212, 55);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picGf
            // 
            this.picGf.Image = ((System.Drawing.Image)(resources.GetObject("picGf.Image")));
            this.picGf.Location = new System.Drawing.Point(19, 13);
            this.picGf.Name = "picGf";
            this.picGf.Size = new System.Drawing.Size(470, 328);
            this.picGf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGf.TabIndex = 2;
            this.picGf.TabStop = false;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(569, 131);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(212, 55);
            this.btnHide.TabIndex = 3;
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 369);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.picGf);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSayHello);
            this.Name = "frmHello";
            this.Text = "Green Hackers";
            this.Load += new System.EventHandler(this.frmHello_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picGf;
        private System.Windows.Forms.Button btnHide;
    }
}

