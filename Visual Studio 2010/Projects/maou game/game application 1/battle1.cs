using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class battle1
    {
        public static void Battle1display()
        {

            int failedcount = 0;
            global Battlesentaku = new global();
            Battlesentaku.monsterhp1 = 130;
        //  Console.WriteLine("阿部生命 {0}", Battlesentaku.monsterhp1);
        a:

            #region
            while (Battlesentaku.monsterhp1 * Battlesentaku.playerhp > 0)
            {


            c:

                Console.WriteLine("");
                Console.WriteLine("目前訊息");
                Console.WriteLine("阿部生命 {0}", Battlesentaku.monsterhp1);
                Console.WriteLine("玩家生命 {0}", Battlesentaku.playerhp);
                Console.WriteLine("玩家魔力 {0}", Battlesentaku.playermana);

                Console.WriteLine("_________________________________________");
                Console.WriteLine("");

                
#region
                #region
                #region
                if (Battlesentaku.turn % 2 == 1)
                {

                    Console.WriteLine("輪到玩家攻擊!");

                    Console.Write("請選擇動作: 1 攻擊 2 魔法 3 逃跑 你選擇: ");
                    Battlesentaku.battlesentaku =Console.ReadLine();
                    Console.WriteLine("你選擇:  {0}", Battlesentaku.battlesentaku);
                    #region
                    if (Battlesentaku.battlesentaku == "1")
                    {

                        Console.WriteLine("你的攻擊產生了{0}的物理傷害!", Battlesentaku.playerdamage);
                        Battlesentaku.monsterhp1 = Battlesentaku.monsterhp1 - Battlesentaku.playerdamage;
                        Battlesentaku.turn = Battlesentaku.turn + 1;
                    }

                    else if (Battlesentaku.battlesentaku == "2")
                    {
                        if (Battlesentaku.playermana >= 20)
                        {
                            Console.WriteLine("消耗20瑪那，產生了15點的魔法傷害!");
                            Battlesentaku.monsterhp1 = Battlesentaku.monsterhp1 - Battlesentaku.playermanadamage;
                            Battlesentaku.playermana = Battlesentaku.playermana - Battlesentaku.playermanacost;
                            Console.WriteLine("");
                            Battlesentaku.turn = Battlesentaku.turn + 1;
                        }
                        else
                        {
                            Console.WriteLine("瑪那不夠!");
                            Console.WriteLine("");
                        }
                    #endregion
                }
               

                else if (Battlesentaku.battlesentaku != "1" && Battlesentaku.battlesentaku != "2" && Battlesentaku.battlesentaku != "3")
                {
                        Console.WriteLine("輸入錯誤");
                        Console.WriteLine("");
                        goto c;
                }

                else if (Battlesentaku.battlesentaku == Battlesentaku.magicword)
                {
                        Console.WriteLine("突然一陣強光襲來，眼前出現了謎樣的文字......");
                        Console.ReadLine();
                        Console.Write("請輸入隱含世界真理之密語:");
                        string keycheck = Console.ReadLine();
                        #region
                        if (keycheck == Battlesentaku.keyword)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("騷年，想不到你竟然答對了...");
                            Console.ReadLine();
                            Console.WriteLine("我就成全你! 讓你成為真正的 真。好。男。人 吧!");
                            Console.ReadLine();
                            Console.WriteLine("\"碰\"一聲。一股力量就這樣從你的屁股注入!");
                            Console.ReadLine();
                            Console.WriteLine("職業轉職! 進化成混沌魔導S師(笑)!");
                            Console.ReadLine();
                            Console.WriteLine("生命加成9999! 物攻加成9999! 魔攻加成9999!");
                            Console.ReadLine();
                            Console.WriteLine("去吧.....騷年，去反征服魔王吧...讓他了解誰才是真正的\"攻\"!");
                            Console.ReadLine();
                            Console.WriteLine("一陣強光襲來，你回到戰鬥之中。");
                            Console.ReadLine();
                            Battlesentaku.playerdamage = 9999;
                            Battlesentaku.playerhp = 9999;
                            Battlesentaku.playermana = 9999;
                            Battlesentaku.playermanadamage = 9999;
                        }
                        else { }
                        #endregion
                }

                else if (Battlesentaku.battlesentaku1 == "3")
                {

                        Console.WriteLine("");
                        Console.WriteLine("恭喜!逃跑失敗!");
                        Console.WriteLine("");
                        Battlesentaku.turn++;
                }

                else
                {
                        Console.WriteLine("輸入錯誤!");
                        Console.WriteLine("用掉一回合。");
                        Console.ReadLine();
                }
                #endregion
                #endregion
                }



                else if (Battlesentaku.battlesentaku1 == "1" && Battlesentaku.monsterhp1 - 8 < 0)
                {
                    Battlesentaku.monsterhp1 = Battlesentaku.monsterhp1 - 500;
                    break;
                }

                else if (Battlesentaku.battlesentaku1 == "2" && Battlesentaku.monsterhp1 - 15 < 0)
                {
                    Battlesentaku.monsterhp1 = Battlesentaku.monsterhp1 - 500;
                    break;
                }

                else { }


#endregion
#region



                if (Battlesentaku.turn % 2 == 0)//怪物攻擊回合
                {
                    Console.WriteLine("");
                    if (Battlesentaku.turn % 6 > 0)
                    {
                        Console.WriteLine("輪到阿部攻擊!");
                        //  Console.ReadLine();
                        Battlesentaku.playerhp = Battlesentaku.playerhp - Battlesentaku.monsterdamage;
                        Console.WriteLine("你被肛了!受到了{0}傷害!", Battlesentaku.monsterdamage);
                        Console.WriteLine("阿部露出了相當興奮的笑容!");
                        Console.ReadLine();
                        Battlesentaku.turn = Battlesentaku.turn + 1;
                    }
                    else if (Battlesentaku.turn % 6 == 0)
                    {
                        Console.WriteLine("輪到阿部攻擊!");
                        Console.ReadLine();
                        double atlcrtrate2 = Randomglobal.Attackcriticalrate(1);
                        // Console.WriteLine("{0}",atlcrtrate2);
                        int monsterctrhit = Convert.ToInt32(Battlesentaku.monsterdamage * atlcrtrate2);
                        Battlesentaku.playerhp = Battlesentaku.playerhp - monsterctrhit;
                        Console.WriteLine("阿部突然有feel了!他更奮力地動起他的腰!你受到了{0}傷害!", monsterctrhit);
                        Console.WriteLine("阿部露出了相當興奮的笑容!");
                        Console.ReadLine();
                        Battlesentaku.turn = Battlesentaku.turn + 1;
                    }

                    else { }

                }
                else { }

#endregion
#region
                if (Battlesentaku.monsterhp1 <= 0)
                {
                    Console.WriteLine("恭喜擊敗!");
                    Console.WriteLine("");
                    Console.WriteLine("_______________________________________________________________");
                }
                else if (Battlesentaku.playerhp <= 0)
                {
                    Console.WriteLine("你失敗了!要再試一次嗎?");
                    Console.Write("選1代表繼續,選2代表關閉程式  ");
                    Battlesentaku.battlesentaku1 = Console.ReadLine();
                    if (Battlesentaku.battlesentaku1 == "1")
                    {
                        Battlesentaku.playerhp = 100;
                        Battlesentaku.monsterhp1 = 130;
                        Battlesentaku.playermana = 100;
                        failedcount++;
                        switch (failedcount)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("提示一:不可硬上，只可智取。");
                                Console.WriteLine("");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("提示二:採取行動:行動代號:今日之內不變之常數。8碼");
                                Console.WriteLine("");
                                break;
                            case 3:
                                Console.WriteLine("");
                                Console.WriteLine("提示三:智慧之語:密語代號一:賦予你智慧的月份。2碼");
                                Console.WriteLine("");
                                break;
                            case 4:
                                Console.WriteLine("");
                                Console.WriteLine("提示四:智慧之語:密語代號二:陽之相反。非陰。1碼");
                                Console.WriteLine("");
                                break;
                            case 5:
                                Console.WriteLine("");
                                Console.WriteLine("提示五:智慧之語:密語代號三:賦予你生命的日子。2碼");
                                Console.WriteLine("");
                                break;
                            case 6:
                                Console.WriteLine("");
                                Console.WriteLine("提示六:智慧之語:密語代號四:密語代碼與行動代號中重複一次高的字。1碼");
                                Console.WriteLine("");
                                break;
                            default:
                                Console.WriteLine("");
                                Console.WriteLine("總提示:");
                                Console.WriteLine("提示一:不可硬上，只可智取。");
                                Console.WriteLine("提示二:採取行動:行動代號:今日之內不變之常數。8碼");
                                Console.WriteLine("提示三:智慧之語:密語代號一:賦予你智慧的月份。2碼");
                                Console.WriteLine("提示四:智慧之語:密語代號二:陽之相反。非陰。1碼");
                                Console.WriteLine("提示五:智慧之語:密語代號三:賦予你生命的日子。2碼");
                                Console.WriteLine("提示六:智慧之語:密語代號四:密語代碼與行動代號中重複為一次頻率最高的字。1碼");
                                Console.WriteLine("");
                                break;
                        }

                        goto a;
                    }
                }

                else if (Battlesentaku.battlesentaku1 == "2")
                {
                    System.Environment.Exit(System.Environment.ExitCode);
                }


                else
                {
                }
#endregion
            }

#endregion
        }
          

    }
}


