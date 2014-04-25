import javax.swing.JOptionPane;

import java.util.Random;

public class count
{
	public static String[] counts(int ss,int s1,char[] impChar)
	{
		
			
		
		String end = JOptionPane.showInputDialog("Enter your guess(4 letters");
		end = end.toUpperCase();
		
		char[] tmpChar = end.toCharArray(); 
		
		//char[] tmpChar1 = new char[4];
	//	char[] impChar1 = new char[4];
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
		
			
		
				
		
		
		char[] chknum1  = new char[4];		
		char[] chknum2  = new char[4];
		int[]  chknum11 = new int[4];
		int[]  chknum22 = new int[4];
		
		count11.counting(tmpChar, chknum1, chknum11);		
		count11.counting(impChar, chknum2, chknum22);
		
		int maxsame1 = Math.max(Math.max(chknum11[0], chknum11[1]),Math.max(chknum11[2], chknum11[3]));
		int maxsame2 = Math.max(Math.max(chknum22[0], chknum22[1]),Math.max(chknum22[2], chknum22[3]));
		
		// for2		
		char maxnum2of1='0',maxnum2of2='0';
		char maxnum2of11='0',maxnum2of22='0';
		int maxnum2chk1=0,maxnum2chk2=0;
		int count2for1 = 0;
		int count2for2 = 0;
		for(int count3 = 0; count3 < 4; count3++)
		{ 
				if(chknum11[count3]==2 && count2for1 ==0)
				{	
						maxnum2of1 = chknum1[count3];					
						count2for1 = 1 ;
				}
				else if(chknum11[count3]==2 && count2for1 == 1) 
				{
						maxnum2of11 = chknum1[count3];
						maxnum2chk1++;
				}
				else{}
				
				if(chknum22[count3]==2 && count2for2 ==0)
				{	
						maxnum2of2 = chknum2[count3];					
						count2for2 = 1;
				}
				else if(chknum22[count3]==2 && count2for2 == 1)
				{
					maxnum2of22 = chknum2[count3];	
					maxnum2chk2++;
				}
				else{}
				
		}
		
		int efg1=0,efg2=0,efg11 =0,efg22=0;;
		for(int count3 = 0; count3 < 4; count3++)
		{
				if(chknum11[count3]==1 &&efg1 ==0)				
					efg1 = count3;
				else if(chknum11[count3]==1 &&efg1 !=0)	//if(chknum11[count3]==1 &&efg1 !=0)
					efg11 = count3;	
				else{}
				if(chknum22[count3]==1 &&efg2 ==0)
					efg2 = count3;	
				else if(chknum22[count3]==1 &&efg2 !=0)//if(chknum22[count3]==1 &&efg2 !=0)
					efg22 = count3;
				else{}
		}
		
	
		//for 3
		char maxnum3of1='0',maxnum3of2='0';
		for(int count3 = 0; count3 < 4; count3++)
		{
				if(chknum11[count3]==3)
					maxnum3of1 = chknum1[count3];
				if(chknum22[count3]==3)
					maxnum3of2 = chknum2[count3];
		}
		
		char maxnum4of1='0',maxnum4of2='0';
		for(int count3 = 0; count3 < 4; count3++)
		{
				if(chknum11[count3]==4)
					maxnum4of1 = chknum1[count3];
				if(chknum22[count3]==4)
					maxnum4of2 = chknum2[count3];
		}
		
		int cde1=0,cde2=0;
		for(int count3 = 0; count3 < 4; count3++)
		{
				if(chknum11[count3]==1)
				cde1 = count3;
				if(chknum22[count3]==1)
				cde2 = count3;	
		}
	
		//for 4		
		 for(int count=0 ; count < 4 ; count++ )
		 {
			 if (tmpChar[count] == impChar[count])
		 		{
				 ss=ss+1;
				}		 	
	     }
		
		 //counting start!
		 for(int count=0 ; count < 4 ; count++ )
		 {
			
			 for(int count2=0 ; count2 < 4 ; count2++ )
			 {
				 if(maxsame1 ==1 && maxsame2 ==1)
				 {
					 if (tmpChar[count] == impChar[count2])				 	
					 	{
						 s1=s1+1;						 
						break; 
					 	}	
				 }
				 if(maxsame1 ==1 && maxsame2 !=1)
				 {
					 if(maxsame2 ==2)
					 {
						
						 if(maxnum2chk2 == 0) // 2=AABC
						 {						 
							if(maxnum2of2 == tmpChar[0] || maxnum2of2 == tmpChar[1] || maxnum2of2 == tmpChar[2] || maxnum2of2 == tmpChar[3])
							{
								int count9=0;
								for(int count8 =0;count8<4;count8++ )
								{
									if(impChar[efg2] == tmpChar[count8])
										count9++;
									if(impChar[efg22] == tmpChar[count8])
										count9++;
								}
								switch(count9)
								{
								case 0:
									s1=1;
									break;
								case 1:
									s1=2;
									break;
								case 2:
									s1=3;
									break;
								default:
									break;										
								}
							}
							else
							{
								int count9=0;
								for(int count8 =0;count8<4;count8++ )
								{
									if(impChar[efg2] == tmpChar[count8])
										count9++;
									if(impChar[efg22] == tmpChar[count8])
										count9++;
								}
								switch(count9)
								{
								case 0:
									s1=0;
									break;
								case 1:
									s1=1;
									break;
								case 2:
									s1=2;
									break;
								default:
									break;										
								}
							}
							
						 }
						 else  // 2=AABB
						 {
							 if( ((maxnum2of2  == tmpChar[0]) || (maxnum2of2  == tmpChar[1]) || (maxnum2of2  == tmpChar[2]) ||(maxnum2of2  == tmpChar[3])) &&
							     ((maxnum2of22 == tmpChar[0]) || (maxnum2of22 == tmpChar[1]) || (maxnum2of22 == tmpChar[2]) ||(maxnum2of22 == tmpChar[3])) )
								s1=2;
							 else if( ((maxnum2of2  == tmpChar[0]) || (maxnum2of2  == tmpChar[1]) || (maxnum2of2  == tmpChar[2]) ||(maxnum2of2  == tmpChar[3])) ||
								     ((maxnum2of22 == tmpChar[0]) || (maxnum2of22 == tmpChar[1]) || (maxnum2of22 == tmpChar[2]) ||(maxnum2of22 == tmpChar[3])) )
							 	s1=1;
							 else
							 	s1=0;					 
							 
						 }						 
					 }
					 else if(maxsame2 ==3) //maxsame1 =1 && maxsame2 =3
					 {					
									if(maxnum3of2 == tmpChar[0] || maxnum3of2 == tmpChar[1] || maxnum3of2 == tmpChar[2] || maxnum3of2 == tmpChar[3] )
									{
										
										if(impChar[cde2] == tmpChar[0] || impChar[cde2] == tmpChar[1] || impChar[cde2] == tmpChar[2] || impChar[cde2] == tmpChar[3]) 
										{
											if(impChar[cde2] == tmpChar[cde2]) 
												s1 = 2;
											else 
												s1 = 2 ;								
										}
									}
									else 
									{
										if(impChar[cde2] == tmpChar[0] || impChar[cde2] == tmpChar[1] || impChar[cde2] == tmpChar[2] || impChar[cde2] == tmpChar[3]) 
										{
											if(impChar[cde2] == tmpChar[cde2]) 
												s1 = 1;
											else 
												s1 = 1 ;
										}
										else 
											s1 = 1;
									}							
					 }
					 else //maxsame1 =1 && maxsame2 =4
					 {
						    if(maxnum4of2 == tmpChar[0] || maxnum4of2 == tmpChar[1] || maxnum4of2 == tmpChar[2] || maxnum4of2 == tmpChar[3])
						    	s1=1;
						    else
						    	s1=0;
					 }
				 }
				 
				 if(maxsame1 ==2)
				 {
					 if(maxnum2chk1 == 0) // 1=AABC
					 {						 
						if(maxsame2 == 1)
						{
							int count7 = 0 ; //check AABC |ABCD OR ABDE OR ADEF 
							 for(int count5=0 ; count5 < 4 ; count5++ )
							 {
								 for(int count6=0 ; count6 < 4 ; count6++ )
								 {
									  if (tmpChar[count5] == impChar[count6])				 	
										 	{
											 count7=count7+1;
											break; 
										 	}										 
								 }
							 }
							 switch(count7)
							 {
							 	case 4: //AABC | ABCD
							 		s1=3;
							 		break;
							 	case 3: //AABC | ABDE
							 		s1=2;
							 		break;
							 	case 2: //AABC | ADEF
							 		s1=1;
							 		break;
							 	case 1: //AABC | BDEF
							 		s1=1;
							 	default:							 		
							 		break;	
							 
							 }
						}
						else if(maxsame2 == 2)
						{						
							if(maxnum2chk2!=0)								
							{
								if(maxnum2of1 == maxnum2of2)
								{
									if(maxnum2of22 == tmpChar[efg1] || maxnum2of22 == tmpChar[efg2])
										s1=3;
									else //maxnum2of22 != tmpChar[efg1] && maxnum2of22 != tmpChar[efg2]
										s1=2;
								}
								else
								{
									if(maxnum2of22 == tmpChar[efg1] || maxnum2of22 == tmpChar[efg2])
										s1=2;
									else //maxnum2of22 != tmpChar[efg1] && maxnum2of22 != tmpChar[efg2]
										s1=0;									
								}
							}
							else //maxnum2chk ==0
							{
								if(maxnum2of1 == maxnum2of2)
								{	
									if( (impChar[efg2] == tmpChar[efg1] || impChar[efg22] == tmpChar[efg1]) && (impChar[efg2] == tmpChar[efg11] || impChar[efg22] == tmpChar[efg11]) )
										s1=4;
									else if( (impChar[efg2] == tmpChar[efg1] || impChar[efg22] == tmpChar[efg1]) || (impChar[efg2] == tmpChar[efg11] || impChar[efg22] == tmpChar[efg11]))
										s1=3;
									else
										s1=2;
								}
								else if(maxnum2of1 != maxnum2of2 && (maxnum2of2 == tmpChar[efg1] || maxnum2of2 == tmpChar[efg11]))
								{  
									if( (impChar[efg2] == maxnum2of1 || impChar[efg22] == maxnum2of1) && (impChar[efg2] == maxnum2of1 || impChar[efg22] == maxnum2of1) )
										s1=3;
									else if( (impChar[efg2] == maxnum2of1 || impChar[efg22] == maxnum2of1) || (impChar[efg2] == maxnum2of1 || impChar[efg22] == maxnum2of1) )
										s1=2;
									else
										s1=1;
								}
								else
								{
									if(maxnum2of22 == tmpChar[efg1] || maxnum2of22 == tmpChar[efg2])
										s1=2;
									else //maxnum2of22 != tmpChar[efg1] && maxnum2of22 != tmpChar[efg2]
										s1=0;										
								}
							}
						}
							 
						else if(maxsame2 == 3)
						{
							//System.out.println("123");							
							if(maxnum3of2 == maxnum2of1)
							{								
								if(impChar[cde2] == tmpChar[efg1]  || impChar[cde2] == tmpChar[efg11])	
									s1=3;
								else
									s1=2;
							}
							else if(maxnum3of2 != maxnum2of1 && !(maxnum3of2== tmpChar[efg1] || maxnum3of2== tmpChar[efg11]) )
							{
								if(impChar[cde2] == maxnum2of2)	
									s1=1;
								else if(impChar[cde2] == tmpChar[efg1]  || impChar[cde2] == tmpChar[efg11])	
									s1=1;
								else
									s1=0;
							}
							else
							{
								if(impChar[cde2] == maxnum2of1)	
									s1=2;
								else if(impChar[cde2] == tmpChar[efg1]  || impChar[cde2] == tmpChar[efg11])	
									s1=2;
								else
									s1=1;
							}							
						}
							
						else //if(maxsame2 ==4 )
						{
							if(maxnum4of2 == maxnum2of1)
								s1=2;
							else if( (maxnum4of2 != maxnum2of1) && ( (maxnum4of2 == tmpChar[efg1])||(maxnum4of2 == tmpChar[efg2]) ) )
								s1=1;
							else
								s1=0;
						}
					 }
					 else //maxnum2chk1==1 AABB
					 {
						 if(maxsame2 ==1)
							{
							 
								if((maxnum2of1  == impChar[0] || maxnum2of1  == impChar[1] || maxnum2of1  == impChar[2] || maxnum2of1  == impChar[3]) && 
								  (maxnum2of11 == impChar[0] || maxnum2of11 == impChar[1] || maxnum2of11 == impChar[2] || maxnum2of11 == impChar[3]) )
								{
									int count4=0;
									for(int count3 = 0; count3 < 4; count3++)
									{
										if(tmpChar[count3] == impChar[count3])
											count4++;
									}
									if(count4 ==2)
										s1 = 2;
									else if (count4 ==1)
										s1 = 2;
									else // count4 =0
										s1 = 2;									
								}
								else if((maxnum2of1  == impChar[0] || maxnum2of1  == impChar[1] || maxnum2of1  == impChar[2] || maxnum2of1  == impChar[3]) || 
									    (maxnum2of11 == impChar[0] || maxnum2of11 == impChar[1] || maxnum2of11 == impChar[2] || maxnum2of11 == impChar[3]) && 
									   !((maxnum2of1  == impChar[0] || maxnum2of1  == impChar[1] || maxnum2of1  == impChar[2] || maxnum2of1  == impChar[3]) && 
										(maxnum2of11 == impChar[0] || maxnum2of11 == impChar[1] || maxnum2of11 == impChar[2] || maxnum2of11 == impChar[3]) ))
								{
									int count4=0;
									for(int count3 = 0; count3 < 4; count3++)
									{
										if(tmpChar[count3] == impChar[count3])
											count4++;
									}
									if(count4==0)
										s1 = 1;
									else //count4=1
										s1 = 1;
								}
								else
									s1=0;
																	  
							}
						 else if(maxsame2 ==2)
						 	{
							 if(maxnum2chk2 == 0) // 2=AABC
							 {								 
								if(maxnum2of1 == maxnum2of2 || maxnum2of11 == maxnum2of2)
								{
									if(impChar[efg2] == maxnum2of1 || impChar[efg2] == maxnum2of11 || impChar[efg22] == maxnum2of1 || impChar[efg22] == maxnum2of11)
										s1 =3;
									else
										s1 =2;  
								}
								else
								{
									if((impChar[efg2] == maxnum2of1 && impChar[efg22] == maxnum2of11) || (impChar[efg2] == maxnum2of11 && impChar[efg22] == maxnum2of1))
										s1 =2;
									else if(impChar[efg2] == maxnum2of1 || impChar[efg2] == maxnum2of11 || impChar[efg22] == maxnum2of1 || impChar[efg22] == maxnum2of11)
										s1 =1;
									else
										s1 =0;
								}
								 
							 }		
							 else // 2=AABB
							 {
								 if((maxnum2of1 == maxnum2of2 && maxnum2of11 == maxnum2of22) || (maxnum2of1 == maxnum2of22 && maxnum2of11 == maxnum2of2))
									s1 = 4;
								else if(maxnum2of1 == maxnum2of2 || maxnum2of1 == maxnum2of22 || maxnum2of11 == maxnum2of2 || maxnum2of11 == maxnum2of22)
										s1 = 2;
								else // maxnum2of1 != maxnum2of2 && maxnum2of11 != maxnum2of22
								 s1 = 0;
							 }
						 }
					
					 else if(maxsame2 == 3)
						{
						 	if(maxnum3of2 == maxnum2of1 || maxnum3of2 == maxnum2of11)
							{
								if((maxnum2of11== impChar[cde2] || maxnum2of1== impChar[cde2]) )
									s1=3;
								else
									s1=2;
							}
							else if(maxnum2of11== impChar[cde2] || maxnum2of1== impChar[cde2] )
									s1=1;
							else
									s1=0;			
						}
								
					 else //if(maxsame2 ==4 )
						{
						 	if(maxnum4of2 == maxnum2of1 || maxnum4of2 == maxnum2of11)
						 			s1=2;
							else
									s1=0;
						}
					 } 
				 }
				 
				 if(maxsame1 == 3 ) //tmpchar AAAB
				 {
				 	 if(maxsame2 ==1) //maxsame1 =3 && maxsame2 =1
						{
								if(maxnum3of1 == impChar[0] || maxnum3of1 == impChar[1] || maxnum3of1 == impChar[2] || maxnum3of1 == impChar[3] )
								{
									
									if(tmpChar[cde1] == impChar[0] || tmpChar[cde1] == impChar[1] || tmpChar[cde1] == impChar[2] || tmpChar[cde1] == impChar[3]) //AAAB|ABCD
									{
										if(tmpChar[cde1] == impChar[cde1]) //AAAB|ADEB
											s1 = 2;
										else //AAAB|ACBD
											s1 = 2 ;								
									}
								}
								else //FFFB|ACDE
								{
									if(tmpChar[cde1] == impChar[0] || tmpChar[cde1] == impChar[1] || tmpChar[cde1] == impChar[2] || tmpChar[cde1] == impChar[3]) //EEEB|ABCD
									{
										if(tmpChar[cde1] == impChar[cde1]) //FFFB|ADEB
											s1 = 1;
										else //FFFB|ACBD
											s1 = 1 ;
									}
									else //ABCD|EEEF
										s1 = 1;
								}
						}	
					 
					 else if(maxsame2==2)
					 {
						 if(maxnum2chk1 != 0)
						 {
							 if( maxnum2of2 == maxnum3of1 || maxnum2of22 == maxnum3of1 )
							 {
								 if( maxnum2of2 == tmpChar[cde1] || maxnum2of22 == tmpChar[cde1] )
									 s1=3;
								 else
									 s1=2;										
							 }
							 else if( maxnum2of2 == tmpChar[cde1] || maxnum2of22 == tmpChar[cde1])
								 s1=1;
							 else
								 s1=0;
							 
						 }
						 else
						 {
							 
							 if( maxnum2of2 == maxnum3of1 )
							 {
								 if(impChar[efg2] == tmpChar[cde1] || impChar[efg22] == tmpChar[cde1])
									 s1=3;
								 else
									 s1=2;
							 }
							 else if ( maxnum2of2 == tmpChar[cde1])
							 {
								
								 if(impChar[efg2] == maxnum3of1 || impChar[efg22] == maxnum3of1)
									 s1=2;								 
								 else
									 s1=1;
							 }
							 else
							 {
								 s1=0;
								 if(impChar[efg2] == maxnum3of1 || impChar[efg22] == maxnum3of1)
									 s1++;
								 if(impChar[efg2] == tmpChar[cde1] || impChar[efg22] == tmpChar[cde1])
									 s1++;
							 }
						 }
					 }
					 
					 else if(maxsame2 == 3 ) // AAA:|???!
					 {
						if(maxnum3of1 == maxnum3of2) //AAAB|AAA?
						{
							for(int count3 = 0; count3 < 4; count3++)
							{
									if(chknum11[count3]==1 && chknum22[count3]==1)
									{
										if(chknum1[count3]==chknum2[count3])
											s1=4; //AAAB|AAAB
									}
									else
										s1=3; //AAAB|BAAA OR ABAA OR AABA
									}	
									if(chknum1[cde1]==chknum2[cde2])
									s1=4;   // AAAB|AAAB
							}	
							else
							{
								if(chknum1[cde1]==chknum2[cde2] && chknum1[cde1]!=maxnum3of2 && chknum2[cde2]!= maxnum3of1 ) //AAAB|AAAC
									s1=1;
								else if(chknum1[cde1]==maxnum3of2 && chknum2[cde2]== maxnum3of1 ) //AAAB|BBBA
									s1=2;
								else if(chknum1[cde1]!=maxnum3of2 && chknum2[cde2]== maxnum3of1 ) //AAAB|CCCB
									s1=1;
								else if(chknum1[cde1]==maxnum3of2 && chknum2[cde2]!= maxnum3of1 ) //AAAB|BBBC
									s1=1;
								else //AAAB|CCCD
								{s1=0;}
							}
					 }
					 else// if(maxsame2==4) //maxsame1 =3 && maxsame2 =4
					 {
							if(maxnum3of1 == maxnum4of2)
								s1 = 3;
							else if(maxnum3of1 != maxnum4of2 && tmpChar[cde1] == maxnum4of2)
								s1 = 1;
							else
								s1 = 0;
					}		 	
					 
				}//end if(maxsame1==3)
				 
				 
				 if(maxsame1 ==4)
				 {
					 if(maxsame2 ==1)
					 {
						 if(impChar[0] == maxnum4of1 || impChar[1] == maxnum4of1 || impChar[2] == maxnum4of1 || impChar[3] == maxnum4of1)
							 s1=1;
						 else
							 s1=0;
					 }
					 else if(maxsame2 ==2)
					 {
						 if(maxnum2chk1 != 0)
						 {
							 int count7 = 0 ; //check AABC |ABCD OR ABDE OR ADEF 
							 for(int count5=0 ; count5 < 4 ; count5++ )
							 {
								 if (impChar[count5] == maxnum4of1)	 	
									 count7=count7+1;											
							 }
							 s1=count7;							 
						 }
						 else
						 {
							 int count7 = 0 ; //check AABC |ABCD OR ABDE OR ADEF 
							 for(int count5=0 ; count5 < 4 ; count5++ )
							 {
								 if (impChar[count5] == maxnum4of1)	 	
									 count7=count7+1;											
							 }
							 s1=count7;	
						 }
					 }
					 else if(maxsame2 ==3)
					 {
						 	if(maxnum3of2 == maxnum4of1)
								s1 = 3;
							else if(maxnum3of2 != maxnum4of1 && impChar[cde2] == maxnum4of1)
								s1 = 1;
							else
								s1 = 0;
					 }
					 else //maxsame2 ==4
					 {
						 if(maxnum4of1 == maxnum4of2 && maxnum4of2 != 1 && maxnum4of1 != 1)
							 s1 = 4;
						 else
							 s1 = 0;
					 }
				 }				 
				 
				 
				 
		   	}//end for2
		 }	//end for1	 
		
	
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
		 
