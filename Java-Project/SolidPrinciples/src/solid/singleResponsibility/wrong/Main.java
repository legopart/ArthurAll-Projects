
package solid.singleResponsibility.wrong;

public class Main {
	public static void main(String args[]) {
		IPhone phone = new Phone();
		phone.dial("12345678");
		phone.send("hi message");
		phone.receive();
		phone.disconnect();
		
	}
}
