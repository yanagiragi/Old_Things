import java.io.*;
import javax.sound.sampled.*;

public class tri extends Thread{
	
public void run() {
while(true){
try {
// �إ� File ����
File sf = new File("Triodust-Dissonant Interval  ����M�U�����");

// ���o�n����J��y
AudioInputStream astr = AudioSystem.getAudioInputStream(sf);

// ���o�n���Φ�
AudioFormat afmt = astr.getFormat();

// �إ߰T���u��T����
DataLine.Info inf = new DataLine.Info(SourceDataLine.class,afmt);

// ���o�ŦX���w�T���u��T���T���u
SourceDataLine l = (SourceDataLine) AudioSystem.getLine(inf);

// �H���w�Φ��}�ҰT���u
l.open(afmt);

// �}�l�T���u��Ū�g
l.start();

// Ū�g�w�İ�
byte[] buf = new byte[65536];

// �q�n����yŪ�J��Ƽg�J�V����
for( int n=0; (n=astr.read(buf,0,buf.length))>0; )
{
l.write(buf,0,n);
}

// �M���V�����������
l.drain();

// ����
l.close();

} catch (Exception e) {
e.printStackTrace();
}
}
}
} 