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
import Classes.Test;
import Classes.TestMark;
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
import Sql.SqlTest;
import Sql.SqlTestMark;

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

public class PrintTestMark extends JFrame {
	private static JPanel contentPane;
	
	public static ArrayList<Test> testList;
	public static Test tempTest;
	public static ArrayList<Student> studentList;
	public static Student tempStudent;
	public static ArrayList<TestMark> testMarkListUnsorted;
	public static ArrayList<TestMark> testMarkList;
	public static TestMark tempTestMark;
	
	
	public static DefaultTableModel model;
	public static JScrollPane scrollPane;
	public static JTable table;
	
	public static int count=0;
	public static int testMarkPlace=0;

	/**
	 * Launch the application.
	 * main:
	 * @throws Illegal_Exception_Id 
	 * @throws Illegal_Exception_Message 
	 */
	public static void main(String[] args) throws Illegal_Exception_Message  {

/***/	testList=SqlTest.testList();// load Sql
		F.println("Test Print Tests: "+testList+"\n\n");
		studentList=SqlStudent.studentList(false);// load Sql
		F.println("Test Print Students: "+studentList+"\n\n");
		testMarkList=SqlTestMark.testMarkList(testList, studentList);// load Sql
		testMarkListUnsorted=testMarkList;
		System.out.println("Test Print Test Marks: "+testMarkList+"\n\n");
		
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					PrintTestMark frame = new PrintTestMark();
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
	public PrintTestMark() {
		setTitle("Print Test Marks");
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 792, 399);
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
		
		btnNewButton = new JButton("Sort by Mark",Image.sort);
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				sortByMark();
				
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
				F.println("Print TestMark frame is closed.");
				
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
		dates(); 
	}
	
	
	public static void pageStart(){
		String[][] objArray=new String[testMarkList.size()][9];
		int j=0;
			for(TestMark i:testMarkList) {
				if(i!=null) {
					objArray[j][0]=""+j;
					if(i.getTest()!=null) {
					objArray[j][1]=i.getTest().getTestID();
					objArray[j][2]=i.getTest().getTestName();
					objArray[j][3]=i.getTest().getTestDate();
					}
					if(i.getStudent()!=null) {
					objArray[j][4]=i.getStudent().getId();
					objArray[j][5]=i.getStudent().getFirstName()+" "+i.getStudent().getLastName();
					}
					objArray[j][6]=""+i.getMark();
					objArray[j][7]="edit"+j;
					objArray[j][8]="delete"+j;
					j+=1;
				}	
			}

		model = new DefaultTableModel();
		model.setDataVector(objArray, new String[] {"i","TestID", "Name", "Date", "StudentID", "Name", "Mark", "Edit", "Delete" });
		table = new JTable();
		table.setModel(model);
		scrollPane.setViewportView(table);
	    table.getColumn("Delete").setCellRenderer(new TableDeleteButtonRenderer());
	    table.getColumn("Delete").setCellEditor(new TableDeleteButtonEditor(new JCheckBox(),"TestMark"));
	    table.getColumn("Edit").setCellRenderer(new TableEditButtonRenderer());
	    table.getColumn("Edit").setCellEditor(new TableEditButtonEditor(new JCheckBox(),"TestMark"));
	}
	
	
	public static void editTestMark(int listplace)  {
		tempTestMark=null;
	//	F.println("-->"+table.getValueAt(listplace, 5).toString());
		try {

			tempTestMark= new TestMark(
					testMarkList.get(listplace).getTest(),
					testMarkList.get(listplace).getStudent(),
					null,
					F.stringInt(table.getValueAt(listplace, 6).toString())
					);
			
			if(tempTestMark!=null)
			
				SqlTestMark.editTestMark(tempTestMark.getTestID(), tempTestMark.getStudentID(), null, tempTestMark.getMark());
			if(Sql.isSql)
				F.msg("Test Mark Edited", contentPane);
			else F.illegalExeptionMessage("Test Mark not edited", contentPane);
		} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
	}
	
	
	public static void selectedDate() {
		//String selected=(String) comboBox.getSelectedItem();
		if(comboBox.getSelectedItem().equals("all")) testMarkList=testMarkListUnsorted;
		else {	
			
			List<TestMark> tempTestMarkList = new ArrayList<>(); 
			((List<TestMark>)testMarkListUnsorted).stream()
			.filter(i ->i.getTest().getTestDate().equals(comboBox.getSelectedItem()))
			.forEach(e -> tempTestMarkList.add(e));
					
			testMarkList=(ArrayList<TestMark>) tempTestMarkList;
		}
		pageStart();
	}
	
	public static void sortByMark() {
		
		List<TestMark> tempTestMarkList = new ArrayList<>(); 
		((List<TestMark>)testMarkList).stream()
		.sorted(Comparator.comparing(TestMark::getMark).reversed())
		.forEach(e -> tempTestMarkList.add(e));
				
		testMarkList=(ArrayList<TestMark>) tempTestMarkList;
		
		pageStart();
	}

	
	public static void dates() {

		List<String> tempdates = new ArrayList<>(); 
		
		((List<TestMark>)testMarkList).stream().map(TestMark::getTestDate)
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
	
	

	public static void confrimeRemoveTestMark(int testMarkPlace1) {
		testMarkPlace=testMarkPlace1; //lessonPlace set!
	       if( JOptionPane.showConfirmDialog(contentPane, "Accept Test Mark Delete?", "Select an Option...",JOptionPane.YES_NO_OPTION)==0)
	    	   removeTestMark() ;
	}
	
	
	public static void removeTestMark() {
		try {
			tempTestMark=testMarkList.get(testMarkPlace);
			if(testMarkInTempList(true)) {
				F.println("TestMark info "+tempTestMark);
				SqlTestMark.deleteCascadeTestMark(
						tempTestMark.getTestID(),
						tempTestMark.getStudentID()
						//null,//tempTestMark.getTeacherID(),
						//tempTestMark.getMark()
				);
			}
			
			
			if (Sql.isSql) {
				
					testMarkList=SqlTestMark.testMarkList(testList, studentList);
					testMarkListUnsorted=testMarkList;
					F.println("Test Print TestMark: "+testMarkList+"\n\n");
					testMarkInTempList(false);
					
		pageStart();
		dates();

		F.msg("The Test Mark is deleted!", contentPane);
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
	public static boolean testMarkInTempList(boolean findTestMark) throws Illegal_Exception_Message {
		for(TestMark i:testMarkList)
				if(i!=null&&i.getTest()!=null&&i.getStudent()!=null //&&i.getTeacher()!=null&
						&&tempTestMark.getTestID().equals(i.getTestID())
						&&tempTestMark.getStudentID().equals(i.getStudentID())
						//&&tempTestMark.getTeacherID().equals(i.getTeacherID())
				){
						if(findTestMark) {//true, 
							F.println(tempTestMark+ "found and plan to delete!:");
							return true; 

						}
						if(!findTestMark) {//false
							tempTestMark=null;
							F.println("TestMark not deleted and aleardy exist! \n Please try again!");		
							F.illegalExeptionMessage("TestMark not deleted and already exsist", contentPane);
						}
				}
		return false;
	}
}