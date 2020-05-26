using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020052501CS_HW1_TimeAndDelay
{
    public partial class frmMsgBox : Form
    {
        public string sMsg="";
        public string sTitle = "";
        public frmMsgBox()
        {
            InitializeComponent();
        }
        public frmMsgBox(string Info)
        {
            InitializeComponent();
            sMsg = Info;
        }
        public frmMsgBox(string Title, string Info)
        {
            InitializeComponent();
            sMsg = Info;
            sTitle = Title;
        }

        private void frmMsgBox_Load(object sender, EventArgs e)
        {
            txtMsg.Text = sMsg;
            this.Text = sTitle;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
