﻿using System;
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
    public partial class frmShowAll : Form
    {
        public frmShowAll()
        {
            InitializeComponent();
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            funShowAll();
        }

        private void frmShowAll_Load(object sender, EventArgs e)
        {
            funShowAll();
        }

        public void funShowAll()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from student.student_tb", con);

                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "student_tb");
                DataView dv;
                dv = new DataView(ds.Tables[0], "course = 'C#' ", "course Asc", DataViewRowState.CurrentRows);
                dgvStuData.DataSource = dv; // ds.Tables["student_tb"]; 
                //dgvStuData.Sort(dgvStuData.Columns[1], ListSortDirection.Descending);
                dgvStuData.Columns[5].Visible = false;
                //dgvStuData.Rows[1].Visible = false;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvStuData.DataSource = null;
        }
    }
}

