namespace _2020030101CsMediaPlayer
{
    partial class frmPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayer));
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPlay2 = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.lstPlayList = new System.Windows.Forms.ListBox();
            this.btnPlaylist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // wmp
            // 
            this.wmp.Dock = System.Windows.Forms.DockStyle.Left;
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 0);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(525, 494);
            this.wmp.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(543, 20);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(426, 60);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPlay2
            // 
            this.btnPlay2.Location = new System.Drawing.Point(543, 86);
            this.btnPlay2.Name = "btnPlay2";
            this.btnPlay2.Size = new System.Drawing.Size(426, 60);
            this.btnPlay2.TabIndex = 2;
            this.btnPlay2.Text = "Play2";
            this.btnPlay2.UseVisualStyleBackColor = true;
            this.btnPlay2.Click += new System.EventHandler(this.btnPlay2_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // lstPlayList
            // 
            this.lstPlayList.FormattingEnabled = true;
            this.lstPlayList.ItemHeight = 20;
            this.lstPlayList.Location = new System.Drawing.Point(543, 152);
            this.lstPlayList.Name = "lstPlayList";
            this.lstPlayList.ScrollAlwaysVisible = true;
            this.lstPlayList.Size = new System.Drawing.Size(426, 244);
            this.lstPlayList.TabIndex = 3;
            this.lstPlayList.SelectedIndexChanged += new System.EventHandler(this.lstPlayList_SelectedIndexChanged);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Location = new System.Drawing.Point(543, 413);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(426, 48);
            this.btnPlaylist.TabIndex = 4;
            this.btnPlaylist.Text = "Add PL";
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 494);
            this.Controls.Add(this.btnPlaylist);
            this.Controls.Add(this.lstPlayList);
            this.Controls.Add(this.btnPlay2);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.wmp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlayer";
            this.Text = "GH Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPlay2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ListBox lstPlayList;
        private System.Windows.Forms.Button btnPlaylist;
    }
}

