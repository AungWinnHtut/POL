namespace _2020061103
{
    partial class frmPicturebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPicturebox));
            this.picbox = new System.Windows.Forms.PictureBox();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox
            // 
            this.picbox.Image = ((System.Drawing.Image)(resources.GetObject("picbox.Image")));
            this.picbox.Location = new System.Drawing.Point(-1, 2);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(336, 255);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 0;
            this.picbox.TabStop = false;
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(-1, 262);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(93, 68);
            this.btnEnable.TabIndex = 1;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = true;
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(250, 262);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(85, 67);
            this.btnDisable.TabIndex = 2;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = true;
            // 
            // frmPicturebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.picbox);
            this.Name = "frmPicturebox";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
    }
}

