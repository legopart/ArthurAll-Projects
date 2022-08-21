package Interface;

import Exeption.Illegal_Exception_Message;

public interface UserInterface {
	public String getUserName() ;
	public String getPassword();
	public void setName(String name) throws Illegal_Exception_Message;
	public void setPassword(String password) throws Illegal_Exception_Message;
	
}
