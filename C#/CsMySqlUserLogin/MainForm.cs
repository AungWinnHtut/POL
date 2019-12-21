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
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
           
            
          try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from student.user_tb", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "user_tb");
                dataGridView1.DataSource = ds.Tables[0]; //ds.Tables["user_tb"]; 
                con.Close();
             
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {              
            dataGridView1.DataSource = "";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string sUname = txtUname.Text.ToString();
            string sPass = txtPass.Text.ToString();

            string sU = "";
            string sP = "";

            Boolean status = false ; //no ok


            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
            con.Open();
            string query = "SELECT * from student.user_tb";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read ())
            {
                sU = reader.GetString("uname").ToString();
                sP = reader.GetString("password").ToString();

                if(sU == sUname && sP == sPass )
                {
                    status = true;
                }

                cboUname.Items.Add(sU);
                cboPass .Items.Add(sP);                
            }
            con.Close();

            if(status)
            {
                MessageBox.Show ("User Login Successfully!");
                status = false;
            }
            else
            {
                MessageBox.Show("Try Again!");
            }

        }
    }
}
