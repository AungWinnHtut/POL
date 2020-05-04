using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_rev1
{
    public partial class frmTest1 : Form
    {
        public frmTest1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            txtDouble.Text= double.MaxValue .ToString();
            txtInt.Text = int.MaxValue.ToString();
            MessageBox.Show(sw.Elapsed.TotalMilliseconds.ToString ());
            sw.Stop();
        }
    }
}
