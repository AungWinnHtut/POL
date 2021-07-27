using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020052801HGCS_1_HelloWorld
{
    public partial class frmVideo : Form
    {
        public frmVideo()
        {
            InitializeComponent();
        }

        private void frmVideo_Load(object sender, EventArgs e)
        {
            wmp.settings.autoStart = false;
            wmp.URL =@"d:\exercises.mp4";
            
            
        }
    }
}
