package Page;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.border.TitledBorder;

import AddEditDelete.AddAdmin;
import AddEditDelete.AddLesson;
import AddEditDelete.AddStudent;
import AddEditDelete.AddTeacher;
import AddEditDelete.AddTest;
import AddEditDelete.AddTestMark;
import AddEditDelete.EditStudent;
import AddEditDelete.EditTeacher;
import AddEditDelete.EditTest;
import AddEditDelete.PrintLesson;
import AddEditDelete.PrintTestMark;
import Classes.Lesson;
import Classes.Student;
import Classes.Teacher;
import Exeption.Illegal_Exception_Message;
import Function.F;
import Sql.Sql;
import Sql.SqlAdmin;
import Sql.SqlLesson;
import Sql.SqlStudent;
import Sql.SqlTeacher;
import Sql.SqlTest;
import Sql.SqlTestMark;
import Sql.SqlUser;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.UIManager;
import javax.swing.UIManager.LookAndFeelInfo;
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
import java.awt.event.FocusAdapter;
import java.awt.event.FocusEvent;

public class PageAdmin extends JFrame {
	private static JPanel contentPane;

	private static AddAdmin pageAddAdmin;
	private static AddTeacher pageAddTeacher;
	private static PrintLesson pagePrintLesson;
	private static AddStudent pageAddStudent;
	private static EditTeacher pageEditTeacher;
	private static AddLesson pageAddLesson;
	private static EditStudent pageEditStudent;
	private static AddTest pageAddTest;
	private static EditTest pageEditTest;
	private static AddTestMark pageAddTestMark;
	private static PrintTestMark pagePrintTestMark;
	/**
	 * Launch the application.
	 * main:
	 */
	public static void main(String[] args) {
		
		Sql.contentPane=contentPane;
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					PageAdmin frame = new PageAdmin();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	
	
	/**
	 * Create the frame.
	 */
	public PageAdmin() {
   
		setTitle("Admin Page");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 488, 553);
		contentPane = new JPanel();

		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JButton btnExit = new JButton("Exit");
		btnExit.setMnemonic('B');
		btnExit.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				closeOtherWindows();
				setVisible(false); 
				dispose();
				System.out.println("AddAdmin frame is closed.");
				
			}
		});
		btnExit.setBounds(251, 447, 140, 33);
		contentPane.add(btnExit);
		
		JButton btnAddAdmin = new JButton("ADD New Admin");
		btnAddAdmin.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
			try {
/***/			AddAdmin.adminList=SqlAdmin.adminList();
				F.println("Test Print: "+AddAdmin.adminList);
			} catch (NumberFormatException | Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
				closeOtherWindows();
				pageAddAdmin= new AddAdmin();
				pageAddAdmin.setVisible(true);
				//dispose();
			}
		});
		btnAddAdmin.setMnemonic('A');
		btnAddAdmin.setBounds(25, 43, 201, 33);
		contentPane.add(btnAddAdmin);
		
		JButton btnAddTeacher = new JButton("ADD New Teacher(+user)");
		btnAddTeacher.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
			
				try {			
				AddTeacher.teacherList=SqlTeacher.teacherList();
				System.out.println("Test Print Teachers: "+AddTeacher.teacherList+"\n\n");
				
				AddTeacher.userList=SqlUser.userList();
				System.out.println("Test Print Users: "+AddTeacher.userList+"\n\n");
				} catch (NumberFormatException | Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}

				
				closeOtherWindows();
/***/			pageAddTeacher= new AddTeacher();
				pageAddTeacher.setVisible(true);
				//dispose();
				
				
			}
		});
		btnAddTeacher.setMnemonic('A');
		btnAddTeacher.setBounds(25, 100, 201, 33);
		contentPane.add(btnAddTeacher);
		
		JButton btnPrintLeason = new JButton("Print/Delete Lessons");
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
					
				
				closeOtherWindows();
				pagePrintLesson= new PrintLesson();
				pagePrintLesson.setVisible(true);
				//dispose();
				} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
			}
		});
		btnPrintLeason.setMnemonic('A');
		btnPrintLeason.setBounds(251, 262, 202, 33);
		contentPane.add(btnPrintLeason);
		
		JButton btnAddStudent = new JButton("Add New Student");
		btnAddStudent.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
				
			AddStudent.studentList=SqlStudent.studentList();
			F.println("Test Print Students: "+AddStudent.studentList+"\n\n");
					
				
				closeOtherWindows();
/***/			pageAddStudent= new AddStudent();
				pageAddStudent.setVisible(true);
				//dispose();
				} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}

			}
		});
		btnAddStudent.setMnemonic('A');
		btnAddStudent.setBounds(251, 100, 202, 33);
		contentPane.add(btnAddStudent);
		
		JButton btnEditdeleteTeacheruser = new JButton("Edit/Delete \r\nTeacher/user");
		btnEditdeleteTeacheruser.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
