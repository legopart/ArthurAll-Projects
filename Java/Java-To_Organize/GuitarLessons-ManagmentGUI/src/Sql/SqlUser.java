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

import Classes.Admin;
import Classes.Student;
import Classes.Teacher;
import Classes.User;
import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;
import Function.F;
import Sql.Sql;

public class SqlUser {
/*User Area*/
	/*First Create the Teacher and then the user and then close*/
	public static ArrayList<User> userList() throws Illegal_Exception_Message{
		ArrayList<User> userList = new ArrayList<>();
		Sql.init();
		try {  
			String quary = "SELECT * FROM Users ORDER BY UserId";  
			Sql.statement = Sql.connection.createStatement();  
			Sql.resultset = Sql.statement.executeQuery(quary);  

			// Iterate through the data in the result set and display it.  
			while (Sql.resultset.next()) {  
				userList.add(new User(Sql.resultset.getString(1),Sql.resultset.getString(2)));
			}  

		Sql.close();
		}catch (SQLException e) {Sql.sqlError(Sql.contentPane);}//e.printStackTrace();// Handle any errors that may have occurred.  

		return userList;
	}
	
	/*User Log In*/
	public static User tempUser(String username, String password) throws Illegal_Exception_Message{
		User user=null;
		Sql.init();
		try {  
			CallableStatement callablestatement =Sql.connection.prepareCall("select * from Users where UserID=? and Password=?");
			// Set Data
			callablestatement.setString(1, username);
			callablestatement.setString(2, password);
			
			Sql.resultset = callablestatement.executeQuery();  
			// Get data  
				while(Sql.resultset.next()) 
					user=new User(Sql.resultset.getString(1), Sql.resultset.getString(2) );
				
		Sql.close();
		}catch (SQLException e) {Sql.sqlError(Sql.contentPane);}//e.printStackTrace();// Handle any errors that may have occurred.  

		return user;
	}
	
	/*Edit Data Base*/
	public static void editUser(String studentId, String firstName, String lastName
			, String address, String phone, Instrument instrument, Gender gender, String date, String acchivementYears
			) {
		Sql.init();
		try {  

	CallableStatement  callablestatement = 
			Sql.connection.prepareCall("Update Users set UserId=?, Password=? where User Id=?");
			callablestatement.setString(3, studentId);
			callablestatement.setString(1, firstName);
			callablestatement.setString(2, lastName);

			callablestatement.executeUpdate();
			
			F.println("quary done");
		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
	}
	
	
	/*Delete Data Base*/
	public static void deleteStudent(String studentId) {
		Sql.init();
		try {  

			CallableStatement  callablestatement = 
			Sql.connection.prepareCall("delete from student where StudentId=?");
			callablestatement.setString(1, studentId);
			callablestatement.executeUpdate();
			
			F.println("quary done");
		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
	}
}
