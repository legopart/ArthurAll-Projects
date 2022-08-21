package _Examples;


import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.sql.Statement;


public class SqlExample {


	public static void main(String[] args) throws SQLException {
		// TODO Auto-generated method stub

System.out.println("SQL Statement and metadata");
				String connectUrl = "jdbc:sqlserver://localhost:1433;" + "databaseName=MyDB;integratedSecurity=true"; 
				boolean connectedToDB=false;
				
				Connection connection = DriverManager.getConnection(connectUrl);
				//connection=DriverManager.getConnection(url, user, password)
				String quary= "select * from Student";
				Statement statement = connection.createStatement();
				 	connectedToDB=true; //throw
				
				ResultSet resultset = statement.executeQuery(quary);
					ResultSetMetaData metadata = resultset.getMetaData();
						int numOfColums=metadata.getColumnCount();	
					
					//לחזור על שליפה מעמודה / תא
					
					System.out.println(resultset );
					System.out.println(numOfColums);

					for(int i = 1;  i <= metadata.getColumnCount();  i++)
						System.out.printf("%-8s\t",metadata.getColumnClassName(i));
					System.out.println();
					
					for(int i = 1;  i <= metadata.getColumnCount();  i++)
						System.out.printf("%-8s\t",metadata.getColumnName(i));
					System.out.println();
					
					while (resultset.next()) { 
						for(int i=1; i<=metadata.getColumnCount(); i++)
							System.out.printf("%-8s\t",resultset.getObject(i));
								//resultset.getString("StudentId")
						System.out.println();
					}

					if (resultset != null) resultset.close();
					if (statement != null) statement.close();
				if (connection != null) connection.close(); 

						
				
System.out.println();
System.out.println();
System.out.println();
System.out.println();
System.out.println();
System.out.println();				
System.out.println("SQL2 PreparedStatement and metadata");
				connectUrl = "jdbc:sqlserver://localhost:1433;" + "databaseName=MyDB;integratedSecurity=true"; 
				connectedToDB=false;
				
				 connection = DriverManager.getConnection(connectUrl);
				//connection=DriverManager.getConnection(url, user, password)
					quary= "select * from Student where StillStuding=?";
				PreparedStatement preparedstatement = connection.prepareStatement(quary);
				preparedstatement.setBoolean(1,true);

				 resultset = preparedstatement.executeQuery();
					metadata = resultset.getMetaData();
				 		numOfColums=metadata.getColumnCount();	
				
				for(int i = 1;  i <= metadata.getColumnCount();  i++)
					System.out.printf("%-8s\t",metadata.getColumnName(i));
				System.out.println(); 		
				while (resultset.next()) {  
					for (int i=1;i<=numOfColums;i++)System.out.printf("%-8s\t", resultset.getString(i));
					System.out.println();
				}	 	
						
				
					
					if (resultset != null) resultset.close();
					if (statement != null) statement.close();
				if (connection != null) connection.close(); 
				
				
				
				
				
System.out.println();
System.out.println();
System.out.println();
System.out.println();
System.out.println();
System.out.println();				
//System.out.println("SQL2 Callabale and metadata");




	}
}
