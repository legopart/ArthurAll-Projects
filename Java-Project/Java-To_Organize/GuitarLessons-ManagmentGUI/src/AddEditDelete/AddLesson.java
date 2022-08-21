package AddEditDelete;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import Classes.Lesson;
import Classes.Student;
import Classes.Teacher;
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

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.AbstractButton;
import javax.swing.ButtonGroup;
import javax.swing.DefaultComboBoxModel;
import javax.swing.Icon;
import javax.swing.ImageIcon;
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

public class AddLesson extends JFrame {
	private static JPanel contentPane;
	
	public static ArrayList<Lesson> lessonList;
	public static Lesson tempLesson;
	public static ArrayList<Teacher> teacherList;
	public static Teacher tempTeacher;
	public static ArrayList<Student> studentList;
	public static Student tempStudent;

	public static JComboBox comboBoxStudent;
	public static JComboBox comboBoxTeacher;
	public static Instrument instrument;
	public static Gender gender;
	public static JButton btnAddLesson;
	private static JTextField textLessonTime;
	private static JTextField textLessonDate;


	/**
	 * Launch the application.
	 * main:
	 * @throws Illegal_Exception_Id 
	 * @throws Illegal_Exception_Message 
	 */
	public static void main(String[] args) throws Illegal_Exception_Message {

/***/	teacherList=SqlTeacher.teacherList();// load Sql
		F.println("Test Print Teachers: "+teacherList+"\n\n");
		studentList=SqlStudent.studentList();// load Sql
		F.println("Test Print Students: "+studentList+"\n\n");
		lessonList=SqlLesson.lessonList(studentList, teacherList);// load Sql
		System.out.println("Test Print Lessons: "+lessonList+"\n\n");
		
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					AddLesson frame = new AddLesson();
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
	public AddLesson() {
		setTitle("Add Leason");
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 417, 431);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblName = new JLabel("IDTecher");
		lblName.setBounds(41, 75, 135, 20);
		contentPane.add(lblName);
		
		btnAddLesson = new JButton("ADD Lesson",Image.add);
		btnAddLesson.setMnemonic('A');
		btnAddLesson.addActionListener(new ActionListener() {
/*Creating Event*/			public void actionPerformed(ActionEvent e) {
	
/***/						addLessonApply();

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
				System.out.println("AddLesson frame is closed.");
				
			}
		});
		btnBack.setBounds(224, 330, 140, 33);
		contentPane.add(btnBack);
		
		textLessonTime = new JTextField();
		textLessonTime.setColumns(3);
		textLessonTime.setBounds(165, 264, 80, 30);
		contentPane.add(textLessonTime);
		
		JLabel lblLessonLength = new JLabel("Lesson Time");
		lblLessonLength.setBounds(41, 269, 135, 20);
		contentPane.add(lblLessonLength);
		
		JLabel lblDate = new JLabel("Lesson Date");
		lblDate.setBounds(41, 224, 135, 20);
		contentPane.add(lblDate);
		
		textLessonDate = new JTextField();
		textLessonDate.setColumns(2);
		textLessonDate.setBounds(165, 221, 135, 30);
		contentPane.add(textLessonDate);
		
		JLabel lblPesonalData = new JLabel("Lesson Data");
		lblPesonalData.setBounds(96, 35, 135, 16);
		contentPane.add(lblPesonalData);
		
		JLabel lblmin = new JLabel("HH:mm");
		lblmin.setBounds(252, 269, 135, 20);
		contentPane.add(lblmin);
		
		JLabel label_2 = new JLabel("-");
		label_2.setBounds(234, 552, 14, 16);
		contentPane.add(label_2);
		

		JLabel lblDdmmyy = new JLabel("DD/MM/YY");
		lblDdmmyy.setBounds(312, 224, 103, 20);
		contentPane.add(lblDdmmyy);
		
		JLabel lblIdstudent = new JLabel("IDStudent");
		lblIdstudent.setBounds(41, 121, 135, 20);
		contentPane.add(lblIdstudent);
		
		JLabel lblLocation = new JLabel("Location (optional)");
		lblLocation.setBounds(41, 176, 135, 20);
		contentPane.add(lblLocation);
		
		JRadioButton rdbtnClassRoom = new JRadioButton("Classroom");
		rdbtnClassRoom.setSelected(true);
		rdbtnClassRoom.setBounds(184, 174, 127, 25);
		contentPane.add(rdbtnClassRoom);

		/***/ // Groups
		ButtonGroup groupLocation = new ButtonGroup();
		groupLocation.add(rdbtnClassRoom);
		
		comboBoxTeacher = new JComboBox();
		comboBoxTeacher.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent arg0) {
				
/***/				updateCheckedTeacher(); 
				
			}
		});
		comboBoxTeacher.setBounds(123, 74, 248, 22);
		contentPane.add(comboBoxTeacher);
		
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
			if(!teacherList.isEmpty()) {
				comboBoxTeacher.setModel(new DefaultComboBoxModel(setComboBoxAreasTeacher())); //first set ComboBoxAreas
				comboBoxTeacher.setSelectedIndex(0);
				tempTeacher=teacherList.get(comboBoxTeacher.getSelectedIndex());
				F.println("found "+tempTeacher.getFirstName());
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
		String comboBoxAreas[]=new String[teacherList.size()];
		int k=0;
		for(Teacher i:teacherList) {
			comboBoxAreas[k]=i.getFirstName()+" "+i.getLastName()+" "+i.getId();
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
	
	
	
	public static void addLessonApply(){
		try {/*Active Inputs on temp___ after checking the inputs and throw the alerts and exeptions*/
				int listIndexTeacher=comboBoxTeacher.getSelectedIndex();				
				tempTeacher=teacherList.get(listIndexTeacher);
				int listIndexStudent=comboBoxStudent.getSelectedIndex();				
				tempStudent=studentList.get(listIndexStudent);
				
				tempLesson=null;
				Patterns.contentPane=contentPane;
					tempLesson = new Lesson(
		/*Student*/								tempStudent,
		/*Teacher*/								tempTeacher,
		/*String location*/						null,
		/*String date*/							textLessonDate.getText(),
		/*String time*/							textLessonTime.getText()
					);


				/*List similarity, already available check*/		
				lessonInTempList(false);
				
		/*!*/		if(tempLesson!=null) {
			

					checkLessonPeriod();
							
					SqlLesson.addLesson(
							/*String1*/								tempLesson.getStudentID(),
							/*String2*/								tempLesson.getTeacherID(),
							/*String3*/								tempLesson.getLocation(),
							/*String4*/								tempLesson.getDate(),
							/*String5*/								tempLesson.getTime()
							);
					
						if(Sql.isSql) {
	/*reload Sql to list*/				lessonList=SqlLesson.lessonList(studentList, teacherList);
	/*check from it if added done*/		if(!lessonInTempList(true)) F.msg("Lesson not added", btnAddLesson);
										F.println();
						}
						else {tempStudent=null;F.illegalExeptionMessage("Data Base Error, no Lesson added!", contentPane);}
				}
		} catch (NumberFormatException | Illegal_Exception_Message  e1) {System.err.printf("%s",e1+"\n  \n");}
	}

	public static void checkLessonPeriod() throws Illegal_Exception_Message{
	for(Lesson i:lessonList) {
	if(i!=null&&i.getTeacher()!=null&&i.getStudent()!=null
			&&(tempLesson.getStudentID().equals(i.getStudentID())||tempLesson.getTeacherID().equals(i.getTeacherID()))
			&&tempLesson.getDate().equals(i.getDate())
			&&F.time(tempLesson.getTime(),i.getTime(),tempTeacher.getLessonMinutesLong())
	) {
		F.illegalExeptionMessage("lesson exsist for this teacher on this time period of: "+tempLesson.getTeacher().getLessonMinutesLong()+"(min)", btnAddLesson);				 
	}}
	}
	
	public static void updateCheckedTeacher() { 
			tempTeacher=teacherList.get(comboBoxTeacher.getSelectedIndex());
			F.println("found "+tempTeacher.getFirstName());
	}
	
	public static void updateCheckedStudent() { 
			tempStudent=studentList.get(comboBoxStudent.getSelectedIndex());
			F.println("found "+tempStudent.getFirstName());
	}
	
	
	/*check Lesson inside list on-adding and after-adding*/
	public static boolean lessonInTempList(boolean findLesson) throws Illegal_Exception_Message {
		for(Lesson i:lessonList) 
				if(i!=null&&i.getTeacher()!=null&&i.getStudent()!=null
						&&tempLesson.getStudentID().equals(i.getStudentID())
						&&tempLesson.getTeacherID().equals(i.getTeacherID())
				//		&&tempLesson.getLocation().equals(i.getLocation()) //Next versions will support
						&&tempLesson.getDate().equals(i.getDate())
						&&tempLesson.getTime().equals(i.getTime())
				){
						if(findLesson) {//true
							F.msg("New Lesson is added ", btnAddLesson); 
							F.println(tempLesson+ "is added!");
							return true;
						}
						if(!findLesson) {//false
							tempLesson=null;
							F.println("Entered Lesson aleardy exist! \n Please try again!");		
							F.illegalExeptionMessage("Entered Lesson is already exsist", btnAddLesson);
						}
				}
		return false;
	}
	
	
}


