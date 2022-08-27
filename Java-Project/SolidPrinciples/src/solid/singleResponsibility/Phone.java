package solid.singleResponsibility;

public class Phone implements IConnectionManager, IDataManager {

	private IConnectionManager connection;	//interface!
	private IDataManager dataChannel;
	
	public Phone() {
		connection = new ConnectionManager();
		dataChannel = new DataManager();
	}
	
	public void send(String message) {
		dataChannel.send(message);
	}

	public int receive() {
		return dataChannel.receive();
	}

	public void dial(String phoneNumbe) {
		connection.dial(phoneNumbe);
		
	}

	public void disconnect() {
		connection.disconnect();
	}

}
