package solid.singleResponsibility;

public class DataManager implements IDataManager {
	@Override
	public void send(String message) {
		System.out.println("send  "+ message);
		
	}

	@Override
	public int receive() {
		System.out.println("receive v");
		return 0;
	}

}
