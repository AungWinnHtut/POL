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

namespace _2020061301GHCS_FileIO
{
    public partial class frmFileIO : Form
    {
        public frmFileIO()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string sFname = txtFname.Text.ToString();
            StreamReader sr = new StreamReader(sFname);
            string data = sr.ReadToEnd();
            //MessageBox.Show(data);
            txtOutput.Text = data;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdFname.Filter = "Data File|*.txt|Pictures|*.jpg";
            if (ofdFname.ShowDialog() == DialogResult.OK)
            {
                string fname = ofdFname.FileName;
                txtFname.Text = fname;
                
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string sPath = System.Environment.GetEnvironmentVariable("Path");
            //txtOutput.Text = sPath;
            string[] strArray = sPath.Split(';');

            foreach(string str in strArray )
            {
                if(str != "")
                {
                    txtOutput.Text = txtOutput.Text + str + Environment.NewLine;
                }                
            }

            lstList.Items.Clear();
            foreach (string str in strArray )
            {
                if (str != "")
                {
                    lstList.Items.Add(str);
                }
            }
        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
           //switch(lstList .SelectedIndex )
           // {
           //     case 0: MessageBox.Show("apple"); break;
           //     case 1: MessageBox.Show("ant"); break;
           //     case 2: MessageBox.Show("arrow"); break;
           //     default: MessageBox.Show("error"); break;
           // }
        }
    }
}
