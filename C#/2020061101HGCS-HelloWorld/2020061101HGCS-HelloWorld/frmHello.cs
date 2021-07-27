using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020061101HGCS_HelloWorld
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void frmHello_Load(object sender, EventArgs e)
        {
            MessageBox.Show("HelloWord");
            

        }
    }
}
