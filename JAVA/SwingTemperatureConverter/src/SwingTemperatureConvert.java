import java.awt.FlowLayout;

import javax.swing.*;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;

public class SwingTemperatureConvert extends JFrame
{
	private JLabel label1;
	private JLabel label2;
	private JTextField text1;
	private JTextField text2;
	
	
	public SwingTemperatureConvert()
	{
	super("Temperature Converter");
	setLayout(new FlowLayout());
	
	label1= new JLabel("Fahrenheit: ",SwingConstants.LEFT);
	label2= new JLabel("Celsius:       ",SwingConstants.LEFT);
	text1 = new JTextField(15);
	text2 = new JTextField(15);
	
	add(label1);
	add(text1);
	add(label2);
	add(text2);
	
	TextFieldHandler handler= new TextFieldHandler();
	text1.addActionListener(handler);
	text2.addActionListener(handler);	
	}
	
	private class TextFieldHandler implements ActionListener
	{
		public void actionPerformed(ActionEvent event)
		{
			if(event.getSource() == text1)
			{
				Double convert2 = ((5.0/9.0 * (((Double.parseDouble(text1.getText())) -32))));
				text2.setText(convert2 + " ¢XC");
				//textFahr.requestFocus();
				//textFahr.selectAll();
			}
			else
			{
				Double convert1 =( 9.0/5.0 *  (Double.parseDouble( text2.getText() ) ) +32 );
				text1.setText(convert1 + " ¢XF");
				//textCels.requestFocus();
				//textCels.selectAll();
			}
		}
		
	}

}
