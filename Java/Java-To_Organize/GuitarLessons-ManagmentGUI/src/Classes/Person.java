package Classes;
import java.io.Serializable;
import java.util.regex.Pattern;

import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;
import Exeption.Patterns;
import Interface.PersonInterface;

public abstract class  Person implements PersonInterface, Serializable  {
private		String id;
private 	String firstName;
private		String lastName;
private		String address;
private		String phoneNumber;
private		Instrument instrument;
private		Gender gender;

public Person(String id, String firstName, String lastName) throws Illegal_Exception_Message {
	setId(id);
	setFirstName(firstName);
	setLastName(lastName);
}

public Person(String id, String firstName, String lastName, String address, String phoneNumber, Instrument instrument, Gender gender) throws Illegal_Exception_Message {
	this(id, firstName, lastName);
	setAddress(address);
	setPhoneNumber(phoneNumber);
	setInstrument(instrument);
	setGender(gender);
}

public  String getFirstName() {return firstName;}
public String getLastName() {return lastName;}
public String getAddress() {return address;}
public String getPhoneNumber() {return phoneNumber;}
public Instrument getInstrument() {return instrument;}
public Gender getGender() {return gender;}
public String getId() {return id;}


public void setId(String id) throws Illegal_Exception_Message  {
	Patterns.id(id);
	this.id = id;
	}
public void setFirstName(String firstName) throws Illegal_Exception_Message {
	Patterns.firstName(firstName);
	this.firstName = firstName;
	}
public void setLastName(String lastName) throws Illegal_Exception_Message {
	Patterns.lastName(lastName);
	this.lastName = lastName;
	}
public void setAddress(String address) throws Illegal_Exception_Message {
	Patterns.address(address);
	this.address = address;
	}
public void setPhoneNumber(String phoneNumber) throws Illegal_Exception_Message {
	Patterns.phoneNumber(phoneNumber);
	this.phoneNumber = phoneNumber;
	}
public void setInstrument(Instrument instrument) {this.instrument = instrument;}
public void setGender(Gender gender) {this.gender = gender;}

@Override
public String toString() {
	return "\n- "
	+getId()+", "
	+getFirstName()+", "
	+getLastName()+", "
	+getAddress()+", "
	+getPhoneNumber()+", "
	+getInstrument()+", "
	+getGender()+", "
	;
}


}
