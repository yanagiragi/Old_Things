using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cardhw
{
    public class Card
    {
        private string face;
        private string suit;

        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }

        public string GetFace()
        {
            return face;
        }

        public string GetSuit()
        {
            return suit;
        }

        public override string ToString()
        {
            return face + " of " + suit;
        }
    }
}
