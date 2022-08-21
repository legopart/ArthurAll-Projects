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

import Classes.Student;
import Classes.Teacher;
import Classes.User;
import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;
import Function.F;
import Page.PageUser;
import Sql.Sql;

public class SqlTeacher {
/*Teacher Area*/
	/*Set List from Data Base*/	
	
	public static ArrayList<Teacher> teacherList() throws Illegal_Exception_Message {return teacherList(true);}
	public static ArrayList<Teacher> teacherList(Boolean stillTeaching) throws Illegal_Exception_Message {
		ArrayList<Teacher> teacherList = new ArrayList<>();
		Sql.init();
		try {  
			String quary = "SELECT * , day(BegingTeachingDate), month(BegingTeachingDate), year(BegingTeachingDate)%100\r\n" + 
					"FROM Teacher\r\n" + 
					(stillTeaching ? "Where StillTeaching=1 "+(PageUser.globalTeacherId!=null ? "and TeacherId='"+PageUser.globalTeacherId +"' ":" ") 
					: " ") +
					" ORDER BY TeacherId";  // למיין בנוסף ולהכניס לאפליקצייה
			Sql.statement = Sql.connection.createStatement();  
			Sql.resultset = Sql.statement.executeQuery(quary);  

			// Iterate through the data in the result set and display it.  
			while (Sql.resultset.next()) {  
				teacherList.add(new Teacher( 
	/*String1*/			Sql.resultset.getString(1),
	/*String2*/			Sql.resultset.getString(2),
	/*String3*/			Sql.resultset.getString(3),
	/*String4*/			Sql.resultset.getString(4),
	/*String5*/			Sql.resultset.getString(5),
	/*Instrument*/		Sql.instrumentEnom(Sql.resultset.getString(6)),
	/*Gender*/			Sql.genderEnom(Sql.resultset.getString(7)),
	//(11) is for still teaching
	/*String*/			Sql.dateListed(Sql.resultset.getString(8),Sql.resultset.getString(12),Sql.resultset.getString(13),Sql.resultset.getString(14)),
	/*Int*/				Sql.stringInt(Sql.resultset.getString(9)),
	/*double*/			Sql.stringDouble(Sql.resultset.getString(10))
						));
			}  

		Sql.close();
		}catch (SQLException e) {Sql.sqlError(Sql.contentPane);}//e.printStackTrace();// Handle any errors that may have occurred.  

		return teacherList;
	}

	/*Add to Data Base*/	
	public static void addTeacherUser(String teacherId, String password, String firstName, String lastName, String address, String phone, Instrument instrument, Gender gender, String date, int lessonMinuteLong, double salary) {
		Sql.init();
		try {  
			CallableStatement  callablestatement = 
					Sql.connection.prepareCall("Insert into Teacher values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, 1)\r\n"
							+ "Update Users set Password=? where UserId=?");
			callablestatement.setString(1, teacherId);
			callablestatement.setString(12, teacherId);
			callablestatement.setString(2, firstName);
			callablestatement.setString(3, lastName);
			callablestatement.setString(4, address);
			callablestatement.setString(5, phone);
			callablestatement.setString(6, Sql.instrumentString(instrument));
			callablestatement.setString(7, Sql.genderString(gender));
			callablestatement.setString(8, Sql.date(date));
			callablestatement.setInt(9, lessonMinuteLong);
			callablestatement.setDouble(10, salary);	
			callablestatement.setString(11, password);
			callablestatement.addBatch();
			callablestatement.executeUpdate();
			
			F.println("quary done");

		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();

	}
	
	/*Edit Data Base*/
	public static void editTeacher(String teacherId, String password, String firstName, String lastName, String address, String phone, Instrument instrument, Gender gender, String date, int lessonMinuteLong, double salary) {
		Sql.init();
		try {  

	CallableStatement  callablestatement = 
			Sql.connection.prepareCall("Update Teacher set FirstName=?, LastName=?, Address=?, PhoneNumber=?, Instrument=?, Gender=?, BegingTeachingDate=?, LessonMinutesLong=?, Salary=? where TeacherId=? \r\n"
					+ "Update Users set Password=? where UserId=?"
					);
			callablestatement.setString(10, teacherId);
			callablestatement.setString(12, teacherId);
			callablestatement.setString(1, firstName);
			callablestatement.setString(2, lastName);
			callablestatement.setString(3, address);
			callablestatement.setString(4, phone);
			callablestatement.setString(5, Sql.instrumentString(instrument));
			callablestatement.setString(6, Sql.genderString(gender));
			callablestatement.setString(7, Sql.date(date));
			callablestatement.setInt(8, lessonMinuteLong);
			callablestatement.setDouble(9, salary);
			callablestatement.setString(11, password);
			callablestatement.executeUpdate();
			
			F.println("quary done");

		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();

	}
	
	
	/*Delete Data Base From Listing*/
	public static void deleteTeacher(String studentId) {
		Sql.init();
		try {  

	CallableStatement  callablestatement = 
			Sql.connection.prepareCall("Update Teacher set StillTeaching=0 where TeacherId=?");
			callablestatement.setString(1, studentId);
			callablestatement.executeUpdate();
			
			F.println("quary done");


		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
	}
	
	
	/*Delete Data Base History*/
	public static void deleteStudent2(String studentId) {
		Sql.init();
		try {  

	CallableStatement  callablestatement = 
			Sql.connection.prepareCall("delete from teacher where TeacherId=?");
			callablestatement.setString(1, studentId);
			callablestatement.executeUpdate();
			
			F.println("quary done");

		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();

	}
	
}
