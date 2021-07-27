using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2020061801GHCS_FileIO
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string sFname = txtFname.Text;
            StreamReader sr = new StreamReader(sFname);
            string sText = sr.ReadToEnd();
            txtDoc.Text = sText;
            sr.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string sFname = txtFname.Text;
            StreamWriter sw = new StreamWriter(sFname);
            sw.Write(txtDoc.Text);
            sw.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(ofdFname.ShowDialog()==DialogResult.OK)
            {
                txtFname.Text = ofdFname.FileName;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDoc.Clear();
        }
    }
}
