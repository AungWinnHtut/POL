using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020052801HGCS_1_HelloWorld
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
        }

        private void openPhotoAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhoto frmAlbum = new frmPhoto();
            frmAlbum.Show();
        }
    }
}
