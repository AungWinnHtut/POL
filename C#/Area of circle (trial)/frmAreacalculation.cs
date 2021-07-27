using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_of_circle__trial_
{
    public partial class frmAreacalculation : Form
    {
        public frmAreacalculation()
        {
            InitializeComponent();
        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            funCalculate();
        }

        private void txtRadius_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter)
            {
                btnCalculate.Focus();
                funCalculate();
            }
        }
        private void funCalculate()
        {
            double dRadius = 0.0;
            double dArea = 0.0;

            dRadius = double.TryParse(txtRadius.Text);
            dArea = dRadius * 3.142 * dRadius * dRadius;
            txtArea.Text = dArea.ToString();
        }
    }
}
