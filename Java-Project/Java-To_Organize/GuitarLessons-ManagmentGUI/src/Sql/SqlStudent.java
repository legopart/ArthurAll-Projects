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
import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;
import Function.F;
import Page.PageUser;
import Sql.Sql;

public class SqlStudent {
/*Student Area*/
	/*Set List from Data Base*/
	public static ArrayList<Student> studentList() throws Illegal_Exception_Message {return studentList(true);}
	public static ArrayList<Student> studentList(Boolean stillStuding) throws Illegal_Exception_Message {
		ArrayList<Student> studentList = new ArrayList<>();
		Sql.init();
		try {  
			String quary = "SELECT * , day(BegingStudyDate), month(BegingStudyDate), year(BegingStudyDate)%100\r\n" + 
					"FROM Student \r\n"+  
					(stillStuding ? "Where StillStuding=1 ":"")+
					" ORDER BY StudentId";  // למיין בנוסף ולהכניס לאפליקצייה
			Sql.statement = Sql.connection.createStatement();  
			Sql.resultset = Sql.statement.executeQuery(quary);  

			// Iterate through the data in the result set and display it.  
			while (Sql.resultset.next()) {  
				studentList.add(new Student( 
	/*String1*/			Sql.resultset.getString(1),
	/*String2*/			Sql.resultset.getString(2),
	/*String3*/			Sql.resultset.getString(3),
	/*String4*/			Sql.resultset.getString(4),
	/*String5*/			Sql.resultset.getString(5),
	/*Instrument*/		Sql.instrumentEnom(Sql.resultset.getString(6)),
	/*Gender*/			Sql.genderEnom(Sql.resultset.getString(7)),
	//(10) is for still studying
	/*String*/			Sql.dateListed(Sql.resultset.getString(8),Sql.resultset.getString(11),Sql.resultset.getString(12),Sql.resultset.getString(13)),
	/*Int*/				Sql.stringInt(Sql.resultset.getString(9))
						));
			}  

		Sql.close();
		}catch (SQLException e) {Sql.sqlError(Sql.contentPane);}//e.printStackTrace();// Handle any errors that may have occurred.  

		return studentList;
	}
	
	/*Add to Data Base*/
	public static void addStudent(String teacherId, String firstName, String lastName
			, String address, String phone, Instrument instrument, Gender gender, String date, int acchivementYears
			) {
		Sql.init();
		try {  
			CallableStatement  callablestatement = 
					Sql.connection.prepareCall("Insert into Student values (?, ?, ?, ?, ?, ?, ?, ?, ?, 1)");
			callablestatement.setString(1, teacherId);
			callablestatement.setString(2, firstName);
			callablestatement.setString(3, lastName);
			callablestatement.setString(4, address);
			callablestatement.setString(5, phone);
			callablestatement.setString(6, Sql.instrumentString(instrument));
			callablestatement.setString(7, Sql.genderString(gender));
			callablestatement.setString(8, Sql.date(date));
			callablestatement.setInt(9, acchivementYears);

			callablestatement.executeUpdate();
			
			F.println("quary done");
		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
		
	}
	
	
	/*Edit Data Base*/
	public static void editStudent(String studentId, String firstName, String lastName
			, String address, String phone, Instrument instrument, Gender gender, String date, int acchivementYears
			) {
		Sql.init();
		try {  

	CallableStatement  callablestatement = 
			Sql.connection.prepareCall("Update Student set FirstName=?, LastName=?, Address=?, PhoneNumber=?, Instrument=?, Gender=?, BegingStudyDate=?, AcchivementYears=? where StudentId=?");
			callablestatement.setString(9, studentId);
			callablestatement.setString(1, firstName);
			callablestatement.setString(2, lastName);
			callablestatement.setString(3, address);
			callablestatement.setString(4, phone);
			callablestatement.setString(5, Sql.instrumentString(instrument));
			callablestatement.setString(6, Sql.genderString(gender));
			callablestatement.setString(7, Sql.date(date));
			callablestatement.setInt(8, acchivementYears);

			callablestatement.executeUpdate();
			
			F.println("quary done");
		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
	}
	
	
	/*Delete Data Base From Listing*/
	public static void deleteStudent(String studentId) {
		Sql.init();
		try {  

	CallableStatement  quary = 
			Sql.connection.prepareCall("Update Student set StillStuding=0 where StudentId=?");
			quary.setString(1, studentId);
			quary.executeUpdate();
			
			F.println("quary done");
		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
	}
	
	/*Delete Data Base History*/	
	public static void deleteCascadeStudent(String studentId) {
		Sql.init();
		try {  

	CallableStatement  quary = 
			Sql.connection.prepareCall("delete from Student where StudentId=?");
			quary.setString(1, studentId);
			quary.executeUpdate();
			
			F.println("quary done");
		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
	}
	
	
}
