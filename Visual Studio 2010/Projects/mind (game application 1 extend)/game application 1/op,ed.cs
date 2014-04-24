using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    
        class opening
        {
            public static void OpeningDisplayMessage()
            {
                Console.WriteLine("據說是哈佛研究出來的人格分析測驗");
                Console.WriteLine("一共十題喔!");
                Console.WriteLine("____________________________________________________________________");

            }
        }

        class ending
        {
            public static void EndingDisplayMessage()
            {
                gametextingpattern b = new gametextingpattern(); // b是為了呼叫gametextingpattern類別中的a創建的物件
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine("結束!");
                Console.WriteLine("結果分數:{0}", b.A);
                //由於a是實體變數,所以用A來表示他的值
                if (b.A >= 12 && b.A <= 20)
                {

                    Console.WriteLine("你是個害羞的人喔！當處在人多的場合時，你便會感到不自在。你常會覺得你的身心生得不是很一致或覺得你生錯了時代。你實際上比你看起來要聰明多了但是你不想讓別人知道這點。大概是屬於那種深藏不露的人。你有一顆可以容納很多想法的”心” 可是也因為你有太多想法，所以常你的思緒塞車。");

                }
                else if (b.A >= 21 && b.A <= 30)
                {

                    Console.WriteLine("儘管生活是有崎嶇挫折，但你總有辦法克服，順利渡過！你遭遇過的挫折比一般人多。你曾經接觸過一些難相處的人、沒道理的規定和不和諧的人際關係。你對愛情的態度就像太陽表面一般熱情高溫。當你被很多煩人的事困擾的時候，你要不就是非常鎮定的靜觀其變要不就是以領導者的姿態出現叫大家都閉嘴。");

                }
                else if (b.A >= 31 && b.A <= 42)
                {

                    Console.WriteLine("大致而言，你算是一個冷靜的人會讓你興奮的情況有：1.當你愛的樂團或歌手要來舉行演唱會。2.和情人約會。3.和朋友跳舞的時候。對你來說，朋友比什麼都重要。你愛好藝術和喜歡詩詞。你喜歡辦party或幫朋友一齊籌劃party。通常你身旁不缺追求的人，但你總是三不五時碰到一些呆板不解風情的人。你喜歡戶外活動，即使下雨天也影響不了你愛好戶外活動的精神。認識你的人都覺得你是一個，可依賴值得信賴的人。");

                }
                else if (b.A >= 43 && b.A <= 53)
                {

                    Console.WriteLine("你有太多想法和計劃以致你總是覺得時間不夠用。如果你感到無聊你總是能夠想出辦法把場面炒熱。你是那種會讓人崇拜的人，你可以說是一個有能力讓”心想事成”的人。你通常不在乎別人的想法是個自我中心的人。你可以很自然的在大庭廣眾下親吻你的男/女朋友。”性”對你來說就像是一種充滿熱情的藝術品。即使有時候你也是一團糟，但你從不讓自己頹廢下去。");

                }
                else
                {

                }
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine("請按任一鍵退出.......");

            }
        }
    
}
