package AddEditDelete;


import java.awt.BorderLayout;
import java.awt.Button;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.table.DefaultTableModel;

import Classes.Lesson;
import Classes.Student;
import Classes.Teacher;
import Enum.Gender;
import Enum.Instrument;
import Exeption.Illegal_Exception_Message;
import Function.F;
import Function.TableDeleteButtonEditor;
import Function.TableDeleteButtonRenderer;
import Function.TableEditButtonEditor;
import Function.TableEditButtonRenderer;
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
import javax.swing.ComboBoxModel;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

import java.io.ObjectOutputStream;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.awt.event.ActionEvent;
import javax.swing.JRadioButton;
import java.awt.event.ItemListener;
import java.awt.event.ItemEvent;
import javax.swing.JComboBox;
import javax.swing.JTable;
import javax.swing.JScrollBar;
import javax.swing.JInternalFrame;
import javax.swing.JSeparator;
import javax.swing.JTree;
import javax.swing.JList;
import javax.swing.JSpinner;
import javax.swing.JScrollPane;
import java.awt.ComponentOrientation;
import javax.swing.JCheckBox;
import java.awt.FlowLayout;
import java.awt.GridBagLayout;
import java.awt.GridBagConstraints;
import java.awt.Insets;

public class PrintLesson extends JFrame {
	private static JPanel contentPane;
	
	public static ArrayList<Teacher> teacherList;
	public static Teacher tempTeacher;
	public static ArrayList<Student> studentList;
	public static Student tempStudent;
	public static ArrayList<Lesson> lessonListUnsorted;
	public static ArrayList<Lesson> lessonList;
	public static Lesson tempLesson;
	
	public static DefaultTableModel model;
	public static JScrollPane scrollPane;
	public static JTable table;
	
	public static int count=0;
	public static int lessonPlace=0;

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
		lessonListUnsorted=lessonList;
		System.out.println("Test Print Lessons: "+lessonList+"\n\n");
		
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					PrintLesson frame = new PrintLesson();
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
	public PrintLesson() {
		setTitle("Print Leassons");
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 818, 393);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(new BorderLayout(0, 0));
		
		scrollPane = new JScrollPane();
		contentPane.add(scrollPane);
		
		panel = new JPanel();
		panel.setBounds(50, 100, 687, 352);
		contentPane.add(panel, BorderLayout.NORTH);
		GridBagLayout gbl_panel = new GridBagLayout();
		gbl_panel.columnWidths = new int[]{315, 30, 0, 0};
		gbl_panel.rowHeights = new int[]{22, 0};
		gbl_panel.columnWeights = new double[]{0.0, 0.0, 0.0, Double.MIN_VALUE};
		gbl_panel.rowWeights = new double[]{0.0, Double.MIN_VALUE};
		panel.setLayout(gbl_panel);
		
