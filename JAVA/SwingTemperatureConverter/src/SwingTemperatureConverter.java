import javax.swing.JFrame;

public class SwingTemperatureConverter
{
	public static void main(String[] arg)
	{
		SwingTemperatureConvert cvt = new SwingTemperatureConvert();
		cvt.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		cvt.setSize(300, 100);
		cvt.setVisible(true);
	}
}