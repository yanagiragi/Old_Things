using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class gamehontai
    //game 本體
    {
        static void Main(string[] args)
        {
            opening.OpeningDisplayMessage();
            Console.WriteLine();
            gametextingpattern.GameTextingPattern();
            Console.WriteLine();
            ending.EndingDisplayMessage();
            Console.ReadLine();
        }
    }
}
