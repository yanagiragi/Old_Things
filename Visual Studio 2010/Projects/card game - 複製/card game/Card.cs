using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Card
    {
        private string face, number;
        
        public Card(string cardface, string cardnumber)
        {
            face = cardface;
            number = cardnumber;
        }

        public override string ToString()
        {
            return face +" of "+   number;
        }


    }
}
