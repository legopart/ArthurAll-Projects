package AddEditDelete;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import Classes.Admin;
import Classes.Student;
import Classes.Teacher;
import Classes.Test;
import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;
import Exeption.Patterns;
import Function.F;
import Images.Image;
import Sql.Sql;
import Sql.SqlAdmin;
import Sql.SqlStudent;
import Sql.SqlTest;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.ButtonGroup;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Formatter;
import java.util.FormatterClosedException;
import java.util.NoSuchElementException;
import java.util.Scanner;
import java.awt.event.ActionEvent;
import javax.swing.JRadioButton;
import java.awt.event.ItemListener;
import java.awt.event.ItemEvent;
import javax.swing.JCheckBox;

public class AddTest extends JFrame {

	public static ArrayList<Test> testList;
	public static Test tempTest;
	
	public static Instrument instrument;
	public static Gender gender;

	private static JPanel contentPane;
	private static JTextField textTestName;
	private static JTextField textTime;
	private static JTextField textTestDate;
	public static JButton btnAddUser;
	public static AddTest frame;

	/**
	 * Launch the application.
	 * main:
	 * @throws Illegal_Exception_Id 
	 * @throws Illegal_Exception_Message 
	 */
	public static void main(String[] args) throws Illegal_Exception_Message {
		
		testList=SqlTest.testList();
		F.println("Test Print Test: "+testList+"\n\n");
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					frame = new AddTest();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	
	
	/**
	 * Create the frame.
	 * @throws Illegal_Exception_Id 
	 * @throws Illegal_Exception_Message 
	 */
	public AddTest() {
		setTitle("Add Test");
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 417, 430);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JButton btnAddTest = new JButton("ADD Test",Image.add);
		btnAddTest.setMnemonic('A');
		btnAddTest.addActionListener(new ActionListener() {
/*Creating Event*/			public void actionPerformed(ActionEvent e) {

	addStudentApply();
	
			}
		});
		btnAddTest.setBounds(22, 307, 140, 33);
		contentPane.add(btnAddTest);
		
		JButton btnBack = new JButton("Back",Image.back);
		btnBack.setMnemonic('B');
		btnBack.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				setVisible(false); 
				dispose();
				F.println("AddTest frame is closed.");
			}
		});
		btnBack.setBounds(224, 307, 140, 33);
		contentPane.add(btnBack);
		
		textTestName = new JTextField();
		textTestName.setColumns(15);
		textTestName.setBounds(155, 62, 199, 30);
		contentPane.add(textTestName);
		
		JLabel lblTestName = new JLabel("Test Name");
		lblTestName.setBounds(31, 67, 135, 20);
		contentPane.add(lblTestName);
		
		textTime = new JTextField();
		textTime.setColumns(15);
		textTime.setBounds(155, 142, 71, 30);
		contentPane.add(textTime);
		
		JLabel lblTime = new JLabel("Time");
		lblTime.setBounds(31, 147, 135, 20);
		contentPane.add(lblTime);
		
		JLabel lblTestDate = new JLabel("Test Date");
		lblTestDate.setBounds(31, 108, 135, 20);
		contentPane.add(lblTestDate);
		
		textTestDate = new JTextField();
		textTestDate.setColumns(10);
		textTestDate.setBounds(153, 103, 135, 30);
		contentPane.add(textTestDate);
		
		JLabel lblTestData = new JLabel("Test Data");
		lblTestData.setBounds(96, 35, 135, 16);
		contentPane.add(lblTestData);
		
		JLabel lblddmmyyyy = new JLabel("DD/MM/YY");
		lblddmmyyyy.setBounds(298, 108, 103, 20);
		contentPane.add(lblddmmyyyy);
		
		JLabel lblHhmm = new JLabel("HH:mm");
		lblHhmm.setBounds(237, 150, 103, 20);
		contentPane.add(lblHhmm);
		
		JCheckBox chckbxEditStudent = new JCheckBox("Edit Test");
		chckbxEditStudent.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
					EditTest.testList=SqlTest.testList();
					F.println("Test Print Test: "+EditTest.testList+"\n\n");
					EditTest pageEditTest= new EditTest();
					pageEditTest.setVisible(true);
					dispose();
				} catch (Illegal_Exception_Message  e1) {System.err.printf("%s",e1+"\n  \n");}

			}
		});
		chckbxEditStudent.setBounds(22, 7, 127, 23);
		contentPane.add(chckbxEditStudent);
	}

			
			public static void addStudentApply(){
						try {
							/*Active Inputs on temp___ after checking the inputs and throw the alerts and exeptions*/
							tempTest=null;
							Patterns.contentPane=contentPane;

							tempTest = new Test(null,textTestName.getText(), textTestDate.getText(), textTime.getText() );
						
								
							/*List similarity, already available check*/		
							testInTempList(false);
							
				/*!*/			if(tempTest!=null) 	
										SqlTest.addTest(tempTest.getTestName(), tempTest.getTestDate(), tempTest.getTestTime());

								if(Sql.isSql) {
		/*reload Sql to list*/				testList=SqlTest.testList();
		/*check from it if added done*/		testInTempList(true);
											F.println();
								}
								else {tempTest=null;F.illegalExeptionMessage("Data Base Error, no test added!", contentPane);}
										
						} catch (NumberFormatException | Illegal_Exception_Message  e1) {System.err.printf("%s",e1+"\n  \n");}
			}

			
			/*check Student inside list on-adding and after-adding*/
			public static void testInTempList(boolean findTest) throws Illegal_Exception_Message {
				for(Test i:testList)   
						if(i!=null&&tempTest.getTestName().equals(i.getTestName())
							&&tempTest.getTestDate().equals(i.getTestDate())
							&&tempTest.getTestTime().equals(i.getTestTime())
								){
								if(findTest) {//true
									tempTest=i;
									F.msg("New Test is added!", btnAddUser); 
									F.println(tempTest+ "is added!");
								}
								if(!findTest) {//false
									tempTest=null;
									F.println("Entered Test: "+ textTestName.getText() + " aleardy exist! \n Please try again!");		
									F.illegalExeptionMessage("Entered test is already exsist", contentPane);
								}
						}
			}
}