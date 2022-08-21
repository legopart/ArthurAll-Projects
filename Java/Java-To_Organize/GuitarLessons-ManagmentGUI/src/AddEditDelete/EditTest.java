package AddEditDelete;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import Classes.Test;
import Classes.User;
import Exeption.Illegal_Exception_Message;
import Exeption.Patterns;
import Function.F;
import Images.Image;
import Sql.Sql;
import Sql.SqlStudent;
import Sql.SqlTest;

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

public class EditTest extends JFrame {
/***/
	public static ArrayList<Test> testList;
	public static Test tempTest;
	public static int listIndex=-1;
	
	private static JPanel contentPane;	
	public static JComboBox comboBox;
	
	private static JTextField textTestName;
	private static JTextField textLessonSalary;
	private static JTextField textTime;
	private static JTextField textDate;
	public static JButton btnDelete;
	public static JButton btnEditTest;
	public static EditTest frame;
	private JLabel lblTestName;
	
	/**
	 * Launch the application.
	 * main:
	 * @throws Illegal_Exception_Id 
	 * @throws Illegal_Exception_Message 
	 */
	public static void main(String[] args) throws Illegal_Exception_Message {

/***/	testList=SqlTest.testList();// load Sql
		F.println("Test Print Test: "+testList+"\n\n");
		
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					frame = new EditTest();
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
	public EditTest() {
		setTitle("Edit/Delete Test");
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 417, 430);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		btnEditTest = new JButton("Edit Test",Image.edit);
		btnEditTest.setMnemonic('A');
		btnEditTest.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
					
/***/				editTestApply(); //Edit button applied
			}
		});
		btnEditTest.setBounds(22, 307, 140, 33);
		contentPane.add(btnEditTest);
		
		JButton btnBack = new JButton("Back",Image.back);
		btnBack.setMnemonic('B');
		btnBack.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {//Back button

				setVisible(false); 
				dispose();
				System.out.println("EditTest frame is closed.");		
				
			}
		});
		btnBack.setBounds(224, 307, 140, 33);
		contentPane.add(btnBack);
		
		textTestName = new JTextField();
		textTestName.setColumns(15);
		textTestName.setBounds(150, 126, 199, 30);
		contentPane.add(textTestName);
		
		lblTestName = new JLabel("Test Name");
		lblTestName.setBounds(26, 131, 135, 20);
		contentPane.add(lblTestName);
		
		textTime = new JTextField();
		textTime.setToolTipText("0");
		textTime.setColumns(3);
		textTime.setBounds(150, 215, 66, 30);
		contentPane.add(textTime);
		
		JLabel lblTime = new JLabel("Tume");
		lblTime.setBounds(26, 220, 135, 20);
		contentPane.add(lblTime);
		
		JLabel lblBeginDate = new JLabel("Begin Teaching Date");
		lblBeginDate.setBounds(26, 175, 135, 20);
		contentPane.add(lblBeginDate);
		
		JLabel lblTestData = new JLabel("Test Data Edit");
		lblTestData.setBounds(96, 35, 135, 16);
		contentPane.add(lblTestData);
		
		JLabel lblHHmm = new JLabel("(HH:mm)");
		lblHHmm.setBounds(229, 220, 135, 20);
		contentPane.add(lblHHmm);
		
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
		lblDdmmyy.setBounds(302, 175, 62, 20);
		contentPane.add(lblDdmmyy);
		
		comboBox = new JComboBox();
		comboBox.setBounds(54, 80, 310, 22);
		contentPane.add(comboBox);
		
		textDate = new JTextField();
		textDate.setColumns(3);
		textDate.setBounds(150, 170, 127, 30);
		contentPane.add(textDate);
		
		JLabel lblTestId = new JLabel("Test Name,Date, Sysetem Id");
		lblTestId.setBounds(41, 58, 190, 20);
		contentPane.add(lblTestId);
		
		JCheckBox chckbxNewCheckBox = new JCheckBox("Add New Test");
		chckbxNewCheckBox.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				try {
					AddTest.testList=SqlTest.testList();
					F.println("Test Print Test: "+AddTest.testList+"\n\n");
					AddTest pageAddTest= new AddTest();
					pageAddTest.setVisible(true);
					dispose();
				} catch (Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}

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
		if(!testList.isEmpty()) {
			comboBox.setModel(new DefaultComboBoxModel(setComboBoxAreas())); //first set ComboBoxAreas
			comboBox.setSelectedIndex(0);
			tempTest=testList.get(comboBox.getSelectedIndex());
			System.out.println("found"+tempTest.getTestName()+" "+tempTest.getTestDate()+" "+tempTest.getTestTime());
			setAreas();
		}
		else {btnDelete.setEnabled(false);btnEditTest.setEnabled(false);}
	}
	
	public static void updateAreasOnChangeSet() {
		tempTest=testList.get(comboBox.getSelectedIndex());
		System.out.println("found"+tempTest.getTestName()+" "+tempTest.getTestDate()+" "+tempTest.getTestTime());
		setAreas();
	}
	
	public static void confrimeDeleteWindow() {
	       if( JOptionPane.showConfirmDialog(contentPane, "Accept Test Delete?", "Select an Option...",JOptionPane.YES_NO_OPTION)==0)
	    	   removeTest() ;
	}


	public static void setAreas() {
		if(tempTest!=null) {
			textTestName.setText(tempTest.getTestName());
			textDate.setText(tempTest.getTestDate());
			textTime.setText(tempTest.getTestTime());
		}
		else {
			setAreasAsNull();
		}
	}
	
	public static void setAreasAsNull(){
		textTestName.setText("");
		textDate.setText("");
		textTime.setText("");
	}
	
	public static String[] setComboBoxAreas() {
		String comboBoxAreas[]=new String[testList.size()];
		int k=0;
		for(Test i:testList) {
			comboBoxAreas[k]=i.getTestID()+" "+i.getTestName()+" "+i.getTestDate()+" "+i.getTestTime();
			k+=1;
		}
		return comboBoxAreas;
	}
		
	public static void editTestApply(){
		try {
			listIndex=comboBox.getSelectedIndex();
			tempTest=null;
			/*Active Inputs on temp___ after checking the inputs and throw the alerts and exeptions*/
			Patterns.contentPane=contentPane;
			F.println("-->"+testList.get(listIndex).toString());
			tempTest=new Test(testList.get(listIndex).getTestID(), textTestName.getText(), textDate.getText(), textTime.getText() );
			
			if(tempTest!=null)
			SqlTest.editTest(tempTest.getTestID(), tempTest.getTestName(), tempTest.getTestDate(), tempTest.getTestTime() );

			if(Sql.isSql) {
/*reload Sql to list*/			testList=SqlTest.testList();
/*Set combo box*/				comboBox.setModel(new DefaultComboBoxModel(setComboBoxAreas()));
						comboBox.setSelectedIndex(listIndex);
						F.msg("The test is edited!",btnEditTest);
				}
				else {listIndex=-1;F.illegalExeptionMessage("Data Base Error, no test edited!", contentPane);}
				F.println();
		} catch (NumberFormatException | Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
	}
	
	
	public static void removeTest() {
		try {
		// Delete Student list
		
		if(tempTest!=null) {
			listIndex =comboBox.getSelectedIndex();
			tempTest=testList.get(listIndex);
			
			//studentList.remove(tempStudent);
			
			if(testInTempList(true)) {
					SqlTest.deleteCascadeTest(testList.get(listIndex).getTestID());
			}
			
			if (Sql.isSql) {
	/*reload Sql to list*/				testList=SqlTest.testList();
	/*check from it if delete is done*/	testInTempList(false);
										F.println();
				
					if(!testList.isEmpty()) {
						F.msg("This test is deleted!  ", contentPane);
						int oldListIndex =comboBox.getSelectedIndex();
						comboBox.setModel(new DefaultComboBoxModel(setComboBoxAreas())); //first set ComboBoxAreas
						if(oldListIndex==0) {comboBox.setSelectedIndex(0);} //list is empty
						else {comboBox.setSelectedIndex(oldListIndex-1);} //list go to next upper element
						tempTest=testList.get(comboBox.getSelectedIndex());
						F.println("found "+tempTest.getTestID()+" "+tempTest.getTestName()+" "+tempTest.getTestDate()+" "+tempTest.getTestTime());
						setAreas();
					}
					else {F.msg("This list is empty! (The last student is deleted!)  ", contentPane);
							setAreasAsNull();
							comboBox.setModel(new DefaultComboBoxModel());
							btnDelete.setEnabled(false);
							btnEditTest.setEnabled(false);
					}
			}
			else {tempTest=null;F.illegalExeptionMessage("Data Base Error, no test delete!", contentPane);}	
		}
		
		} catch (NumberFormatException | Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
	}
	
	/*check Student inside list on-adding and after-adding*/		//Can't test it properly
	public static boolean testInTempList(boolean findTest) throws Illegal_Exception_Message {
		for(Test i:testList) if(i!=null&&tempTest.getTestID().equals(i.getTestID())){
						if(findTest) {//true
							F.println(tempTest+ "found and plan to delete!:");
							return true;
						}
						if(!findTest) {//false
							tempTest=null;
							F.println("Error Test not deleted!,He aleardy exist! \n Please try again!");		
							F.illegalExeptionMessage("Error!, Test not deleted!", contentPane);
						}
				}
		return false;
	}
	
}