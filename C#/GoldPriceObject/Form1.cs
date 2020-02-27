using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldPriceObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalGoldPrice();
        }


        public void CalGoldPrice()
        {
            goldprice gp1 = new goldprice();

            gp1.setk( double.Parse(txtKyat.Text.ToString()));
            gp1.setp(double.Parse(txtPae.Text.ToString()));
            gp1.sety(double.Parse(txtYway.Text.ToString()));
            gp1.setppk ( double.Parse(txtPPK.Text.ToString()));
            
            txtTotal.Text = gp1.caltotalprice().ToString();

            goldprice gp2 = new goldprice(1, 2, 3, 1000000);
            MessageBox.Show(gp2.caltotalprice().ToString());

            goldpiece gpp = new goldpiece();
            gpp.settype("ring");
            MessageBox.Show(gpp.getgtype());

        }
    }

    class goldpiece : goldprice
    {
        string gtype;
        public void settype(string s)
        {
            gtype = s;
        }

        public string getgtype()
        {
            return gtype;
        }
    }


    class goldprice
    {
         double k;
         double p;
         double y;
         double ppk;
         double tp;

        public goldprice()
        {

        }
        public goldprice(double kk, double pp, double yy, double ppkk)
        {
            k = kk;
            p = pp;
            y = yy;
            ppk = ppkk;
        }

        public void setk(double kk)
        {
            k = kk;
        }
        public void setp(double pp)
        {
            p = pp;
        }
        public void sety(double yy)
        {
            y = yy;
        }
        public void setppk(double ppkk)
        {
            ppk = ppkk;
        }

        public double getk()
        {
            return k;
        }

        public double getp()
        {
            return p;
        }
        public double gety()
        {
            return y;
        }
        public double getppk()
        {
            return ppk;
        }


        public double caltotalprice()
        {
            tp = ppk * (k + (p / 16) + (y / 16 / 8));
            return tp;
        }

    }
}
