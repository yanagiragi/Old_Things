import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;

import javax.swing.*;

public class kindergarten extends JApplet
{
	
	public void paint(Graphics g)
	{
		super.paint( g );	
		
		g.setColor( Color.cyan );
		g.fillRect(0, 0, 300, 300);	
		
		g.setColor(Color.black);
		g.drawRect(0, 0, 300, 300);
		
		g.setColor( Color.yellow );
		g.fillOval(0, 0, 50, 50);
		
		g.fillRect(45, 25, 20, 2);
		g.fillRect(45, 15, 20, 2);
		g.fillRect(35, 5, 30, 2);
		g.fillRect(25, 45, 2, 20);
		g.fillRect(15, 45, 2, 20);
		g.fillRect(5, 35, 2, 30);
		int[] arg0 = {45,30,60,75};
		int[] arg1 = {45,30,55,65};
		g.fillPolygon(arg0, arg1, 4);
		int[] arg2 = {40,25,40,55};
		int[] arg3 = {55,40,50,60};
		g.fillPolygon(arg2, arg3, 4);
		int[] arg4 = {45,30,50,65};
		int[] arg5 = {30,15,30,40};
		g.fillPolygon(arg4, arg5, 4);

		Color brown = new Color(168, 83, 83);
		g.setColor(brown);
		g.fillRect(220, 170, 20, 130);
		g.fillRect(190, 200, 30, 15);
		g.fillRect(190, 150, 10, 50);

		g.setColor(Color.green);
		g.fillOval(150, 60, 150, 100);
		g.fillOval(180, 45, 100, 130);	
		
		g.fillRect(0, 270, 100, 30);
		g.fillOval(0, 240, 100, 60);
		g.fillOval(95, 270, 10, 30);
		
		
		g.setColor(Color.white);
		g.fillRect(140, 260, 10, 40);
		g.drawRect(120, 240, 50, 20);
		
		g.setColor(Color.black);		
		g.drawString("sky", 150, 20);
		g.drawString("sun", 15, 27);
		g.drawString("tree-", 210, 110 );
		g.drawString("leaves", 210, 125 );
		g.drawString("tree-", 225, 250 );
		g.drawString("trunk", 225, 265 );
		g.drawString("bush", 40, 280 );
		
		
		Font myFont = new Font("Courier", Font.ITALIC ,13);         
        g.setFont(myFont);        
		g.drawString("®}  ¹t", 130, 255);
		
		
		g.setColor(Color.pink);
		g.fillOval(15, 250, 10, 10);
		g.fillOval(30, 270, 10, 10);
		g.fillOval(55, 265, 10, 10);
		g.fillOval(85, 260, 10, 10);
		g.fillOval(90, 290, 10, 10);
	}
	
}