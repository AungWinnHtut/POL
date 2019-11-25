using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2019111501CsAreaOfCircle
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

      

        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (picBox.Visible == true)
            {
                picBox.Visible = false;
                btnEnable.Text = "Enable";
            }
            else
            {
                picBox.Visible = true;
                btnEnable.Text = "Disable";
            }
            
        }

       

        private void frmArea_Load(object sender, EventArgs e)
        {
            btnEnable.Text = "Disable";

        }

        public void funHello(String msg,String title)
        {
            MessageBox.Show(msg, title);
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            funHello("You clicked picturebox", "GH");
        }

        private void frmArea_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
