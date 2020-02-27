using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            fileop fop = new fileop();
            datas dd = new datas();
            dd.setss(@"k:\video\SB.mp4");
            dd.setsd(@"d:\SB.mp4");
            Thread fct = new Thread(new ParameterizedThreadStart(fop.fcopy));
            fct.Start(dd);
        }

        class fileop
        {            
            public void fcopy(object s)
            {
                datas ddd = (datas)s;
                File.Copy(ddd.getss(),ddd.getsd());
            }
        }

        class datas
        {
            string s = @"k:\video\HA.mp4";
            string d = @"d:\HA.mp4";
            public string getss()
            {
                return s;
            }

            public string getsd()
            {
                return d;
            }
            
            public void setss(string s1)
            {
                s = s1;
            }
            public void setsd(string d1)
            {
                d = d1;
            }
        }
       
    }
}
