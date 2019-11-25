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
    public partial class frmLogin : Form
    {
        int counter = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String sUname = "";
            String sPass = "";
            

            frmArea varFrmArea = new frmArea();

            sUname = txtUname.Text.ToString();
            sPass = txtPass.Text.ToString();

            if (sUname == "aung" && sPass == "1234")
            {
                varFrmArea.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Uname or Pass", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = "";
                txtUname.Text = "";
                txtUname.Focus();
                counter++;
                if (counter >= 3)
                {
                    Application.Exit();
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
