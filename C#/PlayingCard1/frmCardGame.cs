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
using System.Threading.Tasks;
 

namespace PlayingCard1
{
    public partial class frmCardGame : Form
    {
        public frmCardGame()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Random rnd = new Random((int)System.DateTime.Now .Millisecond);
            int card = 0;
            card= rnd.Next(1,14);
            //this.Text = card.ToString();
            string curpath = Directory.GetCurrentDirectory();
            string picpath = curpath + "\\cards\\";
            switch (card)
            {
                //case 1: picDrawCard.Image = Image.FromFile(picpath +"1.png"); break;
                //case 2: picDrawCard.Image = Image.FromFile(picpath + "2.png"); break;
                //case 3: picDrawCard.Image = Image.FromFile(picpath + "3.png"); break;
                //case 4: picDrawCard.Image = Image.FromFile(picpath + "4.png"); break;
                //case 5: picDrawCard.Image = Image.FromFile(picpath + "5.png"); break;
                //case 6: picDrawCard.Image = Image.FromFile(picpath + "6.png"); break;
                //case 7: picDrawCard.Image = Image.FromFile(picpath + "7.png"); break;
                //case 8: picDrawCard.Image = Image.FromFile(picpath + "8.png"); break;
                //case 9: picDrawCard.Image = Image.FromFile(picpath + "9.png"); break;
                //case 10: picDrawCard.Image = Image.FromFile(picpath + "10.png"); break;
                case 1:
                case 2: 
                case 3: 
                case 4: 
                case 5: 
                case 6: 
                case 7: 
                case 8: 
                case 9: 
                case 10: string pic = card.ToString() + ".png"; 
                         picDrawCard.Image = Image.FromFile(picpath + pic); break;
                case 11: picDrawCard.Image = Image.FromFile(picpath + "j.png"); break;
                case 12: picDrawCard.Image = Image.FromFile(picpath + "q.png"); break;
                case 13: picDrawCard.Image = Image.FromFile(picpath + "k.png"); break;
                default: picDrawCard.Image = Image.FromFile(picpath + "b.png"); break;

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frmCardGame_Load(object sender, EventArgs e)
        {

        }

        private void btnPlayPhoto_Click(object sender, EventArgs e)
        {
            //Graphics g = Graphics.FromHwnd(this.Handle);
            for (int count = 0; count < IL.Images.Count; count++)
            {
                // IL.Draw(g, new Point(20, 20), count);
                // Paint the form and wait to load the image
                picDrawCard.Image = IL.Images[count];
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);

            }
        }
    }
}
