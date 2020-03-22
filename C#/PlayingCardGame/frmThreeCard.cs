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
using System.Threading;

namespace PlayingCard1
{    
    public partial class frmThreeCard : Form
    {
        private int iDscore = 0;
        private int iPscore = 0;

        Card c = new Card();

        public frmThreeCard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmThreeCard_Load(object sender, EventArgs e)
        {
            funRestart();
        }

        public void funRestart()
        {
            string backcard = Directory.GetCurrentDirectory() + "\\cards\\" + "b.png";
            picD1.Image = Image.FromFile(backcard);
            picD2.Image = Image.FromFile(backcard);
            picD3.Image = Image.FromFile(backcard);
            picP1.Image = Image.FromFile(backcard);
            picP2.Image = Image.FromFile(backcard);
            picP3.Image = Image.FromFile(backcard);
            picW.Image = Image.FromFile(backcard);
            txtDscore.Text = "0";
            txtPscore.Text = "0";
            iDscore = 0;
            iPscore = 0;
            c.Shuffle();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            funRestart();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Card.oneCard oC = new Card.oneCard();
            int Dcount = 0;
            int Pcount = 0;

            for(int gamecount=0;gamecount<6;gamecount++)
            {
                oC = c.Deal();
                string img = c.showCard(oC.getFacesuit());

                if (gamecount%2==0)
                {
                    Dcount++;
                    //Dealer
                 
                    iDscore += oC.getValue();
                    txtDscore.Text = iDscore.ToString();
                    

                    switch (Dcount)
                    {
                        case 1: picD1.Image = Image.FromFile(img); break;
                        case 2: picD2.Image = Image.FromFile(img); break;
                        case 3: picD3.Image = Image.FromFile(img); break;
                        default: MessageBox.Show("error"); break;
                    }
                }
                else
                {
                    Pcount++;
                    //Player
                    iPscore += oC.getValue();
                    txtPscore.Text = iPscore.ToString();

                    switch (Dcount)
                    {
                        case 1: picP1.Image = Image.FromFile(img); break;
                        case 2: picP2.Image = Image.FromFile(img); break;
                        case 3: picP3.Image = Image.FromFile(img); break;
                        default: MessageBox.Show("error"); break;
                    }
                }

                //Thread.Sleep(2000);

            }

            //Game rule

            iDscore = iDscore % 10;
            iPscore = iPscore % 10;

            txtDscore.Text = iDscore.ToString();
            txtPscore.Text = iPscore.ToString();


            if (iDscore > iPscore )
            {
                MessageBox.Show("Dealer Win!");
            }
            else if(iPscore > iDscore )
            {
                MessageBox.Show("Player Win!");
            }
            else
            {
                MessageBox.Show("Draw!");
            }
           

        }
    }
}
