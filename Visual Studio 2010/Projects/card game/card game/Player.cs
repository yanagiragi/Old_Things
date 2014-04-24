using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cardhw
{
    public class Player
    {
        public int plrmoney = 1000;
        public int makmoney = 1000;
        public int counter = 4;

        public void PlrBalance()
        {
            Console.WriteLine("player money:{0}", plrmoney);
            Console.WriteLine("maker money:{0}", makmoney);


            Console.Write("bet!(0 to leave,bet account:1~100):");
            counter = Convert.ToInt32(Console.ReadLine());
            if (counter == 0)
            {
                Console.WriteLine("\n game over");
                Console.ReadLine();
                Console.WriteLine("press any button to quit");
                Console.ReadKey();
                System.Environment.Exit(System.Environment.ExitCode);

            }


            if (counter == 0)
            {
                return;
            }
            else if (counter > 100)
            {
                goto Here;
            }

        Here:
            {
                if (counter > 100)
                {
                    Console.WriteLine("wrong!");
                    Console.WriteLine("bet!(0 to leave,bet account:1~100):");
                    counter = Convert.ToInt32(Console.ReadLine());
                    if (counter == 0)
                    {
                        return;
                    }
                    else if (counter > 100)
                    {
                        goto Here;
                    }
                }
            }
        }
    }
}

