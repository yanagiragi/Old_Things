import javax.swing.JOptionPane ; 

import java.awt.Color;
import java.awt.Graphics;

import javax.swing.*;

import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;

public class pro1 extends JApplet
{
	
	public void paint(Graphics g)
	{
		 super.paint(g);
		
		 g.setColor(Color.black);
		 g.fillRect(0, 0, 500, 500); 
		 g.setColor(Color.white);
		 g.drawString("Mastermind", 215, 20);
		 
		 char[] impChar = new char[4];	 
		 char[] refChar = {'R','G','B','Y','W','O'};
			
		 Random random = new Random();
		 int a;	  // for input random numbers(index) to  reference char array
		 
		
		 
		 int ss=0;
		 int s1=0;		 
		 int refwinnum =1;	
		 int win =0;
		 int nnn =0; // try again catch		
		 int playtimes=0;
		 int[] posit = new int[3];
		 int[] score = new int[100];
		 String[] sss1 = new String[6];
		 String end = "4";
		 
		 Object[] options = {"infinity", "Easy","Normal","Hard"};
		 Object[] options2 = {"Try again", "View scores","Quit"};
		 
		 JOptionPane.showMessageDialog(null,"\nRules\n");
		 JOptionPane.showMessageDialog(null,"Infinity\n   Represents you are allowed to guess as many times until you reach the answer\n   BUT you can't quit this app until you reach it\n   Nor can you check your score if you terminate this app directly!");
		 JOptionPane.showMessageDialog(null,"Easy\n   Represents you are allowed to 10 times until you reach the answer, or else you lose. ");
		 JOptionPane.showMessageDialog(null,"Normal\n   Represents you are allowed to 5 times until you reach the answer, or else you lose. ");
		 JOptionPane.showMessageDialog(null,"Hard\n   Represents you are allowed to 3 times until you reach the answer, or else you lose. ");
		 JOptionPane.showMessageDialog(null,"At last, if you find your score is -1 , that means you losed in that ?th game");
		 JOptionPane.showMessageDialog(null,"Application Begin\nHope you enjoy it :) ");
		 
		 
		 
		 do
		 {
			 g.setColor(Color.black);
			 g.fillRect(0, 0, 500, 500); 
			 g.setColor(Color.white);
			 g.drawString("Mastermind", 215, 20);
			 refwinnum =1;
			 int n = JOptionPane.showOptionDialog(null, "Which mode??", "OPTIONS", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, options, options[1]);
				
			 for(int i=0 ; i < 4 ; i++)
			 {
				a = random.nextInt(6);
				switch(a)
				{
					case 0:
						impChar[i] = refChar[0];
						break;
					case 1:
						impChar[i] = refChar[1];
						break;
					case 2:
						impChar[i] = refChar[2];
						break;
					case 3:
						impChar[i] = refChar[3];
						break;
					case 4:
						impChar[i] = refChar[4];
						break;
					case 5:
						impChar[i] = refChar[5];
						break;
					default:		
						break;		
				}	
			}
			 
			 if(n==0)
			 {
				 posit[0] = 40;
				 posit[1] = 50;		
				 
				 sss1 = count.counts(ss, s1,impChar);	
				 posit = banashi(sss1,posit[0],posit[1],g,refwinnum,n,win);
				 
				 while(!sss1[0].equals(end))
				 {			
					 if(refwinnum % 11 != 0 || refwinnum == 0 )
					 {
						 sss1 = count.counts(ss, s1,impChar);	
						 posit = banashi(sss1,posit[0],posit[1],g,refwinnum,n,win);
					 }
					 else if(refwinnum % 11 == 0)
					 {
						 g.setColor(Color.black);
						 g.fillRect(0, 0, 500, 500); 
						 g.setColor(Color.white);
						 g.drawString("Mastermind", 215, 20); 
						 posit[0] = 40;
						 posit[1] = 50;
						 posit = banashi(sss1,posit[0],posit[1],g,refwinnum,n,win);
					 }
					 else{}
					 refwinnum++;
				}
			
				 if(refwinnum % 11 == 0)
				 {
					 g.setColor(Color.black);
					 g.fillRect(0, 0, 500, 500); 
					 g.setColor(Color.white);
					 g.drawString("Mastermind", 215, 20);
					 posit[0] = 40;
					 posit[1] = 50;
					 posit = banashi(sss1,posit[0],posit[1],g,refwinnum,n,win);
				 }			 
				
				 JOptionPane.showMessageDialog(null,"You Win!\nYou had tried "+(refwinnum)+" times!");
					
			 }
			 else if(n==1)
			 {
				 {
					 posit[0] = 40;
					 posit[1] = 50;		
					 
					 sss1 = count.counts(ss, s1,impChar);	
					 posit = banashi(sss1,posit[0],posit[1],g,refwinnum,n,win);
					 
					 while(!sss1[0].equals(end))
					 {
						if( refwinnum == 10)
						 break;
						
						sss1 = count.counts(ss, s1,impChar);	
						posit = banashi(sss1,posit[0],posit[1],g,refwinnum,n,win);
						refwinnum++;
					 }

					 if(posit[2] != 1)
					 {
						 JOptionPane.showMessageDialog(null,"You Lose!");
						 refwinnum=refwinnum+10;
					 }
				 }
			 }
			 else if(n==2)
			 {
				 {
					 posit[0] = 40;
					 posit[1] = 50;		
					 
					 sss1 = count.counts(ss, s1,impChar);	
					 posit = banashi(sss1,posit[0],posit[1],g,refwinnum,n,win);
					 
					 while(!sss1[0].equals(end))
					 {
						if( refwinnum == 5)
						 break;
						
						sss1 = count.counts(ss, s1,impChar);	
						posit = banashi(sss1,posit[0],posit[1],g,refwinnum,n,win);
						refwinnum++;
					 }

					 if(posit[2] != 1)
					 {
						 JOptionPane.showMessageDialog(null,"You Lose!");
						 refwinnum=refwinnum+10;
					 }
				 } 
			 }
			 else if(n==3)
			 {
				 posit[0] = 40;
				 posit[1] = 50;		
				 
				 sss1 = count.counts(ss, s1,impChar);	
				 posit = banashi(sss1,posit[0],posit[1],g,refwinnum,n,win);
				 
				 while(!sss1[0].equals(end))
				 {
					if( refwinnum == 3)
					 break;
					
					sss1 = count.counts(ss, s1,impChar);	
					posit = banashi(sss1,posit[0],posit[1],g,refwinnum,n,win);
					refwinnum++;
				 }

				 if(posit[2] != 1)
				 {
					 JOptionPane.showMessageDialog(null,"You Lose!");
					 refwinnum=refwinnum+10;
					
				 }
			 }
			 else
			 {
				 System.exit(0); 
			 }	 
 
			 int nn = JOptionPane.showOptionDialog(null, "Try again?", "OPTIONS", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, options2, options2[1]);
			 if(nn == 0)
			 {
				 nnn=0;
			 }
			 else if(nn == 1)
			 {
				 nnn=1;
			 }
			 else if(nn == 2)
			 {
				 nnn=2;
			 }
			 else;
			 
			 playtimes =playtimes +1;			 
			 score[playtimes] = refwinnum;
			
			 if(n==0)
			 {
				 score[playtimes] = refwinnum+1 ;
			 }
			 else if(n==1)
			 {
				 if(score[playtimes] == 20)					 
					 score[playtimes] =0 ;
			 }
			 else if(n==2)
			 {
				 if(score[playtimes] == 15)					 
					 score[playtimes] = 0 ; 
			 }
			 else if(n==3)
			 {
				 if(score[playtimes] == 13)					 
					 score[playtimes] = 0 ;
			 }
			 else;
			 
			 if(nnn == 1)
			 {
				 JOptionPane.showMessageDialog(null,"score:");
				 for(int abc=1; abc < playtimes+1;abc++)
					 JOptionPane.showMessageDialog(null,abc + "th : " + (score[abc]-1) +" ");
			 }
			 
			 if(nnn == 2)
				 break;
			 
		 }while(nnn == 0);
				 
	}
	
