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
using System.Diagnostics;

namespace _2020051201CS_UI
{
    public partial class frmUi : Form
    {
        public frmUi()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            funCalArea();
        }

        private void txtRadius_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter )
            {
                funCalArea();
            }
        }

        private void funCalArea()
        {
           
            double dRadius = 0.0;
            double dArea = 0.0;

            if (double.TryParse(txtRadius.Text.ToString(), out dRadius))
            {
                StreamWriter sw = new StreamWriter("data.txt", true);
                dArea = 3.14 * dRadius * dRadius;
                txtArea.Text = dArea.ToString();
                sw.WriteLine(dRadius .ToString ()+","+dArea .ToString ());
                sw.Close();
                txtRadius.SelectAll();
            }
            else
            {
                MessageBox.Show("Not valid double format input!");
                txtRadius.SelectAll();
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //Process.Start("notepad.exe","data.txt");
            frmFileOpen fileOpenForm = new frmFileOpen();
            fileOpenForm.ShowDialog();
        }
    }
}
