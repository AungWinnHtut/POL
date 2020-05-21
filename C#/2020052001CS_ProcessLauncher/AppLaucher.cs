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
using System.IO;
using System.Threading;

namespace _2020052001CS_ProcessLauncher
{
    public partial class AppLaucher : Form
    {
        public AppLaucher()
        {
            InitializeComponent();
        }

        private void btnLauncher_Click(object sender, EventArgs e)
        {
            string strQuery = txtQuery.Text.ToString();
            ////running dos internal command
            //using (Process process = new Process())
            //{
            //    process.StartInfo.FileName = "ipconfig.exe";
            //    process.StartInfo.UseShellExecute = false;
            //    process.StartInfo.RedirectStandardOutput = true;
            //    process.Start();

            //    // Synchronously read the standard output of the spawned process.
            //    StreamReader reader = process.StandardOutput;
            //    string output = reader.ReadToEnd();

            //    // Write the redirected output to this application's window.
            //    txtOutput.Text = output;

            //    process.WaitForExit();
            //}


            Process[] processes = Process.GetProcessesByName("Chrome");
                    
            
            // Loop over processes.
            foreach (Process process in processes)
            {
                txtOutput.Text += process.Id.ToString()+"       " +process.ProcessName+ Environment.NewLine;
            }



        }
    }
}
