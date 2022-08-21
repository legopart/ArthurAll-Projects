package gui;
import java.awt.FlowLayout;

import javax.swing.Icon;
import javax.swing.ImageIcon;
// Fig. 12.7: LabelTest.java
// Testing LabelFrame.
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.SwingConstants;

public class LabelTest extends JFrame
{
	   private final JLabel label1; // JLabel with just text
	   private final JLabel label2; // JLabel constructed with text and icon
	   private final JLabel label3; // JLabel with added text and icon
	   private JLabel  lblNewLabel;
   public static void main(String[] args)
   { 
	  LabelTest labelFrame = new LabelTest(); 
      labelFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      labelFrame.setSize(260, 180); 
      labelFrame.setVisible(true); 
   } 
   
   // LabelFrame constructor adds JLabels to JFrame
   public LabelTest()
   {
      super("Testing JLabel");
      getContentPane().setLayout(new FlowLayout()); // set frame layout

      // JLabel constructor with a string argument
      label1 = new JLabel("Label with text");
      label1.setToolTipText("This is label1");
      getContentPane().add(label1); // add label1 to JFrame

      // JLabel constructor with string, Icon and alignment arguments
      Icon bug = new ImageIcon(getClass().getResource("bug1.png"));

      label3 = new JLabel();
      label3.setVerticalTextPosition(SwingConstants.BOTTOM);
      label3.setVerticalAlignment(SwingConstants.BOTTOM);
      label3.setText("Label with icon and text at bottom");
      label3.setIcon(bug); // add icon to JLabel
      label3.setHorizontalTextPosition(SwingConstants.CENTER);
      label3.setToolTipText("This is label3");
      getContentPane().add(label3);
      
      label2 = new JLabel("Label with text and icon", bug, 
         SwingConstants.LEFT);
      label2.setToolTipText("This is label2");
      getContentPane().add(label2); // add label2 to JFrame
      
      lblNewLabel = new JLabel("New label");
      lblNewLabel.setIcon(bug);
      lblNewLabel.setVerticalTextPosition(SwingConstants.CENTER);
      
      getContentPane().add(lblNewLabel);
   } 
   
} // end class LabelTest


/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
