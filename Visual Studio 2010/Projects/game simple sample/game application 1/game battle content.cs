using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class game_battle_content
    {
        public static void Battledisplay()
            
        {
            global Battlesentaku = new global();
            //Randomglobal random = new Randomglobal();
          //  Battlesentaku.turn =Battlesentaku.turn+1;
            
          a:
          
            while (Battlesentaku.monsterhp1*Battlesentaku.playerhp >0)
            {
                c:
                Console.WriteLine("{0}", Battlesentaku.turn);
               // Console.WriteLine("{0}", Battlesentaku.turn);
                Console.WriteLine("");
                Console.WriteLine("目前訊息.................................");
                Console.WriteLine("monsterhp1 {0}", Battlesentaku.monsterhp1);
                Console.WriteLine("playermana {0}", Battlesentaku.playermana);
                Console.WriteLine("playerhp {0}", Battlesentaku.playerhp);
                Console.WriteLine("........................................");
                Console.WriteLine("");

                if (Battlesentaku.turn % 2 == 1) //普通攻擊
                {
                    // Battlesentaku.playerhp = Battlesentaku.playerhp - 1000;

                    //Console.ReadLine();


                    Console.Write("請選擇動作: ");
                    //  Console.WriteLine("");
                    Battlesentaku.battlesentaku = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("你選擇:  {0}", Battlesentaku.battlesentaku);
                    if (Battlesentaku.battlesentaku == 1)
                    {
                        Console.WriteLine("minus 5hp");
                        Battlesentaku.monsterhp1 = Battlesentaku.monsterhp1 - Battlesentaku.playerdamage;
                        Console.WriteLine("current monster hp  {0}", Battlesentaku.monsterhp1);
                        Battlesentaku.turn = Battlesentaku.turn + 1;
                        // Console.WriteLine("{0}", Battlesentaku.turn);
                        // Console.ReadLine();

                    }

                    else if (Battlesentaku.battlesentaku == 2) //魔力攻擊
                    {
                        if (Battlesentaku.playermana >= 30)
                        {
                            Console.WriteLine("-20hp,mana-30");
                            Battlesentaku.monsterhp1 = Battlesentaku.monsterhp1 - Battlesentaku.playermanadamage;
                            Battlesentaku.playermana = Battlesentaku.playermana - Battlesentaku.playermanacost;
                            Console.WriteLine("");
                            Battlesentaku.turn = Battlesentaku.turn + 1;

                            //  Console.ReadLine();


                        }
                        else if (Battlesentaku.battlesentaku == 3)
                        {
                            if (Randomglobal.attackcriticalrate >= 1.3)
                            {
                                Console.WriteLine("逃走失敗!");
                                Battlesentaku.turn++;

                            }
                            else 
                            {
                                Console.WriteLine("逃走成功!");
                                
                            }


                        }
                        else
                        {
                            Console.WriteLine("mana not enough!");
                            Console.WriteLine("");
                            //Console.ReadLine();
                        }

                    }
                    else if (Battlesentaku.battlesentaku != 1 && Battlesentaku.battlesentaku != 2 && Battlesentaku.battlesentaku != 3) //&& Battlesentaku.battlesentaku != 4)
                    {
                        Console.WriteLine("輸入錯誤");
                        Console.WriteLine("");
                        goto c;
                        //  Console.ReadLine();
                    }
                    else { }
                }
                else { }

                if (Battlesentaku.turn % 2 == 0)//怪獸攻擊回合
                {
                    Console.WriteLine("");
                    if (Battlesentaku.turn % 5 > 0)
                    {
                        Console.WriteLine("輪到怪獸攻擊!");
                        Battlesentaku.playerhp = Battlesentaku.playerhp - Battlesentaku.monsterdamage;
                        Console.WriteLine("你受到了{0}傷害!", Battlesentaku.monsterdamage);
                       // Console.WriteLine("請按任一鍵繼續...");
                        //Console.ReadLine();
                        Battlesentaku.turn = Battlesentaku.turn + 1;

                        // goto d;

                    }
                    else if (Battlesentaku.turn % 5 == 0)
                    {
                        Console.WriteLine("輪到怪獸攻擊!");
                        int monsterctrhit = Convert.ToInt32(Battlesentaku.monsterdamage * Randomglobal.attackcriticalrate);
                        Battlesentaku.playerhp = Battlesentaku.playerhp - monsterctrhit;
                        Console.WriteLine("暴擊率{0}!你受到了{1}傷害!",Randomglobal.attackcriticalrate, monsterctrhit);
                       // Console.WriteLine("請按任一鍵繼續...");
                       // Console.ReadLine();
                        Battlesentaku.turn = Battlesentaku.turn + 1;

                        // goto d;
                        //  Console.ReadLine();
                    }
                    else { }

                }
                else { }
               
                if (Battlesentaku.monsterhp1 < 0)
                {
                    Console.WriteLine("恭喜擊敗!");
                }
                else if (Battlesentaku.playerhp < 0)
                {
                    Console.WriteLine("你失敗了!要再試一次嗎?");
                    Console.WriteLine("選1代表繼續,選2代表關閉程式");
                    Battlesentaku.battlesentaku = Convert.ToInt32(Console.ReadLine());
                    if (Battlesentaku.battlesentaku == 1)
                    {
                        Battlesentaku.playerhp = Battlesentaku.playerhp + 100;
                        goto a;
                    }
                    else if (Battlesentaku.battlesentaku == 2)
                    {
                        System.Environment.Exit(System.Environment.ExitCode);
                    }

                }
                else
                {
                }
               // Battlesentaku.turn = Battlesentaku.turn + 1;
                
         
              

            }
        
            
        
        }


         
       
    }
}
