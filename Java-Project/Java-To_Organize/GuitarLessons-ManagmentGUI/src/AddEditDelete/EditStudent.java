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
import javax.swing.JComboBox;
import javax.swing.JCheckBox;

public class EditStudent extends JFrame {
/***/
	public static ArrayList<Student> studentList;
	public static Student tempStudent;
	public static int listIndex=-1;
	
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
	private static JTextField textAcchievement;
	private static JTextField textBeginDateDay;
	private static JTextField textAddress;
	private static JTextField textPhoneNumber;
	public static JButton btnDelete;
	public static JButton btnEditStudent;
	public static EditStudent frame;
	
	/**
	 * Launch the application.
	 * main:
	 * @throws Illegal_Exception_Id 
	 * @throws Illegal_Exception_Message 
	 */
	public static void main(String[] args) throws Illegal_Exception_Message {

/***/	studentList=SqlStudent.studentList();// load Sql
		F.println("Test Print Students: "+studentList+"\n\n");
		
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					frame = new EditStudent();
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
	public EditStudent() {
		setTitle("Edit/Delete Student");
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 417, 860);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		btnEditStudent = new JButton("Edit Student",Image.edit);
		btnEditStudent.setMnemonic('A');
		btnEditStudent.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
					
/***/				editStudentApply(); //Edit button applied
			}
		});
		btnEditStudent.setBounds(22, 767, 140, 33);
		contentPane.add(btnEditStudent);
		
		JButton btnBack = new JButton("Back",Image.back);
		btnBack.setMnemonic('B');
		btnBack.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {//Back button

				setVisible(false); 
				dispose();
				System.out.println("AddStudent frame is closed.");		
				
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
		textAcchievement.setToolTipText("0");
		textAcchievement.setColumns(3);
		textAcchievement.setBounds(165, 352, 66, 30);
		contentPane.add(textAcchievement);
		
		JLabel lblAcchievement = new JLabel("Acchievement");
		lblAcchievement.setBounds(41, 357, 135, 20);
		contentPane.add(lblAcchievement);
		
		JLabel lblBeginDate = new JLabel("Begin Teaching Date");
		lblBeginDate.setBounds(41, 312, 135, 20);
		contentPane.add(lblBeginDate);
		
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
		
		JLabel lblPesonalData = new JLabel("Pesonal Data Edit");
		lblPesonalData.setBounds(96, 35, 135, 16);
		contentPane.add(lblPesonalData);
		
		JLabel lblOptionalData = new JLabel("Personal Data (optional)");
		lblOptionalData.setBounds(96, 469, 152, 16);
		contentPane.add(lblOptionalData);
		
		JLabel lblyears = new JLabel("(years)");
		lblyears.setBounds(244, 357, 135, 20);
		contentPane.add(lblyears);
		
		textAddress = new JTextField();
		textAddress.setColumns(50);
		textAddress.setBounds(165, 499, 199, 30);
		contentPane.add(textAddress);
		
		textPhoneNumber = new JTextField();
		textPhoneNumber.setColumns(3);
		textPhoneNumber.setBounds(165, 545, 140, 30);
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
		
		
/***/ 	// Groups
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
		btnDelete.setBounds(210, 24, 95, 33);
		contentPane.add(btnDelete);
		
		JLabel lblDdmmyy = new JLabel("DD/MM/YY");
		lblDdmmyy.setBounds(317, 312, 62, 20);
		contentPane.add(lblDdmmyy);
		
		comboBox = new JComboBox();
		comboBox.setBounds(54, 80, 310, 22);
		contentPane.add(comboBox);
		
		textBeginDateDay = new JTextField();
		textBeginDateDay.setColumns(3);
		textBeginDateDay.setBounds(165, 307, 127, 30);
		contentPane.add(textBeginDateDay);
		
		JLabel lblFullNameId = new JLabel("Full Name, Id");
		lblFullNameId.setBounds(41, 58, 135, 20);
		contentPane.add(lblFullNameId);
		
		JCheckBox chckbxNewCheckBox = new JCheckBox("Add New Student");
		chckbxNewCheckBox.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
					AddStudent.studentList=SqlStudent.studentList();
					F.println("Test Print Students: "+AddStudent.studentList+"\n\n");
					AddStudent pageAddStudent= new AddStudent();
					pageAddStudent.setVisible(true);
					dispose();
				} catch (Illegal_Exception_Message  e1) {System.err.printf("%s",e1+"\n  \n");}

			}
		});
		chckbxNewCheckBox.setBounds(22, 7, 127, 23);
		contentPane.add(chckbxNewCheckBox);

	comboBox.addItemListener(new ItemListener() {
		public void itemStateChanged(ItemEvent e) {

/***/		updateAreasOnChangeSet(); //update data auto input
		
			}
		});
		
	
