package Classes;
import java.io.Serializable;

import Exeption.Illegal_Exception_Message;
import Interface.UserInterface;

public class Admin extends User implements Serializable,  UserInterface  {
		public Admin(String name, String password) throws Illegal_Exception_Message {
				super(name, password);
		}	
}
