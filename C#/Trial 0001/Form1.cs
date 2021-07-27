using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial_0001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            funCalculate();
        }

        private void txtKg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKg_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCalculate.Focus();
                funCalculate();
            }
         }
        private void funCalculate()
        {
            double dKilogram = 0.0;
            double dGram = 0.0;

            dKilogram = double.Parse(txtKg.Text);
            dGram = 1000 * dKilogram;
            txtG.Text = dGram.ToString();
        }
    }
}
