public class discussion2q3{
	
	public static void main( String[] args )
	{
		int totalSeconds = 2549 ;
		int hr,min;		
		hr =(int)(totalSeconds /3600) ;			
		totalSeconds = totalSeconds - (3600*hr);		
		min =(int)(totalSeconds /60) ;			
		totalSeconds = totalSeconds - (60*min);
		System.out.printf("2549 seconds is equals as " + hr + "hr "+ min + "min "+ totalSeconds + "sec");	
		
		
		
	}	
	
}