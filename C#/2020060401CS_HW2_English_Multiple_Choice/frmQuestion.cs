using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020060401CS_HW2_English_Multiple_Choice
{
    public partial class frmQuestion : Form
    {
        private string sCorrectAnswer;
        private int iMarks = 0;
        public frmQuestion()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(rdoAns1 .Checked ==true)
            {
                if (rdoAns1.Text == sCorrectAnswer )
                {
                    MessageBox.Show("Correct Answer");
                    iMarks++;
                }
                else
                {
                    MessageBox.Show("Wrong Answer");
                }
            }
            else if(rdoAns2 .Checked ==true)
            {
                if (rdoAns2.Text == sCorrectAnswer)
                {
                    MessageBox.Show("Correct Answer");
                    iMarks++;
                }
                else
                {
                    MessageBox.Show("Wrong Answer");
                }
            }
            else if(rdoAns3.Checked ==true )
            {
                if (rdoAns3.Text == sCorrectAnswer)
                {
                    MessageBox.Show("Correct Answer");
                    iMarks++;
                }
                else
                {
                    MessageBox.Show("Wrong Answer");
                }
                txtMarks.Text = iMarks.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picQuestion.Image = Image.FromFile(@"d:\Q1.jpg");
            rdoAns1.Text = "Ball";
            rdoAns2.Text = "Bell";
            rdoAns3.Text = "Bird";
            sCorrectAnswer = "Bird";
            txtMarks.Text = iMarks.ToString();

        }
    }
}
