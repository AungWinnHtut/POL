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
    public partial class frmStudentRegister : Form
    {
        public frmStudentRegister()
        {
            InitializeComponent();
        }

        private void frmStudentRegister_Load(object sender, EventArgs e)
        {

        }

        private void frmStudentRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String stuName = txtStuName.Text.ToString();
            String stuPhone = txtStuPhone.Text.ToString();
            String stuAddress = txtStuAddress.Text.ToString();
            String stuGmail = txtStuGmail.Text.ToString();
            String stuCourse = txtStuCourse.Text.ToString();

            if( stuName == "" || stuPhone =="" || stuCourse =="")
            {
                MessageBox.Show("Please Check Your Input!");
                txtStuName.Focus();
            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                    con.Open();

                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO student.student_tb(student_name,student_phone,student_address,student_gmail,course) " +
                        "VALUES (@stuname,@stuphone,@stuadd,@stugmail,@stucourse)";
                    cmd.Parameters.AddWithValue("@stuname", stuName);
                    cmd.Parameters.AddWithValue("@stuphone", stuPhone);
                    cmd.Parameters.AddWithValue("@stuadd", stuAddress );
                    cmd.Parameters.AddWithValue("@stugmail", stuGmail);
                    cmd.Parameters.AddWithValue("@stucourse", stuCourse );

                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    if (result>0)
                    {
                        MessageBox.Show("Student Register!");
                        txtStuName.Clear();
                        txtStuPhone.Clear();
                        txtStuGmail.Clear();
                        txtStuAddress.Clear();
                        txtStuCourse.Clear();
                        txtStuName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
