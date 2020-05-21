using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _2020052101CS_7zip
{
    public partial class frm7zip : Form
    {

        private string sType = "7z";
        private string sFname = "Archive";
        private string sFullname = "Archive.7z";
        private string sPassword = "Password";

        public frm7zip()
        {
            InitializeComponent();
        }

        private void btnZip_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "7za.exe";
            psi.Arguments = "a -t"+sType +" "+sFname +" *.txt -p"+sPassword ;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            Process p = Process.Start(psi);
            string sOut= p.StandardOutput.ReadToEnd();
            txtOutput.Text = sOut;
            txtOutput.Enabled = true;
            p.WaitForExit();
        }

        private void btnUnzip_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "7za.exe";
            psi.Arguments = "e "+sFullname +" -p"+sPassword +" -y";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            Process p = Process.Start(psi);
            string sOut = p.StandardOutput.ReadToEnd();
            txtOutput.Text = sOut;
            txtOutput.Enabled = true;
            p.WaitForExit();
        }

        private void frm7zip_Load(object sender, EventArgs e)
        {
            txtFname.Text = sFname;
            sFullname = sFname + "." + sType;
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            sType = cboType.SelectedItem.ToString();

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            sFname = txtFname.Text.ToString();
            sFullname = sFname + "." + sType;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sPassword = txtPassword.Text.ToString();
        }
    }
}
