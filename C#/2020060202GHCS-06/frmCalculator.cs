using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020060202GHCS_06
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            txtHello.Text = "";
            lblHello.Text = "";
           string sName = txtName.Text;
            MessageBox.Show("Hello "+sName );
            lblHello.Text = "Hello " + sName;
            txtHello .Text = "Hello " + sName;
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            txtHello.Text = "";
            lblHello.Text = "";
        }
    }
}