/***/			EditTeacher.teacherList=SqlTeacher.teacherList();// load Sql
				F.println("Test Print Teachers: "+EditTeacher.teacherList+"\n\n");
				EditTeacher.userList=SqlUser.userList();// load Sql
				F.println("Test Print Users: "+EditTeacher.userList+"\n\n");
				
				closeOtherWindows();
				pageEditTeacher= new EditTeacher();
				pageEditTeacher.setVisible(true);
				//dispose();
				} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}

			}
		});
		btnEditdeleteTeacheruser.setMnemonic('A');
		btnEditdeleteTeacheruser.setBounds(25, 156, 201, 33);
		contentPane.add(btnEditdeleteTeacheruser);
		
		JLabel lblAdmin = new JLabel("Admin Permissions");
		lblAdmin.setBounds(69, 13, 112, 16);
		contentPane.add(lblAdmin);
		
		JLabel lblTeacheruserPermissions = new JLabel("Admin/Teacher(User) Permissions");
		lblTeacheruserPermissions.setBounds(249, 14, 209, 16);
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
				
				closeOtherWindows();
				pageAddLesson= new AddLesson();
				pageAddLesson.setVisible(true);
				//dispose();
			} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
			}
		});
		btnAddLesson.setMnemonic('A');
		btnAddLesson.setBounds(251, 213, 202, 33);
		contentPane.add(btnAddLesson);
		
		JButton btnEditStudent = new JButton("Edit/Delete Student");
		btnEditStudent.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				try {				
/***/			EditStudent.studentList=SqlStudent.studentList();// load Sql
				F.println("Test Print Students: "+EditStudent.studentList+"\n\n");

				closeOtherWindows();
				pageEditStudent= new EditStudent();
				pageEditStudent.setVisible(true);
				//dispose();
			} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
				
			}
		});
		btnEditStudent.setMnemonic('A');
		btnEditStudent.setBounds(251, 156, 202, 33);
		contentPane.add(btnEditStudent);
		
		JButton button = new JButton("Add Test");
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
/***/				AddTest.testList=SqlTest.testList();
					F.println("Test Print Test: "+AddTest.testList+"\n\n");
					
					closeOtherWindows();
					pageAddTest = new AddTest();
					pageAddTest.setVisible(true);
					//dispose();
				} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
				
				
			}
		});
		button.setMnemonic('A');
		button.setBounds(24, 213, 201, 33);
		contentPane.add(button);
		
		JButton button_1 = new JButton("Edit Test");
		button_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
/***/				EditTest.testList=SqlTest.testList();// load Sql
					F.println("Test Print Test: "+EditTest.testList+"\n\n");
					
					closeOtherWindows();
					pageEditTest = new EditTest();
					pageEditTest.setVisible(true);
					//dispose();
				} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
				
			}
		});
		button_1.setMnemonic('A');
		button_1.setBounds(24, 262, 201, 33);
		contentPane.add(button_1);
		
		JButton button_2 = new JButton("Add Test Mark");
		button_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
/***/				AddTestMark.testList=SqlTest.testList();// load Sql
					F.println("Test Print Test: "+AddTestMark.testList+"\n\n");
					AddTestMark.studentList=SqlStudent.studentList(false);// load Sql
					F.println("Test Print Students: "+AddTestMark.studentList+"\n\n");
					AddTestMark.testMarkList=SqlTestMark.testMarkList(AddTestMark.testList,AddTestMark.studentList);// load Sql
					System.out.println("Test Print Test Marks: "+AddTestMark.testMarkList+"\n\n");
					
					
					closeOtherWindows();
					pageAddTestMark = new AddTestMark();
					pageAddTestMark.setVisible(true);
					//dispose();
				} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
				
			}
		});
		button_2.setMnemonic('A');
		button_2.setBounds(24, 319, 202, 33);
		contentPane.add(button_2);
		
		JButton btnPrintdeleteTestMark = new JButton("Print/Delete Test Mark");
		btnPrintdeleteTestMark.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
/***/				PrintTestMark.testList=SqlTest.testList();// load Sql
					F.println("Test Print Tests: "+PrintTestMark.testList+"\n\n");
					PrintTestMark.studentList=SqlStudent.studentList(false);// load Sql
					F.println("Test Print Students: "+PrintTestMark.studentList+"\n\n");
					PrintTestMark.testMarkList=SqlTestMark.testMarkList(PrintTestMark.testList, PrintTestMark.studentList);// load Sql
					PrintTestMark.testMarkListUnsorted=PrintTestMark.testMarkList;
					System.out.println("Test Print Test Marks: "+PrintTestMark.testMarkList+"\n\n");
						
					
					closeOtherWindows();
					pagePrintTestMark = new PrintTestMark();
					pagePrintTestMark.setVisible(true);
					//dispose();
				} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
				
			}
		});
		btnPrintdeleteTestMark.setMnemonic('A');
		btnPrintdeleteTestMark.setBounds(24, 368, 202, 33);
		contentPane.add(btnPrintdeleteTestMark);
	}
	
	public static void closeOtherWindows(){
		if(pageAddAdmin!=null)pageAddAdmin.setVisible(false);
		if(pageAddTeacher!=null)pageAddTeacher.setVisible(false);
		if(pagePrintLesson!=null)pagePrintLesson.setVisible(false);
		if(pageAddStudent!=null)pageAddStudent.setVisible(false);
		if(pageEditTeacher!=null)pageEditTeacher.setVisible(false);
		if(pageAddLesson!=null)pageAddLesson.setVisible(false);
		if(pageEditStudent!=null)pageEditStudent.setVisible(false);
		if(pageAddTest!=null)pageAddTest.setVisible(false);
		if(pageEditTest!=null)pageEditTest.setVisible(false);
		if(pageAddTestMark!=null)pageAddTestMark.setVisible(false);
		if(pagePrintTestMark!=null)pagePrintTestMark.setVisible(false);
		//dispose()
	}
}


