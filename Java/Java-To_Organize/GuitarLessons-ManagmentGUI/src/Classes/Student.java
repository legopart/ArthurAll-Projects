package Classes;

import java.io.Serializable;

import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;
import Exeption.Patterns;
import Function.F;

public class Student extends Person implements Serializable  {
private		String begingStudyDate;
private		int acchivementYears;
		public Student (String id, String firstName, String lastName)
throws Illegal_Exception_Message
		{
			super(id, firstName, lastName);
		}
		public Student (String id, String firstName, String lastName, String address, String phoneNumber, Instrument instrument, Gender gender,String begingStudyDate, int acchivementYears) throws Illegal_Exception_Message {
			super(id, firstName, lastName, address, phoneNumber, instrument, gender);
			setBegingStudyDate(begingStudyDate);
			setAcchivementYears(acchivementYears);
		}
		public Student (String id, String firstName, String lastName, String address, String phoneNumber, Instrument instrument, Gender gender,String begingStudyDate, String acchivementYears) throws Illegal_Exception_Message {
			super(id, firstName, lastName, address, phoneNumber, instrument, gender);
			setBegingStudyDate(begingStudyDate);
			setAcchivementYears(acchivementYears);
		}		
		
		public String getBegingStudyDate() {return (begingStudyDate==null ? null :begingStudyDate.replaceAll(" ",""));}
		public int getAcchivementYears() {return acchivementYears;}
		
		public void setBegingStudyDate(String begingStudyDate) throws Illegal_Exception_Message {
			Patterns.date(begingStudyDate);
			this.begingStudyDate = begingStudyDate;
		}
		

		public void setAcchivementYears(String acchivementYears) throws Illegal_Exception_Message {
			Patterns.acchievement(acchivementYears);
			this.acchivementYears=F.stringInt(acchivementYears);
		}
			public void setAcchivementYears(int acchivementYears) {
				this.acchivementYears = acchivementYears;
			}

			
		@Override
		public String toString() {
			return super.toString()+
			getBegingStudyDate()+", "+
			getAcchivementYears()+"\n "
			;
		}
}
