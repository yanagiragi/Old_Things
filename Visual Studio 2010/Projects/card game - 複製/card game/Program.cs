using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string names;
            int nums=1;
            decksofcard dd = new decksofcard();



            //dd.construct();
            //dd.shuffle();
            
           // Console.Write("請輸入你的名字:");
            names = Console.ReadLine();
            Player pp = new Player(names);
            Player qq = new Player(nums);
            pp.cons1();
            qq.cons1();

            int sentaku = 1;


            


           
           /* Console.Write("一開始籌碼各1000元 按0退出 請輸入籌碼(1~100):");
            sentaku = Convert.ToInt32(Console.ReadLine());
               
            while (sentaku > 100 || sentaku < 1)
            {
                Console.WriteLine("輸入錯誤,請再試一次!");
                Console.Write("一開始籌碼各1000元 按0退出 請輸入籌碼(1~100):");
                sentaku = Convert.ToInt32(Console.ReadLine());
            }*/

            Console.WriteLine("{0}的手牌:",names);
            pp.game(names);
            Console.WriteLine("莊家手牌:");
            qq.game(nums);

            





            
            Console.WriteLine("");
            //qq.game(nums);
             
            Console.ReadLine();
            
        }
    
    }
}
