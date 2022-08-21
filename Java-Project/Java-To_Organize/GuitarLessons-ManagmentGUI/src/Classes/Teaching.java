package Classes;

import java.io.Serializable;

import Enum.Instrument;
import Interface.TeachingInterface;

public class Teaching implements TeachingInterface, Serializable  {
	private		Student student;
	private		Teacher teacher;
	private		Instrument instrument;
	public Teaching(Student student, Teacher teacher, Instrument instrument) {
		setStudent(student);
		setTeacher(teacher);
		setInstrument(instrument);
	}
	
	public Student getStudent() {
		return student;
	}
	public Teacher getTeacher() {
		return teacher;
	}
	public Instrument getInstrument() {
		return instrument;
	}
	
	
	public void setStudent(Student student) {
		this.student = student;
	}
	public void setTeacher(Teacher teacher) {
		this.teacher = teacher;
	}
	public void setInstrument(Instrument instrument) {
		this.instrument = instrument;
	}
	
	
	public String getStudenttID() {
		return getStudent().getId();
	}
	public String getTeachertID() {
		return getTeacher().getId();
	}
	
	@Override
	public String toString() {
		return "- student("
				+getStudent().getId()+", "
				+getStudent().getFirstName()+", "
				+getStudent().getLastName()+") "
				
				+"teacher("
				+getTeacher().getId()+", "
				+getTeacher().getFirstName()+", "
				+getTeacher().getLastName()+") "
				
				+"instrument("
				+getInstrument()+") "	
				;
	}

}
