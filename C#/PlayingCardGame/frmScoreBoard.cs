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

namespace PlayingCard1
{
    public partial class frmScoreBoard : Form
    {
        public string datapath = Directory.GetCurrentDirectory() + "\\cards\\" + "gamedata.txt";
        public frmScoreBoard()
        {
            InitializeComponent();
        }

        private void frmScoreBoard_Load(object sender, EventArgs e)
        {
            showScores();
        }

        public void showScores()
        {
            string line = "";
            string[] gameResult = new string[3];
            using (StreamReader sr = new StreamReader(datapath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    gameResult = line.Split(',');
                    lstDealer.Items.Add(gameResult[0]);
                    lstPlayer.Items.Add(gameResult[1]);
                    switch(gameResult[2])
                    {
                        case "0": lstStatus.Items.Add("Dealer"); break;
                        case "1": lstStatus.Items.Add("Player"); break;
                        case "2": lstStatus.Items.Add("Draw"); break;
                    }
                }
            }
        }
    }
}
