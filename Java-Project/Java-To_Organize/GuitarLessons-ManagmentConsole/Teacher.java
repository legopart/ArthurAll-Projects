public class Teacher extends Person {
private		String begingTeachingDate;
private		int lessonMinutesLong;
private		double salary;
			public Teacher (String id, String firstName, String lastName) 
	throws Illegal_Exception_Message, Illegal_Exception_Id
			{
				super(id, firstName, lastName);
			}
			public Teacher (String id, String firstName, String lastName, String address, String phoneNumber, Instrument instrument, Gender gender,
					String begingTeachingDate, int lessonMinutesLong, double salary
					) 
	throws Illegal_Exception_Message, Illegal_Exception_Id 
			{
				super(id, firstName, lastName, address, phoneNumber, instrument, gender);
				setBegingTeachingDate(begingTeachingDate);
				setLessonMinutesLong(lessonMinutesLong);
				setSalary(salary);
			}
			

			public String getBegingTeachingDate() {
				return begingTeachingDate;
			}
			public int getLessonMinutesLong() {
				return lessonMinutesLong;
			}
			public double getSalary() {
				return salary;
			}
			

			public void setBegingTeachingDate(String begingTeachingDate) {
				this.begingTeachingDate = begingTeachingDate;
			}
			public void setLessonMinutesLong(int lessonMinutesLong) {
				this.lessonMinutesLong = lessonMinutesLong;
			}
			public void setSalary(double salary) {
				this.salary = salary;
			}
			

			@Override
			public String toString() {
				return super.toString()
				+getBegingTeachingDate()+", "
				+getLessonMinutesLong()+", "
				+getSalary()+", "
				;
			}
			
			
}
