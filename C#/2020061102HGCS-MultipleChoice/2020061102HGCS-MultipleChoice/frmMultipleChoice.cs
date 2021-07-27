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

namespace _2020061102HGCS_MultipleChoice
{
    public partial class frmMultipleChoice : Form
    {
        private string[] sQuestions=new string[3];
        private int i;
        private int current_question;
        private int total_line;

        public frmMultipleChoice()
        {
            InitializeComponent();
        }

        private void btnDice_Click(object sender, EventArgs e)
        {
            int iDice = 0;
            Random dice = new Random();
            iDice = dice.Next(1, 7);
            txtDice.Text = iDice.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           if(current_question <total_line )
            {
                string[] sParts = new string[5];
                sParts = sQuestions[current_question].Split(';');
                current_question++;

                string pic_address = sParts[0];
                string ans1 = sParts[1];
                string ans2 = sParts[2];
                string ans3 = sParts[3];
                string real_ans = sParts[4];

                picQuestion.Image = Image.FromFile(pic_address);
                rdo1.Text = ans1;
                rdo2.Text = ans2;
                rdo3.Text = ans3;

            }
        }

        private void frmMultipleChoice_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("question.txt");
            Random ran = new Random();
            i = 0;
            int k = 0;
            string temp;
            string buffer = "";
            while(sr.Peek ()>0)
            {
                buffer = sr.ReadLine();
                if(buffer != "")
                {
                    sQuestions[i] = buffer;
                    i++;
                }
                
            }

            total_line = i;

            for(int j=0;j< total_line; j++)
            {
                do
                {
                    k = ran.Next(0, total_line);
                } while (k == j);

                temp = sQuestions[j];
                sQuestions[j] = sQuestions[k];
                sQuestions[k]=temp;

            }

            current_question = 0;
            string[] sParts = new string[5];
            sParts = sQuestions[current_question].Split(';');
            current_question++;
            string path = Directory.GetCurrentDirectory();
            string pic_address = path + "\\" + sParts[0];
            string ans1 = sParts[1];
            string ans2 = sParts[2];
            string ans3 = sParts[3];
            string real_ans = sParts[4];

            picQuestion.Image = Image.FromFile(pic_address);
            rdo1.Text = ans1;
            rdo2.Text = ans2;
            rdo3.Text = ans3;

            //test

        }
    }
}
