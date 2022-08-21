package Classes;

import java.io.Serializable;

import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;
import Exeption.Patterns;
import Function.F;


public class Teacher extends Person implements Serializable {
private		String begingTeachingDate;
private		int lessonMinutesLong;
private		double salary;
			public Teacher (String id, String firstName, String lastName) throws Illegal_Exception_Message {
				super(id, firstName, lastName);
			}
			public Teacher (String id, String firstName, String lastName, String address, String phoneNumber, Instrument instrument, Gender gender, String begingTeachingDate, int lessonMinutesLong, double salary) throws Illegal_Exception_Message {
				super(id, firstName, lastName, address, phoneNumber, instrument, gender);
				setBegingTeachingDate(begingTeachingDate);
				setLessonMinutesLong(lessonMinutesLong);
				setSalary(salary);
			}
			public Teacher (String id, String firstName, String lastName, String address, String phoneNumber, Instrument instrument, Gender gender, String begingTeachingDate, String lessonMinutesLong, String salary) throws Illegal_Exception_Message {
				super(id, firstName, lastName, address, phoneNumber, instrument, gender);
				setBegingTeachingDate(begingTeachingDate);
				setLessonMinutesLong(lessonMinutesLong);
				setSalary(salary);
			}		

			public String getBegingTeachingDate() {return (begingTeachingDate==null ? null :begingTeachingDate.replaceAll(" ",""));}
			public int getLessonMinutesLong() {return lessonMinutesLong;}
			public double getSalary() {return salary;}

			public void setBegingTeachingDate(String begingTeachingDate) throws Illegal_Exception_Message {
				Patterns.date(begingTeachingDate);
				this.begingTeachingDate = begingTeachingDate;
			}

			public void setLessonMinutesLong(String lessonMinutesLong) throws Illegal_Exception_Message {
				Patterns.lessonLength(lessonMinutesLong);
				setLessonMinutesLong( ( !lessonMinutesLong.isEmpty() ? F.stringInt(lessonMinutesLong) : 0 ) );
			}
				public void setLessonMinutesLong(int lessonMinutesLong) {
					this.lessonMinutesLong = lessonMinutesLong;
				}
			public void setSalary(String salary) throws Illegal_Exception_Message {
				Patterns.lessonSalary(salary);
				setSalary( ( !salary.isEmpty() ? F.stringDouble(salary) : 0.0 ) );
			}			
				public void setSalary(double salary) {
					this.salary = salary;
				}
				
			@Override
			public String toString() {
				return super.toString()
				+getBegingTeachingDate()+", "
				+getLessonMinutesLong()+", "
				+getSalary()+"\n "
				;
			}		
}