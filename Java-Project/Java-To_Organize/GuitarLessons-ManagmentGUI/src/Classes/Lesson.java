package Classes;

import java.io.Serializable;

import Exeption.Illegal_Exception_Message;
import Exeption.Patterns;
import Interface.TeachingInterface;

public class Lesson implements TeachingInterface, Serializable  {
private		Student student;
private		Teacher teacher;
private		String location;
private		String date;
private		String time;
	
	public Lesson(Student student, Teacher teacher, String location, String date, String time) throws Illegal_Exception_Message {
		setStudent(student);
		setTeacher(teacher);
		setLocation(location);
		setDate(date);
		setTime(time);
	}

	public Student getStudent() {return student;}
	public Teacher getTeacher() {return teacher;}
	public String getLocation() {return location;}
	public String getDate() {return date;}
			public String getDateYear(){return getDate().substring(6,8);}
			public String getDateMouth(){return getDate().substring(3,5);}
			public String getDateDay(){return getDate().substring(0,2);}
	public String getTime() {return time;}

	public void setStudent(Student student) {this.student = student;}
		public String getStudentID() {return getStudent().getId();}
		public String getStudentFirstName() {return getStudent().getFirstName();}
		public String getStudentLastName() {return getStudent().getLastName();}
	public void setTeacher(Teacher teacher) {this.teacher = teacher;}
		public String getTeacherID() {return getTeacher().getId();}
	public void setLocation(String location) {
		this.location = location;
	}
	public void setDate(String date) throws Illegal_Exception_Message {
		Patterns.lessonDate(date);
		this.date = date;
	}
	public void setTime(String time) throws Illegal_Exception_Message {
		Patterns.lessonTime(time);
		
		this.time = time;
	}
	

	@Override
	public String toString() {
		return
			"- student("+
			((getStudent()==null)? "-" : getStudent().getId()+", "+getStudent().getFirstName()+", "+getStudent().getLastName() )+
			") teacher("+
			
			((getTeacher()==null)? "-" : getTeacher().getId()+", "+getTeacher().getFirstName()+", "+getTeacher().getLastName() )+
			
			") lesson set("+getLocation()+", "+getDate()+", "+getTime()+") \n"
		;
	}

}
