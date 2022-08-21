package AddEditDelete;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import Classes.Lesson;
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
import java.util.Comparator;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.awt.event.ActionEvent;
import javax.swing.JRadioButton;
import java.awt.event.ItemListener;
import java.awt.event.ItemEvent;
import java.awt.Color;
import javax.swing.JSpinner;
import javax.swing.JComboBox;

public class EditTeacher extends JFrame {
/***/
	public static ArrayList<Teacher> teacherList = new ArrayList<>();
	public static Teacher tempTeacher;
	public static int listIndex=-1;
	public static ArrayList<User> userList = new ArrayList<>();
	public static User tempUser;

	private static JPanel contentPane;	
	public static JRadioButton rdbtnGuitar;
	public static JRadioButton rdbtnPiano;
	public static JRadioButton rdbtnAccuardion;
	public static JRadioButton rdbtnMale;
	public static JRadioButton rdbtnFemale;
	public static JComboBox comboBox;
	
	public static Instrument instrument;
	public static Gender gender;
	
	private static JTextField textFirstName;
	private static JTextField textLastName;
	private static JTextField textLessonSalary;
	private static JTextField textLessonLength;
	private static JTextField textBeginDateDay;
	private static JTextField textPassword;
	private static JTextField textAddress;
	private static JTextField textPhoneNumber;
	public static JButton btnDelete;
	public static JButton btnEditUser;
	
	/**
	 * Launch the application.
	 * main:
	 * @throws Illegal_Exception_Id 
	 * @throws Illegal_Exception_Message 
	 */
	public static void main(String[] args) throws Illegal_Exception_Message {

/***/	teacherList=SqlTeacher.teacherList();// load Sql
		F.println("Test Print Teachers: "+teacherList+"\n\n");
/***/	userList=SqlUser.userList();// load Sql
		F.println("Test Print Users: "+userList+"\n\n");
				
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					EditTeacher frame = new EditTeacher();
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
	public EditTeacher() {
		setTitle("Edit/Delete Teacher");
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 417, 857);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblName = new JLabel("Full Nam, ID");
		lblName.setBounds(41, 55, 85, 20);
		contentPane.add(lblName);
		
		btnEditUser = new JButton("Edit Teacher",Image.edit);
		btnEditUser.setMnemonic('A');
		btnEditUser.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

/***/					editTeacherApply();
			}
		});
		btnEditUser.setBounds(22, 767, 140, 33);
		contentPane.add(btnEditUser);
		
		JButton btnBack = new JButton("Back",Image.back);
		btnBack.setMnemonic('B');
		btnBack.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				setVisible(false); 
				dispose();
				System.out.println("AddTeacher frame is closed.");
				
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
		textLessonSalary.setColumns(10);
		textLessonSalary.setBounds(165, 395, 66, 30);
		contentPane.add(textLessonSalary);
		
		textLessonLength = new JTextField();
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
		
		JLabel lblA = new JLabel("Teaching Data (optional)");
		lblA.setBounds(96, 257, 152, 16);
		contentPane.add(lblA);
		
		JLabel lblPesonalData = new JLabel("Pesonal Data Edit");
		lblPesonalData.setBounds(96, 35, 135, 16);
		contentPane.add(lblPesonalData);
		
		JLabel lblOptionalData = new JLabel("Personal Data (optional)");
		lblOptionalData.setBounds(96, 469, 167, 16);
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
		textPhoneNumber.setBounds(165, 545, 153, 30);
		contentPane.add(textPhoneNumber);
		
		rdbtnGuitar = new JRadioButton("Guitar");
		rdbtnGuitar.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if(rdbtnGuitar.isSelected()) {instrument=Instrument.Guitar;}
				System.out.println("[pressed/un:"+instrument+"]");
			}
		});
		rdbtnGuitar.setBounds(121, 586, 127, 25);
		contentPane.add(rdbtnGuitar);
		
		rdbtnPiano = new JRadioButton("Piano");
		rdbtnPiano.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if(rdbtnPiano.isSelected()) {instrument=Instrument.Piano;}
				System.out.println("[pressed/un:"+instrument+"]");
			}
		});
		rdbtnPiano.setBounds(121, 617, 127, 25);
		contentPane.add(rdbtnPiano);
		
		rdbtnAccuardion = new JRadioButton("Accuardion");
		rdbtnAccuardion.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if(rdbtnAccuardion.isSelected()) {instrument=Instrument.Accuardion;}
				System.out.println("[pressed/un:"+instrument+"]");
			}
		});
		rdbtnAccuardion.setBounds(121, 647, 127, 25);
		contentPane.add(rdbtnAccuardion);
		
		
		rdbtnMale = new JRadioButton("male");
		rdbtnMale.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent arg0) {
				if(rdbtnMale.isSelected()) {gender=Gender.Male;}
				System.out.println("[pressed/un:"+gender+"]");
			}
		});
		rdbtnMale.setBounds(121, 687, 127, 25);
		contentPane.add(rdbtnMale);
		
		rdbtnFemale = new JRadioButton("female");
		rdbtnFemale.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				if(rdbtnFemale.isSelected()) {gender=Gender.Female;}
				System.out.println("[pressed/un:"+gender+"]");
			}
		});
		rdbtnFemale.setBounds(121, 718, 127, 25);
		contentPane.add(rdbtnFemale);
		
		
