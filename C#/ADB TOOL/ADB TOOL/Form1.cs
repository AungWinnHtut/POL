using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace ADB_TOOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool ok = false;
        private void button1_Click(object sender, EventArgs e)
        {
            Process adb = new Process();
            adb.StartInfo.FileName = "adb";
            adb.StartInfo.CreateNoWindow = true;
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            adb.StartInfo.RedirectStandardOutput = true;
            adb.StartInfo.RedirectStandardError = true;
            adb.EnableRaisingEvents = false;

            adb.StartInfo.Arguments = "get-state";
            adb.Start();
            adb.WaitForExit();

            string str = "";
            str = adb.StandardOutput.ReadToEnd();
            if (str.Trim().Equals("device"))
            {
                label2.Text = "YES";

            }
            else
            {

                label2.Text = "NO";
            }
            adb.StartInfo.Arguments = "shell getprop ro.product.model";
            adb.Start();
            adb.WaitForExit();
            String model = adb.StandardOutput.ReadToEnd();
            label3.Text = model;

            adb.StartInfo.Arguments = "shell getprop ro.product.device";
            adb.Start();
            adb.WaitForExit();
            String device = adb.StandardOutput.ReadToEnd();
            label6.Text = device;

            adb.StartInfo.Arguments = "shell getprop ro.build.version.release";
            adb.Start();
            adb.WaitForExit();
            String version = adb.StandardOutput.ReadToEnd();
            label8.Text = version;


            adb.StartInfo.Arguments = "shell getprop ro.ril.miui.imei0";
            adb.Start();
            adb.WaitForExit();
            String imei0 = adb.StandardOutput.ReadToEnd();
            label12.Text = imei0;



            adb.StartInfo.Arguments = "shell getprop ro.ril.miui.imei1";
            adb.Start();
            adb.WaitForExit();
            String imei1 = adb.StandardOutput.ReadToEnd();
            label11.Text = imei1;

           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Process adb = new Process();
            adb.StartInfo.FileName = "adb";
            adb.StartInfo.CreateNoWindow = true;
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            adb.StartInfo.Arguments = "reboot";
            adb.Start();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "adb";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            process.StartInfo.Arguments = "reboot recovery";
            process.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process aks = new Process();
            aks.StartInfo.FileName="adb";
            aks.StartInfo.CreateNoWindow=true;
            aks.StartInfo.UseShellExecute=false;
            aks.StartInfo.WorkingDirectory=Directory.GetCurrentDirectory();
            aks.StartInfo.Arguments="reboot bootloader";         
            aks.Start();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process adb = new Process();
            adb.StartInfo.FileName = "adb";
            adb.StartInfo.CreateNoWindow = true;
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            adb.StartInfo.Arguments = "reboot edl";
            adb.Start();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process adb = new Process();
            adb.StartInfo.FileName="adb";
            adb.StartInfo.CreateNoWindow = true;
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            adb.StartInfo.Arguments = "reboot download";
           adb.Start();
        } 
          
    }
}
