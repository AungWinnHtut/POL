using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020022601CsTestProj
{
    public partial class frmPhoto : Form
    {
        public frmPhoto()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void btnHidePhoto_Click(object sender, EventArgs e)
        {
            picPhoto.Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            picPhoto.Visible = true;
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if(picPhoto .Visible ==true)
            {
                picPhoto.Visible = false;
                btnControl.Text = "Show Photo";
            }
           else
            {
                picPhoto.Visible = true;
                btnControl.Text = "Hide Photo";
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //webBrowser1.Url = new Uri("www.yahoo.com");
            webBrowser1.Navigate("www.yahoo.com");
        }
    }
}
