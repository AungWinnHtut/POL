using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//https://www.dllme.com/getfile.php?file=9566&id=7d70b3192b64539739f5353a4be3da4c

namespace CsMySqlTest
{
    public partial class frmDbase : Form
    {
        public frmDbase()
        {
            InitializeComponent();
        }

        private void btnTestDb_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                MessageBox.Show("connected!");
            }
            con.Close();
         
        }
    }
}
