import java.util.regex.Pattern;

public abstract class  Person implements PersonInterface {
private		String id;
private 	String firstName;
private		String lastName;
private		String address;
private		String phoneNumber;
private		Instrument instrument;
private		Gender gender;

		public Person(String id, String firstName, String lastName) 
throws Illegal_Exception_Message, Illegal_Exception_Id
		{
			setId(id);
			setFirstName(firstName);
			setLastName(lastName);
		}


			public Person(String id, String firstName, String lastName, String address, String phoneNumber, Instrument instrument, Gender gender) 
throws Illegal_Exception_Message, Illegal_Exception_Id
			{
				this(id, firstName, lastName);
				setAddress(address);
				setPhoneNumber(phoneNumber);
				setInstrument(instrument);
				setGender(gender);
			}

public  String getFirstName() {
	return firstName;
}
public String getLastName() {
	return lastName;
}
public String getAddress() {
	return address;
}
public String getPhoneNumber() {
	return phoneNumber;
}
public Instrument getInstrument() {
	return instrument;
}
public Gender getGender() {
	return gender;
}
public String getId() {
	return id;
}


public void setId(String id) throws Illegal_Exception_Id  {
	if(Pattern.compile("[^0-9]").matcher( id ).find()) {throw new Illegal_Exception_Id("\""+id + "\" --is not a number! (alowed between 3-10 and numbers)");}
	if(id.length()<3) {throw new Illegal_Exception_Id("\""+id + "\" --is too short id (alowed between 3-10 and numbers)");}
	if(id.length()>11) {throw new Illegal_Exception_Id("\""+id + "\" --is too long id (alowed between 3-10 and numbers)");}
	this.id = id;
}
public void setFirstName(String firstName) throws Illegal_Exception_Message {
	if(Pattern.compile("[^A-Za-z]").matcher( firstName  ).find()) {throw new Illegal_Exception_Message("\""+firstName + "\" --first name is not a number! (alowed between 3-10 and numbers)");}
	if(firstName.length()<3) {throw new Illegal_Exception_Message("\""+firstName + "\" --is too short first name (alowed between 3-19 letters)");}
	if(firstName.length()>20) {throw new Illegal_Exception_Message("\""+firstName + "\" --is too long first name (alowed between 3-19 letters)");}
	this.firstName = firstName;
}
public void setLastName(String lastName) throws Illegal_Exception_Message {
	if(Pattern.compile("[^A-Za-z]").matcher( lastName  ).find()) {throw new Illegal_Exception_Message("\""+lastName + "\" --last name is not a number! (alowed between 3-10 and numbers)");}
	if(lastName.length()<3) {throw new Illegal_Exception_Message("\""+lastName + "\" --is too short last name (alowed between 3-19)");}
	if(lastName.length()>20) {throw new Illegal_Exception_Message("\""+lastName + "\" --is too long last name (alowed between 3-19)");}
	this.lastName = lastName;
}

public void setAddress(String address) {
	this.address = address;
	
}
public void setPhoneNumber(String phoneNumber) throws Illegal_Exception_Message {
	if(Pattern.compile("^[0-9]").matcher( phoneNumber ).find()) {throw new Illegal_Exception_Message("\""+phoneNumber + "\" --is not a number! (alowed input only numbers)");}
	this.phoneNumber = phoneNumber;
}
public void setInstrument(Instrument instrument) throws Illegal_Exception_Message {
	this.instrument = instrument;
}
public void setGender(Gender gender) {
	this.gender = gender;
}

@Override
public String toString() {
	return "- "
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
