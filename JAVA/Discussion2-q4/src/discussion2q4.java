import javax.swing.JOptionPane ; 

public class discussion2q4{
	
	public static void main( String[] args){
		
		String money;
		String cost;
		int m,c;
		int converted[] = {0,0,0,0,0,0,0};
		
		m = Integer.parseInt(JOptionPane.showInputDialog("Enter money:"));	
		
		c = Integer.parseInt(JOptionPane.showInputDialog("Enter cost:"));
		
		while(m>100 || m<0 || c>100 || c<0)
		{
			JOptionPane.showMessageDialog(null,"Wrong Input!\n The amount of the money and cost you insert must not bigger than 100 or lesser than 0!");
			m = Integer.parseInt(JOptionPane.showInputDialog("Enter money:"));				
			c = Integer.parseInt(JOptionPane.showInputDialog("Enter cost:"));
		}
		
		converted[0] = (m-c)/100;
		m = (m-c) - 100 * converted[0];
		if(converted[0] >= 1)
		System.out.println("Number of 100 p is "+ converted[0]);
		
		
		
		while(m > 0)
		{
			if(m >= 50)
			{
				converted[1] = m/50;
				m = m - 50 * converted[1];
				System.out.println("Number of 50 p is "+ converted[1]);
			}
			else{}
			
			if(m >= 20)
			{		
				converted[2] = m/20;
				m = m - 20 * converted[2];
				System.out.println("Number of 20 p is "+ converted[2]);
			}
			else{}
			
			if(m >= 10)
			{
				converted[3] = m/10;
				m = m - 10 * converted[3];
				System.out.println("Number of 10 p is "+ converted[3]);
				
			}
			else{}
			
			if(m >= 5)
			{
				converted[4] = m/5;
				m = m - 5 *  converted[4];
				System.out.println("Number of 5  p is "+ converted[4]);
			}
			else{}
			
			if(m >= 2)
			{
				converted[5] = m/2;
				m = m - 5 *  converted[5];
				System.out.println("Number of 2  p is "+ converted[5]);
			}
			else{}
		
			if(m >= 1)
			{
				converted[6] = m;				
				System.out.println("Number of 1  p is "+ converted[6]);
				m = m - 1 *  converted[6];
			}
			else{}
		
		}
		
		
	}
	
	
	
	
	
}