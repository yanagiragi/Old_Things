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
            battle2.Battle2display();
           //battle1.Battle1display();
               
            Console.WriteLine("     這是一個，悲傷到淚流不止，但又令人喜極而泣的故事....");
            Console.WriteLine("");
            Console.WriteLine("                        ~故事開始~");
            Console.WriteLine("__________________________________________________________");
            Console.WriteLine("");
           
            
            openingending.OpeningDisplayMessage(0);

            gametextingpattern.GameTextingPattern();
            openingending.endingDisplayMessage();
            Console.WriteLine("");
            Console.WriteLine("遊戲破關!");
            Console.Write("請按任一鍵離開......");
            Console.ReadLine();
              
            battle1.Battle1display();
        }
    }
}
