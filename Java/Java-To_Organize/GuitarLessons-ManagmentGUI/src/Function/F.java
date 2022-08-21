package Function;

import javax.swing.JButton;
import javax.swing.JOptionPane;
import javax.swing.JPanel;

import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;


public class F {
	public static void errorMsg(String str) {System.err.printf("%s",str+"\n  \n");}
	public static void errorMsg(String str, JPanel contentPane) {
		System.err.printf("%s",str+"\n  \n");
		JOptionPane.showMessageDialog(contentPane, str);
					}
	public static void illegalExeptionMessage(String str, JPanel contentPane) throws Illegal_Exception_Message {
		JOptionPane.showMessageDialog(contentPane, str);		
		throw new Exeption.Illegal_Exception_Message("\""+ str +"\"");
	}
	public static void illegalExeptionMessage(String str, JButton contentButton) throws Illegal_Exception_Message {
		JOptionPane.showMessageDialog(contentButton, str);		
		throw new Exeption.Illegal_Exception_Message("\""+ str +"\"");
	}
	
	public static void msg(String str, JPanel contentPane) {JOptionPane.showMessageDialog(contentPane, str);}
	public static void msg(String str, JButton contentButton) {JOptionPane.showMessageDialog(contentButton, str);}
	
	public static void println(String str) {System.out.println(String.valueOf(str));}
	public static void println() {System.out.println();}
	
	
	//For classes like Teacher and Student
	public static int stringInt(String str) {return ((str.isEmpty()) ? 0 : Integer.parseInt(str));}
	public static double stringDouble(String str) {return ((str.isEmpty()) ? 0.0 : Double.parseDouble(str));}
	
	public static int timeInt(String time) {return stringInt(time.replaceAll(":",""));}
	public static boolean time(String timeSeted, String timeCompared, int allowedLong) {
		return 	( timeInt(timeCompared) < timeInt(timeSeted)&&timeInt(timeSeted) <= timeInt(timeCompared)+allowedLong)
				||( timeInt(timeCompared) <= timeInt(timeSeted) +allowedLong&&timeInt(timeSeted)+allowedLong < timeInt(timeCompared)+allowedLong);
	}
}
