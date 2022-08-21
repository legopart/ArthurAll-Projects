package Page;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import AddEditDelete.AddAdmin;
import AddEditDelete.AddLesson;
import AddEditDelete.AddStudent;
import AddEditDelete.AddTeacher;
import AddEditDelete.AddTestMark;
import AddEditDelete.EditStudent;
import AddEditDelete.EditTeacher;
import AddEditDelete.PrintLesson;
import Classes.Lesson;
import Classes.Student;
import Classes.Teacher;
import Exeption.Illegal_Exception_Message;
import Function.F;
import Sql.SqlLesson;
import Sql.SqlStudent;
import Sql.SqlTeacher;
import Sql.SqlTest;
import Sql.SqlTestMark;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;
import java.awt.event.ActionEvent;

public class PageUser extends JFrame {
	private JPanel contentPane;
	public static String globalTeacherId;
	
	private static PrintLesson pagePrintLesson;
	private static AddStudent pageAddStudent;
	private static AddLesson pageAddLesson;
	private static EditStudent pageEditStudent;
	
	/**
	 * Launch the application.
	 * main:
	 */
	public static void main(String[] args) {
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					PageUser frame = new PageUser(null);
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	
	
	/**
	 * Create the frame.
	 * @throws Illegal_Exception_Message 
	 */
	public PageUser(String UserId) throws Illegal_Exception_Message {
		globalTeacherId=UserId;
		setTitle("Teacher(User) Page");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 499, 553);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JButton btnExit = new JButton("Exit");
		btnExit.setMnemonic('B');
		btnExit.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				closeOtherVindow();
				setVisible(false); 
				dispose();
				System.out.println("AddAdmin frame is closed.");
				
			}
		});
		btnExit.setBounds(251, 447, 140, 33);
		contentPane.add(btnExit);
		
		JButton btnPrintLeason = new JButton("Print(+Delete) Lessons");
		btnPrintLeason.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
/***/				PrintLesson.teacherList=SqlTeacher.teacherList();// load Sql
					F.println("Test Print Teachers: "+PrintLesson.teacherList+"\n\n");
					PrintLesson.studentList=SqlStudent.studentList();// load Sql
					F.println("Test Print Students: "+PrintLesson.studentList+"\n\n");
					PrintLesson.lessonList=SqlLesson.lessonList(PrintLesson.studentList, PrintLesson.teacherList);// load Sql
					PrintLesson.lessonListUnsorted=PrintLesson.lessonList;
					System.out.println("Test Print Lessons: "+PrintLesson.lessonList+"\n\n");
					
				closeOtherVindow();
				pagePrintLesson= new PrintLesson();
				pagePrintLesson.setVisible(true);
				//dispose();
				} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
			}
		});
		btnPrintLeason.setMnemonic('A');
		btnPrintLeason.setBounds(143, 261, 202, 33);
		contentPane.add(btnPrintLeason);
		
		JButton btnAddStudent = new JButton("Add New Student");
		btnAddStudent.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					
			AddStudent.studentList=SqlStudent.studentList();
			F.println("Test Print Students: "+AddStudent.studentList+"\n\n");
					
			
				
				
				closeOtherVindow();
/***/			pageAddStudent= new AddStudent();
				pageAddStudent.setVisible(true);
				//dispose();
				} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}

			}
		});
		btnAddStudent.setMnemonic('A');
		btnAddStudent.setBounds(143, 99, 202, 33);
		contentPane.add(btnAddStudent);
		
		JLabel lblTeacheruserPermissions = new JLabel("Teacher/User Permissions");
		lblTeacheruserPermissions.setBounds(141, 13, 209, 16);
		contentPane.add(lblTeacheruserPermissions);
		
		JButton btnAddLesson = new JButton("AddLesson");
		btnAddLesson.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				try {
/***/			AddLesson.teacherList=SqlTeacher.teacherList();// load Sql
				F.println("Test Print Teachers: "+AddLesson.teacherList+"\n\n");
				AddLesson.studentList=SqlStudent.studentList();// load Sql
				F.println("Test Print Students: "+AddLesson.studentList+"\n\n");
				AddLesson.lessonList=SqlLesson.lessonList(AddLesson.studentList, AddLesson.teacherList);// load Sql
				System.out.println("Test Print Lessons: "+AddLesson.lessonList+"\n\n");
				
				closeOtherVindow();
				pageAddLesson= new AddLesson();
				pageAddLesson.setVisible(true);
				//dispose();
				} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
			}
		});
		btnAddLesson.setMnemonic('A');
		btnAddLesson.setBounds(143, 212, 202, 33);
		contentPane.add(btnAddLesson);
		
		JButton btnEditStudent = new JButton("Edit(+Delete) Student");
		btnEditStudent.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				try {				
/***/			EditStudent.studentList=SqlStudent.studentList();// load Sql
				F.println("Test Print Students: "+EditStudent.studentList+"\n\n");

				closeOtherVindow();
				pageEditStudent= new EditStudent();
				pageEditStudent.setVisible(true);
				//dispose();
			} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
				
			}
		});
		btnEditStudent.setMnemonic('A');
		btnEditStudent.setBounds(143, 155, 202, 33);
		contentPane.add(btnEditStudent);
		
		String teacher="";
		if(globalTeacherId!=null) {
			Teacher tempTeacher=SqlTeacher.teacherList().get(0);
			teacher="Test Print Teachers: "+tempTeacher.getId()+" "+tempTeacher.getFirstName()+" "+tempTeacher.getLastName()+"\n\n";
		}
		
		JLabel lblNewLabel = new JLabel("Welcome: "+ teacher);
		lblNewLabel.setBounds(31, 52, 341, 14);
		contentPane.add(lblNewLabel);
	}
	
	public static void closeOtherVindow(){
		if(pagePrintLesson!=null)pagePrintLesson.setVisible(false);
		if(pageAddStudent!=null)pageAddStudent.setVisible(false);
		if(pageAddLesson!=null)pageAddLesson.setVisible(false);
		if(pageEditStudent!=null)pageEditStudent.setVisible(false);	
	}
}


