using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
            double l = 0.0;
            double w = 0.0;
            double a = 0.0;
            rectangle1 r11 = new rectangle1();
           

            l = double.Parse(txtLength.Text.ToString());
            w = double.Parse(txtWidth.Text.ToString());

            r11.setl(l);
            r11.setw(w);
            r11.calArea();
            txtArea.Text = r11.geta().ToString();
        }
    }


   

    class rectangle1
    {
         double l;
         double w;
         double a;

        public void setl(double ll)
        {
            l = ll;
        }
        public void setw(double ww)
        {
            w = ww;
        }
        public void seta(double aa)
        {
            a = aa;
        }

        public double getl()
        {
            return l;
        }

        public double getw()
        {
            return w;
        }
        public double geta()
        {
            return a;
        }

        public void calArea()
        {
            a = l * w;            
        }

    }
}
