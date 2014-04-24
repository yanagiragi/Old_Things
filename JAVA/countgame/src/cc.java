import javax.swing.JOptionPane;

public class cc 
{
	
	public static void main( String args[] )
	{
		
		
		int sum = 3 ;
		int sum2 = 3 ; 
		int i = 3 ;
		
				
		JOptionPane.showMessageDialog(null, "This is a game to count to 20\nWho counts 20 loses!", "Game",JOptionPane.INFORMATION_MESSAGE);	
		JOptionPane.showMessageDialog(null, "Computer goes first!!", "Game",JOptionPane.INFORMATION_MESSAGE);		
		
		Object[] option0 = {"1","2","3",};	
		
		while( sum < 20 )
		{		

			if( i == 0 )
			{
				System.exit(0);
			}						
			else if ( sum == 19)
			{
				JOptionPane.showMessageDialog(null, "Computer counts "+sum2+"!\nThe sum is "+sum+" !\n You Loses!", "Game",JOptionPane.INFORMATION_MESSAGE);
				sum = 21;
			}
			else
			{				 
				i=  1 + JOptionPane.showOptionDialog(null, "Computer count  "+ sum2+"!\nThe sum is "+sum+"\nWhich do you count?", "Game",JOptionPane.YES_NO_OPTION,JOptionPane.INFORMATION_MESSAGE,null,option0,option0[1]) ; 
				sum2 =4- i ;
				sum = sum + 4 ;				
			}			
		}		
	}	
}


