using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopTest
{
    public partial class Form1 : Form
    {

        string msg = "Hello World";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            test t = new test();
            t.i = 2;
            t.setc('a');
            //MessageBox.Show(t.getcc().ToString ());
            t.name = "aung";
            //MessageBox.Show(t.name);
            MessageBox.Show("I am Aung Win Htut", "Programmer",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
        }
    }

    
}