		comboBox = new JComboBox();
		comboBox.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				selectedDate();
			}
		});
		GridBagConstraints gbc_comboBox = new GridBagConstraints();
		gbc_comboBox.insets = new Insets(0, 0, 0, 5);
		gbc_comboBox.anchor = GridBagConstraints.NORTHWEST;
		gbc_comboBox.gridx = 0;
		gbc_comboBox.gridy = 0;
		panel.add(comboBox, gbc_comboBox);
		
		btnNewButton = new JButton("Sort by Student Name",Image.sort);
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				sortByName();
				
			}
		});
		GridBagConstraints gbc_btnNewButton = new GridBagConstraints();
		gbc_btnNewButton.gridx = 2;
		gbc_btnNewButton.gridy = 0;
		panel.add(btnNewButton, gbc_btnNewButton);
		
		panel_1 = new JPanel();
		contentPane.add(panel_1, BorderLayout.SOUTH);
		GridBagLayout gbl_panel_1 = new GridBagLayout();
		gbl_panel_1.columnWidths = new int[]{303, 55, 0, 0, 0, 0, 0, 0};
		gbl_panel_1.rowHeights = new int[]{23, 0};
		gbl_panel_1.columnWeights = new double[]{0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, Double.MIN_VALUE};
		gbl_panel_1.rowWeights = new double[]{0.0, Double.MIN_VALUE};
		panel_1.setLayout(gbl_panel_1);
		
		btnBack = new JButton("Back",Image.back);
		btnBack.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				setVisible(false); 
				dispose();
				F.println("Print Lesson frame is closed.");
				
			}
		});
		GridBagConstraints gbc_btnBack = new GridBagConstraints();
		gbc_btnBack.insets = new Insets(0, 0, 0, 5);
		gbc_btnBack.anchor = GridBagConstraints.NORTHWEST;
		gbc_btnBack.gridx = 4;
		gbc_btnBack.gridy = 0;
		panel_1.add(btnBack, gbc_btnBack);
		
		
		pageStart();
		dates();
		 
	}
	
	
	public static void pageStart(){
		String[][] objArray=new String[lessonList.size()][9];
		int j=0;
			for(Lesson i:lessonList) {
				if(i!=null) {
					objArray[j][0]=""+j;
					if(i.getStudent()!=null) {
					objArray[j][1]=i.getStudent().getId();
					objArray[j][2]=i.getStudent().getFirstName()+" "+i.getStudent().getLastName();
					}
					if(i.getTeacher()!=null) {
					objArray[j][3]=i.getTeacher().getId();
					objArray[j][4]=i.getTeacher().getFirstName()+" "+i.getTeacher().getLastName();
					}
					objArray[j][5]=i.getDate();
					objArray[j][6]=i.getTime();
					objArray[j][7]="edit"+j;
					objArray[j][8]="delete"+j;
					j+=1;
				}	
			}

		model = new DefaultTableModel();
		model.setDataVector(objArray, new String[] {"i","StudentID", "Name", "TeacherID", "Name", "Date", "Time", "Edit", "Delete" });
		table = new JTable();
		table.setModel(model);
		scrollPane.setViewportView(table);
	    table.getColumn("Delete").setCellRenderer(new TableDeleteButtonRenderer());
	    table.getColumn("Delete").setCellEditor(new TableDeleteButtonEditor(new JCheckBox(),"Lesson"));
	    table.getColumn("Edit").setCellRenderer(new TableEditButtonRenderer());
	    table.getColumn("Edit").setCellEditor(new TableEditButtonEditor(new JCheckBox(),"Lesson"));
	}
	
	
	public static void editLesson(int listplace)  {
		tempLesson=null;
		try {
			
			tempLesson= new Lesson(
					lessonList.get(listplace).getStudent(),
					lessonList.get(listplace).getTeacher(),
					lessonList.get(listplace).getLocation(),
					table.getValueAt(listplace, 5).toString(),
					table.getValueAt(listplace, 6).toString()
					);
			F.println("-->" + tempLesson);
			if(tempLesson!=null) {
					/*old lesson update!!!!*/
				int x=0;
				for (Lesson i:lessonListUnsorted) {
					if (
							lessonList.get(listplace).getStudentID().equals(i.getStudentID())
							&&lessonList.get(listplace).getTeacherID().equals(i.getTeacherID())
					//		&&lessonList.get(listplace).getLocation().equals(i.getLocation()) 
							&&lessonList.get(listplace).getDate().equals(i.getDate())
							&&lessonList.get(listplace).getTime().equals(i.getTime()))  break;
					x+=1;
				}
				
				lessonListUnsorted.get(x).setTime(tempLesson.getTime());
				lessonListUnsorted.get(x).setTime(tempLesson.getTime());
				lessonList.get(listplace).setDate(tempLesson.getDate());
				lessonList.get(listplace).setTime(tempLesson.getTime());					
				
				
				SqlLesson.editLesson(tempLesson.getStudentID(), tempLesson.getTeacherID(), tempLesson.getLocation(), tempLesson.getDate(), tempLesson.getTime());
			}
			if(Sql.isSql)
				F.msg("Lesson Edited", contentPane);
			else F.illegalExeptionMessage("lesson not edited", contentPane);
		} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
	}
	
	public static void selectedDate() {
		//String selected=(String) comboBox.getSelectedItem();
		if(comboBox.getSelectedItem().equals("all")) lessonList=lessonListUnsorted;
		else {	
			
			List<Lesson> templessonList = new ArrayList<>(); 
			((List<Lesson>)lessonListUnsorted).stream()
			.filter(i ->i.getDate().equals(comboBox.getSelectedItem()))
			.forEach(e -> templessonList.add(e));
					
			lessonList=(ArrayList<Lesson>) templessonList;

		}
		pageStart();
	}
	
	public static void sortByName() {
		
		List<Lesson> templessonList = new ArrayList<>(); 
		((List<Lesson>)lessonList).stream()
		.sorted(Comparator.comparing(Lesson::getStudentFirstName).thenComparing(Lesson::getStudentLastName))
		.forEach(e -> templessonList.add(e));
				
		lessonList=(ArrayList<Lesson>) templessonList;
		
		pageStart();
	}

	
	public static void dates() {

		List<String> tempdates = new ArrayList<>(); 
		
		((List<Lesson>)lessonList).stream().map(Lesson::getDate)
		.distinct().forEach(e -> tempdates.add(e));

		
		String comboBoxAreas[]=new String[tempdates.size()+1];
		comboBoxAreas[0]="all";
		int k=1;
		for(String i:tempdates) {
			comboBoxAreas[k]=i;
			k+=1;
		}
		
		comboBox.setModel(new DefaultComboBoxModel(comboBoxAreas));
		
		
	}
	
	public static void confrimeRemoveLesson(int lessonPlace1) {
		lessonPlace=lessonPlace1; //lessonPlace set!

	       if( JOptionPane.showConfirmDialog(contentPane, "Accept Lesson Delete?", "Select an Option...",JOptionPane.YES_NO_OPTION)==0)
	    	   removeLesson() ;
		
	}
	
	
	public static void removeLesson() {
		try {
			tempLesson=lessonList.get(lessonPlace);
			
			
			
			if(lessonInTempList(true)) {
				F.println("Lesson info "+tempLesson);
				SqlLesson.deleteCascadeLesson(
						tempLesson.getStudentID(),
						tempLesson.getTeacherID(),
						null,//tempLesson.getLocation(),
						tempLesson.getDate(),
						tempLesson.getTime()
				);
			}
			
			
			if (Sql.isSql) {
				
					lessonList=SqlLesson.lessonList(studentList, teacherList);
					lessonListUnsorted=lessonList;
					F.println("Test Print Lessons: "+lessonList+"\n\n");
					lessonInTempList(false);
					
		pageStart();
		dates();

		F.msg("The lesson is deleted!", contentPane);
		F.println("This Item Deleted! ");
		}
		
		} catch (NumberFormatException | Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
		
	}

	/*check Lesson inside list on-delete and after-delete*/	
	public static boolean deleteFlag=false;
	private JPanel panel;
	private JPanel panel_1;
	private JButton btnBack;
	private static JComboBox comboBox;
	private JButton btnNewButton;
	public static boolean lessonInTempList(boolean findLesson) throws Illegal_Exception_Message {
		for(Lesson i:lessonList) 
				if(i!=null&&i.getTeacher()!=null&&i.getStudent()!=null
						&&tempLesson.getStudentID().equals(i.getStudentID())
						&&tempLesson.getTeacherID().equals(i.getTeacherID())
				//		&&tempLesson.getLocation().equals(i.getLocation()) //Next versions will support
						&&tempLesson.getDate().equals(i.getDate())
						&&tempLesson.getTime().equals(i.getTime())
				){
						if(findLesson) {//true, 
							F.println(tempLesson+ "found and plan to delete!:");
							return true; 
							
						}
						if(!findLesson) {//true
							tempLesson=null;
							F.println("Entered Lesson aleardy exist in list! \n Please try again!");		
							F.illegalExeptionMessage("Entered Lesson is already exsist and not deleted!", contentPane);
						}
				}
		return false;
	}
}