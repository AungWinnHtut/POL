using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2019111701CsMenu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void areaOfCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArea formArea = new frmArea();
            formArea.ShowDialog();

        }
    }
}
