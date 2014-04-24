using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cardhw
{
    public class DeckOfCards
    {
        string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        private Card[] deck;
        private int currentCard;
        private const int NUMBER_OF_CARDS = 52;
        private Random randomNumbers;
        private bool straightHand1, straightHand2, pair1, pair2;
        private int hand1Value, hand2Value;
        private const int ONEPAIR = 2;
        private const int TWOPAIR = 4;
        private const int THREEKIND = 6;
        private const int STRAIGHT = 8;
        private const int FULLHOUSE = 10;
        private const int FLUSH = 12;
        private const int FOURKIND = 14;
        private const int STRAIGHTFLUSH = 16;
        public static int win = 1;
        public DeckOfCards()
        {
            deck = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            randomNumbers = new Random();
            for (int count = 0; count < deck.Length; count++)
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
        }
        public void Shuffle()
        {
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = randomNumbers.Next(NUMBER_OF_CARDS);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }
        public Card DealCard()
        {
            if (currentCard < deck.Length)
                return deck[currentCard++];
            else
                return null;
        }

        private int[] TotalHand(Card[] hand)
        {
            int[] numbers = new int[faces.Length];
            for (int h = 0; h < hand.Length; h++)
            {
                for (int f = 0; f < 13; f++)
                {
                    if (hand[h].GetFace() == faces[f])
                        ++numbers[f];
                }
            }

            return numbers;
        }
        public void Pairs(Card[] hand1, Card[] hand2)
        {
            int numberPairs1 = 0;
            int numberPairs2 = 0;
            int highest1 = 0;
            int highest2 = 0;
            int[] numbers1 = TotalHand(hand1);
            int[] numbers2 = TotalHand(hand2);
            for (int k = 0; k < faces.Length; k++)
            {
                if (numbers1[k] == 2)
                {
                    pair1 = true;
                    if (k == 0)
                        highest1 = 13;

                    if (k > highest1)
                        highest1 = k;

                    ++numberPairs1;
                }
                if (numbers2[k] == 2)
                {
                    pair2 = true;

                    if (k == 0)
                        highest2 = 13;
                    else { }

                    if (k > highest2)
                        highest2 = k;
                    else { }
                    ++numberPairs2;
                }
            }

            if (numberPairs1 == 1)
                hand1Value = ONEPAIR;
            else if (numberPairs1 == 2)
                hand1Value = TWOPAIR;
            else { }

            if (numberPairs2 == 1)
                hand2Value = ONEPAIR;
            else if (numberPairs2 == 2)
                hand2Value = TWOPAIR;
            else { }

            if (highest1 > highest2)
                ++hand1Value;
            else if (highest2 > highest1)
                ++hand2Value;
            else { }
        }

        public void ThreeOfAKind(Card[] hand1, Card[] hand2)
        {
            int tripletValue1 = 0;
            int tripletValue2 = 0;
            bool flag1 = false;
            bool flag2 = false;
            int[] numbers1 = TotalHand(hand1);
            int[] numbers2 = TotalHand(hand2);

            for (int k = 0; k < faces.Length; k++)
            {
                if (numbers1[k] == 3)
                {
                    hand1Value = THREEKIND;
                    flag1 = true;

                    if (k == 0)
                        tripletValue1 = 13;
                    else { }

                    if (k > tripletValue1)
                        tripletValue1 = k;
                    else { }

                    if (pair1 == true)
                        hand1Value = FULLHOUSE;
                    else { }
                }
                if (numbers2[k] == 3)
                {
                    hand2Value = THREEKIND;
                    flag2 = true;
                    if (k == 0)
                        tripletValue2 = 13;
                    else { }

                    if (k > tripletValue2)
                        tripletValue2 = k;
                    else { }

                    if (pair2 == true)
                        hand2Value = FULLHOUSE;
                    else { }
                }
            }

            if (flag1 == true && flag2 == true)
            {
                if (tripletValue1 > tripletValue2)
                    ++hand1Value;
                else if (tripletValue1 < tripletValue2)
                    ++hand2Value;
            }
        }
        public void FourOfAKind(Card[] hand1, Card[] hand2)
        {
            int highest1 = 0;
            int highest2 = 0;
            bool flag1 = false;
            bool flag2 = false;
            int[] numbers1 = TotalHand(hand1);
            int[] numbers2 = TotalHand(hand2);
            for (int k = 0; k < faces.Length; k++)
            {
                if (numbers1[k] == 4)
                {
                    hand1Value = FOURKIND;
                    flag1 = true;

                    if (k == 0)
                        highest1 = 13;
                    else { }

                    if (k > highest1)
                        highest1 = k;
                    else { }
                }
                if (numbers2[k] == 4)
                {
                    hand2Value = FOURKIND;
                    flag2 = true;

                    if (k == 0)
                        highest2 = 13;
                    else { }

                    if (k > highest2)
                        highest2 = k;
                    else { }
                }
            }
            if (flag1 == true && flag2 == true)
            {
                if (highest1 > highest2)
                    ++hand1Value;
                else if (highest1 < highest2)
                    ++hand2Value;
                else { }
            }
        }
        public void Flush(Card[] hand1, Card[] hand2)
        {
            string hand1Suit = hand1[0].GetSuit();
            string hand2Suit = hand2[0].GetSuit();
            bool flag1 = true, flag2 = true;
            for (int s = 1; s < hand1.Length && flag1 == true; s++)
            {
                if (hand1[s].GetSuit() != hand1Suit)
                    flag1 = false;
                else { }
            }

            for (int s = 1; s < hand2.Length && flag2 == true; s++)
            {
                if (hand2[s].GetSuit() != hand2Suit)
                    flag2 = false;
                else { }
            }
            if (flag1 == true)
            {
                hand1Value = FLUSH;
                if (straightHand1 == true)
                    hand1Value = STRAIGHTFLUSH;
                else { }
            }

            if (flag2 == true)
            {
                hand2Value = FLUSH;
                if (straightHand2 == true)
                    hand2Value = STRAIGHTFLUSH;
                else { }
            }
        }
        public void Straight(Card[] hand1, Card[] hand2)
        {
            int[] locations1 = new int[5];
            int[] locations2 = new int[5];
            int[] numbers1 = TotalHand(hand1);
            int[] numbers2 = TotalHand(hand2);
            for (int y = 0, z = 0; y < numbers1.Length; y++)
            {
                if (numbers1[y] == 1)
                    locations1[z++] = y;
                else { }
            }

            for (int y = 0, z = 0; y < numbers2.Length; y++)
            {
                if (numbers1[y] == 1)
                    locations1[z++] = y;
                else { }
            }

            int faceValue = locations1[0];
            bool flag1 = true, flag2 = true;

            if (faceValue == 0)
            {
                faceValue = 13;

                for (int m = locations1.Length - 1; m >= 1; m--)
                {
                    if (faceValue != locations1[m] + 1)
                        return;
                    else
                        faceValue = locations1[m];
                }
            }
            else
            {
                for (int m = 1; m < locations1.Length; m++)
                {
                    if (faceValue != locations1[m] - 1)
                        return;
                    else
                        faceValue = locations1[m];
                }
            }

            faceValue = locations2[0];

            if (faceValue == 0)
            {
                faceValue = 13;

                for (int m = locations2.Length - 1; m >= 1; m--)
                {
                    if (faceValue != locations2[m] + 1)
                        return;
                    else
                        faceValue = locations2[m];
                }
            }
            else
            {
                for (int m = 1; m < locations2.Length; m++)
                {
                    if (faceValue != locations2[m] - 1)
                        return;
                    else
                        faceValue = locations2[m];
                }
            }

            int highest1 = 0;
            int highest2 = 0;
            if (flag1 == true)
            {
                straightHand1 = true;
                hand1Value = STRAIGHT;

                if (locations1[0] != 0)
                    highest1 = locations1[4];
                else
                    highest1 = 13;
            }
            if (flag2 == true)
            {
                straightHand2 = true;
                hand2Value = STRAIGHT;

                if (locations2[0] != 0)
                    highest2 = locations2[4];
                else
                    highest2 = 13;
            }
            if (straightHand1 == true && straightHand2 == true)
            {
                if (highest1 > highest2)
                    ++hand1Value;
                else if (highest2 > highest1)
                    ++hand2Value;
            }
        }

        public void CompareTwoHands(Card[] hand1, Card[] hand2)
        {
            Pairs(hand1, hand2);
            ThreeOfAKind(hand1, hand2);
            FourOfAKind(hand1, hand2);
            Straight(hand1, hand2);
            Flush(hand1, hand2);
            DisplayHandValues();

            int[] numbers1 = TotalHand(hand1);
            int[] numbers2 = TotalHand(hand2);
            int highestValue1 = 0;
            int highestValue2 = 0;

            if (numbers1[0] > 0)
                highestValue1 = 13;
            else
            {
                for (int i = 1; i < numbers1.Length; i++)
                {
                    if (numbers1[i] > 0)
                    {
                        highestValue1 = i;
                    }
                }
            }

            if (numbers2[0] > 0)
                highestValue2 = 13;
            else
            {
                for (int i = 1; i < numbers2.Length; i++)
                {
                    if (numbers2[i] > 0)
                    {
                        highestValue2 = i;
                    }
                }
            }

            if (hand1Value > hand2Value)
            {
                Console.WriteLine("\n player wins");
                Console.WriteLine("--------------------------------------------------------");
                win = 1;
            }
            else if (hand1Value < hand2Value)
            {
                Console.WriteLine("\n player wins");
                Console.WriteLine("--------------------------------------------------------");
                win = 2;
            }
            else
            {
                // test for the highest card
                if (highestValue1 > highestValue2)
                {
                    Console.WriteLine("\n player loses");
                    Console.WriteLine("--------------------------------------------------------");
                    win = 1;
                }
                else if (highestValue1 < highestValue2)
                {
                    Console.WriteLine("\n player loses");
                    Console.WriteLine("--------------------------------------------------------");
                    win = 2;
                }
                else
                {
                    win = 3;
                    Console.WriteLine("\n draw");
                    Console.WriteLine("--------------------------------------------------------");
                }
            }
        }

        // display hand values
        public void DisplayHandValues()
        {
            string[] handValue = { "none", "none" };
            int value = hand1Value;

            for (int i = 0; i < 2; i++)
            {
                if (i == 1)
                    value = hand2Value;

                switch (value)
                {
                    case 2:
                    case 3:
                        handValue[i] = "One Pair";
                        break;
                    case 4:
                    case 5:
                        handValue[i] = "Two Pair";
                        break;
                    case 6:
                    case 7:
                        handValue[i] = "Three of a Kind";
                        break;
                    case 8:
                    case 9:
                        handValue[i] = "Straight";
                        break;
                    case 10:
                    case 11:
                        handValue[i] = "Full House";
                        break;
                    case 12:
                    case 13:
                        handValue[i] = "Flush";
                        break;
                    case 14:
                    case 15:
                        handValue[i] = "Four of a Kind";
                        break;
                    case 16:
                        handValue[i] = "Straight Flush";
                        break;
                }
            }

            Console.Write("{0,-20}", handValue[0]);
            Console.WriteLine("{0,-20}", handValue[1]);
        }
    }
}
