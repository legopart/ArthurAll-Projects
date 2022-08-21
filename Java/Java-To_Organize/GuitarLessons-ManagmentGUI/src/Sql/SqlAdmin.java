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

import javax.swing.JPanel;

import Classes.Admin;
import Classes.Student;
import Exeption.Illegal_Exception_Message;
import Function.F;
import Sql.Sql;

public class SqlAdmin {
	public static ArrayList<Admin> adminList() throws Illegal_Exception_Message{
		ArrayList<Admin> list = new ArrayList<>();
		Sql.init();
		try {  
			String quary = "SELECT * FROM Admin ORDER BY AdminId";  
			Sql.statement = Sql.connection.createStatement();  
			Sql.resultset = Sql.statement.executeQuery(quary);  

			// Iterate through the data in the result set and display it.  
			while (Sql.resultset.next()) {  
				list.add(new Admin(Sql.resultset.getString(1),Sql.resultset.getString(2)));
			}  

		Sql.close();
		}catch (SQLException e) {Sql.sqlError(Sql.contentPane);}//e.printStackTrace();// Handle any errors that may have occurred.  

		return list;
	}
	
	public static void addAdmin(String adminId, String password) {
		Sql.init();
		try {  
			CallableStatement  callablestatement = 
					Sql.connection.prepareCall("insert into Admin\r\n" + 
							"values (?,?)");
			callablestatement.setString(1, adminId);
			callablestatement.setString(2, password);

			
			callablestatement.executeUpdate();
			
			F.println("quary done");
		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
	}
	
	
	/*Admin Log In*/
	public static Admin tempAdmin(String username, String password) throws Illegal_Exception_Message{
		Admin admin=null;
		Sql.init();
		try {  
			CallableStatement callablestatement =Sql.connection.prepareCall("select * from Admin where AdminID=? and Password=?");
			// Set Data
			callablestatement.setString(1, username);
			callablestatement.setString(2, password);
			
			Sql.resultset = callablestatement.executeQuery();  
			// Get data  
				while(Sql.resultset.next()) 
					admin=new Admin(Sql.resultset.getString(1), Sql.resultset.getString(2) );
				
		Sql.close();
		}catch (SQLException e) {Sql.sqlError(Sql.contentPane);}//e.printStackTrace();// Handle any errors that may have occurred.  

		return admin;
	}
	
	
	
}
