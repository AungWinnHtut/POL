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
    public partial class frmPhoto : Form
    {
        public frmPhoto()
        {
            InitializeComponent();
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            if(picAlbum .Visible ==true)
            {
                picAlbum.Visible = false;
                btnShow.Text = "Show";
            }
            else
            {
                picAlbum.Visible = true;
                btnShow.Text = "Hide";
            }
        }

        private void frmPhoto_Load(object sender, EventArgs e)
        {
            picAlbum.Visible = true;
            btnShow.Text = "Hide";
        }
    }
}
