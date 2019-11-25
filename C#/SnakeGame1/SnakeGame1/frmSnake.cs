using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakeGame1
{
    public partial class frmSnake : Form
    {
        int u1 = 1;
        int goal = 36;
        int home = 1;
        public frmSnake()
        {
            InitializeComponent();
        }

        private void btnDice_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int genRand = r.Next(1, 7);
            txtDice.Text = genRand.ToString();
            u1 += genRand;

            btnU1.Location = new Point(pictureBox1.Location.X + 18, pictureBox1.Location.Y+225);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calLoc(7);
        }

        private void calLoc(int i)
        {
            if (i > 1 && i < 7)
            {
                btnU1.Location = new Point(pictureBox1.Location.X + 18 + ((i - 1) * 58), pictureBox1.Location.Y + 225);
            }
            if (i > 6 && i < 13)
            {
                btnU1.Location = new Point(pictureBox1.Location.X + 18 + ((i - 7) * 58), pictureBox1.Location.Y + 180);
            }
        }

    }
}
