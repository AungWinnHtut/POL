namespace PlayingCard1
{
    partial class frmThreeCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThreeCard));
            this.picD1 = new System.Windows.Forms.PictureBox();
            this.picD2 = new System.Windows.Forms.PictureBox();
            this.picD3 = new System.Windows.Forms.PictureBox();
            this.picP3 = new System.Windows.Forms.PictureBox();
            this.picP2 = new System.Windows.Forms.PictureBox();
            this.picP1 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtDscore = new System.Windows.Forms.TextBox();
            this.txtPscore = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picW = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnScoreBoard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picW)).BeginInit();
            this.SuspendLayout();
            // 
            // picD1
            // 
            this.picD1.Location = new System.Drawing.Point(25, 32);
            this.picD1.Name = "picD1";
            this.picD1.Size = new System.Drawing.Size(136, 162);
            this.picD1.TabIndex = 0;
            this.picD1.TabStop = false;
            // 
            // picD2
            // 
            this.picD2.Location = new System.Drawing.Point(188, 32);
            this.picD2.Name = "picD2";
            this.picD2.Size = new System.Drawing.Size(136, 162);
            this.picD2.TabIndex = 1;
            this.picD2.TabStop = false;
            // 
            // picD3
            // 
            this.picD3.Location = new System.Drawing.Point(352, 32);
            this.picD3.Name = "picD3";
            this.picD3.Size = new System.Drawing.Size(136, 162);
            this.picD3.TabIndex = 2;
            this.picD3.TabStop = false;
            // 
            // picP3
            // 
            this.picP3.Location = new System.Drawing.Point(352, 235);
            this.picP3.Name = "picP3";
            this.picP3.Size = new System.Drawing.Size(136, 162);
            this.picP3.TabIndex = 5;
            this.picP3.TabStop = false;
            // 
            // picP2
            // 
            this.picP2.Location = new System.Drawing.Point(188, 235);
            this.picP2.Name = "picP2";
            this.picP2.Size = new System.Drawing.Size(136, 162);
            this.picP2.TabIndex = 4;
            this.picP2.TabStop = false;
            // 
            // picP1
            // 
            this.picP1.Location = new System.Drawing.Point(25, 235);
            this.picP1.Name = "picP1";
            this.picP1.Size = new System.Drawing.Size(136, 162);
            this.picP1.TabIndex = 3;
            this.picP1.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(25, 416);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(185, 47);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtDscore
            // 
            this.txtDscore.Location = new System.Drawing.Point(613, 401);
            this.txtDscore.Name = "txtDscore";
            this.txtDscore.Size = new System.Drawing.Size(100, 26);
            this.txtDscore.TabIndex = 7;
            // 
            // txtPscore
            // 
            this.txtPscore.Location = new System.Drawing.Point(613, 438);
            this.txtPscore.Name = "txtPscore";
            this.txtPscore.Size = new System.Drawing.Size(100, 26);
            this.txtPscore.TabIndex = 8;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(303, 416);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(185, 47);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dealer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Scores";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dealer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Player";
            // 
            // picW
            // 
            this.picW.Image = ((System.Drawing.Image)(resources.GetObject("picW.Image")));
            this.picW.Location = new System.Drawing.Point(525, 32);
            this.picW.Name = "picW";
            this.picW.Size = new System.Drawing.Size(188, 199);
            this.picW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picW.TabIndex = 15;
            this.picW.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // btnScoreBoard
            // 
            this.btnScoreBoard.Location = new System.Drawing.Point(525, 246);
            this.btnScoreBoard.Name = "btnScoreBoard";
            this.btnScoreBoard.Size = new System.Drawing.Size(185, 122);
            this.btnScoreBoard.TabIndex = 16;
            this.btnScoreBoard.Text = "ScoreBoard";
            this.btnScoreBoard.UseVisualStyleBackColor = true;
            this.btnScoreBoard.Click += new System.EventHandler(this.btnScoreBoard_Click);
            // 
            // frmThreeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 473);
            this.Controls.Add(this.btnScoreBoard);
            this.Controls.Add(this.picW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.txtPscore);
            this.Controls.Add(this.txtDscore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picP3);
            this.Controls.Add(this.picP2);
            this.Controls.Add(this.picP1);
            this.Controls.Add(this.picD3);
            this.Controls.Add(this.picD2);
            this.Controls.Add(this.picD1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThreeCard";
            this.Text = "frmThreeCard";
            this.Load += new System.EventHandler(this.frmThreeCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picD1;
        private System.Windows.Forms.PictureBox picD2;
        private System.Windows.Forms.PictureBox picD3;
        private System.Windows.Forms.PictureBox picP3;
        private System.Windows.Forms.PictureBox picP2;
        private System.Windows.Forms.PictureBox picP1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtDscore;
        private System.Windows.Forms.TextBox txtPscore;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picW;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnScoreBoard;
    }
}