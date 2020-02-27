using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace _2020022701CsSystemInfo
{
    public partial class Form1 : MetroFramework .Forms.MetroForm 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            DateTime mydt = new DateTime(1978, 2, 19);
            DateTime noww = DateTime.Now;

            TimeSpan myAge = DateTime.Now.Subtract(mydt);
            MessageBox.Show(myAge.Days.ToString());

            //ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\WMI","SELECT * FROM MSSerial_PortName");
            //foreach (ManagementObject mo in mos.Get ())
            //{
            //    txtOut.Text += mo.ToString() + Environment.NewLine;
            //}

            //IDictionary environmentVariables = Environment.GetEnvironmentVariables();
            //foreach (DictionaryEntry de in environmentVariables)
            //{
            //    txtOut .Text += de.Key+"======="+ de.Value+Environment.NewLine + Environment.NewLine;
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float cpu = pc.NextValue();
            metroProgressBar1.Value = (int)cpu;
            label1.Text = string.Format("{0:0.00}%", cpu);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
