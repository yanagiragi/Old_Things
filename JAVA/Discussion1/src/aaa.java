import javax.swing.JOptionPane;

public class aaa{


  public static void main( String args[] )
  {
    int n1=3,n2=3;
    String name   = JOptionPane.showInputDialog("What's your name?" );
    String number = JOptionPane.showInputDialog("What's your student's ID?" );
    
    
    
    Object[] options = {"是(Y)", "否(N)"};
    Object[] options2 = {"籃球","棒球"};
    Object[] options3 = {"逛街","聽音樂"};
    String[] options4 = {"boy","girl"};
    int n = JOptionPane.showOptionDialog(null, "Are you a boy?", "About you", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, options, options[1]);
    
    
   if ( n == 0)
   {
     n1 = JOptionPane.showOptionDialog(null, "Which one do you like??", "About you", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, options2, options2[1]);
   }
   else
   {
	 n2 = JOptionPane.showOptionDialog(null, "Which one do you like?", "About you", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, options3, options3[1]);
   }


   System.out.printf("My name is %s , amd My student's ID is %s\nI'm a %s , and I like to ",name,number,options4[n]);

   if(n == 0 && n1 ==0)
   {
	   System.out.printf("play basketball.");
   }
   else if (n == 0 && n1 == 1)
   {
	   System.out.printf("play baseball.");
   }
   else if (n == 1 && n2== 0)
   {
	   System.out.printf("shopping.");
   }
   else if (n == 1 && n2 == 1)
   {
	   System.out.printf("listen music.");
   }
    System.exit( 0 );

  }

}
