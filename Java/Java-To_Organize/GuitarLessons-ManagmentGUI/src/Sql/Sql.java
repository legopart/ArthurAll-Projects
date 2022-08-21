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

import javax.swing.JOptionPane;
import javax.swing.JPanel;

import Classes.Admin;
import Enum.Gender;
import Enum.Instrument;
import Function.F;

public class Sql {
	// להוריד את ה 
	//try catch מ INIT + CLOSE
	// לשיפ אותם במחלקות בתוך ה TRY
	public static JPanel contentPane; // For now the message will show in the middle of the screen
	public static boolean isSql=true;
	public static void sqlError(JPanel contentPane) {F.errorMsg("Data Base Load Error", contentPane);isSql=false;}
	public static void sqlError() {F.errorMsg("Data Base Error");isSql=false;}
	
	public static String connectionUrl = "jdbc:sqlserver://localhost:1433;" + "databaseName=GuitarLesson;integratedSecurity=true"; 
	public static Connection connection = null;
	public static Statement statement = null;
//	public static  CallableStatement callablestatement = null;
//	public static CallableStatement  quary = null;
	public static ResultSet resultset = null;

	
	public static void main(String[] args) throws SQLException {
		init();
		try {PreparedStatement quary = connection.prepareStatement("insert into Admin VALUES ('2834','123')"); 
		//quary.executeUpdate();
		System.out.println("quary done");
		} catch (SQLException e) {e.printStackTrace();}
		close();
	}

	
	public static void init() {
		try {// Establish the connection.  
			System.out.println("Trying to set a connectio  to sql server...");
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");  
			connection = DriverManager.getConnection(connectionUrl);  
		} catch (SQLException | ClassNotFoundException e) {e.printStackTrace();System.exit(0);sqlError(contentPane);}
		F.println("connection was set!\n");
	}
	
	public static void close() throws SQLException {
		if (resultset != null) resultset.close();
		if (statement != null) statement.close();
		if (connection != null) connection.close();
	}
	
	
	//External Shortcuts for SQL
	public static Instrument instrumentEnom(String instrument){return (instrument==null ? null : Instrument.valueOf(instrument));}
	public static Gender genderEnom(String gender){return (gender==null ? null : Gender.valueOf(gender));}
	public static String addZero(String str) {return ((str.length()==1) ? "0"+str : str);}
	public static String dateListed(String date,String day,String month,String year) {return (date==null ? null : addZero(day)+"/"+addZero(month)+"/"+addZero(year));}	
	public static String year(String date){return date.substring(6,8);}
	public static String month(String date){return date.substring(3,5);}
	public static String day(String date){return date.substring(0,2);}
	public static String dateSet(String date){return "20"+year(date)+"-"+month(date)+"-"+day(date);}
	public static String date(String date){return ((date.isEmpty()) ? null : dateSet(date));}
	
	public static String instrumentString(Instrument instrument){return ((instrument==null) ? null : instrument.toString());}
	public static String genderString(Gender gender){return ((gender==null) ? null : gender.toString());}
	
	public static int stringInt(String str) {return ((str.isEmpty()) ? 0 : Integer.parseInt(str));}
	public static double stringDouble(String str) {return ((str.isEmpty()) ? 0.0 : Double.parseDouble(str));}
}

