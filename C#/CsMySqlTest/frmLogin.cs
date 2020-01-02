using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string sUname = txtUname.Text.ToString();
            string sPass = txtPass.Text.ToString();

            string sU = "";
            string sP = "";

            Boolean status = false; //no ok


            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");

            con.Open();

            string query = "SELECT * from student.user_tb";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sU = reader.GetString("uname").ToString();
                sP = reader.GetString("password").ToString();

                if (sU == sUname && sP == sPass)
                {
                    status = true;
                    break;
                }

                
            }

            con.Close();

            if (status)
            {
                //MessageBox.Show("User Login Successfully!");
                frmStudentRegister frmstudentregister = new frmStudentRegister();
                frmstudentregister.Show();
                this.Hide();
                status = false;
            }
            else
            {
                MessageBox.Show("Try Again!");
                txtPass.Clear();
                txtUname .SelectionStart = 0;
                txtUname.SelectionLength = txtUname.Text.Length;
                txtUname.Select();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender,  e);
            }
        }
    }
}

