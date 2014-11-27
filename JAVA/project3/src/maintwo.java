import javax.sound.sampled.AudioInputStream;
//import javax.Media.*;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;
import javax.swing.*;
import javax.media.CannotRealizeException;
import javax.media.Manager;
import javax.media.MediaLocator;
import javax.media.NoPlayerException;
import javax.media.Player;

import java.applet.AudioClip;
import java.awt.*;
import java.awt.event.*; 
import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;


public class maintwo extends JFrame
{
	Icon icon1 = new ImageIcon( getClass().getResource("18f6bf757464d772364d576b64eade90.gif") );
	Icon icon2 = new ImageIcon( getClass().getResource("18f6bf757464d772364d576b64eade90.jpg") );
	JLabel label1 = new JLabel(icon2);
	JLabel label2 = new JLabel();
	JLabel label3 = new JLabel();
	JLabel label4 = new JLabel();
	JLabel label5 = new JLabel();
	JButton earthquake = new JButton("Earthquake!");
	JButton encodebutton = new JButton("Encode! >>");
	JButton decodebutton = new JButton("<< Decode!");
	JTextArea text1 = new JTextArea("Type here for Encode                    English only",600,300); 
	JTextArea text2 = new JTextArea("Type here for Decode                    English only",600,300);
	static int count = 0;
	String[] items = {"Please Select Index","Earthquake","Encode & Decode","Music Player","Video Player","Other Components"};
	int itemSelected;
	JComboBox combobox = new JComboBox(items);
	int mainCountClicked  = 0;
	int mainCountNotChange = 0;
	JPanel clear = new JPanel();
	JFrame test1 = new JFrame();
	Container contain ;
	Graphics g1;
	String usertyped;
	public static boolean cls = true;
	static String encoded; 
	static char[] afterEncodeCharArray;
	static char[] afterDecodeCharArray;
	static char[] codechecklist = {'p','q','r','s','t','u','v','w','x','y','z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','\u0020'};
	static char[] codedlist     = {'X','@','{',';','/','[',']','V','x','a','t','F','U','C','K','u','%','B','q','h','~','0','￥','#','g','P','\u0020'};
	static int currentencodeindex = -1 ;
	static int currentdecodeindex = -1 ;
	static int[] currentencodeindexarray; 
	static int[] currentdecodeindexarray; 
	String[] lists = {"Black","Red","Blue","Green","Yellow","White"};
	JList jlists = new JList(lists);
	JButton colorclicked = new JButton("Finish picking!");
	static JRadioButton colorblack = new JRadioButton("Black");
	static JRadioButton colorred = new JRadioButton("Red");
	static JRadioButton colorblue = new JRadioButton("Blue");
	static JRadioButton colorgreen = new JRadioButton("Green");
	static JRadioButton coloryellow = new JRadioButton("Yellow");
	static JRadioButton colorwhite = new JRadioButton("White");
	JButton B_play;
	JButton B_loop;
	JButton B_stop;
	ButtonGroup radiogroup;	
	JPanel panel = new JPanel();
	JPanel panel2 = new JPanel();
	JPanel panel3 = new JPanel();
	music mus;
	
	/**********************************************************************************************************************************************************/
	
