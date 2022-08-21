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

import Classes.Teaching;
import Exeption.Illegal_Exception_Message;
import Function.F;
import Sql.Sql;

public class SqlTeaching {
/*Student Area*/
	
	
	public static ArrayList<Teaching> teachingList() {
		ArrayList<Teaching> teachingList = new ArrayList<>();
		Sql.init();
		try {  
			String quary = "SELECT * FROM Teaching ORDER BY teacherId";  // למיין בנוסף ולהכניס לאפליקצייה ב JOIN
			Sql.statement = Sql.connection.createStatement();  
			Sql.resultset = Sql.statement.executeQuery(quary);  

			// Iterate through the data in the result set and display it.  
			while (Sql.resultset.next()) {
				teachingList.add(new Teaching(
						null,null,null
		//				Sql.resultset.getString(1),
		//				Sql.resultset.getString(2),
		//				Sql.resultset.getString(3) //instrument
						));
			}  

		Sql.close();
		}catch (SQLException e) {Sql.sqlError(Sql.contentPane);}//e.printStackTrace();// Handle any erroresultset that may have occurred.  

		return teachingList;
	}
	
	public static void addStudent(String studentId, String teacherId, String instrument) {
		Sql.init();
		try {  
			CallableStatement  callablestatement = 
					Sql.connection.prepareCall("Insert into Teaching "
							+ "values ("
	/*1.IdStudent*/				+ "?,"
	/*2.IdTeacher*/				+ "?,"
	/*3.Instrument*/			+ "?,"
							+ ")");

			callablestatement.setString(1, studentId);
			callablestatement.setString(2, teacherId);
			callablestatement.setString(3, instrument);
			callablestatement.executeUpdate();
			
			System.out.println("quary done");

		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
	}
	
	
	
}
