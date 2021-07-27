using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021070101_CS_HelloWorld
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String sUname = txtUname.Text;
            String sPassword = txtPassword.Text;
            if( (sUname == "ag ag") &&  (sPassword =="123") )
            {
                frmHelloWorld frmhw = new frmHelloWorld();
                frmhw.Show();
                this.Hide();
            }
         }
    }
}
