
public interface TeachingInterface {
	/*Student student;
	Teacher teacher;*/
	
	Student getStudent();
	Teacher getTeacher();
	
	void setStudent(Student student);
	void setTeacher(Teacher teacher);
	
	String getStudenttID();
	String getTeachertID();

	String toString();
}
