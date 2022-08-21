package AddEditDelete;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import Classes.Lesson;
import Classes.Student;
import Classes.Teacher;
import Classes.Test;
import Classes.TestMark;
import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;
import Exeption.Patterns;
import Function.F;
import Images.Image;
import Sql.Sql;
import Sql.SqlLesson;
import Sql.SqlStudent;
import Sql.SqlTeacher;
import Sql.SqlTest;
import Sql.SqlTestMark;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.AbstractButton;
import javax.swing.ButtonGroup;
import javax.swing.DefaultComboBoxModel;
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
import javax.swing.JRadioButton;
import java.awt.event.ItemListener;
import java.awt.event.ItemEvent;
import javax.swing.JComboBox;

public class AddTestMark extends JFrame {
	private static JPanel contentPane;
	
	public static ArrayList<TestMark> testMarkList;
	public static TestMark tempTestMark;
	public static ArrayList<Test> testList;
	public static Test tempTest;
	public static ArrayList<Student> studentList;
	public static Student tempStudent;

	public static JComboBox comboBoxStudent;
	public static JComboBox comboBoxTest;
	public static JButton btnAddLesson;
	private static JTextField textTestMark;


	/**
	 * Launch the application.
	 * main:
	 * @throws Illegal_Exception_Id 
	 * @throws Illegal_Exception_Message 
	 */
	public static void main(String[] args) throws Illegal_Exception_Message {

/***/	testList=SqlTest.testList();// load Sql
		F.println("Test Print Test: "+testList+"\n\n");
		studentList=SqlStudent.studentList(false);// load Sql
		F.println("Test Print Students: "+studentList+"\n\n");
		testMarkList=SqlTestMark.testMarkList(testList,studentList);// load Sql
		System.out.println("Test Print Test Marks: "+testMarkList+"\n\n");
		
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					AddTestMark frame = new AddTestMark();
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
	public AddTestMark() {
		setTitle("Add Test Mark Data");
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 417, 431);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblName = new JLabel("IDTest");
		lblName.setBounds(41, 75, 135, 20);
		contentPane.add(lblName);
		
		btnAddLesson = new JButton("ADD Test Mark",Image.add);
		btnAddLesson.setMnemonic('A');
		btnAddLesson.addActionListener(new ActionListener() {
/*Creating Event*/			public void actionPerformed(ActionEvent e) {
	
/***/						addTestMarkApply();

			}
		});
		btnAddLesson.setBounds(22, 330, 140, 33);
		contentPane.add(btnAddLesson);
		
		JButton btnBack = new JButton("Back",Image.back);
		btnBack.setMnemonic('B');
		btnBack.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				setVisible(false); 
				dispose();
				System.out.println("AddTestMark frame is closed.");
				
			}
		});
		btnBack.setBounds(224, 330, 140, 33);
		contentPane.add(btnBack);
		
		textTestMark = new JTextField();
		textTestMark.setColumns(3);
		textTestMark.setBounds(165, 171, 80, 30);
		contentPane.add(textTestMark);
		
		JLabel lblMark = new JLabel("Mark");
		lblMark.setBounds(41, 176, 135, 20);
		contentPane.add(lblMark);
		
		JLabel lblMarkData = new JLabel("Mark Data");
		lblMarkData.setBounds(96, 35, 135, 16);
		contentPane.add(lblMarkData);
		
		JLabel label_2 = new JLabel("-");
		label_2.setBounds(234, 552, 14, 16);
		contentPane.add(label_2);
		
		JLabel lblIdstudent = new JLabel("IDStudent");
		lblIdstudent.setBounds(41, 121, 135, 20);
		contentPane.add(lblIdstudent);

		/***/ // Groups
		ButtonGroup groupLocation = new ButtonGroup();
		
		comboBoxTest = new JComboBox();
		comboBoxTest.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent arg0) {
				
/***/				updateCheckedTest(); 
				
			}
		});
		comboBoxTest.setBounds(123, 74, 248, 22);
		contentPane.add(comboBoxTest);
		
		comboBoxStudent = new JComboBox();
		comboBoxStudent.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent arg0) {
				
/***/			updateCheckedStudent();
				
			}
		});
		comboBoxStudent.setBounds(123, 120, 248, 22);
		contentPane.add(comboBoxStudent);
		
