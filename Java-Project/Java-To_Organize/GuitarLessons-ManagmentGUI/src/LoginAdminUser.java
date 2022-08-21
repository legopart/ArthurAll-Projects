
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.border.EmptyBorder;
import javax.swing.border.TitledBorder;

import AddEditDelete.PrintLesson;
import Classes.Admin;
import Classes.User;
import Exeption.Illegal_Exception_Message;
import Function.F;
import Page.PageAdmin;
import Page.PageUser;
import Sql.SqlAdmin;
import Sql.SqlUser;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.UIManager;
import javax.swing.UIManager.LookAndFeelInfo;
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
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

public class LoginAdminUser extends JFrame {
	private JPanel contentPane;
	private static JPasswordField txtPassword;
	private static JTextField txtName;
	private static JButton btnAddUser;
	public static LoginAdminUser frame;
	
	public static Admin tempAdmin;
	public static User tempUser;

	/**
	 * Launch the application.
	 * main:
	 */
	public static void main(String[] args) {
//		deserializeAdmin(fileNameAdmin, adminList);
//		System.out.println("Test Print: "+adminList);
		
//		deserializeUser(fileNameUser, userList);
//		System.out.println("Test Print: "+userList);
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					frame = new LoginAdminUser();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	/*End main*/}

	
	
	/**
	 * Create the frame.
	 */
	public LoginAdminUser() {
		
		try {
		    for (LookAndFeelInfo info : UIManager.getInstalledLookAndFeels()) {
		        if ("Nimbus".equals(info.getName())) {
		            UIManager.setLookAndFeel(info.getClassName());
		            break;
		        }
		        UIManager.put("nimbusBase",new Color(0xBB,0xC3,0xFF));
		        UIManager.put("TitledBorder.position",TitledBorder.CENTER);
		        UIManager.put("nimbusBlueGrey",new Color(0xD1,0xD1,0xD1));
		        UIManager.put("control",new Color(0xEF,0xFB,0xFB));
		    }
		} catch (Exception e) {
		    // If Nimbus is not available, you can set the GUI to another look and feel.
		}
		
		setTitle("Login to User / Admin");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 482, 369);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblId = new JLabel("Password");
		lblId.setBounds(86, 90, 171, 33);
		contentPane.add(lblId);
		
		txtPassword = new JPasswordField();
		txtPassword.addKeyListener(new KeyAdapter() {
			@Override
			public void keyPressed(KeyEvent e) {
				  if(e.getKeyCode() == KeyEvent.VK_ENTER) {
					  loginApply();
					  }
			}
		});
		txtPassword.setBounds(210, 91, 199, 30);
		contentPane.add(txtPassword);
		txtPassword.setColumns(10);
		
		JLabel lblName = new JLabel("ID");
		lblName.setBounds(86, 42, 135, 20);
		contentPane.add(lblName);
		
		txtName = new JTextField();
		txtName.addKeyListener(new KeyAdapter() {
			@Override
			public void keyPressed(KeyEvent e) {
				  if(e.getKeyCode() == KeyEvent.VK_ENTER) {
					  loginApply();
					  }
			}
		});
		txtName.setColumns(10);
		txtName.setBounds(210, 37, 199, 30);
		contentPane.add(txtName);
		
		btnAddUser = new JButton("Login (to user / admin)");
		btnAddUser.setMnemonic('A');
		btnAddUser.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
/***/				loginApply();
	
			}}
		);
		btnAddUser.setBounds(44, 265, 171, 33);
		contentPane.add(btnAddUser);
		
		JButton btnBack = new JButton("Exit");
		btnBack.setMnemonic('B');
		btnBack.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				setVisible(false); 
				dispose();
				System.out.println("AddAdmin frame is closed.");
				
			}
		});
		btnBack.setBounds(275, 265, 162, 33);
		contentPane.add(btnBack);
		
		JLabel lblHint = new JLabel("Hint");
		lblHint.setBounds(86, 136, 56, 16);
		contentPane.add(lblHint);
		
		JLabel lblId_1 = new JLabel("ID: 123");
		lblId_1.setBounds(135, 153, 56, 16);
		contentPane.add(lblId_1);
		
		JLabel lblPasswordAdmin = new JLabel("Password: Admin (for Admin)");
		lblPasswordAdmin.setBounds(135, 180, 192, 16);
		contentPane.add(lblPasswordAdmin);
		
		JLabel lblPasswordUserfro = new JLabel("Password: User (for User)");
		lblPasswordUserfro.setBounds(135, 209, 192, 16);
		contentPane.add(lblPasswordUserfro);
	}

	

	public static void loginApply(){
		try {
		//Get the Admin and the User from SQL and set to temp classes
		tempAdmin=SqlAdmin.tempAdmin(txtName.getText(),txtPassword.getText());
		F.println("Found/not the admin: "+tempAdmin);
		tempUser=SqlUser.tempUser(txtName.getText(),txtPassword.getText());
		F.println("Found/not the user: "+tempUser);				
		
		
		if (tempAdmin!=null) {
			PageAdmin pagePageAdmin= new PageAdmin(); //Send some message to Admin constractor
			pagePageAdmin.setVisible(true);
			
			frame.setVisible(false); 
			frame.dispose();
		}
		else if (tempUser!=null) {
			PageUser pagePageUser= new PageUser(tempUser.getUserName()); //Send some message to User constractor
			pagePageUser.setVisible(true);
			
			frame.setVisible(false); 
			frame.dispose();
		}
		else {F.msg("! User/Admin not found, the entered Id/Password wrong!", btnAddUser);}
		} catch (NumberFormatException | Illegal_Exception_Message e1) {System.err.printf("%s",e1+"\n  \n");}
	}
	
}


