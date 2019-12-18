using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2019121401CsRuHelloWorld
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            this.Text = "Hello World";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Text = "Green Hackers";
        }

        private void btnHide_Click(object sender, EventArgs e)
        {

            if (picGf.Visible == true)
            {
                picGf.Visible = false;
                btnHide.Text = "Show";
            }
            else
            {
                picGf.Visible = true;
                btnHide.Text = "Hide";
            }

          

        }

        private void frmHello_Load(object sender, EventArgs e)
        {
            if (picGf.Visible == true)
            {
                btnHide.Text = "Hide";
            }
            else
            {
                btnHide.Text = "Show";
            }
        }

    
    }
}
