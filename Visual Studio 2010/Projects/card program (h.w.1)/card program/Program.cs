using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace card_program
{
    class Program
    {
        

        static void Main(string[] args)
        {
           
           Console.Write("input id you want                                       : ");//輸入你要的id
           string aaa = Console.ReadLine();
                  
           Console.Write("input card balance you want ( num please,max 5000 min 0): ");//輸入你要的金額
           int bbb = Convert.ToInt32(Console.ReadLine());
           string ccc=aaa;
           
           Card card1 = new Card(aaa,bbb, 0);
           Card card2 = new Card(ccc, bbb, 0);
            //另做aaa,bbb當作丟給card constructer的parameter
            
           if (card1.balancegetset >= 5000)
            {
                card1.balancegetset = 5000; //設定5000
                Console.WriteLine("wrong! We take it as 5000!  ");
                
            }
          else if (card1.balancegetset <= 0)
            {
                card1.balancegetset = 0; //設定0
                Console.WriteLine("wrong! We take it as 0!  ");
                
            }
          else
            {}
         
          
          Console.WriteLine("____________________________________________________________________");

          card1.DisplayCardInfo();
          card1.BuyTicket();
        }
    }
}
