package _Examples;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel; 
import javax.swing.JScrollPane;
import java.awt.FlowLayout;
import javax.swing.ScrollPaneConstants;

public class Table extends JFrame {

	private JPanel contentPane;
	
	//private ResultSetTableModel tableModel; לא עובד
	private DefaultTableModel dataModel;
	private JTable table;
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Table frame = new Table();
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
	public Table() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(new BorderLayout(0, 0));
		
		JScrollPane scrollPane = new JScrollPane();
		contentPane.add(scrollPane, BorderLayout.CENTER);
		
		table = new JTable();
		table.setEnabled(false);
		scrollPane.setViewportView(table);
		

		
		
		String[][] objArray=new String[4][8]; //[lessonList.size()][dataModel.getColumnCount()]
		int j=0;

					objArray[j][0]="0";
					objArray[j][1]="123";
					objArray[j][2]="Arthur";
					objArray[j][3]="456";
					objArray[j][4]="Nizar";
					objArray[j][5]="10/10/10";
					objArray[j][6]="10:10";
					objArray[j][7]="-";
		j+=1;

		
		dataModel = new DefaultTableModel();
		
		dataModel.setDataVector(objArray, new String[] {"i","StudentID", "Name", "TeacherID", "Name", "Date", "Time", "Delete" });
		
		table.setModel(dataModel);

		//dataModel.getValueAt(row, column)
		dataModel.removeRow(1);

		
	}
}
