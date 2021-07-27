using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020060401CS.Hello_World
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sUname = "";
            string sPass = "";

            sUname = txtUname.Text.ToString();
            sPass = txtPass.Text.ToString();

            MessageBox.Show ("Username =  " + sUname + "Password = " + sPass);
        }
    }
}