/***/			startPageSet(); //first data auto input
	
	}
		
	public static void startPageSet() {
		if(!studentList.isEmpty()) {
			comboBox.setModel(new DefaultComboBoxModel(setComboBoxAreas())); //first set ComboBoxAreas
			comboBox.setSelectedIndex(0);
			tempStudent=studentList.get(comboBox.getSelectedIndex());
			System.out.println("found"+tempStudent.getFirstName());
			setAreas();
		}
		else {btnDelete.setEnabled(false);btnEditStudent.setEnabled(false);}
	}
	
	public static void updateAreasOnChangeSet() {
		tempStudent=studentList.get(comboBox.getSelectedIndex());
		System.out.println("found"+tempStudent.getFirstName());
		setAreas();
	}
	
	public static void confrimeDeleteWindow() {
	       if( JOptionPane.showConfirmDialog(contentPane, "Accept Student Delete?", "Select an Option...",JOptionPane.YES_NO_OPTION)==0)
	    	   removeStudent() ;
	}


	public static void setAreas() {
		if(tempStudent!=null) {
			textFirstName.setText(tempStudent.getFirstName());
			textLastName.setText(tempStudent.getLastName());
			textBeginDateDay.setText(tempStudent.getBegingStudyDate());
			textAddress.setText(tempStudent.getAddress());
			textPhoneNumber.setText(tempStudent.getPhoneNumber());
			//Instrument/	
				if(tempStudent.getInstrument()==Instrument.Guitar) {rdbtnGuitar.setSelected(true);}
				if(tempStudent.getInstrument()==Instrument.Piano) {rdbtnPiano.setSelected(true);}
				if(tempStudent.getInstrument()==Instrument.Accuardion) {rdbtnAccuardion.setSelected(true);}
			//Gender	
				if(tempStudent.getGender()==Gender.Male) {rdbtnMale.setSelected(true);}
				if(tempStudent.getGender()==Gender.Female) {rdbtnFemale.setSelected(true);}
				textAcchievement.setText(String.valueOf(tempStudent.getAcchivementYears()));
		}
		else {
			setAreasAsNull();
		}
	}
	
	public static void setAreasAsNull(){
		textFirstName.setText("");
		textLastName.setText("");
		textBeginDateDay.setText("");
		textAddress.setText("");
		textPhoneNumber.setText("");
		/*Instrument*/	//No option to rest
		/*Gender*/	//No option to rest
		textAcchievement.setText("");
	}
	
	public static String[] setComboBoxAreas() {
		String comboBoxAreas[]=new String[studentList.size()];
		int k=0;
		for(Student i:studentList) {
			comboBoxAreas[k]=i.getFirstName()+" "+i.getLastName()+" "+i.getId();
			k+=1;
		}
		return comboBoxAreas;
	}
		
	public static void editStudentApply(){
		try {
			listIndex=comboBox.getSelectedIndex();
			tempStudent=null;
			/*Active Inputs on temp___ after checking the inputs and throw the alerts and exeptions*/
			Patterns.contentPane=contentPane;
			
			tempStudent=new Student(
				/*String1*/				studentList.get(listIndex).getId(),
				/*String2*/				textFirstName.getText(),
				/*String3*/				textLastName.getText(),
				/*String4*/				textAddress.getText(),
				/*String5*/				textPhoneNumber.getText(),
				/*Instrument String*/	instrument,
				/*Gender String*/		gender,
				/*Date String*/			textBeginDateDay.getText(),
				/*Int String*/			textAcchievement.getText()
			);
			
			if(tempStudent!=null)
			SqlStudent.editStudent(		
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
/*reload Sql to list*/			studentList=SqlStudent.studentList();
/*Set combo box*/				comboBox.setModel(new DefaultComboBoxModel(setComboBoxAreas()));
						comboBox.setSelectedIndex(listIndex);
						F.msg("The student is edited!",btnEditStudent);
				}
				else {listIndex=-1;F.illegalExeptionMessage("Data Base Error, no student edited!", contentPane);}
				F.println();
		} catch (NumberFormatException | Illegal_Exception_Message  e1) {System.err.printf("%s",e1+"\n  \n");}
	}
	
	
	public static void removeStudent() {
		try {
		// Delete Student list
		
		if(tempStudent!=null) {
			listIndex =comboBox.getSelectedIndex();
			tempStudent=studentList.get(listIndex);
			
			//studentList.remove(tempStudent);
			
			if(studentInTempList(true)) {
			SqlStudent.deleteStudent(studentList.get(listIndex).getId());
			}
			
			if (Sql.isSql) {
	/*reload Sql to list*/				studentList=SqlStudent.studentList();
	/*check from it if delete is done*/	studentInTempList(false);
										F.println();
				
					if(!studentList.isEmpty()) {
						F.msg("This student is deleted!  ", contentPane);
						int oldListIndex =comboBox.getSelectedIndex();
						comboBox.setModel(new DefaultComboBoxModel(setComboBoxAreas())); //first set ComboBoxAreas
						if(oldListIndex==0) {comboBox.setSelectedIndex(0);} //list is empty
						else {comboBox.setSelectedIndex(oldListIndex-1);} //list go to next upper element
						tempStudent=studentList.get(comboBox.getSelectedIndex());
						F.println("found "+tempStudent.getFirstName());
						setAreas();
					}
					else {F.msg("This list is empty! (The last student is deleted!)  ", contentPane);
							setAreasAsNull();
							comboBox.setModel(new DefaultComboBoxModel());
							btnDelete.setEnabled(false);
							btnEditStudent.setEnabled(false);
					}
			}
			else {tempStudent=null;F.illegalExeptionMessage("Data Base Error, no student delete!", contentPane);}	
		}
		
		} catch (NumberFormatException | Illegal_Exception_Message  e1) {System.err.printf("%s",e1+"\n  \n");}
	}
	
	/*check Student inside list on-adding and after-adding*/		//Can't test it properly
	public static boolean studentInTempList(boolean findStudent) throws Illegal_Exception_Message {
		for(Student i:studentList) if(i!=null&&tempStudent.getId().equals(i.getId())){
						if(findStudent) {//true
							F.println(tempStudent+ "found and plan to delete!:");
							return true;
						}
						if(!findStudent) {//false
							tempStudent=null;
							F.println("Error Student not deleted!,He aleardy exist! \n Please try again!");		
							F.illegalExeptionMessage("Error!, Student not deleted!", contentPane);
						}
				}
		return false;
	}
	
}