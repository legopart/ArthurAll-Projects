 package Sql;

 import java.io.FileNotFoundException;
 import java.sql.CallableStatement;
 import java.sql.Connection;
 import java.sql.DriverManager;
 import java.sql.PreparedStatement;
 import java.sql.ResultSet;
 import java.sql.ResultSetMetaData;
 import java.sql.SQLException;
 import java.sql.Statement;
 import java.sql.Types;
 import java.util.ArrayList;
 import java.util.Date;

import javax.swing.JPanel;

import Classes.Lesson;
import Classes.Student;
import Classes.Teacher;
import Classes.Test;
import Classes.TestMark;
import Exeption.Illegal_Exception_Message;
import Function.F;
import Sql.Sql;

public class SqlTestMark {
/*Test Mark Area*/

	
	static Test findTest(ArrayList<Test> testList, String testId){
		int cnt=0;
		for(Test i:testList) {
			if(i.getTestID().equals(testId) ) return testList.get(cnt);
			cnt+=1;
		}
		return null;
	}
	
	static Student findStudent(ArrayList<Student> studentList, String studentId){
		int cnt=0;
		for(Student i:studentList) {
			if(i.getId().equals(studentId) ) return studentList.get(cnt);
			cnt+=1;
		}
		return null;
	}


public static ArrayList<TestMark> testMarkList(ArrayList<Test> teacherList, ArrayList<Student> studentList) throws Illegal_Exception_Message {
	ArrayList<TestMark> testMarkList = new ArrayList<>();

Sql.init();
try {  
	String quary = "SELECT TM.* from TestMark TM join Test T on TM.TestID=T.TestID join Student S on TM.StudentId=S.StudentId /*join Teacher T on TM.TeacherId=T.TeacherId*/ ORDER BY T.TestID desc, S.studentID";  // למיין בנוסף ולהכניס לאפליקצייה ב JOIN
	Sql.statement = Sql.connection.createStatement();  
	Sql.resultset = Sql.statement.executeQuery(quary);  

	// Iterate through the data in the result set and display it.  
	while (Sql.resultset.next()) {
		testMarkList.add(new TestMark(
				/*Test*/			findTest(teacherList,Sql.resultset.getString(1)),
				/*Student*/			findStudent(studentList,Sql.resultset.getString(2)),
				/*Teache*/			null,	
				/*Int*/				Sql.resultset.getInt(4)
				));
	}  

Sql.close();
}catch (SQLException e) {Sql.sqlError(Sql.contentPane);}//e.printStackTrace();// Handle any errors that may have occurred.  

return testMarkList;
}

public static void addTestMark(String testId, String studentId, String  teacherID, int testMark) {
Sql.init();
try {  
	CallableStatement  callablestatement = 
			Sql.connection.prepareCall("Insert into TestMark Values (?, ?, null, ?)");

	callablestatement.setInt(1, F.stringInt(testId));
	callablestatement.setString(2, studentId);
//	callablestatement.setString(3, null);
	callablestatement.setInt(3, testMark);
	callablestatement.executeUpdate();
	
	F.println("quary done");
Sql.close();
} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
}


public static void editTestMark(String testId, String studentId, String teacherId, int mark) {
	Sql.init();
	try {  

CallableStatement  callablestatement = 
		Sql.connection.prepareCall("Update TestMark set Mark=? Where TestId=? and StudentId=?");
		callablestatement.setInt(1, mark);
		callablestatement.setString(2, testId);
		callablestatement.setString(3, studentId);
		callablestatement.executeUpdate();
		
		F.println("quary done");
	Sql.close();
	} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
}



/*Delete Data Base History*/	
public static void deleteCascadeTestMark(String testId, String studentId) {
Sql.init();
try {  
CallableStatement  callablestatement = 
	Sql.connection.prepareCall("delete from TestMark where TestId=? and StudentId=?"); //   and Location=?
	callablestatement.setString(1, testId);
	callablestatement.setString(2, studentId);
//	callablestatement.setString(,);
//	callablestatement.setString(,);
	callablestatement.executeUpdate();
	
	F.println("quary done");
Sql.close();
} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
}

public static void addTestMark(String testID, String studentID, Object object, int mark) {
	// TODO Auto-generated method stub
	
}


}
