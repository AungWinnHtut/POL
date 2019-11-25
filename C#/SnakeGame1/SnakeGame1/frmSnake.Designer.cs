namespace SnakeGame1
{
    partial class frmSnake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnake));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDice = new System.Windows.Forms.Button();
            this.txtDice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnU1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDice
            // 
            this.btnDice.Location = new System.Drawing.Point(594, 98);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(137, 66);
            this.btnDice.TabIndex = 1;
            this.btnDice.Text = "Play";
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // txtDice
            // 
            this.txtDice.Location = new System.Drawing.Point(676, 52);
            this.txtDice.Name = "txtDice";
            this.txtDice.Size = new System.Drawing.Size(55, 26);
            this.txtDice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dice";
            // 
            // btnU1
            // 
            this.btnU1.Location = new System.Drawing.Point(619, 238);
            this.btnU1.Name = "btnU1";
            this.btnU1.Size = new System.Drawing.Size(40, 41);
            this.btnU1.TabIndex = 5;
            this.btnU1.Text = "button1";
            this.btnU1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnU1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDice);
            this.Controls.Add(this.btnDice);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSnake";
            this.Text = "Snake and Ladder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDice;
        private System.Windows.Forms.TextBox txtDice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnU1;
        private System.Windows.Forms.Button button1;
    }
}

