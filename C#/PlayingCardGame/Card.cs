using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlayingCard1
{
    public class Card
    {

        public int[] Deck = new int[52];
        public int top = 0; //0-51 top of the deck
        
        public struct oneCard
        {
            public string facesuit;
            public int value;

            public void setFacesuit(string fs)
            {
                facesuit = fs;
            }

            public void setValue(int v)
            {
                value = v;
            }
            public string getFacesuit() { return facesuit; }
            public int getValue() { return value; }
        };


        public Card()
        {
            makeNewDeck();
        }

        public oneCard chooseCard(int cardno)
        {


            oneCard r = new oneCard();

            string face = "";
            string suit = "";            
            int isuit = cardno / 13;   //0-3 suit %0=suit--;
            int iface = cardno % 13;   //1-12 face   %0=K   

            int value = -1;

            switch (iface )
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: value = iface; break;

                case 10:
                case 11:
                case 12:
                case 0:   value = 10; break;
                
            }



            r.setValue(value);

            if(iface==0)
            {
                isuit--;
            }

            switch (iface)
            {               
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10: face = iface.ToString(); break;
                case 11: face = "J"; break;
                case 12: face = "Q"; break;
                case 0: face = "K"; break;
                case 1: face = "A"; break;
                default: face = ""; break;

            }

            switch(isuit)
            {
                case 0: suit = "S"; break;
                case 1: suit = "H"; break;
                case 2: suit = "D"; break;
                case 3: suit = "C"; break;
                default: suit = ""; break;
            }

            r.setFacesuit(face + suit);
            return r;

        }

        public void makeNewDeck()
        {
            for(int i=0;i<52;i++)
            {
                Deck[i] = i + 1;
            }
            top = 0;
        }

        public void Shuffle()
        {
            int temp=0;

            for(int j=0;j<100;j++)
            {
                for (int i = 0; i < 52; i++)
                {
                    Random rd = new Random((int)DateTime.Now.Ticks);
                    int card = rd.Next(0, 52);
                    if (i != card)
                    {
                        temp = Deck[i];
                        Deck[i] = Deck[card];
                        Deck[card] = temp;
                    }
                }
            }
            top = 0;          
            
        }

        public string showDeck() //debugging
        {
            string result = "";
            for (int i = 0; i < 52; i++)
            {
                result += Deck[i].ToString() + "-";
            }
            return result;
        }


        public oneCard Deal()
        {
            return chooseCard(Deck[top++]);
        }

        public string showCard(string cd)
        {
            string path = Directory.GetCurrentDirectory()+ "\\cards\\"+cd+".png";
            return path;

        }

    }
}
