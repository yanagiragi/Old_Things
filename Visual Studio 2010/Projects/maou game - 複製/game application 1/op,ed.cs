using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class openingending
    {
        static public string playername;
        public static  string OpeningDisplayMessage(int wuso)
        {
            //int wuso = 0;
            global playernameprop = new global();

            Console.Write("請輸入你的名字:");
            playername = Console.ReadLine();
            Console.WriteLine("");

            while (wuso == 0)
            {
                Console.WriteLine("你真的確定嗎? 1 我很確定(我、很確定!) 2 我還是改一下好了...");
                wuso = Convert.ToInt32(Console.ReadLine()) - 1;
                if (wuso == 1)
                {
                    Console.WriteLine("哈哈騷年為時已晚啦 ~ 謎之拳五郎: 你，已經死了。(大誤)");
                    Console.WriteLine("__________________________________________________________");
                }
                else if (wuso == 0)
                {

                }
                else if (wuso != 0 && wuso != 1)
                {
                    Console.WriteLine("愛亂選那就不給你改囉!");
                    Console.WriteLine("__________________________________________________________");
                    break;
                }
                else { }
            }
            
            Console.WriteLine("");
            Console.WriteLine("於是.....故事開始了。");
            Console.ReadLine();
            Console.WriteLine("時值平安時代，沒錯，就在柏林圍牆倒下後不久，");
            Console.ReadLine();
            Console.WriteLine("我知道你在想甚麼，不要問，你會怕。");
            Console.ReadLine();
            Console.WriteLine("不會怕就算了。人家好難過喔~");
            Console.ReadLine();
            Console.WriteLine("少年--{0} 誕。生。了。 可喜可賀。可喜可賀。", playername);
            Console.ReadLine();
            Console.WriteLine("殊不知他的誕生，將會引起一陣滔天的風暴......");
            Console.ReadLine();
            Console.WriteLine("註記：不是家庭風暴。");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("~序章完~");
            Console.WriteLine("__________________________________________________________");
            Console.WriteLine("");
            //Console.ReadLine();
            
            return playername;

        }




        public static void endingDisplayMessage()
        {
            //opening ending = new opening();
            Console.WriteLine("一場偉大的戰役，總是帶來難以抹平的創傷。");
            Console.ReadLine();
            Console.WriteLine("然而，也會收穫不少。");
            Console.ReadLine();
            Console.WriteLine("對現在的{0}來說，他是再也清楚不過的。",playername);
            Console.ReadLine();
            Console.WriteLine("......因為這場戰鬥後，他多出了一隻寵物(?)");
            Console.ReadLine();
            Console.WriteLine("曾經是魔王，就某個份面來說相當強硬、強悍的寵物。");
            Console.ReadLine();
            Console.WriteLine("他的寵物，總是嬌蠻的要求進食，不然他就要去危害別人。");
            Console.ReadLine();
            Console.WriteLine("無奈的{0}也只好為了大義，乖乖成為它的食物(?)", playername);
            Console.ReadLine();
            Console.WriteLine("\"我......有沒有成為像老爺爺那樣偉大就義的人呢?\"");
            Console.ReadLine();
            Console.WriteLine("{0}經常如此想著。",playername);
            Console.ReadLine();
            Console.WriteLine("今天，又是個要咬緊牙根，加緊屁股的好日子。");
            Console.ReadLine();
            Console.WriteLine("......");
            Console.ReadLine();
            Console.WriteLine("........");
            Console.ReadLine();
            Console.WriteLine("..........");
            Console.ReadLine();
            Console.WriteLine("從前從前，流傳著一個故事。");
            Console.ReadLine();
            Console.WriteLine("有一名勇者，犧牲了自己打敗魔王拯救了大家。");
            Console.ReadLine();
            Console.WriteLine("然而，卻沒有知道這個故事的真相。");
            Console.ReadLine();
            Console.WriteLine("..........");            
            Console.ReadLine();
            Console.WriteLine("從前從前，");
            Console.ReadLine();
            Console.WriteLine("從前從前，時值大航海時代，沒錯，就在萬里長城倒下後不久，");
            Console.ReadLine();
            Console.WriteLine("少年，誕生了。");
            Console.ReadLine();
            Console.WriteLine("故事，又將開始了。");
            Console.ReadLine();
            Console.WriteLine("~終章完~");
            Console.WriteLine("__________________________________________________________");
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}


