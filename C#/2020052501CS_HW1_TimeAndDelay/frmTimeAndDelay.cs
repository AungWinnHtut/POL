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
    public partial class frmTimeAndDelay : Form
    {
        private int iStartTimeH = 7;
        private int iStartTimeM = 50;

        private int iEndTimeH = 0;
        private int iEndTimeM = 0;

        private int iDelayH = 0;
        private int iDelayM = 30;

        private int iCarry = 0;
        private bool bAM = true;

       
        string sQuestion1 = "သဇင္ေက်ာင္းသြားဖို႔ ";
        string sQuestion2 = " မနက္ ";
        //starttime
        string sQuestion3 = " မွာ အိမ္က ထြက္တယ္။ ";

        string sQuestion4 = "ေက်ာင္းကိုေရာက္ဖို႔ ";
        //delay
        string sQuestion5 = " ၾကာတယ္။ ";

        string sQuestion6 = "ဘယ္အခ်ိန္ သူ ေက်ာင္းကို ေရာက္မလဲ။";

        public frmTimeAndDelay()
        {
            InitializeComponent();
        }

        private void frmTimeAndDelay_Load(object sender, EventArgs e)
        {
            txtQ1.Text  = sQuestion1 + sQuestion2 +iStartTimeH +" နာရီ  "+ iStartTimeM + " မိနစ္"+ sQuestion3 ;
            txtQ2.Text = sQuestion4 + iDelayH + " နာရီ  " + iDelayM + " မိနစ္" + sQuestion5;
            txtQ3.Text = sQuestion6;
            txtSH.Text = iStartTimeH.ToString();
            txtSM.Text = iStartTimeM.ToString();

            txtDH.Text = iDelayH.ToString();
            txtDM.Text = iDelayM.ToString();

            iCarry = 0;
            iEndTimeM = iStartTimeM + iDelayM;
            if(iEndTimeM >=60)
            {
                iCarry = 1;
                iEndTimeM = iEndTimeM - 60;
            }
            iEndTimeH = iStartTimeH + iDelayH + iCarry;
            if(iEndTimeH >12)
            {
                bAM = false;
                iEndTimeH = iEndTimeH - 12;
            }
            

        }

        private void picUI_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int iAnsH = int.Parse(txtEH.Text.ToString());
            int iAnsM = int.Parse(txtEM.Text.ToString());

            if (iAnsH > 12)
            {
                MessageBox.Show("The Answer must be in 12 hour format! Pls Try Again!");
                txtEH.SelectAll();
            }
            else
            {
                if ((bAM == true) && (rdoAM.Checked == true) || (bAM == false) && (rdoPM.Checked == true))
                {
                    if (iEndTimeH == iAnsH && iEndTimeM == iAnsM)
                    {
                        MessageBox.Show("အေျဖမွန္ပါတယ္။ ဂုဏ္ယူပါတယ္။");
                    }
                    else
                    {
                        MessageBox.Show(" Pls Try Again!");
                        txtEH.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show(" Pls Try Again!");                    
                }
            }
        }
    }
}
