package Function;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.table.*;

import AddEditDelete.PrintLesson;
import AddEditDelete.PrintTestMark;
import Images.Image;

public class TableDeleteButtonEditor extends DefaultCellEditor {
  protected JButton button;
  private String    label;
  private boolean   isPushed;
  
  public TableDeleteButtonEditor(JCheckBox checkBox,String caller) {
    super(checkBox);
    button = new JButton();
    button.setOpaque(true);
    button.addActionListener(new ActionListener() {
      public void actionPerformed(ActionEvent e) {
			F.println(label +" Preper to delete:");
				/*Delete user from list and Delete Teacher list*/
			 		StringBuilder buffer  = new StringBuilder(label);
			 		buffer.delete(0, 6);
					if(caller.equals("Lesson"))PrintLesson.confrimeRemoveLesson(Integer.parseInt(buffer.toString()));
					if(caller.equals("TestMark"))PrintTestMark.confrimeRemoveTestMark(Integer.parseInt(buffer.toString()));
    	  fireEditingStopped();
      }
    });
  }
  
  public Component getTableCellEditorComponent(JTable table, Object value,
                   boolean isSelected, int row, int column) {
    if (isSelected) {
      button.setForeground(table.getSelectionForeground());
      button.setBackground(table.getSelectionBackground());
      
    } else{
      button.setForeground(table.getForeground());
      button.setBackground(table.getBackground());
    }
    label = (value ==null) ? "" : value.toString();
    button.setText( label );
   // button.setIcon(Image.delete);
    isPushed = true;
    return button;
  }
  
  public Object getCellEditorValue() {
    if (isPushed)  {
  
    	isPushed = false;
    }

    return new String( label ) ;
  }
    
  public boolean stopCellEditing() {
    isPushed = false;
    return super.stopCellEditing();
  }
  
  // protected void fireEditingStopped() {
  //	super.fireEditingStopped();
  // }
}