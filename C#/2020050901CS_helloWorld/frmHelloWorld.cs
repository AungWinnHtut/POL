using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020050901CS_helloWorld
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            frmSecret secretForm = new frmSecret();

            string sUname = "";
            string sPass = "";

            sUname = txtUname.Text.ToString();
            sPass = txtPass.Text.ToString();

            if ( (sUname == "aung") && (sPass =="1234")  )
            {
                MessageBox.Show("Login Correct!");
                secretForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login is not Correct!");
            }


           

        }
    }
}
