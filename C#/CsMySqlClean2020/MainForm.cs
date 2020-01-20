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

        // 1-Connection String
        // 2-MySqlConnection
        // 3-MySqlDataAdapter
        // 4-Con open
        // 5-DataSet
        // 6-adapter,table -> Dataset
        // 7-Dataset,table[index] -> dataGridView,DataSource
        private void btnConnect_Click(object sender, EventArgs e)
        {
            String srv = "localhost";
            String dbname = "student";
            String tbname = "user_tb";
            String uname = "root";
            String pass = "";
            String port = "3306";
            String query = "Select * from '"+dbname+"'.'"+tbname+"'";
            

            GHdatabase ghd = new GHdatabase(srv, dbname, uname, pass,port);
            DataTable dt = new DataTable();
            dt = ghd.funSELECT(query,tbname );

            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Query Error");
            }
            
           
        }

        //To clear Datagridview, set Datasource to ""
        private void btnClose_Click(object sender, EventArgs e)
        {              
            dataGridView1.DataSource = "";
            

        }



        // Test whether data exists!
        // 1-Connection String
        // 2-MySqlConnection
        // 3-Query String
        // 4-MySqlCommand
        // 5-MySqlDataReader -> ExecuteReader
        // 6-Getting each row of data by while loop and reader.Read ()
        // 7-Getting desired colunm by reader.GetString("uname") or reader.GetInt("id"), etc
        private void btnRead_Click(object sender, EventArgs e)
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
            MySqlDataReader reader = cmd.ExecuteReader();  //id uname password

            while(reader.Read ())
            {
                sU = reader.GetString("uname").ToString();
                sP = reader.GetString("password").ToString();

                //Checking user name and password
                if(sU == sUname && sP == sPass )
                {
                    status = true;  //found password
                    //break;        //to immediate exit from testing
                }

                //How to add combo box element
                cboUname.Items.Add(sU);
                cboPass .Items.Add(sP);                
            }
            con.Close();

            //Default selection of combobox item
            cboUname.SelectedIndex = 0;
            cboPass.SelectedIndex = 0;

            //check status whether login success or not
            if (status)
            {
                MessageBox.Show ("User Login Successfully!");
                status = false;
            }
            else
            {
                MessageBox.Show("Try Again!");
            }

        }

        private void cipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCipher frmcipher = new frmCipher();
            frmcipher.Show();
        }

        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBrowser frmbrowser = new frmBrowser();
            frmbrowser.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            frmlogin.Show();
        }

        private void searchByTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchByTitle frmsearchbytitle = new frmSearchByTitle();
            frmsearchbytitle.Show();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowAll frmshowall = new frmShowAll();
            frmshowall.Show();
        }

        private void studentRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentRegister frmstudentregister = new frmStudentRegister();
            frmstudentregister.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
