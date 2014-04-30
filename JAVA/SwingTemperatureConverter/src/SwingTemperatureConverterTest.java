import java.*;

//import javax.*;
import javax.swing.JFrame;

public class SwingTemperatureConverterTest{
	public static void main (String args[]){
		SwingTemperatureConverter swingTemperatureConverter = new SwingTemperatureConverter();
		swingTemperatureConverter.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		swingTemperatureConverter.setSize(280,95);
		swingTemperatureConverter.setVisible(true);
	}
}