package AddEditDelete;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import Classes.Person;
import Classes.Student;
import Classes.Teacher;
import Classes.User;
import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;
import Exeption.Patterns;
import Function.F;
import Images.Image;
import Sql.Sql;
import Sql.SqlStudent;
import Sql.SqlTeacher;
import Sql.SqlUser;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.ButtonGroup;
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

public class AddTeacher extends JFrame {

	public static ArrayList<Teacher> teacherList;
	public static Teacher tempTeacher;

	public static ArrayList<User> userList;
	public static User tempUser;
	
	public static Instrument instrument;
	public static Gender gender;

	private static JPanel contentPane;	
	private static JTextField txtID;	
	private static JTextField textFirstName;
	private static JTextField textLastName;
	private static JTextField textLessonSalary;
	private static JTextField textLessonLength;
	private static JTextField textBeginDateDay;
	private static JTextField textPassword;
	private static JTextField textAddress;
	private static JTextField textPhoneNumber;
	public static JButton btnAddUser;
	

	/**
	 * Launch the application.
	 * main:
	 * @throws Illegal_Exception_Id 
	 * @throws Illegal_Exception_Message 
	 */
	public static void main(String[] args) throws Illegal_Exception_Message {
		
		teacherList=SqlTeacher.teacherList();
		System.out.println("Test Print Teachers: "+teacherList+"\n\n");
		
		userList=SqlUser.userList();
		System.out.println("Test Print Users: "+userList+"\n\n");
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					AddTeacher frame = new AddTeacher();
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
	public AddTeacher() {
		setTitle("Add Teacher");
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
		
		JButton btnAddUser = new JButton("ADD Teacher",Image.add);
		btnAddUser.setMnemonic('A');
		btnAddUser.addActionListener(new ActionListener() {
/*Creating Event*/			public void actionPerformed(ActionEvent e) {
							
								addTecherApply();			
	
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
				F.println("AddTeacher frame is closed.");
				
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
		
		JLabel lblLessonSalary = new JLabel("Lesson Salary ");
		lblLessonSalary.setBounds(41, 400, 135, 20);
		contentPane.add(lblLessonSalary);
		
		textLessonSalary = new JTextField();
		textLessonSalary.setText("90");
		textLessonSalary.setColumns(10);
		textLessonSalary.setBounds(165, 395, 66, 30);
		contentPane.add(textLessonSalary);
		
		textLessonLength = new JTextField();
		textLessonLength.setText("45");
		textLessonLength.setColumns(3);
		textLessonLength.setBounds(165, 352, 66, 30);
		contentPane.add(textLessonLength);
		
		JLabel lblLessonLength = new JLabel("Lesson Length");
		lblLessonLength.setBounds(41, 357, 135, 20);
		contentPane.add(lblLessonLength);
		
		JLabel lblBeginDate = new JLabel("Begin Teaching Date");
		lblBeginDate.setBounds(41, 312, 135, 20);
		contentPane.add(lblBeginDate);
		
		textBeginDateDay = new JTextField();
		textBeginDateDay.setColumns(2);
		textBeginDateDay.setBounds(165, 307, 140, 30);
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
		
		JLabel lblA = new JLabel("Teaching Data");
		lblA.setBounds(96, 257, 135, 16);
		contentPane.add(lblA);
		
		JLabel lblPesonalData = new JLabel("Pesonal Data");
		lblPesonalData.setBounds(96, 35, 135, 16);
		contentPane.add(lblPesonalData);
		
		JLabel lblOptionalData = new JLabel("Optional Personal Data");
		lblOptionalData.setBounds(96, 469, 135, 16);
		contentPane.add(lblOptionalData);
		
		JLabel lblPassword = new JLabel("Password");
		lblPassword.setBounds(41, 206, 135, 20);
		contentPane.add(lblPassword);
		
		textPassword = new JTextField();
		textPassword.setColumns(30);
		textPassword.setBounds(165, 201, 199, 30);
		contentPane.add(textPassword);
		
		JLabel lblmin = new JLabel("(min)");
		lblmin.setBounds(244, 357, 135, 20);
		contentPane.add(lblmin);
		
		JLabel lblnis = new JLabel("(nis)");
		lblnis.setBounds(244, 400, 135, 20);
		contentPane.add(lblnis);
		
		textAddress = new JTextField();
		textAddress.setColumns(50);
		textAddress.setBounds(165, 499, 199, 30);
		contentPane.add(textAddress);
		
		textPhoneNumber = new JTextField();
		textPhoneNumber.setColumns(3);
		textPhoneNumber.setBounds(165, 545, 140, 30);
		contentPane.add(textPhoneNumber);
		
		JRadioButton rdbtnGuitar = new JRadioButton("Guitar");
		rdbtnGuitar.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if(rdbtnGuitar.isSelected()) {instrument=Instrument.Guitar;}
				System.out.println("[pressed/un:"+instrument+"]");
			}
		});
		rdbtnGuitar.setBounds(121, 586, 127, 25);
		contentPane.add(rdbtnGuitar);
		
		JRadioButton rdbtnPiano = new JRadioButton("Piano");
		rdbtnPiano.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if(rdbtnPiano.isSelected()) {instrument=Instrument.Piano;}
				System.out.println("[pressed/un:"+instrument+"]");
			}
		});
		rdbtnPiano.setBounds(121, 617, 127, 25);
		contentPane.add(rdbtnPiano);
		
		JRadioButton rdbtnAccuardion = new JRadioButton("Accuardion");
		rdbtnAccuardion.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if(rdbtnAccuardion.isSelected()) {instrument=Instrument.Accuardion;}
				System.out.println("[pressed/un:"+instrument+"]");
			}
		});
		rdbtnAccuardion.setBounds(121, 647, 127, 25);
		contentPane.add(rdbtnAccuardion);
		

		JRadioButton rdbtnMale = new JRadioButton("male");
		rdbtnMale.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent arg0) {
				if(rdbtnMale.isSelected()) {gender=Gender.Male;}
				System.out.println("[pressed/un:"+gender+"]");
			}
		});
		rdbtnMale.setBounds(121, 687, 127, 25);
		contentPane.add(rdbtnMale);
		
		JRadioButton rdbtnFemale = new JRadioButton("female");
		rdbtnFemale.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if(rdbtnFemale.isSelected()) {gender=Gender.Female;}
				System.out.println("[pressed/un:"+gender+"]");
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
		
		JLabel lblDdmmyy = new JLabel("DD/MM/YY");
		lblDdmmyy.setBounds(317, 314, 70, 20);
		contentPane.add(lblDdmmyy);

	}

	
		public static void addTecherApply(){
					try {
						/*Active Inputs on temp___ after checking the inputs and throw the alerts and exeptions*/
						tempUser=null;
						tempTeacher=null;
						Patterns.contentPane=contentPane;

						tempUser = new User(txtID.getText(), textPassword.getText());
						
					//	int LessonLength=0;
					//	if(!textLessonLength.getText().isEmpty()) {LessonLength=Integer.parseInt(textLessonLength.getText());}
					//	double LessonSalary=0.0;
					//	if(!textLessonSalary.getText().isEmpty()) {LessonSalary=Double.parseDouble(textLessonSalary.getText());}
						tempTeacher = new Teacher(
			/*String1*/								txtID.getText(),
			/*String2*/								textFirstName.getText(),
			/*String3*/								textLastName.getText(),
			/*String4*/								textAddress.getText(),
			/*String5*/								textPhoneNumber.getText(),
			/*Instrument*/							instrument,
			/*Gender*/								gender,
			/*String*/								textBeginDateDay.getText(),
			/*Int*/									textLessonLength.getText(),
			/*Double*/								textLessonSalary.getText()
						);
						
							
						/*List similarity, already available check*/		
						teacherUserInTempList(false);
						
			/*!*/			if(tempTeacher!=null&&tempUser!=null) {	
								SqlTeacher.addTeacherUser(
										/*String1*/								tempTeacher.getId(),
										/*String2*/								tempUser.getPassword(),
										/*String3*/								tempTeacher.getFirstName(),
										/*String4*/								tempTeacher.getLastName(),
										/*String5*/								tempTeacher.getAddress(),
										/*String6*/								tempTeacher.getPhoneNumber(),
										/*Instrument*/							tempTeacher.getInstrument(),
										/*Gender*/								tempTeacher.getGender(),
										/*Date String*/							tempTeacher.getBegingTeachingDate(),
										/*Int*/									tempTeacher.getLessonMinutesLong(),	
										/*Double*/								tempTeacher.getSalary()
							);

							if(Sql.isSql) {
	/*reload Sql to list*/				teacherList=SqlTeacher.teacherList();
	/*reload Sql to list*/				userList=SqlUser.userList();
	/*check from it if added done*/		teacherUserInTempList(true);
										F.println();
							}
							else {tempTeacher=null;tempUser=null;F.illegalExeptionMessage("Data Base Error, no teacher aded!", contentPane);}
							}		
					} catch (NumberFormatException | Illegal_Exception_Message  e1) {System.err.printf("%s",e1+"\n  \n");}
		}

		
		/*check Student inside list on-adding and after-adding*/
		public static void teacherUserInTempList(boolean findTeacher) throws Illegal_Exception_Message {
			for(Teacher i:teacherList) if(i!=null&&tempTeacher.getId().equals(i.getId())){
				for(User j:userList) if(j!=null&&tempTeacher.getId().equals(j.getUserName())){
						if(findTeacher) {//true
							tempTeacher=i;
							tempUser=j;
							F.msg("New Teacher is added!", btnAddUser); 
							F.println(tempTeacher+ "is added!");
							F.println(tempUser+ "is added!");
						}
						if(!findTeacher) {//false
							tempTeacher=null;
							tempUser=null;
							F.println("Entered ID: "+ txtID.getText() + " aleardy exist! \n Please try again!");		
							F.illegalExeptionMessage("Entered teacher is already exsist", contentPane);
						}
				}
			}
		}

		
}