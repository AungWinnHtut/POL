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
        public string datapath = Directory.GetCurrentDirectory() + "\\cards\\" + "gamedata.txt";

        private int iDscore = 0;
        private int iPscore = 0;

        Card c = new Card();
        Card.oneCard oC = new Card.oneCard();
        int Dcount = 0;
        int Pcount = 0;
        int gamecount = 0;
        int status = -1; //0 dealer win, 1 player win, 2 draw


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
            //picW.Image = Image.FromFile(backcard);
            txtDscore.Text = "0";
            txtPscore.Text = "0";
            iDscore = 0;
            iPscore = 0;
            gamecount = 0;
            Dcount = 0;
            Pcount = 0;
            status = -1;
            c.Shuffle();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            funRestart();
        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            funRestart();

            for (int i=0;i<6;i++)
            {

                funDeal();
                await Task.Delay(500);

            }

            //Game rule

            iDscore = iDscore % 10;
            iPscore = iPscore % 10;

            txtDscore.Text = iDscore.ToString();
            txtPscore.Text = iPscore.ToString();


            if (iDscore > iPscore )
            {
                MessageBox.Show("Dealer Win!");
                status = 0;
            }
            else if(iPscore > iDscore )
            {
                MessageBox.Show("Player Win!");
                status = 1;
            }
            else
            {
                MessageBox.Show("Draw!");
                status = 2;
            }

            //iDscor,iPscore,status

            funSaveGameData(iDscore, iPscore, status);

        }

        public void funDeal()
        {
            oC = c.Deal();
            string img = c.showCard(oC.getFacesuit());

            if (gamecount % 2 == 0)
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
            gamecount++;
        }

        public void funSaveGameData(int d, int p, int s)
        {
            
            using (StreamWriter sw = new StreamWriter(datapath,true))
            {
                string data = d.ToString() + "," + p.ToString() + "," + s.ToString();
                sw.WriteLine(data);
            }
        }



        private void btnScoreBoard_Click(object sender, EventArgs e)
        {
            frmScoreBoard frms = new frmScoreBoard();
            frms.ShowDialog();
        }
    }
}
