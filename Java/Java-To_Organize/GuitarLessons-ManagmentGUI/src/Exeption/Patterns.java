package Exeption;


import java.util.regex.Pattern;

import javax.swing.JOptionPane;
import javax.swing.JPanel;

		public class Patterns {
			public static JPanel contentPane;
			
			
			public static Boolean firstName(String input) throws Illegal_Exception_Message
			{
				boolean match=Pattern.matches("^[[A-Za-z]][[A-Za-z[,\\\"()][-]]]{1,14}$", input);
					if(!match) {
						JOptionPane.showMessageDialog(contentPane, input+" Wrong first name entered!, most contain only 2-15 letters and ,\\\"()][- signes");	
						throw new Illegal_Exception_Message("\""+ "Wrong first name entered!, most contain only 2-15 letters and ,\"()][- signes");
					}
				return match;
			}
			
			
			public static Boolean lastName(String input) throws Illegal_Exception_Message
			{
				boolean match=Pattern.matches("^[[A-Za-z]][[A-Za-z[,\\\"()][-]]]{1,14}$", input);
					if(!match) {
						JOptionPane.showMessageDialog(contentPane, "Wrong last name entered!, most contain only 2-15 letters and ,\\\"()][- signes");	
						throw new Illegal_Exception_Message("\""+ "Wrong last name entered!, most contain only 2-15 letters and ,\"()][- signes");
					}
				return match;
			}


			public static Boolean lessonLength(String input) throws Illegal_Exception_Message
			{
				boolean match=Pattern.matches("^[0-9]{0,3}$", input)
						||input.isEmpty();
					if(!match) {
						JOptionPane.showMessageDialog(contentPane, "\"Wrong Lesson Length most contain only 1-3 numbers or empty");	
						throw new Illegal_Exception_Message("\""+ "Wrong  Lesson Length  most contain only 1-3 numbers or empty");
					}
				return match;
			}	
			
			
			public static Boolean lessonSalary (String input) throws Illegal_Exception_Message
			{
				boolean match=Pattern.matches("^[0-9]{0,3}$", input)
						||Pattern.matches("^[0-9]{0,3}[.][0-9]{0,2}$", input)
						||input.isEmpty();
					if(!match) {
						JOptionPane.showMessageDialog(contentPane, "\"Wrong Lesson Salary  most contain only 1-3 or like 222.22 numbers or empty");	
						throw new Illegal_Exception_Message("\""+ "Wrong Lesson Salary  most contain only 1-3 numbers or like 222.22 or empty");
					}
				return match;
			}	
			
			public static Boolean acchievement(String input) throws Illegal_Exception_Message
			{
				boolean match=Pattern.matches("^[0-9]{0,3}$", input)
						||input.isEmpty();
					if(!match) {
						JOptionPane.showMessageDialog(contentPane, "\"Wrong Achievement most contain only 1-3 numbers or empty");	
						throw new Illegal_Exception_Message("\""+ "Wrong Achievement most contain only 1-3 numbers or empty");
					}
				return match;
			}	


					public static boolean dateMatch(String dd,String mm, String input) {
						return Pattern.matches("^"+dd+"[/]"+mm+"[/][0-9]{2}$", input);
					}
					
					public static boolean dateMatchCheck(String input) {
						String dd0="[0][1-9]";
						String mm0="[0][1-9]{1,2}";
						String dd1="[12][0-9]";
						String mm1="[1][012]";
						String dd2="[3][01]";
						return 
								dateMatch(dd0,mm0,input)
							||	dateMatch(dd0,mm1,input)
							||	dateMatch(dd1,mm0,input)
							||	dateMatch(dd1,mm1,input)
							||	dateMatch(dd2,mm0,input)
							||	dateMatch(dd2,mm1,input)
								;
					}
			
			public static Boolean date(String input) throws Illegal_Exception_Message
			{
				if (input==null) return true;
				boolean match=input.isEmpty()||dateMatchCheck(input);
					if(!match) {
						JOptionPane.showMessageDialog(contentPane, "Wrong date entered!, most use this format DD/MM/YY and wrote correct  or empty");	
						throw new Illegal_Exception_Message("\""+ "Wrong date entered!, most use this format DD/MM/YY and wrote correct  or empty");
					}
				return match;
			}	
			
			
			public static Boolean phoneNumber(String input) throws Illegal_Exception_Message
			{
				boolean match=Pattern.matches("^[0-9]{5,15}$", input)
						||input.isEmpty();
					if(!match) {
						JOptionPane.showMessageDialog(contentPane, "\"Wrong phone entered!, most contain only 5-15 numbers or empty  ");	
						throw new Illegal_Exception_Message("\""+ "Wrong phone entered!, most contain only 5-15 numbers or empty");
					}
				return match;
			}				
			
			
			public static Boolean address(String input) throws Illegal_Exception_Message
			{
				boolean match=Pattern.matches("^[[A-Za-z0-9[.,\\\"()][-]][ ]]{2,60}$", input)
						||input.isEmpty();
					if(!match) {
						JOptionPane.showMessageDialog(contentPane, "Wrong address entered!, most contain only 2-60 letters, numbers and ,\\\"()][- signes or empty");	
						throw new Illegal_Exception_Message("\""+ "Wrong address entered!, most contain only 2-60 letters, numbers and ,\"()][- signes or empty");
					}
				return match;
			}	
			
			
			
			public static Boolean lessonDate(String input) throws Illegal_Exception_Message
			{
				boolean match=dateMatchCheck(input);
					if(!match) {
						JOptionPane.showMessageDialog(contentPane, "Wrong date entered!, most use this format DD/MM/YY and wrote correct 00/00/00-31/12/99");	
						throw new Illegal_Exception_Message("\""+ "Wrong date entered!, most use this format DD/MM/YY and wrote correct 00/00/00-31/12/99");
					}
				return match;
			}	
			
			public static Boolean lessonTime(String input) throws Illegal_Exception_Message
			{
				boolean match=Pattern.matches("^[01][0-9][:][0-5][0-9]$", input)||
						Pattern.matches("^[2][0-3][:][0-5][0-9]$", input);
					if(!match) {
						JOptionPane.showMessageDialog(contentPane, "Wrong Time entered!, most use this format HH:mm and wrote correct 00:00-23:59");	
						throw new Illegal_Exception_Message("\""+ "Wrong Time entered!, most use this format HH:mm and wrote correct 00:00-23:59");
					}
				return match;
			}	
			
			
			public static Boolean testId(String input) throws Illegal_Exception_Message
			{
				if(input==null) return true;
				boolean match=Pattern.matches("^[0-9]{0,10}$", input)||input.isEmpty();
					if(!match) {	
						throw new Illegal_Exception_Message("\""+ "Wrong ID entered!, most contain only 0-10 numbers or null");
					}
				return match;
			}
			
			public static Boolean testName(String input) throws Illegal_Exception_Message
			{
				boolean match=Pattern.matches("^[[A-Za-z0-9[.,\\\"()][-]][ ]]{2,60}$", input);
					if(!match) {
						JOptionPane.showMessageDialog(contentPane, "Wrong Test Name entered!, most contain only 2-60 letters, numbers and ,\\\"()][- signes");	
						throw new Illegal_Exception_Message("\""+ "Wrong Test Name entered!, most contain only 2-60 letters, numbers and ,\"()][- signes");
					}
				return match;
			}	
			
			public static Boolean testDate(String input) throws Illegal_Exception_Message
			{
				return lessonDate(input);
			}	
			
			public static Boolean testTime(String input) throws Illegal_Exception_Message
			{
				return lessonTime(input);
			}
			
			
			public static Boolean testMark(int input) throws Illegal_Exception_Message
			{
				boolean match=input>=0&&input<=100;
					if(!match) {
						JOptionPane.showMessageDialog(contentPane, "Wrong Mark entered!, most contain only values 0-100");	
						throw new Illegal_Exception_Message("\""+ "Wrong Mark entered!, most contain only values 0-100");
					}
				return match;
			}
			
			public static Boolean id(String input) throws Illegal_Exception_Message
			{
				boolean match=Pattern.matches("^[0-9]{3,10}$", input);
					if(!match) {
						JOptionPane.showMessageDialog(contentPane, "Wrong ID entered!, most contain only 3-10 numbers");	
						throw new Illegal_Exception_Message("\""+ "Wrong ID entered!, most contain only 3-10 numbers");
					}
				return match;
			}
	
	

		public static Boolean password(String input) throws Illegal_Exception_Message
		{
			boolean match=Pattern.matches("^[0-9a-zA-Z]{3,20}$", input);
				if(!match) {
					JOptionPane.showMessageDialog(contentPane, "Wrong Password entered!, most contain only 3-20 characters, numbers or letters");		
					throw new Exeption.Illegal_Exception_Message("\""+ "Wrong Password entered!, most contain only 3-20 characters, numbers or letters");
				}
			return match;
		}


		
		
		
	
}
