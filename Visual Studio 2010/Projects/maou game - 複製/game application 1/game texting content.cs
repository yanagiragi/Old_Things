using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class gametextingpattern
    {
        public static void GameTextingPattern()
        {
            global Textroadline = new global();
            //openingending playernameprop = new openingending();
            //物件

            Console.WriteLine("");
            Console.WriteLine("故事......要從騷年的誕生說起....");
            Console.ReadLine();
            Console.WriteLine("很久很久以前.....有一對老夫婦，他們多年來膝下無子...");
            Console.ReadLine();
            Console.WriteLine("因為老先生嚴重不舉....(笑)");
            Console.ReadLine();
            Console.WriteLine("但是，神明再次給他們一次機會....");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("有一天，老夫婦們家前的小河飄來了一個異物");
            Console.ReadLine();
            Console.WriteLine("那竟然是........長得像桃子一樣的屁股!");
            Console.ReadLine();
            Console.WriteLine("咬到舌頭了......是長得像屁股一樣的桃子");
            Console.ReadLine();
            Console.WriteLine("老夫婦們便不疑有他，從褲檔抄出一把藍波刀就這樣劈了下去!!!");
            Console.ReadLine();
            Console.WriteLine("只聞刀聲霍霍，老先生一招\"流星墜月\"就這樣夾著淒厲的風勢下刀!!");
            Console.ReadLine();
            Console.WriteLine("只見那屁股...不對是桃子，竟然緩緩抖了兩下，竟噴出了大樣的鮮血!!");
            Console.ReadLine();
            Console.WriteLine("那血噴得可真快，霎那間老夫婦兩人被那血流捲進河流之中，從此失去下落...");
            Console.ReadLine();
            Console.WriteLine("說時遲那時快，屁股竟伴隨著一聲慘叫 \"要...裂開了!!!\" 從中裂開了");
            Console.ReadLine();
            Console.WriteLine("還伴隨著雙眼上翻比\"耶\"的表情呢。");
            Console.ReadLine();
            Console.WriteLine("從中，滾出了一名少年。");
            Console.ReadLine();
            Console.WriteLine("沒錯那就是......");
            Console.ReadLine();
            Console.WriteLine("屁太郎--{0}", openingending.playername);
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("~前章完~");
            Console.WriteLine("__________________________________________________________");


            Console.WriteLine("");
            Console.WriteLine("於是十八年過去了......");
            Console.ReadLine();
            Console.WriteLine("由於出生時就是少年的樣子，少年現在的樣子根本就是魔法師嘛(笑)");
            Console.ReadLine();
            Console.WriteLine("不不不，{0} 真的是一位魔法師，而且快變成黑魔法師了(爆笑)", openingending.playername);
            Console.ReadLine();
            Console.WriteLine("言歸正傳，少年踏上了旅程。");
            Console.ReadLine();
            Console.WriteLine("我知道你在想甚麼，不要問，你會ㄆㄚ..(毆打聲)....總而言之少年踏上了旅程。");
            Console.ReadLine();
            Console.WriteLine("少年第一個到達的地方，是個飽受魔王侵擾的小村子。");
            Console.ReadLine();
            Console.WriteLine("\"真是慘啊...\"魔法師(笑){0}說道。", openingending.playername);
            Console.ReadLine();
            Console.WriteLine("此時，突然一股像怪物般細瘦的手抓住了{0}!!", openingending.playername);
            Console.ReadLine();
            Console.WriteLine("\"求求你，幫幫我...\" 原來是一位倒在路邊的老太太");
            Console.ReadLine();
            Console.WriteLine("\"勇者，幫幫我...我的女兒被魔王抓走了!!請你救救她!!\" 倒在路邊的老太太央求著");
            Console.ReadLine();

        a:
            Console.Write("怎麼辦? 1 推開她，乾我屁事! 2 好吧,我喜歡幫助別人，尤其是倒在路邊的老太太!  ");
            Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2)
            {
                Console.WriteLine("輸入錯誤!");
                Console.Write("怎麼辦? 1 推開她不理她，乾我屁事! 2 好吧,我喜歡幫助別人，尤其是倒在路邊的老太太!  ");
                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

            }  // 當input的是123以外的數字時,重做

            if (Textroadline.textroadline1 == 1)
            {
                Console.WriteLine("\"滾開!干我屁屁事!\"你朝倒在路邊的老太太踹了一腳");
                Console.ReadLine();
                Console.WriteLine("結果老太太爆炸了。");
                Console.ReadLine();
                Console.WriteLine("你被炸死了。");
                Console.ReadLine();

            b:
                Console.WriteLine("Game Over...");
                Console.ReadLine();
                Console.WriteLine("你失敗了!要再試一次嗎?");
                Console.WriteLine("選1代表繼續,選2代表關閉程式");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    goto a;
                }
                else if (a == 2)
                {
                    System.Environment.Exit(System.Environment.ExitCode);
                }
                else
                {
                    Console.WriteLine("輸入錯誤");
                    goto b;
                }
            }
            else if (Textroadline.textroadline1 == 2)
            {
                goto c;
            }
            else
            {
            }
        c:
            Console.WriteLine("{0}選擇接受老太太的委託。", openingending.playername);
            Console.ReadLine();
            Console.WriteLine("老太太瞬間爬起來交給你一張地圖，然後跑走了。");
            Console.ReadLine();
            Console.WriteLine("......究竟是命運的操弄呢？還是一切都只是必然呢？讓我們看下去...");
            Console.ReadLine();
            Console.WriteLine("說時遲，那時快。{0}到達魔王城了。", openingending.playername);
            Console.ReadLine();
            Console.WriteLine("只見大門深鎖。門似乎很硬(廢話)");
            Console.ReadLine();


        d:
            Console.Write("怎麼辦? 1 用力撞開 2 走側門 ");
            Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2)
            {
                Console.WriteLine("輸入錯誤!");
                Console.Write("怎麼辦? 1 用力撞開 2 走側門 ");
                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

            }  // 當input的是12以外的數字時,重做

            if (Textroadline.textroadline1 == 2)
            {
                Console.WriteLine("你走向側門。");
                Console.ReadLine();
                Console.WriteLine("結果遇到魔王成的守衛---貞子!!!。");
                Console.ReadLine();
                Console.WriteLine("進入戰鬥!!!");
                Console.WriteLine("");
                Console.WriteLine("__________________________________________________________");
                battle2.Battle2display();
                Console.WriteLine("你打敗了貞子後，推開側門。");
                Console.ReadLine();
                Console.WriteLine("結果門後只有著，倒插著許多尖刺的巨大洞穴......");
                Console.ReadLine();
                Console.WriteLine("當{0}打算說\"WTF?\"時，他背後突然被人推了一把...!", openingending.playername);
                Console.ReadLine();
                Console.WriteLine("騷年無力的下墜，臨死前只看到剛才交給他地圖的老婆婆站在他本來的位子的後方...");
                Console.ReadLine();
                Console.WriteLine("\"這是為了我剛才被你殺掉女兒!\"老婆婆淒厲的吼叫著。");
                Console.ReadLine();
                Console.WriteLine("{0}只感受到腹部遭到刺穿的感覺，及喉嚨有股灼熱感不斷湧升。然後，失去了意識。", openingending.playername);
                Console.ReadLine();
                Console.WriteLine("你死了。 Game Over......");
                Console.ReadLine();
            e:
                Console.WriteLine("你失敗了!要再試一次嗎?");
                Console.WriteLine("選1代表繼續,選2代表關閉程式");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    goto d;
                }
                else if (a == 2)
                {
                    System.Environment.Exit(System.Environment.ExitCode);
                }
                else
                {
                    Console.WriteLine("輸入錯誤");
                    goto e;
                }



            }
            else if (Textroadline.textroadline1 == 1)
            {
                Console.WriteLine("在撞了第三次後，門終於被撞開。於是{0}走進了魔王城。", openingending.playername);
                Console.ReadLine();
                Console.WriteLine("魔王城內部卻是一片空城。前方隱約傳來啪啪聲。");
                Console.ReadLine();
                Console.WriteLine("究竟要不要前去探查呢?");
                Console.ReadLine();
                Console.WriteLine("你以為可以選選項? 是男人當然要前去偷看，不，是察看啦!");
                Console.ReadLine();
                Console.WriteLine("只見你離傳出啪啪聲的房間越來越近......");
                Console.ReadLine();
                Console.WriteLine("究竟會看到甚麼呢?");
                Console.ReadLine();
                Console.WriteLine("我們下回分曉。");
                Console.ReadLine();
                Console.WriteLine("等等，等等啦!剛剛是開玩笑的!不要按下關閉鍵啊!!");
                Console.ReadLine();
                Console.WriteLine("那麼，究竟會看到甚麼呢?");
                Console.ReadLine();
                Console.WriteLine("{0}用力推開那扇房間的門!卻發現超乎意料之外的事實!", openingending.playername);
                Console.ReadLine();
                Console.WriteLine("老先生竟然在跟阿部啪啪啪!!");
                Console.ReadLine();
                Console.WriteLine("不過雖著震驚而來的，馬上就是悲傷了。");
                Console.ReadLine();
                Console.WriteLine("老先生暴斃了。");
                Console.ReadLine();
                Console.WriteLine("似乎是因為玩法太激烈了(?)");
                Console.ReadLine();
                Console.WriteLine("管他的，反正就是死了。");
                Console.ReadLine();
                Console.WriteLine("阿部停下動作，緩緩地轉過來面對你。開口了。");
                Console.ReadLine();
                Console.WriteLine("\"我就是人稱六肛魔王的阿部，你是來成為我的下一個687的嗎?\"");
                Console.ReadLine();
                Console.WriteLine("阿部上下打良著你的腰部，淫蕩極的笑了。");
                Console.ReadLine();
                Console.WriteLine("\"人家....人家才不是呢!\"{0}嬌羞地反駁了，不愧是神受啊。", openingending.playername);
                Console.ReadLine();
                Console.WriteLine("\"我!我是來打倒你的!!納屁來!\"{0}大吼一聲，像魔王阿部衝刺!", openingending.playername);
                Console.ReadLine();
                Console.WriteLine("\"哼哼，真是愛搗蛋的孩子呢，看來需要調教一下？\"魔王阿部如此說了。");
                Console.ReadLine();
                Console.WriteLine("\"來吧!好男人，不來嗎!\"");
                Console.ReadLine();
                Console.WriteLine("強者之間無須對話，唯有一戰!");
                Console.ReadLine();
                Console.WriteLine("註記：那剛講那麼多是要死喔。");
                Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("進入戰鬥!!");
                Console.WriteLine("__________________________________________________________");
                battle1.Battle1display();

                Console.WriteLine("\"想不到...我也有這麼一天...\"阿部痛苦的喘著氣說道。");
                Console.ReadLine();
                Console.WriteLine("{0}:........", openingending.playername);
                Console.ReadLine();
                Console.WriteLine("\"看來我...輸了呢...\"阿部的身體不停的搖晃。");
                Console.ReadLine();
                Console.WriteLine("\"拿去吧......這是我們道館的徽章...\"阿部斷斷續續的說道。");
                Console.ReadLine();
                Console.WriteLine("\"不對...我在說甚麼...可惡...終於連話都說錯了嗎...\"阿部咋舌了一下。");
                Console.ReadLine();
                Console.WriteLine("\"那些我從別人身上奪走的...你都拿去吧...\"");
                Console.ReadLine();
                Console.WriteLine("\"全部都...接受吧...\"語畢，魔王便倒下了。");
                Console.ReadLine();
                Console.WriteLine("你陡然繳一軟，重重的坐下了。");
                Console.ReadLine();
                Console.WriteLine("一場偉大的戰役背後，總是伴隨著難以衡量的辛苦及代價。");
                Console.ReadLine();
                Console.WriteLine("現在的{0}，深深的體驗這句話了。", openingending.playername);
                Console.ReadLine();
                Console.WriteLine("突然，倒下去的阿部那邊傳來了阿部的聲音。");
                Console.ReadLine();
                Console.WriteLine("\"全部都接受吧...當然....還~有~我~ 啾~\"");
                Console.ReadLine();
                Console.WriteLine("......");
                Console.ReadLine();
                Console.WriteLine("........");
                Console.ReadLine();
                Console.WriteLine("..........");
                Console.ReadLine();
                Console.WriteLine("蛤?!");
                Console.ReadLine();
                Console.WriteLine("~後章完~");
                Console.WriteLine("__________________________________________________________");
                Console.WriteLine("");
                Console.ReadLine();

            }
            else { }



        }
    }
}



    
