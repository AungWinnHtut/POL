using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020051201CS_UI
{
    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();
        }

        private void frmConverter_Load(object sender, EventArgs e)
        {
            cboSelector.SelectedIndex = 0;
            //cboSelector.Text = cboSelector.Items[0].ToString();
        }

        private void cboSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSelector .SelectedItem.ToString ()=="Length")
            {
                cboU1.Items.Add("meters");
                cboU1.Items.Add("yards");
                cboU1.Items.Add("miles");
                cboU1.SelectedIndex = 0;

                cboU2.Items.Add("meters");
                cboU2.Items.Add("yards");
                cboU2.Items.Add("miles");
                cboU2.SelectedIndex = 1;
            }
        }

        private void cboU1_SelectedIndexChanged(object sender, EventArgs e)
        {
            funUnitConverter();
        }

        private void cboU2_SelectedIndexChanged(object sender, EventArgs e)
        {
            funUnitConverter();
        }

        public void funUnitConverter()
        {
            //txtU1.Text = "1.0";
            double dCoeff = 0.0;
            double dU1 = 0.0;
            double dU2 = 0.0;

            if(double.TryParse (txtU1 .Text .ToString (),out dU1))
            {
                if (cboU1.SelectedIndex == cboU2.SelectedIndex)
                {
                    dCoeff = 1;
                }
                else if (cboU1.SelectedIndex == 0)
                {
                    if (cboU2.SelectedIndex == 1)
                    {
                        dCoeff = 1.09361;
                    }
                    else if (cboU2.SelectedIndex == 2)
                    {
                        dCoeff = 0.000621371;
                    }
                }
                else if (cboU1.SelectedIndex == 1)
                {
                    if (cboU2.SelectedIndex == 0)
                    {
                        dCoeff = 1.944;
                    }
                    else if (cboU2.SelectedIndex == 2)
                    {
                        dCoeff = 0.000568182;
                    }
                }
                else if (cboU1.SelectedIndex == 2)
                {
                    if (cboU2.SelectedIndex == 0)
                    {
                        dCoeff = 1609.34;
                    }
                    else if (cboU2.SelectedIndex == 1)
                    {
                        dCoeff = 1760;
                    }
                }

                dU2 = dCoeff * dU1;
                txtU2.Text = dU2.ToString();

                lblFormula.Text = dU2.ToString () + " = " + dCoeff.ToString() + "*" + dU1.ToString ();
            }

           
        }

        private void txtU1_TextChanged(object sender, EventArgs e)
        {
            funUnitConverter();
        }
    }
}
