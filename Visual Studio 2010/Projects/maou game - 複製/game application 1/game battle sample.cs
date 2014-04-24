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
      
          a:
          
            while (Battlesentaku.monsterhp1*Battlesentaku.playerhp >0)
            {
                c:
                //Console.WriteLine("{0}", Battlesentaku.turn);
                Console.WriteLine("");
                Console.WriteLine("目前訊息");
                Console.WriteLine("怪物生命 {0}", Battlesentaku.monsterhp1);
                Console.WriteLine("玩家生命 {0}", Battlesentaku.playerhp);
                Console.WriteLine("玩家魔力 {0}", Battlesentaku.playermana);
                Console.WriteLine("_________________________________________");
                Console.WriteLine("");

                if (Battlesentaku.turn % 2 == 1)
                {
                    Console.Write("輪到玩家攻擊!");
                    Console.ReadLine();
                    Console.Write("請選擇動作: 1 攻擊 2 魔法 3 逃跑 你選擇: ");
                    Battlesentaku.battlesentaku = Console.ReadLine();
                  
                    if (Battlesentaku.battlesentaku == "1")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("你的攻擊產生了{0}的物理傷害!",Battlesentaku.playerdamage);
                        Battlesentaku.monsterhp1 = Battlesentaku.monsterhp1 - Battlesentaku.playerdamage;
                        Battlesentaku.turn = Battlesentaku.turn + 1;
                    }

                    else if (Battlesentaku.battlesentaku == "2")
                    {
                        if (Battlesentaku.playermana >= 20)
                        {
                            Console.WriteLine(""); 
                            Console.WriteLine("消耗20瑪那，產生了15點的魔法傷害!");
                            Battlesentaku.monsterhp1 = Battlesentaku.monsterhp1 - Battlesentaku.playermanadamage;
                            Battlesentaku.playermana = Battlesentaku.playermana - Battlesentaku.playermanacost;
                            Console.WriteLine("");
                            Battlesentaku.turn = Battlesentaku.turn + 1;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("瑪那不夠!");
                            Console.WriteLine("");
                        }

                    }
                    else if (Battlesentaku.battlesentaku == "3")
                    {
                        double runrate = Randomglobal.Attackcriticalrate(1);
                        if (runrate == 1.10)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("恭喜!逃跑成功!");
                            Console.WriteLine("");
                            Battlesentaku.controlrunsucbreak = 1;
                            goto d;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("恭喜!逃跑失敗!");
                            Console.WriteLine("");
                            Battlesentaku.turn++;
                        }
                    }
                    else if (Battlesentaku.battlesentaku != "1" && Battlesentaku.battlesentaku != "2" && Battlesentaku.battlesentaku != "3")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("輸入錯誤");
                        Console.WriteLine("");
                        goto c;
                    }
                    else { }
                }
                else { }

                if (Battlesentaku.turn % 2 == 0)//怪物攻擊回合
                {
                    Console.WriteLine("");
                    if (Battlesentaku.turn % 6 > 0)
                    {
                        Console.WriteLine("輪到怪物攻擊!");
                        Battlesentaku.playerhp = Battlesentaku.playerhp - Battlesentaku.monsterdamage;
                        Console.WriteLine("你受到了{0}傷害!", Battlesentaku.monsterdamage);
                       Battlesentaku.turn = Battlesentaku.turn + 1;
                    }
                    else if (Battlesentaku.turn % 6 == 0)
                    {
                        Console.WriteLine("輪到怪物攻擊!");
                        double atlcrtrate2= Randomglobal.Attackcriticalrate(1);
                       // Console.WriteLine("{0}",atlcrtrate2);
                        int monsterctrhit = Convert.ToInt32(Battlesentaku.monsterdamage * atlcrtrate2);
                        Battlesentaku.playerhp = Battlesentaku.playerhp - monsterctrhit;
                        Console.WriteLine("怪物暴擊!你受到了{0}傷害!", monsterctrhit);
                        Battlesentaku.turn = Battlesentaku.turn + 1;
                    }
                    else { }

                }
                else { }
               
                if (Battlesentaku.monsterhp1 <= 0)
                {
                    Console.WriteLine("恭喜擊敗!");
                    Console.WriteLine("");
                    Console.WriteLine("__________________________________________________________");
                }
                else if (Battlesentaku.playerhp <= 0)
                {
                    Console.WriteLine("你失敗了!要再試一次嗎?");
                    Console.WriteLine("選1代表繼續,選2代表關閉程式");
                    Battlesentaku.battlesentaku = Console.ReadLine();
                    if (Battlesentaku.battlesentaku == "1")
                    {
                        Battlesentaku.playerhp = 100;
                        Battlesentaku.monsterhp1 = 100;
                        Battlesentaku.playermana = 100;
                        goto a;
                    }
                    else if (Battlesentaku.battlesentaku == "2")
                    {
                        System.Environment.Exit(System.Environment.ExitCode);
                    }

                }
                else
                {
                }
            d:
                if (Battlesentaku.controlrunsucbreak == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("__________________________________________________________");
                    break;
                }
            }
        }
    }
}
