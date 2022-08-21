
public class Lesson implements TeachingInterface {
private		Student student;
private		Teacher teacher;
private		String location;
private		String date;
private		String time;
	
	Lesson(Student student, Teacher teacher, String location, String date, String time) throws Illegal_Exception_Message {
		setStudent(student);
		setTeacher(teacher);
		setLocation(location);
		setDate(date);
		setTime(time);
	}

	public Student getStudent() {
		return student;
	}
	public Teacher getTeacher() {
		return teacher;
	}
	public String getLocation() {
		return location;
	}
	public String getDate() {
		return date;
	}
	public String getTime() {
		return time;
	}

	
	
	public void setStudent(Student student) {
		this.student = student;
	}
	public void setTeacher(Teacher teacher) {
		this.teacher = teacher;
	}
	public void setLocation(String location) {
		
		this.location = location;
	}
	public void setDate(String date) {
		this.date = date;
	}
	public void setTime(String time) {
		this.time = time;
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
		"- student("
		+getStudent().getId()+", "
		+getStudent().getFirstName()+", "
		+getStudent().getLastName()+") "
		
		+"teacher("
		+getTeacher().getId()+", "
		+getTeacher().getFirstName()+", "
		+getTeacher().getLastName()+") "
		
		+"lesson set("
		+getLocation()+", "
		+getDate()+", "
		+getTime()+") "
		;
	}
	
	
}
