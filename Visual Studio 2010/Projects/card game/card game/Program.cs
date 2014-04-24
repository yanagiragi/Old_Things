using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cardhw
{
    public class DeckOfCardsTest
    {
        static void Main(string[] args)
        {
            Player thePlayer = new Player();

            while (thePlayer.plrmoney > 0 && thePlayer.makmoney > 0 && thePlayer.counter != 0)
            {
                thePlayer.PlrBalance();

                DeckOfCards myDeckOfCards = new DeckOfCards();
                myDeckOfCards.Shuffle();

                Card[] hand1 = new Card[5];
                Card[] hand2 = new Card[5];

                for (int i = 0; i < 5; i++)
                {
                    hand1[i] = myDeckOfCards.DealCard();
                    hand2[i] = myDeckOfCards.DealCard();
                }

                Console.WriteLine("\n{0,-14}{1,-20}", "maker card：", "player card：");

                for (int i = 0; i < hand1.Length; i++)
                    Console.WriteLine("{0,-20}{1,-20}", hand1[i], hand2[i]);


                myDeckOfCards.CompareTwoHands(hand1, hand2);

                if (DeckOfCards.win == 1)
                {
                    thePlayer.plrmoney = thePlayer.plrmoney + thePlayer.counter;
                    thePlayer.makmoney = thePlayer.makmoney - thePlayer.counter;
                }
                else if (DeckOfCards.win == 2)
                {
                    thePlayer.plrmoney = thePlayer.plrmoney - thePlayer.counter;
                    thePlayer.makmoney = thePlayer.makmoney + thePlayer.counter;
                }
                else { }

                if (thePlayer.makmoney <= 0)
                {
                    Console.WriteLine("no money!game over");
                    Console.ReadLine();
                    Console.WriteLine("press ant button to quit");
                    Console.ReadLine();
                    System.Environment.Exit(System.Environment.ExitCode);
                }
                else if (thePlayer.plrmoney <= 0)
                {
                    Console.WriteLine("maker no money! you win!");
                    Console.ReadLine();
                    Console.WriteLine("press ant button to quit");
                    Console.ReadLine();
                    System.Environment.Exit(System.Environment.ExitCode);
                }
                else { }
            }
        }
    }
}
