
package solid.singleResponsibility;
//Using Facade
public class Main {
	public static void main(String args[]) {
		Phone phone = new Phone();
		phone.dial("9876432");
		phone.send("hellow some message");
		phone.receive();
		phone.disconnect();
	}
}