/***/		startPageSet();
	
	}

	
	
	public static void startPageSet(){
			if(!testList.isEmpty()) {
				comboBoxTest.setModel(new DefaultComboBoxModel(setComboBoxAreasTeacher())); //first set ComboBoxAreas
				comboBoxTest.setSelectedIndex(0);
				tempTest=testList.get(comboBoxTest.getSelectedIndex());
				F.println("found "+tempTest.getTestName()+" "+tempTest.getTestDate()+" "+tempTest.getTestTime());
			}
			else {btnAddLesson.setEnabled(false);}
			
			if(!studentList.isEmpty()) {
				comboBoxStudent.setModel(new DefaultComboBoxModel(setComboBoxAreasStudent())); //first set ComboBoxAreas
				comboBoxStudent.setSelectedIndex(0);
				tempStudent=studentList.get(comboBoxStudent.getSelectedIndex());
				System.out.println("found "+tempStudent.getFirstName());
			}
			else {btnAddLesson.setEnabled(false);}
	}
	
	public static String[] setComboBoxAreasTeacher() {
		String comboBoxAreas[]=new String[testList.size()];
		int k=0;
		for(Test i:testList) {
			comboBoxAreas[k]=i.getTestID()+" "+i.getTestName()+" "+i.getTestDate()+" "+i.getTestTime();
			k+=1;
		}
		return comboBoxAreas;
	}
	
	public static String[] setComboBoxAreasStudent() {
		String comboBoxAreas[]=new String[studentList.size()];
		int k=0;
		for(Student i:studentList) {
			comboBoxAreas[k]=i.getFirstName()+" "+i.getLastName()+" "+i.getId();
			k+=1;
		}
		return comboBoxAreas;
	}
	
	
	
	public static void addTestMarkApply(){
		try {/*Active Inputs on temp___ after checking the inputs and throw the alerts and exeptions*/
				int listIndexTeacher=comboBoxTest.getSelectedIndex();				
				tempTest=testList.get(listIndexTeacher);
				int listIndexStudent=comboBoxStudent.getSelectedIndex();				
				tempStudent=studentList.get(listIndexStudent);
				
				tempTestMark=null;
				F.println("11111");
				Patterns.contentPane=contentPane;
		
					tempTestMark = new TestMark(
		/*TestId*/								tempTest,
		/*Student*/								tempStudent,
		/*Teacher*/								null,
		/*Int*/									F.stringInt(textTestMark.getText())
					);



	
					F.println(tempTestMark+"");
				/*List similarity, already available check*/		
				testMarkInTempList(false);
				
		/*!*/		if(tempTestMark!=null) 
					SqlTestMark.addTestMark(
							/*String1*/								tempTestMark.getTestID(),
							/*String2*/								tempTestMark.getStudentID(),
							/*String3*/								null,
							/*String4*/								tempTestMark.getMark()
							);
					
						if(Sql.isSql) {
	/*reload Sql to list*/				testMarkList=SqlTestMark.testMarkList(testList,studentList);
											F.println("--> "+testMarkList);
	/*check from it if added done*/		if(!testMarkInTempList(true)) F.msg("Test Mark not added", btnAddLesson);
										F.println();
							}
						else {tempStudent=null;F.illegalExeptionMessage("Data Base Error, no student added!", contentPane);}
				
		} catch ( Illegal_Exception_Message  e1) {System.err.printf("%s",e1+"\n  \n");}
		catch (NumberFormatException e1) {F.msg("not int number entered on Mark", contentPane);System.err.printf("%s",e1+"\n  \n");}
	}
	

	
	
	public static void updateCheckedTest() { 
			tempTest=testList.get(comboBoxTest.getSelectedIndex());
			F.println("found "+tempTest.getTestName()+" "+tempTest.getTestDate()+" "+tempTest.getTestTime());
	}
	
	public static void updateCheckedStudent() { 
			tempStudent=studentList.get(comboBoxStudent.getSelectedIndex());
			F.println("found "+tempStudent.getFirstName());
	}
	
	
	/*check Lesson inside list on-adding and after-adding*/
	public static boolean testMarkInTempList(boolean findTestMark) throws Illegal_Exception_Message {
		for(TestMark i:testMarkList) 
				if(i!=null&&i.getTest()!=null&&i.getStudent()!=null //&&i.getTeacher()!=null&
						&&tempTestMark.getTestID().equals(i.getTestID())
						&&tempTestMark.getStudentID().equals(i.getStudentID())
						//&&tempTestMark.getTeacherID().equals(i.getTeacherID()) //Next versions will support
				){
						if(findTestMark) {//true
							F.msg("New TestMark is added ", btnAddLesson); 
							F.println(tempTestMark+ "is added!");
							return true;
						}
						if(!findTestMark) {//false
							tempTestMark=null;
							F.println("Entered TestMark aleardy exist! \n Please try again!");		
							F.illegalExeptionMessage("Entered TestMark is already exsist", btnAddLesson);
						}
				}
		return false;
	}
	
	
}


