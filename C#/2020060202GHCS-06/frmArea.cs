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
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dRadius = 0.0;
            double dArea = 0.0;

           dRadius  =  double.Parse (txtRadius.Text);
            dArea = 3.14 * dRadius * dRadius;
            //MessageBox.Show(dArea.ToString());
            txtArea.Text = dArea.ToString ();

        }
    }
}
