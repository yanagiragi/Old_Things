import java.awt.BorderLayout;
import java.awt.Component;
import java.io.IOException;
import java.net.URL;

import javax.media.CannotRealizeException;
import javax.media.Manager;
import javax.media.NoPlayerException;
import javax.media.Player;
import javax.swing.JPanel;
	

public class movie extends JPanel
{
	
	public movie(URL url)
	{
		setLayout(new BorderLayout());
		
	//	Manager.setHint(Manager.LIGHTWEIGHT_RENDERER,true);
		// MediaLocator xxx = new MediaLocator(new java.lang.String("file:///D:/XXXX.mpg")); 
		try
		{
			Player mediaplayer = Manager.createRealizedPlayer(url);
		
			Component video = mediaplayer.getVisualComponent();
			Component controls = mediaplayer.getControlPanelComponent();
			if(video != null)
				add(video,BorderLayout.CENTER);
			if(controls != null)
				add(controls,BorderLayout.SOUTH);
			mediaplayer.start();
			//Thread.sleep(1000);
		}
		
		catch(NoPlayerException noPlayerException)
		{
			System.err.println("No media player found");
		}
		catch(CannotRealizeException cannotRealizeException)
		{
			System.err.println("Could not realized the media player");
		}
		catch(IOException ioException)
		{
			System.err.println("Error from reading the source");
		}
	}
}