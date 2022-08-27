package solid.singleResponsibility.wrong;

public interface IPhone {
	void dial(String phoneNumbe);
	void disconnect();
	
	
	void send(String message);
	int receive();
}
