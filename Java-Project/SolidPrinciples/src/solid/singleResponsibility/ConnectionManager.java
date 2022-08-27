package solid.singleResponsibility;

public class ConnectionManager implements IConnectionManager {
	@Override
	public void dial(String phoneNumbe) {
		System.out.println("dial " + phoneNumbe);
	}

	@Override
	public void disconnect() {
		System.out.println("dicsconnect.");
	}
	
}
