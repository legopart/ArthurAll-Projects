package AddEditDelete;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import Classes.Admin;
import Classes.Student;
import Classes.Teacher;
import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;
import Exeption.Patterns;
import Function.F;
import Images.Image;
import Sql.Sql;
import Sql.SqlAdmin;
import Sql.SqlStudent;

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

public class AddStudent extends JFrame {

	public static ArrayList<Student> studentList;
	public static Student tempStudent;
	
	public static Instrument instrument;
	public static Gender gender;

	private static JPanel contentPane;
	private static JTextField txtID;	
	private static JTextField textFirstName;
	private static JTextField textLastName;
	private static JTextField textAcchievement;
	private static JTextField textBeginDateDay;
	private static JTextField textAddress;
	private static JTextField textPhoneNumber;
	public static JButton btnAddUser;
	public static AddStudent frame;

	/**
	 * Launch the application.
	 * main:
	 * @throws Illegal_Exception_Id 
	 * @throws Illegal_Exception_Message 
	 */
	public static void main(String[] args) throws Illegal_Exception_Message {
		
		studentList=SqlStudent.studentList();
		F.println("Test Print Students: "+studentList+"\n\n");
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					frame = new AddStudent();
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
	public AddStudent() {
		setTitle("Add Student");
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 417, 860);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblName = new JLabel("ID");
		lblName.setBounds(41, 75, 135, 20);
		contentPane.add(lblName);
		
		txtID = new JTextField();
		txtID.setColumns(10);
		txtID.setBounds(165, 70, 199, 30);
		contentPane.add(txtID);
		
		JButton btnAddUser = new JButton("ADD Student",Image.add);
		btnAddUser.setMnemonic('A');
		btnAddUser.addActionListener(new ActionListener() {
/*Creating Event*/			public void actionPerformed(ActionEvent e) {

	addStudentApply();
	
			}
		});
		btnAddUser.setBounds(22, 767, 140, 33);
		contentPane.add(btnAddUser);
		
		JButton btnBack = new JButton("Back",Image.back);
		btnBack.setMnemonic('B');
		btnBack.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				setVisible(false); 
				dispose();
				F.println("AddStudent frame is closed.");
			}
		});
		btnBack.setBounds(224, 767, 140, 33);
		contentPane.add(btnBack);
		
		textFirstName = new JTextField();
		textFirstName.setColumns(15);
		textFirstName.setBounds(165, 115, 199, 30);
		contentPane.add(textFirstName);
		
		JLabel lblFirstName = new JLabel("First Name");
		lblFirstName.setBounds(41, 120, 135, 20);
		contentPane.add(lblFirstName);
		
		textLastName = new JTextField();
		textLastName.setColumns(15);
		textLastName.setBounds(165, 158, 199, 30);
		contentPane.add(textLastName);
		
		JLabel lblLastName = new JLabel("Last Name");
		lblLastName.setBounds(41, 163, 135, 20);
		contentPane.add(lblLastName);
		
		textAcchievement = new JTextField();
		textAcchievement.setText("0");
		textAcchievement.setColumns(2);
		textAcchievement.setBounds(165, 352, 39, 30);
		contentPane.add(textAcchievement);
		
		JLabel lblAchievement = new JLabel("Acchivement");
		lblAchievement.setBounds(41, 357, 135, 20);
		contentPane.add(lblAchievement);
		
		JLabel lblBeginDate = new JLabel("Begin Study Date");
		lblBeginDate.setBounds(41, 312, 135, 20);
		contentPane.add(lblBeginDate);
		
		textBeginDateDay = new JTextField();
		textBeginDateDay.setColumns(10);
		textBeginDateDay.setBounds(165, 307, 135, 30);
		contentPane.add(textBeginDateDay);
		
		JLabel lblInstrument = new JLabel("Instrument");
		lblInstrument.setBounds(41, 588, 135, 20);
		contentPane.add(lblInstrument);
		
		JLabel lblPhoneNumber = new JLabel("Phone Number");
		lblPhoneNumber.setBounds(41, 545, 135, 20);
		contentPane.add(lblPhoneNumber);
		
		JLabel lblAddress = new JLabel("Address");
		lblAddress.setBounds(41, 500, 135, 20);
		contentPane.add(lblAddress);
		
		JLabel lblGender = new JLabel("Gender");
		lblGender.setBounds(41, 689, 135, 20);
		contentPane.add(lblGender);
		
		JLabel lblA = new JLabel("Studing Data (optional)");
		lblA.setBounds(96, 257, 135, 16);
		contentPane.add(lblA);
		
		JLabel lblPesonalData = new JLabel("Pesonal Data");
		lblPesonalData.setBounds(96, 35, 135, 16);
		contentPane.add(lblPesonalData);
		
		JLabel lblOptionalData = new JLabel("ersonal Data (optional)");
		lblOptionalData.setBounds(96, 469, 135, 16);
		contentPane.add(lblOptionalData);
		
		JLabel lblYears = new JLabel("(Years)");
		lblYears.setBounds(213, 357, 135, 20);
		contentPane.add(lblYears);
		
		textAddress = new JTextField();
		textAddress.setColumns(50);
		textAddress.setBounds(165, 499, 199, 30);
		contentPane.add(textAddress);
		
		textPhoneNumber = new JTextField();
		textPhoneNumber.setColumns(3);
		textPhoneNumber.setBounds(165, 545, 192, 30);
		contentPane.add(textPhoneNumber);
		
		JRadioButton rdbtnGuitar = new JRadioButton("Guitar");
		rdbtnGuitar.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if(rdbtnGuitar.isSelected()) {instrument=Instrument.Guitar;}
				F.println("[pressed/un:"+instrument+"]");
			}
		});
		rdbtnGuitar.setBounds(121, 586, 127, 25);
		contentPane.add(rdbtnGuitar);
		
		JRadioButton rdbtnPiano = new JRadioButton("Piano");
		rdbtnPiano.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if(rdbtnPiano.isSelected()) {instrument=Instrument.Piano;}
				F.println("[pressed/un:"+instrument+"]");
			}
		});
		rdbtnPiano.setBounds(121, 617, 127, 25);
		contentPane.add(rdbtnPiano);
		
		JRadioButton rdbtnAccuardion = new JRadioButton("Accuardion");
		rdbtnAccuardion.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if(rdbtnAccuardion.isSelected()) {instrument=Instrument.Accuardion;}
				F.println("[pressed/un:"+instrument+"]");
			}
		});
		rdbtnAccuardion.setBounds(121, 647, 127, 25);
		contentPane.add(rdbtnAccuardion);

		
		JRadioButton rdbtnMale = new JRadioButton("male");
		rdbtnMale.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent arg0) {
				if(rdbtnMale.isSelected()) {gender=Gender.Male;}
				F.println("[pressed/un:"+gender+"]");
			}
		});
		rdbtnMale.setBounds(121, 687, 127, 25);
		contentPane.add(rdbtnMale);
		
		JRadioButton rdbtnFemale = new JRadioButton("female");
		rdbtnFemale.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if(rdbtnFemale.isSelected()) {gender=Gender.Female;}
				F.println("[pressed/un:"+gender+"]");
			}
		});
		rdbtnFemale.setBounds(121, 718, 127, 25);
		contentPane.add(rdbtnFemale);
		
		
		/***/ // Groups
		ButtonGroup groupInstrument = new ButtonGroup();
		groupInstrument.add(rdbtnGuitar);
		groupInstrument.add(rdbtnPiano);
		groupInstrument.add(rdbtnAccuardion);
		
		ButtonGroup groupGender = new ButtonGroup();
		groupGender.add(rdbtnMale);
		groupGender.add(rdbtnFemale);
		
		JLabel lblddmmyyyy = new JLabel("DD/MM/YY");
		lblddmmyyyy.setBounds(312, 312, 103, 20);
		contentPane.add(lblddmmyyyy);
		
		JCheckBox chckbxNewCheckBox = new JCheckBox("Edit Student");
		chckbxNewCheckBox.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
				/***/	EditStudent.studentList=SqlStudent.studentList();// load Sql
				F.println("Test Print Students: "+EditStudent.studentList+"\n\n");
				
				EditStudent pageEditStudent= new EditStudent();
				pageEditStudent.setVisible(true);
				dispose();
			} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}

						
			}
		});
		chckbxNewCheckBox.setBounds(22, 7, 97, 23);
		contentPane.add(chckbxNewCheckBox);
	}

			
			public static void addStudentApply(){
				
				try {
							tempStudent=null;
							Patterns.contentPane=contentPane;
							tempStudent = new Student(
		/*String1*/								txtID.getText(),
		/*String2*/								textFirstName.getText(),
		/*String3*/								textLastName.getText(),
		/*String4*/								textAddress.getText(),
		/*String5*/								textPhoneNumber.getText(),
		/*Instrument*/							instrument,
		/*Gender*/								gender,
		/*String*/								textBeginDateDay.getText(),
		/*Int*/									textAcchievement.getText()
							);
	
							/*List similarity, already available check*/		
							studentInTempList(false);
							
				/*!*/			if(tempStudent!=null) {	
									SqlStudent.addStudent(
											/*String1*/								tempStudent.getId(),
											/*String2*/								tempStudent.getFirstName(),
											/*String3*/								tempStudent.getLastName(),
											/*String4*/								tempStudent.getAddress(),
											/*String5*/								tempStudent.getPhoneNumber(),
											/*Instrument String*/					tempStudent.getInstrument(),
											/*Gender String*/						tempStudent.getGender(),
											/*Date String*/							tempStudent.getBegingStudyDate(),
											/*Int*/									tempStudent.getAcchivementYears()	
								);

								if(Sql.isSql) {
		/*reload Sql to list*/				studentList=SqlStudent.studentList();
		/*check from it if added done*/		studentInTempList(true);
											F.println();
								}
								else {tempStudent=null;F.illegalExeptionMessage("Data Base Error, no student added!", contentPane);}
								}		
						} catch (NumberFormatException | Illegal_Exception_Message  e1) {System.err.printf("%s",e1+"\n  \n");}
			}

			
			/*check Student inside list on-adding and after-adding*/
			public static void studentInTempList(boolean findStudent) throws Illegal_Exception_Message {
				for(Student i:studentList)   
						if(i!=null&&tempStudent.getId().equals(i.getId())){
								if(findStudent) {//true
									tempStudent=i;
									F.msg("New Student is added!", btnAddUser); 
									F.println(tempStudent+ "is added!");
								}
								if(!findStudent) {//false
									tempStudent=null;
									F.println("Entered ID: "+ txtID.getText() + " aleardy exist! \n Please try again!");		
									F.illegalExeptionMessage("Entered student is already exsist", contentPane);
								}
						}
			}
}