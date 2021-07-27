using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021070101_CS_HelloWorld
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {

            funHello(txtName .Text );
         }

        private void frmHelloWorld_Load(object sender, EventArgs e)
        {

        }

        private void frmHelloWorld_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        // y       =                     f(x)                 =    2x
        // name = depends on input x - fun of x =    function definition
        // X  --f(x)--> Y
        // output function(inputs..)
        // size(data type)  fun_name(size , size, size)
        // A = 3.1415 * r * r; (input r (min, max)->datatype, output A(min, max)->size)
       // Output   Input
       //     1         1
       //     1          0
       //     0          1
       //     0          0
        //function definition
        public double funAreaOfCircle(double r) // header
        {
            double A;
            A = 3.14 * r * r;
            return A;
        }

        private void btnSayHello2_Click(object sender, EventArgs e)
        {
            funHello(txtName .Text );
        }

        private void funHello(String sName)
        {          
            MessageBox.Show("Hello " + sName, "Green Hackers", MessageBoxButtons.YesNoCancel);
        }
    }
}
