using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Player
    {
        private int plrmoney,makmoney;
        private string plrname,makname;       
        decksofcard dd = new decksofcard();
        Card[] plr,mak,cons;
        


        public void cons1()
        {
            cons = new Card[5];
        }
                 

        public Player(string playername)
        {
            plrmoney = 1000;
            plrname = playername;        
        }

        public Player(int returns)
        {
            makmoney = 1000;
            makname = "莊家";
        }      

        public void game(string a)
        {
            dd.construct();
            dd.shuffle();
            plr = new Card[5];
            for(int a1 = 0;a1 < plr.Length ; a1++)
            {
                plr[a1] = dd.dealcard();
                cons[a1] = plr[a1];
                Console.WriteLine("{0}", plr[a1]);
                //Console.WriteLine("{0} {1}", decksofcard.array1[a1],decksofcard.array2[a1]);
            }
             //count shape,number
            int[] shapecount={0,0,0,0,0};
            for (int ti = 0; ti < plr.Length; ti++)
            {
                switch (decksofcard.array1[ti])
                {
                    case 1:
                        shapecount[1]++;
                        break;
                    case 2:
                        shapecount[2]++;
                        break;
                    case 3:
                        shapecount[3]++;
                        break;
                    case 4:
                        shapecount[4]++;
                        break;
                    default:
                        break;
                }
            }
            int[] nmucount={0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            for (int ti = 0; ti < plr.Length; ti++)
            {
                switch (decksofcard.array2[ti])
                {
                    case 1:
                        nmucount[1]++;
                        //Console.WriteLine("{0}", nmucount[1]);
                        break;
                    case 2:
                        nmucount[2]++;
                       // Console.WriteLine("{0)", nmucount[2]);
                        break;
                    case 3:
                        nmucount[3]++;
                       // Console.WriteLine("{0)", nmucount[3]);
                        break;
                    case 4:
                        nmucount[4]++;
                        break;
                    case 5:
                        nmucount[5]++;
                        break;
                    case 6:
                        nmucount[6]++;
                        break;
                    case 7:
                        nmucount[7]++;
                        break;
                    case 8:
                        nmucount[8]++;
                        break;
                    case 9:
                        nmucount[9]++;
                        break;
                    case 10:
                        nmucount[10]++;
                        break;
                    case 11:
                        nmucount[11]++;
                        break;
                    case 12:
                        nmucount[12]++;
                        break;
                    case 13:
                        nmucount[13]++;
                        break;
                    default:
                        break;
                }
                
            }
            
            //Console.WriteLine("{0)", nmucount[1]);
            for (int ti = 0; ti < 14; ti++)
            {
                //Console.WriteLine("{0}",nmucount[ti]);
            }
            

            
            //輸出pairs
            int o1=0, o2=0, o3=0, o4=0;
            int p1 = 1, p2 = 0;
            foreach(int spcount in nmucount)
            {                
                if(spcount==2)
                {
                    if (p1 == 1)
                    {
                        o1 = decksofcard.array2[spcount];
                        p1 = p1 - 1;
                    }
                    else
                    {
                        o2 = decksofcard.array2[spcount];
                    }
                }
                else if(spcount==3)
                    o3 = decksofcard.array2[spcount];
                else if(spcount==4)
                    o4 = decksofcard.array2[spcount];
                else { p2++; }
                               
            }


            Console.WriteLine("a" + o1 + o2 + o3 + o4);

            int gr1 = 0;
            foreach (int ti in decksofcard.array2)
            {
                if (decksofcard.array2[ti] > gr1)
                    gr1 = decksofcard.array2[ti];                
            }
            //int dd12 = Math.Max(decksofcard.array2[1], decksofcard.array2[2], decksofcard.array2[3], decksofcard.array2[4], decksofcard.array2[0]);
            //Console.WriteLine("{0}", gr1);
             for (int ti = 0; ti < 5; ti++)
                {
                    Console.WriteLine("{0}", decksofcard.array2[ti]);
                }


             //int dd1 = Math.Max(decksofcard.array2[1], decksofcard.array2[2]);
            // int dd2 = Math.Max(decksofcard.array2[3], decksofcard.array2[4]);
             //int dd3 = Math.Max(dd1, dd2);
            // int dd4 = Math.Max(dd3, decksofcard.array2[0]);




            
            
            if (p2 == 14) 
            {
                
               

               
                
               /* if( (cco[4]-cco[3])==1 && (cco[3]-cco[2])==1 && (cco[2]-cco[1])==1 && (cco[1]-cco[0])==1 )
                {
                    Console.WriteLine("");                 
                    Console.WriteLine("straight!");
                    int numpit = 0;
                    numpit = cco[4];
                    Console.WriteLine("{0}", numpit);
                }
                else
                {*/
                    Console.WriteLine("");
                    Console.WriteLine("no pairs");
                   // int numtot = 0;                    
                   // numtot =  cco[0]+ cco[1]+ cco[2]+ cco[3]+ cco[4];
                    
                   // Console.WriteLine("{0}", numtot);
               // }

               
            }
            else if (o1 > 0 && o2 > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("two pairs of {0}&{1}", decksofcard.cardnumber[o1], decksofcard.cardnumber[o2]);
            }
            else if (o3 > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("three kinds of {0}", decksofcard.cardnumber[o3]);
            }
            else if (o4 > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("four kinds of {0}", decksofcard.cardnumber[o4]);
            }
            else if (o1 > 0 && o3 > 0)
            {
                if(o3>o1)
                {
                Console.WriteLine("");                
                Console.WriteLine("full house of {0}", decksofcard.cardnumber[o3]);
                }
                else if (o1>o3)
                {                   
                Console.WriteLine("");                
                Console.WriteLine("full house of {0}", decksofcard.cardnumber[o1]);
                }
                else{}
            }
            else if(o1>0&&o2==0)
            {
              Console.WriteLine("");
              Console.WriteLine("one pair of {0}", decksofcard.cardnumber[o1]);
            }
           else if (shapecount[1]==5 || shapecount[2]==5 || shapecount[3]==5 || shapecount[4]==5 )
            {                
                Console.WriteLine("");
                if (shapecount[1] == 5)
                    Console.WriteLine("flush of {0}", shapecount[1]);
                else if (shapecount[2] == 5)
                    Console.WriteLine("flush of {0}", shapecount[2]);
                else if (shapecount[3] == 5)
                    Console.WriteLine("flush of {0}", shapecount[3]);
                else if (shapecount[4] == 5)
                    Console.WriteLine("flush of {0}", shapecount[4]);
               //else if (shapecount[5] == 5)
                  //  Console.WriteLine("flush of {0}", shapecount[5]);
                else { }
            }           
            else { }
        }

    
 
        public void game(int a)
        {
            dd.construct();
            dd.shuffle();
            mak = new Card[5];
            for(int a1 = 0;a1 < mak.Length ; a1++)
            {
                mak[a1] = dd.dealcard();
                cons[a1] =mak[a1];
                Console.WriteLine("{0}", mak[a1]);
                //Console.WriteLine("{0} {1}", decksofcard.array1[a1],decksofcard.array2[a1]);
            }
             //count shape,number
            int[] shapecount={0,0,0,0,0};
            for (int ti = 0; ti < mak.Length; ti++)
            {
                switch (decksofcard.array1[ti])
                {
                    case 1:
                        shapecount[1]++;
                        break;
                    case 2:
                        shapecount[2]++;
                        break;
                    case 3:
                        shapecount[3]++;
                        break;
                    case 4:
                        shapecount[4]++;
                        break;
                    default:
                        break;
                }
            }
            int[] nmucount={0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            for (int ti = 0; ti < mak.Length; ti++)
            {
                switch (decksofcard.array2[ti])
                {
                    case 1:
                        nmucount[1]++;
                        break;
                    case 2:
                        nmucount[2]++;
                        break;
                    case 3:
                        nmucount[3]++;
                        break;
                    case 4:
                        nmucount[4]++;
                        break;
                    case 5:
                        nmucount[5]++;
                        break;
                    case 6:
                        nmucount[6]++;
                        break;
                    case 7:
                        nmucount[7]++;
                        break;
                    case 8:
                        nmucount[8]++;
                        break;
                    case 9:
                        nmucount[9]++;
                        break;
                    case 10:
                        nmucount[10]++;
                        break;
                    case 11:
                        nmucount[11]++;
                        break;
                    case 12:
                        nmucount[12]++;
                        break;
                    case 13:
                        nmucount[13]++;
                        break;
                    default:
                        break;
                }
            }
        
            //輸出pairs
            int o1=0, o2=0, o3=0, o4=0;
            int p1 = 1, p2 = 0;
            foreach(int spcount in nmucount)
            {                
                if(spcount==2)
                {
                    if (p1 == 1)
                    {
                        o1 = decksofcard.array2[spcount];
                        p1 = p1 - 1;
                    }
                    else
                    {
                        o2 = decksofcard.array2[spcount];
                    }
                }
                else if(spcount==3)
                    o3 = decksofcard.array2[spcount];
                else if(spcount==4)
                    o4 = decksofcard.array2[spcount];
                else { p2++; }
                               
            }


           // Console.WriteLine("a" + o1 + o2 + o3 + o4);
            
            
            if (p2 == 14) 
            {
                int[] cco=new int[5];
                for(int ggg=0;ggg<4;ggg++)
                {
                cco[ggg]=Math.Min(nmucount[ggg],nmucount[ggg+1]);
                }
                if( (cco[4]-cco[3])==1 && (cco[3]-cco[2])==1 && (cco[2]-cco[1])==1 && (cco[1]-cco[0])==1 )
                {
                    Console.WriteLine("");                 
                    Console.WriteLine("straight!");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("no pairs");
                }

               
            }
            else if (o1 > 0 && o2 > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("two pairs of {0}&{1}", decksofcard.cardnumber[o1 - 1], decksofcard.cardnumber[o2 - 1]);
            }
            else if (o3 > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("three kinds of {0}", decksofcard.cardnumber[o3 - 1]);
            }
            else if (o4 > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("four kinds of {0}", decksofcard.cardnumber[o4 - 1]);
            }
            else if (o1 > 0 && o3 > 0)
            {
                if(o3>o1)
                {
                Console.WriteLine("");                
                Console.WriteLine("full house of {0}", decksofcard.cardnumber[o3 - 1]);
                }
                else if (o1>o3)
                {                   
                Console.WriteLine("");                
                Console.WriteLine("full house of {0}", decksofcard.cardnumber[o1 - 1]);
                }
                else{}
            }
            else if(o1>0&&o2==0)
            {
              Console.WriteLine("");
              Console.WriteLine("one pair of {0}", decksofcard.cardnumber[o1 - 1]);
            }
           else if (shapecount[1]==5 || shapecount[2]==5 || shapecount[3]==5 || shapecount[4]==5 )
            {                
                Console.WriteLine("");
                if (shapecount[1] == 5)
                    Console.WriteLine("flush of {0}", shapecount[1]);
                else if (shapecount[2] == 5)
                    Console.WriteLine("flush of {0}", shapecount[2]);
                else if (shapecount[3] == 5)
                    Console.WriteLine("flush of {0}", shapecount[3]);
                else if (shapecount[4] == 5)
                    Console.WriteLine("flush of {0}", shapecount[4]);
               //else if (shapecount[5] == 5)
                  //  Console.WriteLine("flush of {0}", shapecount[5]);
                else { }
            }           
            else { }
        
        }


      

    }
}
