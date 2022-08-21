import java.util.ArrayList;
import java.util.Scanner;

import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.Map;
import java.util.TreeMap;
import java.util.function.Function;
import java.util.function.Predicate;
import java.util.stream.Collectors;

public class Main {
		public static Scanner input=new Scanner(System.in);
		public static ArrayList<Person> personList = new ArrayList<Person>();
		public static ArrayList<Test> testList = new ArrayList<Test>();
		public static ArrayList<TestMark> testMarkList = new ArrayList<TestMark>();
		public static ArrayList<Lesson> lessonList = new ArrayList<Lesson>();
		public static void personExistExeption(String id1) throws Illegal_Exception_Message {
			for(Person i:personList) 
				if(id1.compareTo(i.getId())==0) {throw new Illegal_Exception_Message("\""+id1 + "\" --person id is exist!");}			
		}
		
		
		public static void main(String[] args) throws Illegal_Exception_Message, Illegal_Exception_Id {
		
			//tempruary experiments:
			personList.add(new Student("001","HaimB", "Vizman"));
			personList.add(new Teacher("002","ROTHI", "Vizman"));
			personList.add(new Teacher("000","HAIMA", "Vizman"));
			testList.add(new Test(1,"Guitar", "01/01/2011"));
			testMarkList.add(
					new TestMark(
						testList.get(0),
						((Student)personList.get(0)),
						((Teacher)personList.get(1)),					
						100
					)
					
			);
			lessonList.add(
					new Lesson(
							((Student)personList.get(0)),
							((Teacher)personList.get(1)),	
							"Home",
							"10-3-2020",
							"15:30"
							)
					);
			
			personList.add(new Student("000001","Haim", "Vizman"));
			testList.add(new Test(1,"Guitar", "10-3-23"));
			
			
				
		

		

		
		int x;
		do {
			System.out.println(
					"Please input choose\n"+
					"1- create Teacher\n"+
					"2- create Student\n"+
					"3- create Test\n"+
					"4- create test mark\n"+
					"5- create lesson\n"+
					"6- print all data classified\n"+
					"0-exit\n");
			x=input.nextInt();
			switch(x) {
			case 0: ;
			break;
			case 1: 
				try {
				System.out.println(
						"1- create Teacher\n"+
						"Please input the ID of the teacher:"
						);
				String id=input.next();
					personExistExeption(id);
						
				System.out.println("Please input the first name of the teacher:");
				String fname=input.next();
				System.out.println("Please input the last name of the teacher:");
				String lname=input.next();
				personList.add(new Teacher(id, fname, lname));
				}
				catch(Illegal_Exception_Message| Illegal_Exception_Id e1){
					System.err.printf("%s",e1+"\n You returned to first menu, please choose \n");
				}
			;
			break;
			case 2: 
				try {
				System.out.println(
						"2- create Student\n"+
						"Please input the ID of the student:"
						);
				String id=input.next();
				personExistExeption(id);
				System.out.println("Please input the first name of the student:");
				String fname=input.next();
				System.out.println("Please input the last name of the student:");
				String lname=input.next();
				personList.add(new Student(id, fname, lname));
				}
				catch(Illegal_Exception_Message| Illegal_Exception_Id e1){
					System.err.printf("%s",e1+"\n You returned to first menu, please choose \n");
				}
			;
			break;
			case 3:
				try {
				System.out.println(
						"3- create Test\n"+
						"Please input the ID of the test:"
						);

				int id=input.nextInt();
				for(Test i:testList) 
					if(id==i.getTestID()) {throw new Illegal_Exception_Message("\""+id + "\" --test id is exist!");}



				System.out.println("Please input the name of the test:");
				String name=input.next();
				System.out.println("Please input the date of the test:");
				String date=input.next();
				testList.add(new Test(id, name, date));
				}
				catch(Illegal_Exception_Message| Illegal_Exception_Id e1){
					System.err.printf("%s",e1+"\n You returned to first menu, please choose \n");
				}
				;
			break;
			case 4:
				try {
				System.out.println(
						"4- create Test Mark\n"+
						"Please input the ID of existing test:"
						);
				int idTest=input.nextInt();
					Test tmpTest = null;
					for(Test i:testList)
						if(idTest==i.getTestID()) tmpTest=i;
					if(tmpTest == null) throw new Illegal_Exception_Message("\""+idTest + "\" --test Id not found!");
	
					
				System.out.println("Please input the ID of existing student:");
				String idStudent=input.next();
					Student tmpStudent = null;
					for(Person i:personList) {
						if(idStudent.compareTo(i.getId())==0) {
							if(i instanceof Student) {tmpStudent=((Student)i);}
							else {throw new Illegal_Exception_Message("\""+idStudent + "\" --student Id  is not a student!");}
						}
					}
					if(tmpStudent == null) throw new Illegal_Exception_Message("\""+idStudent + "\" --student Id not found!");
				

					System.out.println("Please input the ID of existing teacher:");
					String idTeacher=input.next();
						Teacher tmpTeacher = null;
						for(Person i:personList) {			
							if(idTeacher.compareTo(i.getId())==0) {
								if(i instanceof Teacher) {tmpTeacher=((Teacher)i);}
								else {throw new Illegal_Exception_Message("\""+idTeacher + "\" --teacher Id  is not a teacher!");}
							}
						}
						if(tmpTeacher == null) throw new Illegal_Exception_Message("\""+idTeacher + "\" --teacher Id not found!");

					
				System.out.println("Please input the mark of the test:");
				int mark=input.nextInt();

				
				for(TestMark i:testMarkList) 
					if(tmpTest==i.getTest()&&tmpStudent==i.getStudent()&&tmpTeacher==i.getTeacher())
						{throw new Illegal_Exception_Message("\""+ "Entered test mark exsist" + "\" --test mark is exist!");}
				
				testMarkList.add(new TestMark(tmpTest, tmpStudent, tmpTeacher, mark));

				}
				catch(Illegal_Exception_Message e1){
					System.err.printf("%s",e1+"\n You returned to first menu, please choose \n");
				}
				;
			break;
			case 5:
				//try {
				System.out.println(
						"5- create Lesson\n"+
						"Please input the ID of existing student:"
						);
				String idStudent=input.next();
					Student tmpStudent = null;
					for(Person i:personList) {
						if(idStudent.compareTo(i.getId())==0) {
							if(i instanceof Student) {tmpStudent=((Student)i);}
							else {throw new Illegal_Exception_Message("\""+idStudent + "\" --student Id  is not a student!");}
						}
					}
					if(tmpStudent == null) throw new Illegal_Exception_Message("\""+idStudent + "\" --student Id not found!");

					System.out.println("Please input the ID of existing teacher:");
					String idTeacher=input.next();
						Teacher tmpTeacher = null;
						for(Person i:personList) {
							if(idTeacher.compareTo(i.getId())==0) {
								if(i instanceof Teacher) {tmpTeacher=((Teacher)i);}
								else {throw new Illegal_Exception_Message("\""+idTeacher + "\" --teacher Id  is not a teacher!");}
							}
						}
						if(tmpTeacher == null) throw new Illegal_Exception_Message("\""+idTeacher + "\" --teacher Id not found!");
						
					System.out.println("Please input the Location of the lesson:");
					String location=input.next();
					
					System.out.println("Please input the Date of the lesson:");
					String date=input.next();
					
					System.out.println("Please input the Time of the lesson:");
					String time=input.next();
					
				System.out.println("Please input the mark of the test:");
				int mark=input.nextInt();

				for(Lesson i:lessonList) 
					if(tmpStudent==i.getStudent()&&tmpTeacher==i.getTeacher()&&i.getDate()==date)
						{throw new Illegal_Exception_Message("\""+ "Entered lesson is exsist" + "\" --  the lesson is exist!");}

				lessonList.add(new Lesson(tmpStudent, tmpTeacher, location, date, time));

				
				/*}
				/*catch(Illegal_Exception_Message e1){
					System.err.printf("%s",e1+"\n You returned to first menu, please choose \n");
				}/**/
				;
			break;
			case 6:
				System.out.println("all the Teachers:");
				personList.stream()
					.sorted(Comparator.comparing(Person::getId))
					.filter(i -> i instanceof Teacher)
					.forEach(System.out::println);
					/*for(Person p:personList) {
						if (p instanceof Teacher) {
						System.out.println(((Teacher)p))	;
						}
					}*/
				System.out.println("all the Students:");
				personList.stream()
				.sorted(Comparator.comparing(Person::getId))
				.filter(i -> i instanceof Student)
				.forEach(System.out::println);
				
					/*for(Person p:personList) {
						if (p instanceof Student) {
						System.out.println(((Student)p))	;
						}
					}*/
				System.out.println("all the Test:");				
				testList.stream()
				.sorted(Comparator.comparing(Test::getTestID))
				.forEach(System.out::println);
				
					/*for(Test t:testList) {
						System.out.println(t);
					}*/
				System.out.println("all the Marks:");
					testMarkList.stream()
					.sorted(Comparator.comparing(TestMark::getTestID)
							.thenComparing(TestMark::getStudenttID)
							.thenComparing(TestMark::getTeachertID)
							)
					.forEach(System.out::println);
				
					/*for(TestMark tm:testMarkList) {
						System.out.println(tm);
					}*/
				System.out.println("all the Lessons:");
				
				lessonList.stream()
				.sorted(Comparator.comparing(Lesson::getDate)
						.thenComparing(Lesson::getTime)
						.thenComparing(Lesson::getStudenttID)
						.thenComparing(Lesson::getTeachertID)
						)
				.forEach(System.out::println);
				
				/*	for(Lesson l:lessonList) {
						System.out.println(l);
					}*/
				System.out.println();
				;
			break;
			default: ;
			}
		}
		while(x!=0);

		
	}

}
