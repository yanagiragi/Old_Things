using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class decksofcard
    {
        public Card[] deck ;
        public static string [] cardshape  = { "  Ace  "," Heart ","Diamond","Square " };
        public static string[] cardnumber = { "One", "Deuce", "Third", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        Random randoms = new Random();
        public static int current = 0;       
        public static int[] array1,array2;
        
        
            
        public void construct()
        {
            array1 = new int[52];
            array2 = new int[52];
            deck = new Card[52];
            Random randomclass = new Random();

            for (int counter = 0; counter < deck.Length; counter++) //counter 重複0~51 共52次
            {
                deck[counter] = new Card(cardshape[counter/13],cardnumber[counter%13]);
                array1[counter] = (counter / 13)+1;
                array2[counter] = (counter % 13)+1;                
            }
        }

        public void shuffle()
        {
            for (int first = 0; first < deck.Length; first++)
            {
                int second = randoms.Next(52);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;

                int[] temp2;
                temp2 = new int[52];
                temp2[first] = array1[first];
                array1[first] = array1[second];
                array1[second] = temp2[first];

                int[] temp3;
                temp3 = new int[52];
                temp3[first] = array2[first];
                array2[first] = array2[second];
                array2[second] = temp3[first];

               
                //Console.WriteLine("{0}",deck[first]);

                //Console.WriteLine("{0} {1}", array1[first],array2[first]);

            }
        }

        public  Card dealcard()
        {   
            
            
            if (current < deck.Length)
            {                
                return deck[current++];
                deck[current - 1] = null;
                                
            }
            else
            {
                current = 0;
                return deck[current++];
                  
            }
        }

        public Card dealcard2()
        {
                if (current < deck.Length)
                {
                    return deck[current++];
                    deck[current-1]=null;
                }
                else
                {
                    current = 0;
                    return deck[current++];
                }
        }
    }
}
