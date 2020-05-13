using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020051201CS_UI
{
    public partial class frmFileOpen : Form
    {
        public frmFileOpen()
        {
            InitializeComponent();
        }

        private void frmFileOpen_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string sFname = txtFname.Text.ToString();

            if(File.Exists (sFname ))
            {
                StreamReader sr = new StreamReader(sFname);
                string sData = sr.ReadToEnd();
                txtFile.Text = sData;
            }
            else
            {
                MessageBox.Show("Error no such file!");
                txtFname.Focus();          //to focus the object first  needed!!
                txtFname.SelectAll();      
            }

            
        }
    }
}
