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
import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;
import Function.F;
import Page.PageUser;
import Sql.Sql;

public class SqlLesson {
/*Lesson Area*/
			static Student findStudent(ArrayList<Student> studentList, String studentId){
				int cnt=0;
				for(Student i:studentList) {
					if(i.getId().equals(studentId) ) return studentList.get(cnt);
					cnt+=1;
				}
				return null;
			}
			
			static Teacher findTeacher(ArrayList<Teacher> teacherList, String teacherId){
				int cnt=0;
				for(Teacher i:teacherList) {
					if(i.getId().equals(teacherId) ) return teacherList.get(cnt);
					cnt+=1;
				}
				return null;
			}

	
	public static ArrayList<Lesson> lessonList(ArrayList<Student> studentList, ArrayList<Teacher> teacherList) throws Illegal_Exception_Message {
		ArrayList<Lesson> lessonList = new ArrayList<>();
		
		Sql.init();
		try {  
			String quary = "SELECT L.*, day(FullDate), month(FullDate), year(FullDate)%100, left(CONVERT(varchar,FullDate, 108),5) from Lesson L join Teacher T on L.TeacherId=T.TeacherId join Student S on L.StudentId=S.StudentId where StillTeaching=1 and s.StillStuding=1 "+
					(PageUser.globalTeacherId!=null ? "and T.TeacherId='"+PageUser.globalTeacherId +"'":"")+
					" ORDER BY FullDate";  // למיין בנוסף ולהכניס לאפליקצייה ב JOIN
			Sql.statement = Sql.connection.createStatement();  
			Sql.resultset = Sql.statement.executeQuery(quary);  

			// Iterate through the data in the result set and display it.  
			while (Sql.resultset.next()) {
				lessonList.add(new Lesson(
						/*Student*/			findStudent(studentList,Sql.resultset.getString(1)),
						/*Teacher*/			findTeacher(teacherList,Sql.resultset.getString(2)),
						/*String1*/			Sql.resultset.getString(3),
						/*String2*/			Sql.dateListed(Sql.resultset.getString(4),Sql.resultset.getString(5),Sql.resultset.getString(6),Sql.resultset.getString(7)),
						/*String3*/			Sql.resultset.getString(8)
						));
			}  
		Sql.close();
		}catch (SQLException e) {Sql.sqlError(Sql.contentPane);}//e.printStackTrace();// Handle any errors that may have occurred.  

		return lessonList;
	}
	
	public static void addLesson(String studentId, String teacherId, String location, String date, String time) {
		Sql.init();
		try {  
			
			F.println(">>>>>"+studentId+" "+teacherId+" "+Sql.date(date)+" "+time);
			CallableStatement  callablestatement = 
					Sql.connection.prepareCall("Insert into Lesson "
							+ "values ("
	/*1.IdStudent*/				+ "?,"
	/*2.IdTeacher*/				+ "?,"
	/*3.Location*/				+ "?,"
	/*4.Full Date*/				+ "?"
							+ ")");

			callablestatement.setString(1, studentId);
			callablestatement.setString(2, teacherId);
			callablestatement.setString(3, location);
			callablestatement.setString(4, Sql.date(date)+' '+time);
			callablestatement.executeUpdate();
			
			F.println("quary done");
		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
	}
	
	
	
	public static void editLesson(String studentId, String teacherId, String location, String date, String time
			) {
		Sql.init();
		try {  F.println(Sql.date(date)+" "+time);

	CallableStatement  callablestatement = 
			Sql.connection.prepareCall("Update Lesson set FullDate=? Where StudentId=? and teacherId=?");
			callablestatement.setString(1, Sql.date(date)+" "+time);
			callablestatement.setString(2, studentId);
			callablestatement.setString(3, teacherId);
			callablestatement.executeUpdate();
			
			F.println("quary done");
		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
	}
	
	
	
	/*Delete Data Base History*/	
	public static void deleteCascadeLesson(String studentId, String teacherId, String location, String date, String time) {
		Sql.init();
		try {  
		//	f.println("1111 "+ studentId +" "+ teacherId +" " +location+" "+Sql.date(date)+" "+time);

	CallableStatement  callablestatement = 
			Sql.connection.prepareCall("delete from Lesson where StudentId=? and TeacherId=? and FullDate=?"); //   and Location=?
			callablestatement.setString(1, studentId);
			callablestatement.setString(2, teacherId);
//			callablestatement.setString(, location);
			callablestatement.setString(3, Sql.date(date)+" "+time);
			callablestatement.executeUpdate();
	
			F.println("quary done");
		Sql.close();
		} catch (SQLException e) {Sql.sqlError();}//e.printStackTrace();
	}
	
	
}
