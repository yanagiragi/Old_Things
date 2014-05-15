import javax.swing.*;

import java.awt.*;
import java.awt.event.*;
import java.util.Random;

public class class2 extends JFrame
{
	public int count = 0;
	public static int[] bin ={4,4,4,4,4,4,0,4,4,4,4,4,4,0};//14bins
	//public int[] playerbin = {0,0};
	//public static boolean FreeTurn = false;
	public static String ai = "AI";
	public static String player = "Player";	
	public static int[] posx = {150,270,390,510,630,750,850,750,630,510,390,270,150,40 };//reference to bin's x position
	public static int[] posy = {350,350,350,350,350,350,200, 50, 50, 50, 50, 50, 50,200};//reference to bin's y position
	private JPanel area = new JPanel();
	
	public static int clicked=0;
	public static int randomnum;
	
	public class2()
	{
		super("Mancala");
		add(area);
		repaint();
		
		Clickedbin handler = new Clickedbin(); 
		area.addMouseListener(handler);
		
	}
	public void paint(Graphics g)
	{		
		super.paint(g);

		g.setFont(new Font("TimesRoman", Font.PLAIN, 20));
		
		g.setColor(Color.black);
		g.fillOval(50, 50, 100, 400);
		g.fillOval(850, 50, 100, 400);
		
		g.setColor(Color.WHITE);
		g.fillOval(150, 50, 100, 100);
		g.fillOval(270, 50, 100, 100);
		g.fillOval(390, 50, 100, 100);
		g.fillOval(510, 50, 100, 100);
		g.fillOval(630, 50, 100, 100);
		g.fillOval(750, 50, 100, 100);
		
		g.fillOval(150, 350, 100, 100);
		g.fillOval(270, 350, 100, 100);
		g.fillOval(390, 350, 100, 100);
		g.fillOval(510, 350, 100, 100);
		g.fillOval(630, 350, 100, 100);
		g.fillOval(750, 350, 100, 100);
		
		if(count == 0)
		{
			for(int drawcount = 0 ; drawcount < 14 ; drawcount++)
			{	
				g.setColor(Color.red);
				g.fillOval(posx[drawcount]+20, posy[drawcount]+20, 25, 25);
				g.setColor(Color.blue);
				g.fillOval(posx[drawcount]+50, posy[drawcount]+20, 25, 25);
				g.setColor(Color.green);
				g.fillOval(posx[drawcount]+20, posy[drawcount]+50, 25, 25);
				g.setColor(Color.yellow);
				g.fillOval(posx[drawcount]+50, posy[drawcount]+50, 25, 25);
			}
			g.setColor(Color.black);
			g.fillOval(50, 50, 100, 400);
			g.fillOval(850, 50, 100, 400);
		}
		else
		{
			g.setColor(Color.cyan);
			g.fillOval(posx[randomnum]+30, posy[randomnum]+120, 40, 40);
			
			g.setColor(Color.green);
			g.fillOval(posx[clicked-1]+30, posy[clicked-1]-70, 40, 40);
			dealbins(g);// draw beans
			
			/*if(FreeTurn == true)
			{
				FreeTurn = false;
				JOptionPane.showMessageDialog(null, "FreeTurn!");				
			}*/
			
		}
		
		for(int drawcount = 0 ; drawcount < 14 ; drawcount++)//draw number
		{
			g.setColor(Color.black);
			if(drawcount == 6)
				g.setColor(Color.white);
			if(drawcount == 13)
				g.setColor(Color.white);
			g.drawString(String.format(""+drawcount), posx[drawcount]+45, posy[drawcount]+10);
				
		}
				
	}
	private class Clickedbin extends MouseAdapter//,MouseMotionAdapter // do display how many bins when move to bin
	{		
		public void mouseClicked(MouseEvent event)
		{
			int repeat=-1;
			if(event.getY() < 450 && event.getY() > 350 )
			{
				if( event.getX() > 150 && event.getX() < 250 )
					clicked = 1;
				else if(event.getX() > 270 && event.getX() < 370 )
					clicked = 2;		
				else if(event.getX() > 390 && event.getX() < 490 )
					clicked = 3;
				else if(event.getX() > 510 && event.getX() < 610 )
					clicked = 4;
				else if(event.getX() > 630 && event.getX() < 730 )
					clicked = 5;
				else if(event.getX() > 750 && event.getX() < 850 )
					clicked = 6;
				else
					clicked = 0;
			}
			else
				clicked = 0;
			
			//System.out.println("ed "+clicked);
			//AIplay();
			if(clicked !=0 )
			{
				repeat = dealClicked(clicked,"Player");
				repaint();
				if( repeat != -1)
				{
					AIplay();					
				}
				else
					repaint();
				count++;
				//System.out.println("gamecount: "+count);
				//System.out.println("");
			
			}
			
		}	
		