/***/	// Groups
		ButtonGroup groupInstrument = new ButtonGroup();
		groupInstrument.add(rdbtnGuitar);
		groupInstrument.add(rdbtnPiano);
		groupInstrument.add(rdbtnAccuardion);
		
		ButtonGroup groupGender = new ButtonGroup();
		groupGender.add(rdbtnMale);
		groupGender.add(rdbtnFemale);
		
		btnDelete = new JButton("Delete",Image.delete);
		btnDelete.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

/***/				confrimeDeleteWindow(); //Confrime Delete Window
				
			}
		});
		btnDelete.setMnemonic('A');
		btnDelete.setBounds(265, 27, 95, 33);
		contentPane.add(btnDelete);
		
		JLabel lblDdmmyy = new JLabel("DD/MM/YY");
		lblDdmmyy.setBounds(316, 314, 71, 20);
		contentPane.add(lblDdmmyy);
		
		comboBox = new JComboBox();

		comboBox.setBounds(51, 80, 313, 22);
		contentPane.add(comboBox);
		
		comboBox.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {

/***/		updateAreasOnChangeSet(); //update data auto input

			}
		});
	
		
/***/			starPageSet(); //first data auto input
		
	}

	public static void starPageSet() {
		if(!teacherList.isEmpty()) {
			comboBox.setModel(new DefaultComboBoxModel(setComboBoxAreas())); //first set ComboBoxAreas
			comboBox.setSelectedIndex(0);
			tempTeacher=teacherList.get(comboBox.getSelectedIndex());
				findUserByTeacherSetTempUser();
			F.println("found Teacher "+tempTeacher.getId());
			F.println("found User "+tempUser.getUserName());
			setAreas();
		}
		else {btnDelete.setEnabled(false);btnEditUser.setEnabled(false);}
	}
	

	public static void findUserByTeacherSetTempUser() {
		try {
		tempUser=null;
		for(User i:userList) if(i.getUserName().equals(tempTeacher.getId())) tempUser=i;
		if(tempUser==null) F.illegalExeptionMessage("Not found the user for this teacher cant done the editing right", contentPane);
		} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
	};
	
	public static void updateAreasOnChangeSet() {
		tempTeacher=teacherList.get(comboBox.getSelectedIndex());
			findUserByTeacherSetTempUser();
		System.out.println("found"+tempTeacher.getFirstName());
		setAreas();
	}
	
	public static void confrimeDeleteWindow() {
	       if( JOptionPane.showConfirmDialog(contentPane, "Accept Teacher Delete?", "Select an Option...",JOptionPane.YES_NO_OPTION)==0)
	    	   removeTeacher() ;
	}

	public static void setAreas() {
		if(tempTeacher!=null) {
			textPassword.setText(tempUser.getPassword());
			textFirstName.setText(tempTeacher.getFirstName());
			textLastName.setText(tempTeacher.getLastName());
			textBeginDateDay.setText(tempTeacher.getBegingTeachingDate());
			textAddress.setText(tempTeacher.getAddress());
			textPhoneNumber.setText(tempTeacher.getPhoneNumber());
				//Instrument/	
				if(tempTeacher.getInstrument()==Instrument.Guitar) {rdbtnGuitar.setSelected(true);}
				if(tempTeacher.getInstrument()==Instrument.Piano) {rdbtnPiano.setSelected(true);}
				if(tempTeacher.getInstrument()==Instrument.Accuardion) {rdbtnAccuardion.setSelected(true);}
				//Gender/	
				if(tempTeacher.getGender()==Gender.Male) {rdbtnMale.setSelected(true);}
				if(tempTeacher.getGender()==Gender.Female) {rdbtnFemale.setSelected(true);}
			textLessonLength.setText(String.valueOf(tempTeacher.getLessonMinutesLong()));
			textLessonSalary.setText(String.valueOf(tempTeacher.getSalary()));
		}
		else {
			setAreasAsNull();
		}
	}
	
	public static void setAreasAsNull(){
		textPassword.setText("");
		textFirstName.setText("");
		textLastName.setText("");
		textBeginDateDay.setText("");
		textAddress.setText("");
		textPhoneNumber.setText("");
		/*Instrument*/	//No option to rest
		/*Gender*/	//No option to rest
		textLessonLength.setText("");
		textLessonSalary.setText("");
	}
	
	public static String[] setComboBoxAreas() {
		String comboBoxAreas[]=new String[teacherList.size()];
		int k=0;
		for(Teacher i:teacherList) {
			comboBoxAreas[k]=i.getFirstName()+" "+i.getLastName()+" "+i.getId();
			k+=1;
		}
		return comboBoxAreas;
	}
		
	public static void editTeacherApply(){
		try {
			listIndex=comboBox.getSelectedIndex();
			tempTeacher=null;
			tempUser=null;
			/*Active Inputs on temp___ after checking the inputs and throw the alerts and exeptions*/
			Patterns.contentPane=contentPane;
			
			tempTeacher=new Teacher(
					/*String1*/								teacherList.get(listIndex).getId(),
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
			
			tempUser=new User(teacherList.get(listIndex).getId(),textPassword.getText());
			
			if(tempTeacher!=null&&tempUser!=null)
			SqlTeacher.editTeacher(		
					/*String1*/				tempTeacher.getId(),
					/*String2*/				tempUser.getPassword(),
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
/*reload Sql to list*/			teacherList=SqlTeacher.teacherList();
								userList=SqlUser.userList();
/*Set combo box*/				comboBox.setModel(new DefaultComboBoxModel(setComboBoxAreas()));
								comboBox.setSelectedIndex(listIndex);
								F.msg("The teacher is edited!",btnEditUser);
				}
				else {listIndex=-1;F.illegalExeptionMessage("Data Base Error, no teacher edited!", contentPane);}
				F.println();
		} catch (NumberFormatException | Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
	}
	
	
	public static void removeTeacher() {
		try {
		// Delete Teacher list
		if(tempTeacher!=null) {
			listIndex =comboBox.getSelectedIndex();
			tempTeacher=teacherList.get(listIndex);
				findUserByTeacherSetTempUser();
			
			if(teacherInTempList(true)) {
				SqlTeacher.deleteTeacher(teacherList.get(listIndex).getId());
			}
			
			if (Sql.isSql) {
	/*reload Sql to list*/				teacherList=SqlTeacher.teacherList();
										userList=SqlUser.userList();
	/*check from it if delete is done*/	teacherInTempList(false);
										F.println();
				
					if(!teacherList.isEmpty()) {
						F.msg("This teacher is deleted!  ", contentPane);
						int oldListIndex =comboBox.getSelectedIndex();
						comboBox.setModel(new DefaultComboBoxModel(setComboBoxAreas())); //first set ComboBoxAreas
						if(oldListIndex==0) {comboBox.setSelectedIndex(0);} //list is empty
						else {comboBox.setSelectedIndex(oldListIndex-1);} //list go to next upper element
						tempTeacher=teacherList.get(comboBox.getSelectedIndex());
							findUserByTeacherSetTempUser();
						F.println("found "+tempTeacher.getFirstName());
						setAreas();
					}
					else {F.msg("This list is empty! (The last teacher is deleted!)  ", contentPane);
							setAreasAsNull();
							comboBox.setModel(new DefaultComboBoxModel());
							btnDelete.setEnabled(false);
							btnEditUser.setEnabled(false);
					}
			}
			else {tempTeacher=null;tempUser=null;F.illegalExeptionMessage("Data Base Error, no teacher delete!", contentPane);}	
		}
		
		} catch (NumberFormatException | Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
	}
	
	/*check Student inside list on-editing and after-editing*/		//Can't test it properly
	public static boolean teacherInTempList(boolean findTeacher) throws Illegal_Exception_Message {
		for(Teacher i:teacherList) if(i!=null&&tempTeacher.getId().equals(i.getId())){
						if(findTeacher) {//true
							F.println(tempTeacher+ "found and plan to delete!:");
							return true;
						}
						if(!findTeacher) {//false
							tempTeacher=null;
							F.println("Error Teacher not deleted!,He aleardy exist! \\n Please try again!");		
							F.illegalExeptionMessage("Error!, Teacher not deleted!", contentPane);
						}
				}
		return false;
	}
	
	
}