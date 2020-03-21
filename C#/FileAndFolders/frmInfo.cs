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

namespace FileAndFolders
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            DirectoryInfo myDir = new DirectoryInfo(txtPath .Text .ToString ());
            FileInfo [] files = myDir.GetFiles();

            foreach (FileInfo f in files)
            {
                txtInfo.Text +=txtPath .Text .ToString ()+ f.Name.ToString()+Environment .NewLine ;
                lstFnames.Items.Add(txtPath.Text.ToString() + f.Name.ToString());
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fold = new FolderBrowserDialog();
            if(fold.ShowDialog() == DialogResult .OK )
            {
                String path = fold.SelectedPath;
                txtPath.Text = path;

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInfo.Text = "";
            lstFnames.Items.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (File.Exists(txtFname .Text .ToString ()))
            {
                MessageBox.Show("File Exist");
            }
            else
            {
                MessageBox.Show("File does not Exist");
            }
        }

        private void lstFnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFnames.SelectedIndex>=0)
            {
                txtFname.Text = lstFnames.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show(lstFnames.SelectedIndex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String sfname = txtFname.Text.ToString();
            try
            {
                File.Delete(sfname);
                MessageBox.Show("File is Deleted : " + sfname);
                int i = lstFnames.SelectedIndex;
                lstFnames.Items.RemoveAt(i);
                lstFnames.SelectedIndex = i;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            int i = 2;
            float f = 4.4f;
            double d = 22.5;

            int j = (int)f;
            int k = Convert.ToInt32(f);
        }
    }
}

//DirectoryInfo
//FileInfo[]
//FileInfo