package solid.singleResponsibility.wrong;

public class Phone implements IPhone {

	public void dial(String phoneNumbe) {
		System.out.println("dial " + phoneNumbe);
	}

	public void disconnect() {
		System.out.println("dicsconnect.");
		
	}

	public void send(String message) {
		System.out.println("send  "+ message);
		
	}

	public int receive() {
		System.out.println("receive v");
		return 0;
	}

	
}
