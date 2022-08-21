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

import Classes.Test;
import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;
import Function.F;
import Sql.Sql;

public class SqlTest {
/*Student Area*/
	
	
	public static ArrayList<Test> testList() throws Illegal_Exception_Message{
		ArrayList<Test> testList = new ArrayList<>();
		Sql.init();
		try {  
			String quary = "SELECT *, day(TestDate), month(TestDate), year(TestDate)%100, left(CONVERT(varchar,TestDate, 108),5) FROM Test ORDER BY TestID desc";  // למיין בנוסף ולהכניס לאפליקצייה
			Sql.statement = Sql.connection.createStatement();  
			Sql.resultset = Sql.statement.executeQuery(quary);  

			// Iterate through the data in the result set and display it.  
			while (Sql.resultset.next()) {  
				testList.add(new Test(
						Sql.resultset.getString(1),
						Sql.resultset.getString(2),
						Sql.dateListed(Sql.resultset.getString(3),Sql.resultset.getString(4),Sql.resultset.getString(5),Sql.resultset.getString(6)),
						Sql.resultset.getString(7) 
						));
			}  

		Sql.close();
		}catch (SQLException e) {Sql.sqlError(Sql.contentPane);}//e.printStackTrace();// Handle any errors that may have occurred.
		return testList;
	}
	
	public static void addTest(String tempTestName, String tempTestDate, String tempTestTime) {
		Sql.init();
		try {  
			CallableStatement  callablestatement = 
					Sql.connection.prepareCall("Insert into Test values (?,?)");
			callablestatement.setString(1, tempTestName);
			callablestatement.setString(2, Sql.date(tempTestDate)+' '+tempTestTime);
			callablestatement.executeUpdate();

			F.println("quary done");

		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
	}
	
	
	/*Edit Test Base*/
	public static void editTest(String testId, String testName, String testDate, String testTime) {
		Sql.init();
		try {  

	CallableStatement  callablestatement = 
			Sql.connection.prepareCall("Update Test set TestName=?, TestDate=? where TestId=?");
			callablestatement.setInt(3, F.stringInt(testId));
			callablestatement.setString(1, testName);
			callablestatement.setString(2, Sql.date(testDate)+' '+testTime);
			callablestatement.executeUpdate();
			
			F.println("quary done");
		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
	}
	
	
	
	/*Delete Data Base History*/	
	public static void deleteCascadeTest(String testId) {
		Sql.init();
		try {  

	CallableStatement  callablestatement = 
			Sql.connection.prepareCall("delete from Test where TestId=?");
			callablestatement.setString(1, testId);
			callablestatement.executeUpdate();
			
			F.println("quary done");
		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
	}
	
}
