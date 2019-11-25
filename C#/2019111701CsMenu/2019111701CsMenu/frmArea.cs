using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2019111701CsMenu
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            float fRadius = 0;
            double fArea = 0;
    
          // float.TryParse(txtRadius .Text.ToString () ,out fRadius );
            //
            try
            {
                fRadius = float.Parse(txtRadius.Text.ToString());
                fArea = 3.14 * fRadius * fRadius;
                txtArea.Text = fArea.ToString();
            }
            catch
            {
                MessageBox.Show("wrong input");
                txtRadius.Text = "";
                txtRadius.Focus();
            }

        }
    }
}