	public maintwo()
	{
		super("Project 3 ");
		getContentPane().setLayout(new BorderLayout());
	
		combobox.setMaximumRowCount(6);		
		getContentPane().add(combobox,BorderLayout.NORTH);
		
		panel.setSize(600, 543);
		contain = getContentPane();
		combobox.addItemListener(new ItemListener()
		{
			public void itemStateChanged(ItemEvent e)
			{
				if(e.getStateChange() == ItemEvent.SELECTED)
				{
					if(itemSelected != combobox.getSelectedIndex() )
						mainCountNotChange ++;
					itemSelected = combobox.getSelectedIndex();
					mainCountClicked = mainCountClicked + 1;
				}
			
				if(mainCountClicked != 0 && mainCountNotChange %2 ==1 )
				{
					switch(itemSelected)
					{
						case 0:							
							break;
						case 1:
							oppaimove();
							break;
						case 2:	
							becoded();
							break;
						case 3:	
							musicplayer();
							break;	
						case 4:
							movieplayer();
							break;
						case 5:							
							othercomponents();
							break;
						default:	
							break;						
					}
					mainCountNotChange++;
				}
				
				repaint();
				contain.validate();
				if(itemSelected == 1 || itemSelected == 2 || itemSelected == 3 || itemSelected == 4 || itemSelected == 5)
					cls = false;
				else
					cls = true;
			}
		});
		
	}	
	public void oppaimove()
	{
		getContentPane().add(label1,BorderLayout.CENTER);
		label1.setSize(496,496);
		
		earthquake.setSize(150,50);
		getContentPane().add(earthquake,BorderLayout.SOUTH);
		
		earthquake.addActionListener(new ActionListener()
			{	public void actionPerformed(ActionEvent event)
				{
			
					if(event.getSource() == earthquake)
						count++;
					
					if(count%2 == 1 )
					{
						label1.setIcon(icon1);
						earthquake.setText("Earthquake Stops!");
					}
					else
					{
						label1.setIcon(icon2);				
						earthquake.setText("Earthquake!");
					}
						
				}
			});
	}
	public void becoded()
	{
		Box box = Box.createHorizontalBox();
		
		box.add(text1);
		text1.setLineWrap(true);
		text2.setLineWrap(true);
		box.add(new JScrollPane(text1));
		
		box.add(encodebutton);
		encodebutton.addActionListener(
				
				new ActionListener()
				{
					public void actionPerformed(ActionEvent event)
					{
						if(event.getSource() == encodebutton)
						{
								text2.setText( strEncode( text1.getText() ) );	
						}
					}
				});
		
		box.add(decodebutton);
		decodebutton.addActionListener(
				
				new ActionListener()
				{
					public void actionPerformed(ActionEvent event)
					{
						if(event.getSource() == decodebutton)
						{
							text1.setText( strDecode( text2.getText() ) );							
						}
					}
				});
		box.add(text2);
		box.add(new JScrollPane(text2));
		getContentPane().add(box);
	}	
	public void paint(Graphics g)
	{
		super.paint(g);
		if(cls)
		{
			g.setColor(Color.black);
			g.fillRect(0, 57, 600,543);			
		}
	}
	public static String strEncode(String text)
	{
		int indexcount = 0 ;
		text = text.toLowerCase();
		char[] copytext = text.toCharArray();
		currentencodeindexarray = new int[text.length()];
		for(char chars : copytext)
		{
			for(int i =0 ; i < codechecklist.length; i++)
			{
				if(chars == codechecklist[i])
				{
					currentencodeindex = i ;
					indexcount++;
					break;
				}
			}
			currentencodeindexarray[indexcount-1] = currentencodeindex;		
		}
		
		int ciunt = 0;
		afterEncodeCharArray = new char[currentencodeindexarray.length];
		
		for(int y :currentencodeindexarray)
		{
			afterEncodeCharArray[ciunt] = codedlist[y];
			ciunt++;
		}
		
		String encodeinmethod = new String(afterEncodeCharArray);
		return encodeinmethod;
	}
	public static String strDecode (String text)
	{
		int indexcount = 0 ;
		char[] codedcopytext = text.toCharArray();

		currentdecodeindexarray = new int[text.length()];
		for(char chars : codedcopytext)
		{
			for(int i =0 ; i < codedlist.length; i++)
			{
				if(chars == codedlist[i])
				{
					currentdecodeindex = i ;
					indexcount++;
					break;
				}
			}
			currentdecodeindexarray[indexcount-1] = currentdecodeindex;		
		}
		int ciunt = 0;
		afterDecodeCharArray = new char[currentdecodeindexarray.length];
		for(int num :currentdecodeindexarray)
		{
				afterDecodeCharArray[ciunt] = codechecklist[num];
				ciunt++;
		}
		
		return (new String(afterDecodeCharArray));
		
	}
	public void othercomponents()
	{
		panel2.setLayout(new FlowLayout());
		getContentPane().add(panel2,BorderLayout.CENTER);

		panel2.add(jlists);
		JScrollPane scroll = new JScrollPane(jlists);
		scroll.setVerticalScrollBarPolicy(JScrollPane.VERTICAL_SCROLLBAR_ALWAYS);
		panel2.add(scroll);
		panel2.add(colorclicked);
		panel2.add(colorblack);
		panel2.add(colorred);
		panel2.add(colorblue);
		panel2.add(colorgreen);
		panel2.add(coloryellow);
		panel2.add(colorwhite);	
		radiogroup = new ButtonGroup();
		radiogroup.add(colorblack);
		radiogroup.add(colorred);
		radiogroup.add(colorblue);
		radiogroup.add(colorgreen);
		radiogroup.add(coloryellow);
		radiogroup.add(colorwhite);
	
		panel3.setVisible(true);
		//panel3.setBackground(Color.cyan);;
		getContentPane().add(panel3,BorderLayout.SOUTH);
		panel3.setPreferredSize(new Dimension(100, 330));
		
		
		label2.setText("_____________________________________________________________________________");
		label3.setText("You Have Choosed:  ");
		label4.setText("null");
		panel3.add(label2);		
		panel3.add(label3);
		panel3.add(label4);	

		label5.setText("         Black          Red          Blue          Yellow          Green          White          ");
		panel2.add(label5);
		
		dealothercomponents ion = new dealothercomponents();
		colorblack.addItemListener(ion);
		colorred.addItemListener(ion);
		colorblue.addItemListener(ion);
		coloryellow.addItemListener(ion);
		colorgreen.addItemListener(ion);
		colorwhite.addItemListener(ion);
		colorclicked.addActionListener(ion);
		panel2.addMouseListener(ion);
		
	}
	private class dealothercomponents implements ActionListener,ItemListener,MouseListener
	{
		public void itemStateChanged(ItemEvent event)
		{
				String colors = null;
			
				if(colorblack.isSelected())					
					colors = "Black";
				else if(colorred.isSelected())
					colors = "Red";
				else if(colorblue.isSelected())
					colors = "Blue";
				else if(coloryellow.isSelected())
					colors = "Yellow";
				else if(colorgreen.isSelected())
					colors = "Green";
				else if(colorwhite.isSelected())
					colors = "White";
				else;	
						
				label4.setText(""+colors);
			
		}

