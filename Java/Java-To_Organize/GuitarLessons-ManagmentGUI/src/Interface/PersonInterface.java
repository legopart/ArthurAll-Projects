package Interface;

import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;

public interface PersonInterface {
/*String id;
String firstName;
String lastName;
String address;
String phoneNumber;
Instrument instrument;
Gender gender;*/

String getFirstName();
String getLastName();
String getAddress();
String getPhoneNumber();
Instrument getInstrument();
Gender getGender();
String getId();

void setId(String id) throws Illegal_Exception_Message;
void setFirstName(String firstName) throws Illegal_Exception_Message;
void setLastName(String lastName) throws Illegal_Exception_Message;
void setAddress(String address) throws Illegal_Exception_Message;
void setPhoneNumber(String phoneNumber) throws Illegal_Exception_Message;
void setInstrument(Instrument instrument) throws Illegal_Exception_Message;
void setGender(Gender gender);

String toString();

}
