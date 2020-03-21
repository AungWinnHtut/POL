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
        Card c = new Card();
        public frmCardGame()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            
          
            
           // MessageBox.Show(c.showDeck ());

            c.Shuffle();

            MessageBox.Show(c.showDeck());





        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frmCardGame_Load(object sender, EventArgs e)
        {

        }

        private void btnPlayPhoto_Click(object sender, EventArgs e)
        {
            Card.oneCard oC = new Card.oneCard();
            
            oC= c.Deal();
            
            picDrawCard.Image = Image.FromFile(c.showCard(oC.getFacesuit()));
            txtValue.Text = oC.getValue().ToString ();

        }




    }
}