		public void actionPerformed(ActionEvent event)
		{
				String colors = null;
				if(event.getSource() == colorclicked)
				{
					if(jlists.getSelectedIndex() != -1 )
					{
						
						switch(jlists.getSelectedIndex())
						{
							case 0:
								colors = "Black";
								break;
							case 1:
								colors = "Red";
								break;
							case 2:
								colors = "Blue";
								break;
							case 3:
								colors = "Green";
								break;
							case 4:
								colors = "Yellow";
								break;
							case 5:
								colors = "White";
								break;
							default :
								break;						
						}
						
					}			
					label4.setText(""+colors);
				}
			
		}
		
		public void mousePressed(MouseEvent a)
		{
			String color = null;
			if(a.getY() < 186 && a.getY() > 173)
			{
				if(a.getX() > 124 && a.getX() < 154 )
					color="Black";
				else if(a.getX() > 184 && a.getX() < 205 )
					color="Red";
				else if(a.getX() > 240 && a.getX() < 261 )
					color="Blue";
				else if(a.getX() > 292 && a.getX() < 327 )
					color="Yellow";
				else if(a.getX() > 360 && a.getX() < 393 )
					color="Green";
				else if(a.getX() > 424 && a.getX() < 455 )
					color="White";
				else color="null";	
			}
			label4.setText(""+color);			
		}
		public void mouseClicked(MouseEvent a){}		
		public void mouseReleased(MouseEvent a){}
		public void mouseEntered(MouseEvent a){}
		public void mouseExited(MouseEvent a){}
		
	}
	public void musicplayer()
	{
		 String uta = "Merami - Dear, are you getting sober";
		// setLayout(new BorderLayout() );		 
		 getContentPane().add(new JLabel(uta),BorderLayout.SOUTH);
		 
		 Buttonhandler handler = new Buttonhandler();
		 
		 B_play = new JButton("Play");
		 B_play.addActionListener(handler);
		 getContentPane().add(B_play);

		/* B_loop = new JButton("Loop");
		 B_loop.addActionListener(handler);
		 getContentPane().add(B_loop);*/

		/* B_stop = new JButton("Stop");
		 B_stop.addActionListener(handler);
		 getContentPane().add(B_stop);*/
		 
		 mus = new music();
		 mus.music_main();
		// AudioClip utasong = mus.music_main();
	}
	private class Buttonhandler implements ActionListener
	{
		int count = 0;
		public void actionPerformed(ActionEvent e)
		{
			if(e.getSource() == B_play)
				mus.player((count%2));
			
			count++;
			//mus.player(0);
			/*else if(e.getSource() == B_loop)
				mus.player(1);
			else if(e.getSource() == B_stop)
				mus.player(2);
			else;*/
		}
	}
 public void movieplayer()
	{
		JFileChooser filechose = new JFileChooser();
		int result = filechose.showOpenDialog(null);
		
		if(result == JFileChooser.APPROVE_OPTION)
		{
			URL mediaurl = null ;
			
			try
			{
				mediaurl = filechose.getSelectedFile().toURI().toURL();
			}
			catch(MalformedURLException malformedURLException)
			{
				System.err.println("Could not create URL for the File");
			}
			
			if(mediaurl != null)
			{
				movie mediapanel = new movie(mediaurl);
				getContentPane().add(mediapanel);
				
			}
		}
	}
	
}