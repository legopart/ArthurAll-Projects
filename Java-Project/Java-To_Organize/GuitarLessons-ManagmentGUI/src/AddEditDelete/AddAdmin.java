package AddEditDelete;
import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import Classes.Admin;
import Exeption.Illegal_Exception_Message;
import Exeption.Patterns;
import Function.F;
import Images.Image;
import Sql.Sql;
import Sql.SqlAdmin;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.Arrays;
import java.awt.event.ActionEvent;

public class AddAdmin extends JFrame {
	private static JPanel contentPane;
	private static JTextField txtPassword;
	private static JTextField txtName;
	public static JButton btnAddUser;
	
	public static ArrayList<Admin> adminList;
	public static Admin tempAdmin;



	/**
	 * Launch the application.
	 * main:
	 * @throws Illegal_Exception_Message 
	 */
	public static void main(String[] args) throws Illegal_Exception_Message {
		
/***/	adminList=SqlAdmin.adminList();
		F.println("Test Print: "+adminList);

		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					AddAdmin frame = new AddAdmin();
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
	public AddAdmin() {
		setTitle("Add Admin");
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblId = new JLabel("Password");
		lblId.setBounds(41, 114, 171, 33);
		contentPane.add(lblId);
		
		txtPassword = new JTextField();
		txtPassword.setBounds(165, 115, 199, 30);
		contentPane.add(txtPassword);
		txtPassword.setColumns(10);
		
		JLabel lblName = new JLabel("ID");
		lblName.setBounds(41, 66, 135, 20);
		contentPane.add(lblName);
		
		txtName = new JTextField();
		txtName.setColumns(10);
		txtName.setBounds(165, 61, 199, 30);
		contentPane.add(txtName);
		
		btnAddUser = new JButton("ADD Admin",Image.add);
		btnAddUser.setMnemonic('A');
		btnAddUser.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
/***/			addAdminApply();
				
			}
		});
		btnAddUser.setBounds(72, 176, 140, 33);
		contentPane.add(btnAddUser);
		
		JButton btnBack = new JButton("Back",Image.back);
		btnBack.setMnemonic('B');
		btnBack.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				setVisible(false); 
				dispose();
				F.println("AddAdmin frame is closed.");
			}
		});
		btnBack.setBounds(224, 176, 140, 33);
		contentPane.add(btnBack);
	}
	
	
	
	public static void addAdminApply(){
		try {
/*Active Inputs on temp___ after checking the inputs and throw the alerts and exeptions*/
		tempAdmin=null;
		Patterns.contentPane=contentPane;
		
		tempAdmin = new Admin(txtName.getText(), txtPassword.getText());
		
/*List similarity, already available check*/					
		adminInTempList(false);
		
/*!*/			if(tempAdmin!=null) {
						SqlAdmin.addAdmin(tempAdmin.getUserName(),tempAdmin.getPassword());
								if(Sql.isSql) {
/*reload Sql to list*/			adminList=SqlAdmin.adminList();
/*check from it if added done*/		adminInTempList(true);
								F.println();
								}
								else {tempAdmin=null;F.illegalExeptionMessage("Data Base Error, no admin aded!", contentPane);}
				}
		}catch(NumberFormatException | Exeption.Illegal_Exception_Message e1){System.err.printf("%s",e1+"\n  \n");}
	}
	
	
	
	/*check Admin inside list on-adding and after-adding*/
	public static void adminInTempList(boolean findAdmin) throws Illegal_Exception_Message {
		for(Admin i:adminList)  
			if(i!=null) {
				if(tempAdmin.getUserName().equals(i.getUserName())){
						if(findAdmin) {
						F.msg("Admin is added!", btnAddUser); 
						F.println(tempAdmin+ "is added!");
						}
						if(!findAdmin) {
							tempAdmin=null;
							F.illegalExeptionMessage("Entered ID: "+ txtName.getText() + " aleardy exist! \n Please try again!", contentPane);
						}
					}
			}
	}


}


