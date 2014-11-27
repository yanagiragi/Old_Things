import java.applet.AudioClip;
import java.io.File;

import javax.media.format.AudioFormat;
import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.DataLine;
import javax.sound.sampled.SourceDataLine;
import javax.swing.JApplet;
import javax.swing.JButton;
import javax.swing.JTextField;



public class music extends JApplet
{
	AudioClip utasong ;
	
	public AudioClip music_main()
	{ 
		// utasong = getAudioClip(getDocumentBase(),"Dear, are you getting sober.wav");			 
		 return utasong;		
	}
	public void player( int a)
	{
		if(a == 0)
			playAudio();//utasong.play();
		/*else if (a ==1)
			utasong.loop();*/
		else if (a ==1)
			stopPlayback = true;//utasong.stop();
		else;
		
	}
	
	
	
	final JTextField textField =new JTextField("C:/Users/ragi/Documents/JAVA/project3/bin/Dear, are you getting sober.wav");
	javax.sound.sampled.AudioFormat audioFormat;
	AudioInputStream audioInputStream;
	SourceDataLine sourceDataLine;
	boolean stopPlayback = false;
	final JButton stopBtn = new JButton("Stop");
	final JButton playBtn = new JButton("Play");

	private void playAudio() {
	    try{
	      File soundFile =new File(textField.getText());
	      audioInputStream = AudioSystem.getAudioInputStream(soundFile);
	      audioFormat = audioInputStream.getFormat();
	     // System.out.println(audioFormat);

	      DataLine.Info dataLineInfo =new DataLine.Info(SourceDataLine.class,audioFormat);

	      sourceDataLine =(SourceDataLine)AudioSystem.getLine(dataLineInfo);

	      new PlayThread().start();
	    }catch (Exception e) {
	      e.printStackTrace();
	      System.exit(0);
	    }
	  }

	class PlayThread extends Thread{
	  byte tempBuffer[] = new byte[10000];

	  public void run(){
	    try{
	      sourceDataLine.open(audioFormat);
	      sourceDataLine.start();

	      int cnt;
	      
	      while((cnt = audioInputStream.read(
	           tempBuffer,0,tempBuffer.length)) != -1
	                       && stopPlayback == false){
	        if(cnt > 0)
	        {
	          sourceDataLine.write(tempBuffer, 0, cnt);
	        }
	      }
	      sourceDataLine.drain();
	      sourceDataLine.close();

	      stopBtn.setEnabled(false);
	      playBtn.setEnabled(true);
	      stopPlayback = false;
	    }catch (Exception e) {
	      e.printStackTrace();
	      System.exit(0);
	    }
	  }
	}
	
	
}