using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace _2020030101CsMediaPlayer
{
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string vPath = "";
            ofd.InitialDirectory = "d:\\";
            ofd.Filter ="video files (*.mp4)|*.mp4|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                vPath = ofd.FileName;
                wmp.URL = vPath;
            }
            else
            {
                MessageBox.Show("you chose to cancel");
            }
        }

        private void btnPlay2_Click(object sender, EventArgs e)
        {
            string filepath = @"K:\musics\g.mp4";
            bool ans=false;
            ans = File.Exists(filepath);
            if (ans) 
            {
                wmp.URL =filepath;
            }
            else
            {
                MessageBox.Show("Wrong File Path or name!");
            }

            
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            string vPath = "";
            ofd.InitialDirectory = "k:\\musics\\";
            ofd.Filter = "video files (*.mp4)|*.mp4|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                vPath = ofd.FileName;
                lstPlayList.Items.Add(vPath.ToString());
            }
        }

        private void lstPlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = lstPlayList.SelectedItem.ToString();
            wmp.URL = path;
        }
    }
}