		//motionevent
		
		
		
	}	
	public static void AIplay()
	{
		int repeat = 0;
		//Graphics g = new Graphics();
		Random random = new Random();				
		do
		{
			randomnum = 7+random.nextInt(6);
			//System.out.println("random+1: "+ (randomnum+1));
			
			repeat = dealClicked(randomnum+1,"AI");
		    
			//System.out.println("randomnum-1: "+ (randomnum-1));	
		}while(repeat == -1);
		//clicked = randomnum;
		
	}
	public static int dealClicked(int click,String playone)
	{
		//click = click -1;
		//System.out.println(playone+" click (-1)at : "+(click-1));
		//System.out.println("bin[click-1]: "+bin[click-1]);
		
		int a =(bin[click-1] + click-1);
		if(a >= 14)
		{
			//System.out.println("a; "+a);
			a = -(14-a);
			//	System.out.println("a after; "+a);
			
		}
		else;
			//System.out.println("a; "+a);
		
		
		int repeat=0;
		if(bin[click-1] == 0) //click-1
			repeat = -1;
		else if(a ==13 || a ==6 )
		{
			
			int roll ;
			for(int run=1; run < bin[click-1]+1 ; run++)
			{
				roll = (run + click-1);				
				if( (run + click-1) >= 14)
					roll = -(14 - roll);				
				bin[ roll] = bin[ roll ] +1; 
				
			}
			bin[click-1] = 0;
			
			//String string = null ;
			//JOptionPane.showMessageDialog(null,"Game Over!\nPlayer Point: "+bin[6] +"\nAI Point: "+ bin[13]);	
			if(playone.compareTo(ai) == 0 )
			{
				if(a == 13)
				{
					JOptionPane.showMessageDialog(null, playone +" FreeTurn!");	
					repeat = -1;					
				}
				else
					repeat = 0;
			}
			if(playone.compareTo(player) == 0 )
				if(a == 6)
				{
					JOptionPane.showMessageDialog(null, playone +" FreeTurn!");	
					repeat = -1;					
				}
				else
					repeat = 0;
			
			//FreeTurn = true;
			//System.out.println(playone+" FREETURN!");
			//JOptionPane.showMessageDialog(null, "FreeTurn!");			
		}
		else if(bin[a] == 0 && (a !=13 && a !=6) && ( ((click-1) < 6 && a < 6) || ( (click-1) >6 && a > 6) ) ) //capture
		{
			int roll ;
			for(int run=1; run < bin[click-1]+1 ; run++)
			{
				roll = (run + click-1);				
				if( (run + click-1) >= 14)
					roll = -(14 - roll);				
				bin[ roll] = bin[ roll ] +1; 
				
			}
			bin[click-1] = 0;
			
			
			int binindex = 12-a;
			if(binindex < 0)
				binindex = -binindex;
			if(bin[binindex] != 0)
			{
				//	System.out.println(playone+" CAPTURE!");
				JOptionPane.showMessageDialog(null, playone +" CAPTURE!");	
				if(playone.compareTo(ai) == 0 )
					bin[13] = bin[13]+ bin[binindex] +1;
				if(playone.compareTo(player) == 0 )
					bin[6] = bin[6]+ bin[binindex] +1;
				
				bin[binindex] = 0;
				bin[a]=0;
			}			
			repeat = 0;				
		}		
		else
		{
			int roll ;
			for(int run=1; run < bin[click-1]+1 ; run++)
			{
				roll = (run + click-1);
				
				if( (run + click-1) >= 14)
					roll = -(14 - roll);
				
				//System.out.print(roll+" ");
				
				bin[ roll] = bin[ roll ] +1; 
				
			}
			//set beans to array bin
			bin[click-1] = 0;
			/*System.out.println("");
			System.out.println("bin roll :  0 1 2 3 4 5 6 7 8 9 0 1 2 3");
			System.out.print("bin roll :  ");
			for(int run=0; run < bin.length ; run++)
			{			
			System.out.print(bin[run]+" ");
			}			*/
			
			repeat = 0;
		}
		
		//System.out.println("");
		
		if(bin[0]+bin[1]+bin[2]+bin[3]+bin[4]+bin[5] == 0 || bin[7]+bin[8]+bin[9]+bin[10]+bin[11]+bin[12] == 0)
		{
			String string = null ;
			JOptionPane.showMessageDialog(null,"Game Over!\nPlayer Point: "+bin[6] +"\nAI Point: "+ bin[13]);	
			if(bin[6] > bin[13])
				JOptionPane.showMessageDialog(null,"Player Win!");	
			else if(bin[6] < bin[13])
				JOptionPane.showMessageDialog(null,"AI Win!");
			else 
				JOptionPane.showMessageDialog(null,"Draw!");
			System.exit(0);
		}
		return repeat;	
	}	
	public void dealbins(Graphics g)
	{
		for(int count = 0; count < bin.length;count++)
		{
			
			if(count == 6 || count ==13)
			{
				g.setColor(Color.yellow);
				if(count ==13)
					g.fillOval(posx[count]+30, posy[count]+33, 50,50);
				
				else					
					g.fillOval(posx[count]+25, posy[count]+33, 50,50);
				
				g.setColor(Color.red);
				if(count ==13)
					g.drawString(""+bin[count],posx[count]+47, posy[count]+63);
				
				else
					g.drawString(""+bin[count],posx[count]+42, posy[count]+63);
			}
			else
			{
				//binc = bin[count];
				switch(bin[count])
				{
				case 0:				
					break;
				case 1:			
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+20, 25, 25);
					break;
				case 2:
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+20, 25, 25);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+50, posy[count]+20, 25, 25);
					break;
				case 3:
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+20, 25, 25);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+50, posy[count]+20, 25, 25);
					g.setColor(Color.green);
					g.fillOval(posx[count]+20, posy[count]+50, 25, 25);
					break;
				case 4:
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+20, 25, 25);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+50, posy[count]+20, 25, 25);
					g.setColor(Color.green);
					g.fillOval(posx[count]+20, posy[count]+50, 25, 25);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+50, posy[count]+50, 25, 25);
					break;
				case 5:
					g.setColor(Color.red);
					g.fillOval(posx[count]+30, posy[count]+20, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+50, posy[count]+20, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+30, posy[count]+40, 18, 18);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+50, posy[count]+40, 18, 18);
					g.setColor(Color.orange);
					g.fillOval(posx[count]+30, posy[count]+60, 18, 18);
					break;
				case 6:
					g.setColor(Color.red);
					g.fillOval(posx[count]+30, posy[count]+20, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+50, posy[count]+20, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+30, posy[count]+40, 18, 18);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+50, posy[count]+40, 18, 18);
					g.setColor(Color.orange);
					g.fillOval(posx[count]+30, posy[count]+60, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+50, posy[count]+60, 18, 18);
					break;
				case 7:
					g.setColor(Color.red);
					g.fillOval(posx[count]+30, posy[count]+15, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+50, posy[count]+15, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+30, posy[count]+35, 18, 18);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+50, posy[count]+35, 18, 18);
					g.setColor(Color.orange);
					g.fillOval(posx[count]+30, posy[count]+55, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+50, posy[count]+55, 18, 18);
					g.setColor(Color.magenta);
					g.fillOval(posx[count]+30, posy[count]+75, 18, 18);
					break;
				case 8:
					g.setColor(Color.red);
					g.fillOval(posx[count]+30, posy[count]+15, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+50, posy[count]+15, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+30, posy[count]+35, 18, 18);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+50, posy[count]+35, 18, 18);
					g.setColor(Color.orange);
					g.fillOval(posx[count]+30, posy[count]+55, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+50, posy[count]+55, 18, 18);
					g.setColor(Color.magenta);
					g.fillOval(posx[count]+30, posy[count]+75, 18, 18);
					g.setColor(Color.gray);
					g.fillOval(posx[count]+50, posy[count]+75, 18, 18);
					break;
				case 9:
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+25, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+42, posy[count]+25, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+64, posy[count]+25, 18, 18);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+20, posy[count]+45, 18, 18);
					g.setColor(Color.orange);
					g.fillOval(posx[count]+40, posy[count]+45, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+45, 18, 18);
					g.setColor(Color.magenta);
					g.fillOval(posx[count]+20, posy[count]+65, 18, 18);
					g.setColor(Color.gray);
					g.fillOval(posx[count]+42, posy[count]+65, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+65, 18, 18);
					break;
				case 10:
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+15, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+42, posy[count]+15, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+64, posy[count]+15, 18, 18);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+20, posy[count]+35, 18, 18);
					g.setColor(Color.orange);
					g.fillOval(posx[count]+40, posy[count]+35, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+35, 18, 18);
					g.setColor(Color.magenta);
					g.fillOval(posx[count]+20, posy[count]+55, 18, 18);
					g.setColor(Color.gray);
					g.fillOval(posx[count]+42, posy[count]+55, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+55, 18, 18);				
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+75, 18, 18);
					break;
				case 11:
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+15, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+42, posy[count]+15, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+64, posy[count]+15, 18, 18);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+20, posy[count]+35, 18, 18);
					g.setColor(Color.orange);
					g.fillOval(posx[count]+40, posy[count]+35, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+35, 18, 18);
					g.setColor(Color.magenta);
					g.fillOval(posx[count]+20, posy[count]+55, 18, 18);
					g.setColor(Color.gray);
					g.fillOval(posx[count]+42, posy[count]+55, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+55, 18, 18);				
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+75, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+42, posy[count]+75, 18, 18);
					break;
				case 12:
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+15, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+42, posy[count]+15, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+64, posy[count]+15, 18, 18);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+20, posy[count]+35, 18, 18);
					g.setColor(Color.orange);
					g.fillOval(posx[count]+40, posy[count]+35, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+35, 18, 18);
					g.setColor(Color.magenta);
					g.fillOval(posx[count]+20, posy[count]+55, 18, 18);
					g.setColor(Color.gray);
					g.fillOval(posx[count]+42, posy[count]+55, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+55, 18, 18);				
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+75, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+42, posy[count]+75, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+64, posy[count]+75, 18, 18);
					break;
				case 13:
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+15, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+42, posy[count]+15, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+64, posy[count]+15, 18, 18);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+20, posy[count]+35, 18, 18);
					g.setColor(Color.orange);
					g.fillOval(posx[count]+40, posy[count]+35, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+35, 18, 18);
					g.setColor(Color.magenta);
					g.fillOval(posx[count]+20, posy[count]+55, 18, 18);
					g.setColor(Color.gray);
					g.fillOval(posx[count]+42, posy[count]+55, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+55, 18, 18);				
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+75, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+42, posy[count]+75, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+64, posy[count]+75, 18, 18);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+20, posy[count]+95, 18, 18);
					g.setColor(Color.orange);
					break;
				case 14:
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+15, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+42, posy[count]+15, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+64, posy[count]+15, 18, 18);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+20, posy[count]+35, 18, 18);
					g.setColor(Color.orange);
					g.fillOval(posx[count]+40, posy[count]+35, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+35, 18, 18);
					g.setColor(Color.magenta);
					g.fillOval(posx[count]+20, posy[count]+55, 18, 18);
					g.setColor(Color.gray);
					g.fillOval(posx[count]+42, posy[count]+55, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+55, 18, 18);				
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+75, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+42, posy[count]+75, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+64, posy[count]+75, 18, 18);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+20, posy[count]+95, 18, 18);
					g.setColor(Color.orange);
					g.fillOval(posx[count]+40, posy[count]+95, 18, 18);					
					break;
				case 15:
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+15, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+42, posy[count]+15, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+64, posy[count]+15, 18, 18);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+20, posy[count]+35, 18, 18);
					g.setColor(Color.orange);
					g.fillOval(posx[count]+40, posy[count]+35, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+35, 18, 18);
					g.setColor(Color.magenta);
					g.fillOval(posx[count]+20, posy[count]+55, 18, 18);
					g.setColor(Color.gray);
					g.fillOval(posx[count]+42, posy[count]+55, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+55, 18, 18);				
					g.setColor(Color.red);
					g.fillOval(posx[count]+20, posy[count]+75, 18, 18);
					g.setColor(Color.blue);
					g.fillOval(posx[count]+42, posy[count]+75, 18, 18);
					g.setColor(Color.green);
					g.fillOval(posx[count]+64, posy[count]+75, 18, 18);
					g.setColor(Color.yellow);
					g.fillOval(posx[count]+20, posy[count]+95, 18, 18);
					g.setColor(Color.orange);
					g.fillOval(posx[count]+40, posy[count]+95, 18, 18);
					g.setColor(Color.cyan);
					g.fillOval(posx[count]+64, posy[count]+95, 18, 18);
					break;
					
				default:
					System.out.println("something went wrong!");
					break;
				}
			}					
		}
	}	
}
