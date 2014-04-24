using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace card_program
{
    public class Card
    {

        static string cardId;  //實體變數
        static int balance;     //實體變數
        static int count;       //實體變數

        public Card(string a,int b,int c) //constructer
        {
            cardId=a;
            balance=b;
            count=c;
        }

        public string cardIdgetset //properties:get,set
        {
            get
            {
                return cardId;
            }
            set
            {
                cardId = value;
            }

        }
        public int balancegetset //properties:get,set
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }

        }
        public int countgetset //properties:get,set
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }

        }


         public void DisplayCardInfo()
          {            
              Console.WriteLine("Your ID: {0}",cardId);
              Console.WriteLine("Your Balance: {0}", balance);
              Console.WriteLine("Your Count:{0}",count);
              Console.WriteLine(".............................................");

          }


         public void BuyTicket()
         {
             int sentaku; //選項
             Console.WriteLine("What do you want to buy?      已購買次數: {0} ", count);
             Console.WriteLine("買 嘉義-台北 自強號 來回票價 1196元 請選 (1) ");
             Console.WriteLine("買 嘉義-高雄 自強號 來回票價  490元 請選 (2) ");
             Console.WriteLine("離開                                請選 (3) ");
             Console.Write("你的選擇:");
             sentaku = Convert.ToInt32(Console.ReadLine());

             while (sentaku != 1 && sentaku != 2 && sentaku != 3) //輸入錯誤的情況
             {
                 Console.WriteLine("____________________________________________________________________");
                 Console.WriteLine("輸入錯誤!請再試一次!");
                 Console.WriteLine("What do you want to buy?      已購買次數: {0} ", count);
                 Console.WriteLine("買 嘉義-台北 自強號 來回票價 1196元 請選 (1) ");
                 Console.WriteLine("買 嘉義-高雄 自強號 來回票價  490元 請選 (2) ");
                 Console.WriteLine("離開                                請選 (3) ");
                 Console.Write("你的選擇:");
                 sentaku = Convert.ToInt32(Console.ReadLine());
             }

             while (balance > 0) //金額大於0
             {
                 if (sentaku == 1)
                 {
                     Console.WriteLine("____________________________________________________________________");
                     count = count + 1;
                     balance =balance - 1196;
                     if (balance >0)//扣完餘額尚足
                     {
                         DisplayCardInfo();
                         Console.WriteLine("");
                         Console.WriteLine("What do you want to buy?      已購買次數: {0} ", count);
                         Console.WriteLine("買 嘉義-台北 自強號 來回票價 1196元 請選 (1) ");
                         Console.WriteLine("買 嘉義-高雄 自強號 來回票價  490元 請選 (2) ");
                         Console.WriteLine("離開                                請選 (3) ");
                         Console.Write("你的選擇:");
                         sentaku = Convert.ToInt32(Console.ReadLine());
                     }
                     else { }

                 }
                 else if (sentaku == 2)
                 {
                     Console.WriteLine("____________________________________________________________________");
                     count = count + 1;
                     balance = balance - 490;

                     if (balance >0) //扣完餘額尚足
                     {
                         DisplayCardInfo();
                         Console.WriteLine("");
                         Console.WriteLine("What do you want to buy?      已購買次數: {0} ", count);
                         Console.WriteLine("買 嘉義-台北 自強號 來回票價 1196元 請選 (1) ");
                         Console.WriteLine("買 嘉義-高雄 自強號 來回票價  490元 請選 (2) ");
                         Console.WriteLine("離開                                請選 (3) ");
                         Console.Write("你的選擇:");
                         sentaku = Convert.ToInt32(Console.ReadLine());
                     }
                     else { }
                     
                 }
                 else if (sentaku == 3)
                 {
                     Console.WriteLine("____________________________________________________________________");
                     Console.WriteLine("結束!");
                     DisplayCardInfo();
                     balance = balance - 5001; //跳出迴圈while
                     Console.Write("請按enter鍵結束......");
                     Console.Read();
                 }
                 else
                 {
                 }
             }//end while()balance>0
         
             if (balance <= 0) //金額小於0
             {
                 if (sentaku == 1 && balance <= 0) //選1選項,多扣1196元和1次的購買次數
                 {
                     balance = balance + 1196;
                     count--;
                 }
                 else if (sentaku == 2 && balance <= 0) //選2選項,多扣490元和1次的購買次數
                 {
                     balance = balance + 490;
                     count--;

                 }
                 else {
                     count--;
                 }
                 Console.WriteLine("餘額不足!");
                 DisplayCardInfo();
                 Console.Write("請按enter鍵結束......");
                 Console.Read();

             }
             else
             {
             }

         }
   
        
   }
 }

