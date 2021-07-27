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

namespace _2020061802HGCS_Tools3
{
    public partial class frmTools3 : Form
    {
        public frmTools3()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstView.Items.Remove(lstView.SelectedItems[0]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lstItem = new ListViewItem("Aung Win Htut");
            
            lstItem.SubItems.Add("0933333");

            lstView.Items.Add(lstItem);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true })
            {
                if(ofd.ShowDialog() ==DialogResult.OK)
                {
                    foreach (string fname in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(fname);
                        ListViewItem lstItem = new ListViewItem(fi.Name);
                        lstItem.SubItems.Add(fi.FullName);
                        lstItem.SubItems.Add(fi.CreationTime.ToString ());

                        lstView.Items.Add(lstItem);
                    }
                }
            }
        }
    }
}
