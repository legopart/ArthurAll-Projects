package Interface;

import Classes.Student;
import Classes.Teacher;

public interface TeachingInterface {
	/*Student student;
	Teacher teacher;*/
	
	Student getStudent();
	Teacher getTeacher();
	
	void setStudent(Student student);
	void setTeacher(Teacher teacher);
	
	
	String toString();
}
