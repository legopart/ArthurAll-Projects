package Function;
import java.awt.Component;

import javax.swing.JButton;
import javax.swing.JTable;
import javax.swing.UIManager;
import javax.swing.table.TableCellRenderer;

import Images.Image;

public class TableEditButtonRenderer extends JButton implements TableCellRenderer {
  
  public TableEditButtonRenderer() {
    setOpaque(true);
  }
   
  public Component getTableCellRendererComponent(JTable table, Object value,
                   boolean isSelected, boolean hasFocus, int row, int column) {
    if (isSelected) {
      setForeground(table.getSelectionForeground());
      setBackground(table.getSelectionBackground());
    } else{
      setForeground(table.getForeground());
      setBackground(UIManager.getColor("Button.background"));
    }
    setText( (value ==null) ? "" : "edit" /*value.toString()*/ );
    setIcon(Image.edit);
    return this;
  }
}