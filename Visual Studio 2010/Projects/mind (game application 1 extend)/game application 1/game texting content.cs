using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    namespace ConsoleApplication1
    {
        public class gametextingpattern
        {
            public static int a; //用a當實體變數把Textroadline.textroadlineeffect1的值弄成可被ending.EndingDisplayMessage();呼叫
            public int A
            {
                get //我不需要改變他的值所以不打set了
                {
                    return a;
                }
            }
            public static void GameTextingPattern()
            {

                global Textroadline = new global();
                Console.WriteLine("一 早上起床之後 通常吃什麼當早點?");
                Console.WriteLine("1. 蛋和吐司");
                Console.WriteLine("2. 麥片");
                Console.WriteLine("3. 汽水");
                Console.WriteLine("4. 什麼都不吃");
                Console.WriteLine("");
                Console.Write("你的選擇:");
                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());



                while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3 && Textroadline.textroadline1 != 4)
                {
                    Console.WriteLine("____________________________________________________________________");
                    Console.WriteLine("輸入錯誤!請再試一次!");
                    Console.WriteLine("一 早上起床之後 通常吃什麼當早點?");
                    Console.WriteLine("1. 蛋和吐司");
                    Console.WriteLine("2. 麥片");
                    Console.WriteLine("3. 汽水");
                    Console.WriteLine("4. 什麼都不吃");
                    Console.WriteLine("");
                    Console.Write("你的選擇:");
                    Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

                }
                // 當input的是1234以外的數字時,重做


                if (Textroadline.textroadline1 == 1)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                }
                else if (Textroadline.textroadline1 == 2)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;
                }
                else if (Textroadline.textroadline1 == 3)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 6;
                }
                else if (Textroadline.textroadline1 == 4)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                }
                else
                {
                }
                Console.WriteLine("____________________________________________________________________");

                Console.WriteLine("二 如果你可以選任何一樣你想吃的東西當早點你會選擇什麼?");
                Console.WriteLine("1. 蛋和吐司");
                Console.WriteLine("2. 其它別種東西");
                Console.WriteLine("3. 汽水");
                Console.WriteLine("4. 蛋糕");
                Console.WriteLine("");
                Console.Write("你的選擇:");

                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());


                while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3 && Textroadline.textroadline1 != 4)
                {
                    Console.WriteLine("____________________________________________________________________");
                    Console.WriteLine("輸入錯誤!請再試一次!");
                    Console.WriteLine("二 如果你可以選任何一樣你想吃的東西當早點你會選擇什麼?");
                    Console.WriteLine("1. 蛋和吐司");
                    Console.WriteLine("2. 其它別種東西");
                    Console.WriteLine("3. 汽水");
                    Console.WriteLine("4. 蛋糕");
                    Console.WriteLine("");
                    Console.Write("你的選擇:");
                    Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

                }

                //Console.WriteLine("textroadline1 = {0}", Textroadline.textroadline1);  //輸出,測示用

                if (Textroadline.textroadline1 == 1)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;

                }
                else if (Textroadline.textroadline1 == 2)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;
                }
                else if (Textroadline.textroadline1 == 3)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                }
                else if (Textroadline.textroadline1 == 4)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 4;
                }
                else
                {
                }
                Console.WriteLine("____________________________________________________________________");

                Console.WriteLine("三 午餐時?你會...");
                Console.WriteLine("1. 不吃東西 因為太忙或擔心體重");
                Console.WriteLine("2. 吃你想了一個早上想吃的東西");
                Console.WriteLine("3. 吃自己帶來的食物");
                Console.WriteLine("4. 問朋友要吃什麼 再一起去吃");
                Console.WriteLine("");
                Console.Write("你的選擇:");

                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

                while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3 && Textroadline.textroadline1 != 4)
                {
                    Console.WriteLine("____________________________________________________________________");
                    Console.WriteLine("輸入錯誤!請再試一次!");
                    Console.WriteLine("三 午餐時?你會...");
                    Console.WriteLine("1. 不吃東西 因為太忙或擔心體重");
                    Console.WriteLine("2. 吃你想了一個早上想吃的東西");
                    Console.WriteLine("3. 吃自己帶來的食物");
                    Console.WriteLine("4. 問朋友要吃什麼 再一起去吃");
                    Console.WriteLine("");
                    Console.Write("你的選擇:");
                    Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

                }

                if (Textroadline.textroadline1 == 1)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                }
                else if (Textroadline.textroadline1 == 2)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;
                }
                else if (Textroadline.textroadline1 == 3)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                }
                else if (Textroadline.textroadline1 == 4)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 4;
                }
                else
                {
                }
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine("四 一位朋友請你吃一些她/他帶來的食物 你會...");
                Console.WriteLine("1. 吃一小口 因為實在太餓了");
                Console.WriteLine("2. 為了保持禮貌 只吃一小口");
                Console.WriteLine("3. 拒絕他/她的好意 因為你正在減肥");
                Console.WriteLine("4. 吃兩口");
                Console.WriteLine("");
                Console.Write("你的選擇:");
                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());


                while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3 && Textroadline.textroadline1 != 4)
                {
                    Console.WriteLine("____________________________________________________________________");
                    Console.WriteLine(" 輸入錯誤!請再試一次!");
                    Console.WriteLine("四 一位朋友請你吃一些她/他帶來的食物 你會...");
                    Console.WriteLine("1. 吃一小口 因為實在太餓了");
                    Console.WriteLine("2. 為了保持禮貌 只吃一小口");
                    Console.WriteLine("3. 拒絕他/她的好意 因為你正在減肥");
                    Console.WriteLine("4. 吃兩口");
                    Console.WriteLine("");
                    Console.Write("你的選擇:");
                    Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

                }


                if (Textroadline.textroadline1 == 1)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                }
                else if (Textroadline.textroadline1 == 2)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;
                }
                else if (Textroadline.textroadline1 == 3)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                }
                else if (Textroadline.textroadline1 == 4)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 6;
                }
                else
                {
                }
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine("五 你未來的男/女朋友請你吃一樣 東西 你想那會是什麼?");
                Console.WriteLine("1. 一塊蛋糕");
                Console.WriteLine("2. 一顆蘋果");
                Console.WriteLine("3. 一片批薩");
                Console.WriteLine("4. 一個胡蘿蔔");
                Console.WriteLine("");
                Console.Write("你的選擇:");

                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

                while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3 && Textroadline.textroadline1 != 4)
                {
                    Console.WriteLine("____________________________________________________________________");
                    Console.WriteLine("輸入錯誤!請再試一次!");
                    Console.WriteLine("五 你未來的男/女朋友請你吃一樣 東西 你想那會是什麼?");
                    Console.WriteLine("1. 一塊蛋糕");
                    Console.WriteLine("2. 一顆蘋果");
                    Console.WriteLine("3. 一片批薩");
                    Console.WriteLine("4. 一個胡蘿蔔");
                    Console.WriteLine("");
                    Console.Write("你的選擇:");
                    Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

                }


                if (Textroadline.textroadline1 == 1)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;
                }
                else if (Textroadline.textroadline1 == 2)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                }
                else if (Textroadline.textroadline1 == 3)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 5;
                }
                else if (Textroadline.textroadline1 == 4)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                }
                else
                {
                }
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine("六 你的狗對你奮力搖尾巴 企圖引起你的注意 你會給他...");
                Console.WriteLine("1. 給他一塊狗餅乾");
                Console.WriteLine("2. 一些蛋糕");
                Console.WriteLine("3. 什麼都不給 拍拍他就好");
                Console.WriteLine("4. 什麼都不給 還把他趕開 因為你認為不能讓你的狗養成要什麼有什麼的壞習慣");
                Console.WriteLine("");
                Console.Write("你的選擇:");

                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());


                while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3 && Textroadline.textroadline1 != 4)
                {
                    Console.WriteLine("____________________________________________________________________");
                    Console.WriteLine("輸入錯誤!請再試一次!");
                    Console.WriteLine("六 你的狗對你奮力搖尾巴 企圖引起你的注意 你會給他...");
                    Console.WriteLine("1. 給他一塊狗餅乾");
                    Console.WriteLine("2. 一些蛋糕");
                    Console.WriteLine("3. 什麼都不給 拍拍他就好");
                    Console.WriteLine("4. 什麼都不給 還把他趕開 因為你認為不能讓你的狗養成要什麼有什麼的壞習慣");
                    Console.WriteLine("");
                    Console.Write("你的選擇:");
                    Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

                }

                if (Textroadline.textroadline1 == 1)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;

                }
                else if (Textroadline.textroadline1 == 2)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;
                }
                else if (Textroadline.textroadline1 == 3)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 4;
                }
                else if (Textroadline.textroadline1 == 4)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                }
                else
                {
                }
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine("七 夢中 你正在一家全世界最棒的餐廳裡 你想你會點...");
                Console.WriteLine("1. 菜單上列的每道菜 反正是做夢嘛!!");
                Console.WriteLine("2. 一個大盤 裡面什麼東西都有的沙拉");
                Console.WriteLine("3. 牛排");
                Console.WriteLine("4. 一個會讓你多長很多肥油的點心");
                Console.WriteLine("");
                Console.Write("你的選擇:");

                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());


                while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3 && Textroadline.textroadline1 != 4)
                {
                    Console.WriteLine("____________________________________________________________________");
                    Console.WriteLine("輸入錯誤!請再試一次!");
                    Console.WriteLine("七 夢中 你正在一家全世界最棒的餐廳裡 你想你會點...");
                    Console.WriteLine("1. 菜單上列的每道菜 反正是做夢嘛!!");
                    Console.WriteLine("2. 一個大盤 裡面什麼東西都有的沙拉");
                    Console.WriteLine("3. 牛排");
                    Console.WriteLine("4. 一個會讓你多長很多肥油的點心");
                    Console.WriteLine("");
                    Console.Write("你的選擇:");
                    Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

                }
                if (Textroadline.textroadline1 == 1)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                }
                else if (Textroadline.textroadline1 == 2)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;
                }
                else if (Textroadline.textroadline1 == 3)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                }
                else if (Textroadline.textroadline1 == 4)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 4;
                }
                else
                {
                }
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine("八 在一個熱帶島上 你覺得什麼食物是你一定要吃到的?");
                Console.WriteLine("1. 水果和蔬蔡");
                Console.WriteLine("2. 肉和馬玲薯");
                Console.WriteLine("3. 冰淇淋 巧克力和蛋糕?");
                Console.WriteLine("4. 中國菜");
                Console.WriteLine("");
                Console.Write("你的選擇:");

                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());


                while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3 && Textroadline.textroadline1 != 4)
                {
                    Console.WriteLine("____________________________________________________________________");
                    Console.WriteLine("輸入錯誤!請再試一次!");
                    Console.WriteLine("八 在一個熱帶島上 你覺得什麼食物是你一定要吃到的?");
                    Console.WriteLine("1. 水果和蔬蔡");
                    Console.WriteLine("2. 肉和馬玲薯");
                    Console.WriteLine("3. 冰淇淋 巧克力和蛋糕?");
                    Console.WriteLine("4. 中國菜");
                    Console.WriteLine("");
                    Console.Write("你的選擇:");
                    Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

                }

                if (Textroadline.textroadline1 == 1)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 4;

                }
                else if (Textroadline.textroadline1 == 2)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                }
                else if (Textroadline.textroadline1 == 3)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                }
                else if (Textroadline.textroadline1 == 4)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 5;
                }
                else
                {
                }
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine("九 你現在是一個嬰兒 你媽媽正在餵你吃...");
                Console.WriteLine("1. 嬰兒麥片或嬰兒食物");
                Console.WriteLine("2. 肉和馬鈴薯");
                Console.WriteLine("3. 綠色花椰菜");
                Console.WriteLine("4. 什麼都沒有 你媽正在做別的事");
                Console.WriteLine("");
                Console.Write("你的選擇:");

                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());


                while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3 && Textroadline.textroadline1 != 4)
                {
                    Console.WriteLine("____________________________________________________________________");
                    Console.WriteLine("輸入錯誤!請再試一次!");
                    Console.WriteLine("九 你現在是一個嬰兒 你媽媽正在餵你吃...");
                    Console.WriteLine("1. 嬰兒麥片或嬰兒食物");
                    Console.WriteLine("2. 肉和馬鈴薯");
                    Console.WriteLine("3. 綠色花椰菜");
                    Console.WriteLine("4. 什麼都沒有 你媽正在做別的事");
                    Console.WriteLine("");
                    Console.Write("你的選擇:");
                    Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

                }

                if (Textroadline.textroadline1 == 1)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 6;
                }
                else if (Textroadline.textroadline1 == 2)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 4;
                }
                else if (Textroadline.textroadline1 == 3)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 8;
                }
                else if (Textroadline.textroadline1 == 4)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                }
                else
                {
                }
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine(" 十 你現在是六歲的小孩 你爸爸正在餵你吃...");
                Console.WriteLine("1. 批薩");
                Console.WriteLine("2. 義大利麵");
                Console.WriteLine("3. 泡泡糖");
                Console.WriteLine("4. 胡蘿蔔");
                Console.WriteLine("");
                Console.Write("你的選擇:");
                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

                while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3 && Textroadline.textroadline1 != 4)
                {
                    Console.WriteLine("____________________________________________________________________");
                    Console.WriteLine("輸入錯誤!請再試一次!");
                    Console.WriteLine("十 你現在是六歲的小孩 你爸爸正在餵你吃...");
                    Console.WriteLine("1. 批薩");
                    Console.WriteLine("2. 義大利麵");
                    Console.WriteLine("3. 泡泡糖");
                    Console.WriteLine("4. 胡蘿蔔");
                    Console.WriteLine("");
                    Console.Write("你的選擇:");

                    Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

                }

                if (Textroadline.textroadline1 == 1)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 7;

                }
                else if (Textroadline.textroadline1 == 2)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 5;
                }
                else if (Textroadline.textroadline1 == 3)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;
                }
                else if (Textroadline.textroadline1 == 4)
                {
                    Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                }
                else
                {
                }
                a = Textroadline.textroadlineeffect1;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", a);  //輸出,測示用
            }
        }
    }