	public void init()	 
	{
		 setSize(500, 500);
	}
	public static int[] banashi (String[] a,int pos1,int pos2,Graphics g,int refwinnum,int n,int win)
	{
		int countwintime=refwinnum;
		String R ="R";
		String G ="G";
		String B ="B";
		String Y ="Y";
		String W ="W";
		String O ="O";
		String one ="1";
		String two ="2";
		String tri ="3";
		String four ="4";
		
		for(int count=2; count<6; count ++)
		{
			
			if(a[count].equals(R))
			{
				g.setColor(Color.red);
				g.fillOval(pos1, pos2, 30, 30);	
				g.setColor(Color.black);
				g.drawString("R", pos1+11, pos2+19);
			}
			else if(a[count].equals(G))
			{
				g.setColor(Color.green);
				g.fillOval(pos1, pos2, 30, 30);
				g.setColor(Color.black);
				g.drawString("G", pos1+11, pos2+19);
			}
			else if(a[count].equals(B))
			{
				g.setColor(Color.blue);
				g.fillOval(pos1, pos2, 30, 30);
				g.setColor(Color.black);
				g.drawString("B", pos1+11, pos2+19);
			}
			else if(a[count].equals(Y))
			{
				g.setColor(Color.yellow);
				g.fillOval(pos1, pos2, 30, 30);
				g.setColor(Color.black);
				g.drawString("Y", pos1+11, pos2+19);
			}
			else if(a[count].equals(W))
			{
				g.setColor(Color.white);
				g.fillOval(pos1, pos2, 30, 30);
				g.setColor(Color.black);
				g.drawString("W", pos1+11, pos2+19);
			}
			else if(a[count].equals(O))
			{
				g.setColor(Color.orange);
				g.fillOval(pos1, pos2, 30, 30);
				g.setColor(Color.black);
				g.drawString("O", pos1+11, pos2+19);
			}
			else{}
			g.setColor(Color.white);
			g.drawOval(pos1, pos2, 30, 30);
			
			if(count == 5)
			{
				
				if(a[0].equals(one))
				{
					g.setColor(Color.red);
					g.fillOval(pos1+110, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("R", pos1+116, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+110, pos2+5, 20, 20);
					pos1 = pos1 +115;
				}
				else if(a[0].equals(two))
				{
					g.setColor(Color.red);
					g.fillOval(pos1+110, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("R", pos1+116, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+110, pos2+5, 20, 20);
					
					g.setColor(Color.red);
					g.fillOval(pos1+135, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("R", pos1+141, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+135, pos2+5, 20, 20);
					pos1 = pos1 +140;
				}
				else if(a[0].equals(tri))
				{
					g.setColor(Color.red);
					g.fillOval(pos1+110, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("R", pos1+116, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+110, pos2+5, 20, 20);
					
					g.setColor(Color.red);
					g.fillOval(pos1+135, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("R", pos1+141, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+135, pos2+5, 20, 20);
					
					g.setColor(Color.red);
					g.fillOval(pos1+160, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("R", pos1+166, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+160, pos2+5, 20, 20);
					pos1 = pos1 +140;
				}
				else if(a[0].equals(four))
				{
					g.setColor(Color.red);
					g.fillOval(pos1+110, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("R", pos1+116, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+110, pos2+5, 20, 20);
					
					g.setColor(Color.red);
					g.fillOval(pos1+135, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("R", pos1+141, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+135, pos2+5, 20, 20);
					
					g.setColor(Color.red);
					g.fillOval(pos1+160, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("R", pos1+166, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+160, pos2+5, 20, 20);
					
					g.setColor(Color.red);
					g.fillOval(pos1+185, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("R", pos1+191, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+185, pos2+5, 20, 20);
					pos1 = pos1 +190;		
					
					if(n!=0)
						JOptionPane.showMessageDialog(null,"You Win!\nYou had tried "+(refwinnum+1)+" times!");
					win = 1;
					}
				else
				{
					pos1=pos1+90;
				}
				
				if((a[1].equals(one)))
				{
					g.setColor(Color.white);
					g.fillOval(pos1+20, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("W", pos1+26, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+20, pos2+5, 20, 20);
				}
				else if((a[1].equals(two)))
				{
					g.setColor(Color.white);
					g.fillOval(pos1+20, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("W", pos1+26, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+20, pos2+5, 20, 20);
					
					g.setColor(Color.white);
					g.fillOval(pos1+45, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("W", pos1+51, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+45, pos2+5, 20, 20);
				}
				else if((a[1].equals(tri)))
				{
					g.setColor(Color.white);
					g.fillOval(pos1+20, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("W", pos1+26, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+20, pos2+5, 20, 20);
					
					g.setColor(Color.white);
					g.fillOval(pos1+45, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("W", pos1+51, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+45, pos2+5, 20, 20);
					
					g.setColor(Color.white);
					g.fillOval(pos1+70, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("W", pos1+76, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+70, pos2+5, 20, 20);
				}
				else if((a[1].equals(four)))
				{
					g.setColor(Color.white);
					g.fillOval(pos1+20, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("W", pos1+26, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+20, pos2+5, 20, 20);
					
					g.setColor(Color.white);
					g.fillOval(pos1+45, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("W", pos1+51, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+45, pos2+5, 20, 20);
					
					g.setColor(Color.white);
					g.fillOval(pos1+70, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("W", pos1+76, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+70, pos2+5, 20, 20);
					
					g.setColor(Color.white);
					g.fillOval(pos1+95, pos2+5, 20, 20);	
					g.setColor(Color.black);
					g.drawString("W", pos1+101, pos2+19);
					g.setColor(Color.white);
					g.drawOval(pos1+95, pos2+5, 20, 20);
				}
				else{}
			}
			pos1=pos1+45;
		}
		
		countwintime++;
		pos1 = 40;
		pos2 = pos2 + 45 ;
		int[] a1 = new int[3];
		a1[0]=pos1;
		a1[1]=pos2;
		a1[2]=win;
		return a1;			
		}	
}