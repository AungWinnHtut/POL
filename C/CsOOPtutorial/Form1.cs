using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsOOPtutorial
{
    public partial class Form1 : Form
    {
        public Form1() //Constructor function
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestClass tc1 = new TestClass();
            TestClass t = new TestClass("aung");
            TestClass tc = new TestClass(1,"aung");
            TestClass tc2 = new TestClass(1);

            tc.age = 23;


            tc.setcount();
            MessageBox.Show(tc.getcount().ToString());
            MessageBox.Show(tc2.getcount().ToString());
            MessageBox.Show(tc.getname());
            MessageBox.Show(tc.age.ToString ());
        }
    }

    class TestClass
    {
        private int count;
        string name;

        public int age  // property
        { get; set; }

        public TestClass()
        { }
        public TestClass(int c)
        {
            count = c;
        }
        public TestClass(int c,string s)
        {
            count = c;
            name = s;
        }
        public TestClass(string s)
        {            
            name = s;
        }

        public void setcount()
        {
            count = 4;
        }
        public int getcount()
        {
            return count;
        }
        public string getname()
        {
            return name;
        }
    }



}
