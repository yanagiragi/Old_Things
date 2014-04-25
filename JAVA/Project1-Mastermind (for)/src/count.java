import javax.swing.JOptionPane;

import java.util.Random;

public class count
{
	public static String[] counts(int ss,int s1,char[] impChar)
	{
		
			
		
		String end = JOptionPane.showInputDialog("Enter your guess(4 letters");
		end = end.toUpperCase();
		

		char[] tmpChar = end.toCharArray(); 
		
		
		char[] tmpChar1 = new char[4];
		char[] impChar1 = new char[4];
		for(int r=0;r<4;r++)
		{
			tmpChar1[r]=tmpChar[r];
			impChar1[r]=impChar[r];
		}
		
		
		while(tmpChar.length !=4)
		{			
			JOptionPane.showMessageDialog(null,"Wrong Input!");
			end= JOptionPane.showInputDialog("Enter your guess(4 letters");		
			tmpChar = end.toCharArray(); 	
			end.toUpperCase();
		}
		while(
				(tmpChar[0] != 'R' && tmpChar[0] != 'G' && tmpChar[0] != 'B' && tmpChar[0] != 'Y' && tmpChar[0] != 'W' && tmpChar[0] != 'O' ) || 
				(tmpChar[1] != 'R' && tmpChar[1] != 'G' && tmpChar[1] != 'B' && tmpChar[1] != 'Y' && tmpChar[1] != 'W' && tmpChar[1] != 'O' ) ||
				(tmpChar[2] != 'R' && tmpChar[2] != 'G' && tmpChar[2] != 'B' && tmpChar[2] != 'Y' && tmpChar[2] != 'W' && tmpChar[2] != 'O' ) ||
				(tmpChar[3] != 'R' && tmpChar[3] != 'G' && tmpChar[3] != 'B' && tmpChar[3] != 'Y' && tmpChar[3] != 'W' && tmpChar[3] != 'O' ) )
		{
			JOptionPane.showMessageDialog(null,"Wrong Input!");
			end	= JOptionPane.showInputDialog("Enter your guess(4 letters");		
			tmpChar = end.toCharArray(); 			
		}
				ss=0;
		s1=0;
		for(int q=0;q<4;q++)
		{
			if(tmpChar1[q] == impChar1[q])
			{
				ss++;
				tmpChar1[q] = 'P';
				impChar1[q] = 'P';				
			}			
		}	
		
		
		
		for(int q=0;q<4;q++)
		{
			for(int qq=0;qq<4;qq++)
			{
				if(tmpChar1[q]!='P' && tmpChar1[q] == impChar1[qq] && impChar1[qq]!='P' )
				{
					impChar1[qq] = 'P';	
						s1++;
						break;
				}
			}
		}
		
		 String[] sss1 = new String[6];
		 sss1[0]=Integer.toString(ss);
		 sss1[1]=Integer.toString((s1-ss));
		 sss1[2]=Character.toString(tmpChar[0]) ;
		 sss1[3]=Character.toString(tmpChar[1]);
		 sss1[4]=Character.toString(tmpChar[2]);
		 sss1[5]=Character.toString(tmpChar[3]);
		 return sss1;
	}
}
		 
