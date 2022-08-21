package Classes;

import java.io.Serializable;

import Exeption.Illegal_Exception_Message;
import Exeption.Patterns;
import Function.F;
import Interface.TeachingInterface;

public class TestMark implements TeachingInterface, Serializable {
private		Test test;
private		Student student;
private		Teacher teacher;
private		int mark;

	public TestMark(Test test, Student student, Teacher teacher, int mark)
throws Illegal_Exception_Message
	{
		setTest(test);
		setStudent(student);
		setTeacher(teacher);
		setMark(mark);
	}

	
	public Test getTest() {return test;}
		public String getTestID() {return getTest().getTestID();}
		public String getTestDate() {return getTest().getTestDate();}
	public Student getStudent() {return student;}
		public String getStudentID() {return getStudent().getId();}
	public Teacher getTeacher() {return teacher;}
		public String getTeacherID() {return getTeacher().getId();}
	public int getMark() {return mark;}

	
	
	public void setTest(Test test) {
		this.test = test;
	}
	public void setStudent(Student student) {
		this.student = student;
	}
	public void setTeacher(Teacher teacher) {
		this.teacher = teacher;
	}
	public void setMark(int mark) throws Illegal_Exception_Message {
		Patterns.testMark(mark);
		this.mark = mark;
	}

	@Override
	public String toString() {
		return
		"- Test("+getTest().getTestID()+", "+getTest().getTestName()+", "+getTest().getTestDate()+") "
		+(getStudent()!=null ? "student("+getStudent().getId()+", "+getStudent().getFirstName()+", "+getStudent().getLastName()+") " : "")
//		+"teacher("+getTeacher().getId()+", "+getTeacher().getFirstName()+", "+getTeacher().getLastName()+") "
		+"mark("+getMark()+") "
		;

	}



}
