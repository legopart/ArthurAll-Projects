public class Student extends Person {
private		String begingStudyDate;
private		int eperementYears;
		public Student (String id, String firstName, String lastName)
throws Illegal_Exception_Message, Illegal_Exception_Id
		{
			super(id, firstName, lastName);
		}
		public Student (String id, String firstName, String lastName, String address, String phoneNumber, Instrument instrument, Gender gender,
			String begingStudyDate, int eperementYears
			) 
throws Illegal_Exception_Message, Illegal_Exception_Id
		{
		super(id, firstName, lastName, address, phoneNumber, instrument, gender);
		setBegingStudyDate(begingStudyDate);
		setEperementYears(eperementYears);
		}
		
		
		
		
		public String getBegingStudyDate() {
			return begingStudyDate;
		}
		public int getEperementYears() {
			return eperementYears;
		}
		
		
		
		
		public void setBegingStudyDate(String begingStudyDate) {
			this.begingStudyDate = begingStudyDate;
		}
		public void setEperementYears(int eperementYears) {
			this.eperementYears = eperementYears;
		}


		@Override
		public String toString() {
			return super.toString()
			+getBegingStudyDate()+", "
			+getEperementYears()+", "
			;
		}


	
}
