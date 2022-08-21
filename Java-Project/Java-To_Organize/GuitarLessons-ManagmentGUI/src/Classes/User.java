package Classes;

import java.io.Serializable;

import Exeption.Illegal_Exception_Message;
import Exeption.Patterns;
import Interface.UserInterface;

public class User implements Serializable,  UserInterface {
	private String name;
	private String password;
	
	public User(String name, String password) throws Illegal_Exception_Message {
		setName(name);
		setPassword(password);
	}
	
	public String getUserName() {return name;}
	public String getPassword() {return password;}

	public void setName(String name) throws Illegal_Exception_Message {
		Patterns.id(name);
		this.name = name;
	}
	public void setPassword(String password) throws Illegal_Exception_Message {
		Patterns.password(password);
		this.password = password;
	}

	@Override
	public String toString() {
		return getClass().getName()+ " [userName : " + name + ", password: " + password + "]\n";
	}
}