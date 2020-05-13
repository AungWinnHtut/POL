using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020051201CS_UI
{
    public partial class frmFileOpen : Form
    {
        public frmFileOpen()
        {
            InitializeComponent();
        }

        private void frmFileOpen_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("data.txt");
            string sData = sr.ReadToEnd();
            txtFile.Text = sData;
        }
    }
}
