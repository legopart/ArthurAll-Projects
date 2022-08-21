
public class TestMark implements TeachingInterface {
private		Test test;
private		Student student;
private		Teacher teacher;
private		int mark;

	TestMark(Test test, Student student, Teacher teacher, int mark)
throws Illegal_Exception_Message
	{
		setTest(test);
		setStudent(student);
		setTeacher(teacher);
		setMark(mark);
	}
	
	
	
	
	
	
	public Test getTest() {
		return test;
	}
	public Student getStudent() {
		return student;
	}
	public Teacher getTeacher() {
		return teacher;
	}
	public int getMark() {
		return mark;
	}

	
	
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
		if(mark<0||mark>100) {throw new Illegal_Exception_Message("\""+mark + "\" --wrong mark range! (alowed between 0-100)");}
		this.mark = mark;
	}

	
	public int getTestID() {
		return getTest().getTestID();
	}
	public String getStudenttID() {
		return getStudent().getId();
	}
	public String getTeachertID() {
		return getTeacher().getId();
	}

	@Override
	public String toString() {
		return
		"- Test("
		+getTest().getTestID()+", "
		+getTest().getTestName()+", "
		+getTest().getTestDate()+") "
		
		+"student("
		+getStudent().getId()+", "
		+getStudent().getFirstName()+", "
		+getStudent().getLastName()+") "
		
		+"teacher("
		+getTeacher().getId()+", "
		+getTeacher().getFirstName()+", "
		+getTeacher().getLastName()+") "
		
		+"mark("
		+getMark()+") "
		;

	}
}
