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
    public partial class frmSearchByTitle : Form
    {
        MySqlDataAdapter adapter2;


        public frmSearchByTitle()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String txt = txtPhone.Text.ToString();
            funSearchByTitle(txt, title_selected);
        }
       
        public void funSearchByTitle(String txt, int title)
        {
           
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");             
                switch (title)
                {
                    case 0: adapter2 = new MySqlDataAdapter("Select * from student.student_tb where student_id like " + txt , con); 
                            break;
                    case 1: adapter2 = new MySqlDataAdapter("Select * from student.student_tb where student_name like '" + txt + "'", con); 
                            break;
                    case 2: adapter2 = new MySqlDataAdapter("Select * from student.student_tb where student_phone like '" + txt + "'", con);
                            break;
                    case 3: adapter2 = new MySqlDataAdapter("Select * from student.student_tb where student_address like '" + txt + "'", con);
                            break;
                    case 4: adapter2 = new MySqlDataAdapter("Select * from student.student_tb where student_gmail like '" + txt + "'", con);
                            break;
                    case 5: adapter2 = new MySqlDataAdapter("Select * from student.student_tb where course like '" + txt + "'", con);
                            break;
                }              

                con.Open();
                DataSet ds = new DataSet();
                adapter2.Fill(ds, "student_tb");
                dataGridView1.DataSource = ds.Tables[0]; //ds.Tables["user_tb"]; 
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Update with variable parameters
        // 1-Connection String
        // 2-MySqlConnection
        // 3-Connection Open
        // 4-Query String with variable parameters @uname
        // 5-MySqlCommand
        // 6-Query -> CommandText
        // 7-Parameters.AddWithValue("@uname", user)
        // 8-Connection
        // 9-ExecuteNonQuery
        // 10-Connection Close
        public void funUpdatePassword(String user,String pass)
        {

            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                con.Open();             
                   
                string query = "UPDATE student.user_tb SET password=@password WHERE uname =@uname";               
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@uname", user);
                cmd.Parameters.AddWithValue("@password", pass);                                  
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Success!");       

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        int title_selected = 0;
      

        private void cboTitle_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtPhone.SelectAll();
            txtPhone.Focus();
            switch (cboTitle.SelectedIndex)
            {
                case 0: title_selected = 0; lblTitle.Text = "Student ID"; break;
                case 1: title_selected = 1; lblTitle.Text = "Student Name"; break;
                case 2: title_selected = 2; lblTitle.Text = "Student Phone"; break;
                case 3: title_selected = 3; lblTitle.Text = "Student Address"; break;
                case 4: title_selected = 4; lblTitle.Text = "Student Gmail"; break;
                case 5: title_selected = 5; lblTitle.Text = "Course"; break;

            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String user = txtUser.Text.ToString();
            String pass = txtPassword.Text.ToString();
            funUpdatePassword(user, pass);
        }
    }
}
