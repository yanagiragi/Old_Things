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
            //物件
            Console.Write("key serifu:");
            //選擇肢
            Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());
            //量化選擇之選擇肢


            while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3)
            {
                Console.WriteLine("again!");
                Console.Write("key serifu:");
                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

            }
            // 當input的是123以外的數字時,重做

            Console.WriteLine("textroadline1 = {0}", Textroadline.textroadline1);  //輸出,測示用

            if (Textroadline.textroadline1 == 1)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;

                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +1 暫定
            }
            else if (Textroadline.textroadline1 == 2)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +2 暫定
            }
            else if (Textroadline.textroadline1 == 3)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +3 暫定
            }
            else
            {
            }
            //判斷路線分歧(暫定 不考慮因選擇影響劇情)
            Console.WriteLine();
            //________________________________________________________________________________________________________________

            //選擇肢2開始     
            Console.Write("key serifu2:"); //選擇肢2
            Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());



            while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3)
            {

                Console.WriteLine("again!");
                Console.Write("key serifu2:"); //選擇肢2
                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("textroadline1 = {0}", Textroadline.textroadline1);  //輸出,測示用

            if (Textroadline.textroadline1 == 1)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;

                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +1 暫定
            }
            else if (Textroadline.textroadline1 == 2)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +2 暫定
            }
            else if (Textroadline.textroadline1 == 3)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +3 暫定
            }
            else
            {
            }
            //判斷路線分歧(暫定 不考慮因選擇影響劇情)
            Console.WriteLine();
            //________________________________________________________________________________________________________________

            //選擇肢3開始
            Console.Write("key serifu3:"); //選擇肢3
            Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());



            while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3)
            {

                Console.WriteLine("again!");
                Console.Write("key serifu3:"); //選擇肢3
                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("textroadline1 = {0}", Textroadline.textroadline1);  //輸出,測示用

            if (Textroadline.textroadline1 == 1)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;

                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +1 暫定
            }
            else if (Textroadline.textroadline1 == 2)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +2 暫定
            }
            else if (Textroadline.textroadline1 == 3)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +3 暫定
            }
            else
            {
            }
            //判斷路線分歧(暫定 不考慮因選擇影響劇情)
            Console.WriteLine();
            //________________________________________________________________________________________________________________

            //選擇肢4開始     
            Console.Write("key serifu4:"); //選擇肢4
            Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());



            while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3)
            {

                Console.WriteLine("again!");
                Console.Write("key serifu4:"); //選擇肢4
                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("textroadline1 = {0}", Textroadline.textroadline1);  //輸出,測示用

            if (Textroadline.textroadline1 == 1)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;

                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +1 暫定
            }
            else if (Textroadline.textroadline1 == 2)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +2 暫定
            }
            else if (Textroadline.textroadline1 == 3)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +3 暫定
            }
            else
            {
            }
            //判斷路線分歧(暫定 不考慮因選擇影響劇情)
            Console.WriteLine();
            //________________________________________________________________________________________________________________

            //選擇肢5開始     
            Console.Write("key serifu5:"); //選擇肢5
            Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());



            while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3)
            {

                Console.WriteLine("again!");
                Console.Write("key serifu5:"); //選擇肢5
                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("textroadline1 = {0}", Textroadline.textroadline1);  //輸出,測示用

            if (Textroadline.textroadline1 == 1)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;

                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +1 暫定
            }
            else if (Textroadline.textroadline1 == 2)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +2 暫定
            }
            else if (Textroadline.textroadline1 == 3)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +3 暫定
            }
            else
            {
            }
            //判斷路線分歧(暫定 不考慮因選擇影響劇情)
            Console.WriteLine();
            //________________________________________________________________________________________________________________

            //選擇肢6開始     
            Console.Write("key serifu6:"); //選擇肢6
            Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());



            while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3)
            {

                Console.WriteLine("again!");
                Console.Write("key serifu6:"); //選擇肢6
                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("textroadline1 = {0}", Textroadline.textroadline1);  //輸出,測示用

            if (Textroadline.textroadline1 == 1)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;

                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +1 暫定
            }
            else if (Textroadline.textroadline1 == 2)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +2 暫定
            }
            else if (Textroadline.textroadline1 == 3)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +3 暫定
            }
            else
            {
            }
            //判斷路線分歧(暫定 不考慮因選擇影響劇情)
            Console.WriteLine();
            //________________________________________________________________________________________________________________

            //選擇肢7開始     
            Console.Write("key serifu7:"); //選擇肢7
            Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());



            while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3)
            {

                Console.WriteLine("again!");
                Console.Write("key serifu7:"); //選擇肢7
                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("textroadline1 = {0}", Textroadline.textroadline1);  //輸出,測示用

            if (Textroadline.textroadline1 == 1)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;

                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +1 暫定
            }
            else if (Textroadline.textroadline1 == 2)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +2 暫定
            }
            else if (Textroadline.textroadline1 == 3)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +3 暫定
            }
            else
            {
            }
            //判斷路線分歧(暫定 不考慮因選擇影響劇情)
            Console.WriteLine();
            //________________________________________________________________________________________________________________

            //選擇肢8開始     
            Console.Write("key serifu8:"); //選擇肢8
            Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());



            while (Textroadline.textroadline1 != 1 && Textroadline.textroadline1 != 2 && Textroadline.textroadline1 != 3)
            {

                Console.WriteLine("again!");
                Console.Write("key serifu8:"); //選擇肢8
                Textroadline.textroadline1 = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("textroadline1 = {0}", Textroadline.textroadline1);  //輸出,測示用

            if (Textroadline.textroadline1 == 1)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 1;

                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +1 暫定
            }
            else if (Textroadline.textroadline1 == 2)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 2;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +2 暫定
            }
            else if (Textroadline.textroadline1 == 3)
            {
                Textroadline.textroadlineeffect1 = Textroadline.textroadlineeffect1 + 3;
                Console.WriteLine("Textroadline.textroadlineeffect1 = {0}", Textroadline.textroadlineeffect1);  //輸出,測示用
                // +3 暫定
            }
            else
            {
            }
            //判斷路線分歧(暫定 不考慮因選擇影響劇情)
            Console.WriteLine();
            //________________________________________________________________________________________________________________



        }
    }
}
