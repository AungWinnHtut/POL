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



            cboSelector.Items.Add("Length");
            cboSelector.Items.Add("Temperature");
            cboSelector.Items.Add("Volume");
            cboSelector.SelectedIndex = 0;

            txtU1.Text = "1.0";
            //cboSelector.Text = cboSelector.Items[0].ToString();
        }

        private void cboSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboU1.Items.Clear();
            cboU2.Items.Clear();
            switch (cboSelector.SelectedItem.ToString())
            {
                case "Length":
                    cboU1.Items.Add("meters");
                    cboU1.Items.Add("yards");
                    cboU1.Items.Add("miles");
                    cboU1.SelectedIndex = 0;
                    cboU2.Items.Add("meters");
                    cboU2.Items.Add("yards");
                    cboU2.Items.Add("miles");
                    cboU2.SelectedIndex = 1;
                    break;
                case "Temperature":
                    cboU1.Items.Add("Celsius");
                    cboU1.Items.Add("Fahrenheit");
                    cboU1.Items.Add("Kelvin");
                    cboU1.SelectedIndex = 0;
                    cboU2.Items.Add("Celsius");
                    cboU2.Items.Add("Fahrenheit");
                    cboU2.Items.Add("Kelvin");
                    cboU2.SelectedIndex = 1;
                    break;
                case "Volume":
                    cboU1.Items.Add("litres");
                    cboU1.Items.Add("gallons");
                    cboU1.Items.Add("fluid ounces");
                    cboU1.SelectedIndex = 0;
                    cboU2.Items.Add("litres");
                    cboU2.Items.Add("gallons");
                    cboU2.Items.Add("fluid ounces");
                    cboU2.SelectedIndex = 1;
                    break;
                default: MessageBox.Show("error!"); break;
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



            switch (cboSelector.SelectedItem.ToString())
            {
                case "Length": funConvertLength(); break;
                case "Temperature": funConvertTemperature(); break;
                case "Volume": funConvertVolume(); break;
            }





        }

        public void funConvertLength()
        {
            //txtU1.Text = "1.0";
            double dCoeff = 0.0;
            double dU1 = 0.0;
            double dU2 = 0.0;
            if (double.TryParse(txtU1.Text.ToString(), out dU1))
            {
                if (cboU1.SelectedIndex == cboU2.SelectedIndex)
                {
                    dCoeff = 1;
                }
                else if (cboU1.SelectedIndex == 0)
                {
                    switch (cboU2.SelectedIndex)
                    {
                        case 1: dCoeff = 1.09361; break;
                        case 2: dCoeff = 0.000621371; break;
                    }

                }
                else if (cboU1.SelectedIndex == 1)
                {
                    switch (cboU2.SelectedIndex)
                    {
                        case 0: dCoeff = 1.944; break;
                        case 2: dCoeff = 0.000568182; break;
                    }

                }
                else if (cboU1.SelectedIndex == 2)
                {
                    switch (cboU2.SelectedIndex)
                    {
                        case 0: dCoeff = 1609.34; break;
                        case 1: dCoeff = 1760; break;
                    }

                }

                dU2 = dCoeff * dU1;
                txtU2.Text = dU2.ToString();

                lblFormula.Text = dU2.ToString() + " = " + dCoeff.ToString() + "*" + dU1.ToString();
            }
        }

        public void funConvertTemperature()
        {
            //txtU1.Text = "1.0";
            
            double dU1 = 0.0;
            double dU2 = 0.0;
            
            if (double.TryParse(txtU1.Text.ToString(), out dU1))
            {
                if (cboU1.SelectedIndex == cboU2.SelectedIndex)
                {
                    dU2 = dU1;
                }
                //Tc=(5/9)*(Tf-32)
                //Tf=((9/5)*Tc) + 32
                //Tk=(Tf+459.67)*(5/9)
                //Tk=Tc+273
                else if (cboU1.SelectedIndex == 0)
                {
                    switch (cboU2.SelectedIndex)
                    {
                        case 1: dU2 = ((9.0 / 5.0) * dU1) + 32; break;
                        case 2: dU2 = dU1 + 273.15;  break;
                    }

                }
                else if (cboU1.SelectedIndex == 1)
                {
                    switch (cboU2.SelectedIndex)
                    {
                        case 0: dU2 = (5.0 / 9.0) * (dU1 - 32); break;
                        case 2: dU2 = (dU1 + 459.67) * (5.0 / 9.0); break;
                    }

                }
                else if (cboU1.SelectedIndex == 2)
                {
                    switch (cboU2.SelectedIndex)
                    {
                        case 0: dU2=dU1-273; break;
                        case 1: dU2 = (dU1 * 9.0 / 5.0) - 459.67; break;
                    }

                }

                
                txtU2.Text = dU2.ToString();

                
            }
        }
        public void funConvertVolume()
        {
            //txtU1.Text = "1.0";
            double dCoeff = 0.0;
            double dU1 = 0.0;
            double dU2 = 0.0;
            if (double.TryParse(txtU1.Text.ToString(), out dU1))
            {
                if (cboU1.SelectedIndex == cboU2.SelectedIndex)
                {
                    dCoeff = 1;
                }
                else if (cboU1.SelectedIndex == 0)
                {
                    switch (cboU2.SelectedIndex)
                    {
                        case 1: dCoeff = 0.219969; break;
                        case 2: dCoeff = 33.814; break;
                    }

                }
                else if (cboU1.SelectedIndex == 1)
                {
                    switch (cboU2.SelectedIndex)
                    {
                        case 0: dCoeff = 4.5460869495736; break;
                        case 2: dCoeff = 153.72148731743388339; break;
                    }

                }
                else if (cboU1.SelectedIndex == 2)
                {
                    switch (cboU2.SelectedIndex)
                    {
                        case 0: dCoeff = 0.029573509718661600276; break;
                        case 1: dCoeff = 0.006505262702379758892; break;
                    }

                }

                dU2 = dCoeff * dU1;
                txtU2.Text = dU2.ToString();

                lblFormula.Text = dU2.ToString() + " = " + dCoeff.ToString() + "*" + dU1.ToString();
            }
        }

        private void txtU1_TextChanged(object sender, EventArgs e)
        {

            funUnitConverter();
        }
    }
}
