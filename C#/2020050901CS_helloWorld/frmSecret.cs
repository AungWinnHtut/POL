using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020050901CS_helloWorld
{
    public partial class frmSecret : Form
    {
        public frmSecret()
        {
            InitializeComponent();
        }

        private void frmSecret_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
