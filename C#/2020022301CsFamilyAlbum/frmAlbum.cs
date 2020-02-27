using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020022301CsFamilyAlbum
{
    public partial class frmAlbum : Form
    {
        public frmAlbum()
        {
            InitializeComponent();
        }

        private void btnAWH_Click(object sender, EventArgs e)
        {
            this.Text = "Family Album - Aung Win Htut";
            picAlbum.Image = Image.FromFile(@"d:\c\pic\awh.jpg");
        }

        private void btnKKL_Click(object sender, EventArgs e)
        {
            this.Text = "Family Album - Kaung Kaung Latt";
        }

        private void btnPyone_Click(object sender, EventArgs e)
        {
            this.Text = "Family Album - PYone";
            picAlbum.Image = Image.FromFile(@"d:\c\pic\Pyone.jpg");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            picAlbum.Visible = false;
        }
    }
}
