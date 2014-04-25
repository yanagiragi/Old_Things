import javax.swing.*;
import java.util.Scanner;
import java.util.Arrays;

public class count11 
{
	
	static public void counting (char[] arg0,char[] chknumchar1,int[] chknumchar11)
	{
		int counter2=0; //for check how many number player matches

		chknumchar1[0] = arg0[0];
		chknumchar11[0]++;
		
		for(int count=1 ; count < arg0.length ; count++) // CHECK NUMBERS OF COLOR OF INPUTED arg0
		{
			switch(count)
			{
			 case 1:
				 if(arg0[count] == chknumchar1[0])
				 {chknumchar11[0]++;}					
			     else
			     {
			    	 chknumchar1[1] = arg0[count];
					 chknumchar11[1]++; 
			     }			    	
				 break;
				 
			 case 2:
				 if(arg0[count] == chknumchar1[0])
				 {chknumchar11[0]++;}
				 else if(arg0[count] == chknumchar1[1])
				 {chknumchar11[1]++;}				
			     else
			     {
			    	 chknumchar1[2] = arg0[count]; 
					 chknumchar11[2]++;
			     }
				 break;
				 
			 case 3:
				 if(arg0[count] == chknumchar1[0])
				 {chknumchar11[0]++;}	
				 else if(arg0[count] == chknumchar1[1])
				 {chknumchar11[1]++;}
				 else if(arg0[count] == chknumchar1[2])
				 {chknumchar11[2]++;}
				 else if(arg0[count] != chknumchar1[0] && arg0[count] != chknumchar1[1] && arg0[count] != chknumchar1[2])
				 {
					 chknumchar1[3] = arg0[count]; 
					 chknumchar11[3]++;
				 }				 
			     else{}
				 break;
		     default:		
		    	 break;
			}
				
		}
		
		
			
		
	}
	
	
}