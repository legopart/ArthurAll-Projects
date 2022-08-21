import java.util.Scanner;
public class Main {
	public static Scanner in = new Scanner(System.in);

	public static void main(String[] args) {
		Book b1= new Book("a","0001","Arthur",1988,5);
		Book b2= new Book("b","0002","Arthur",1988,5);
		Book b3= new Book("c","0003","Arthur",1988,5);
		Book b4= new Book("d","0004","Arthur",1988,5);
		Book b5= new Book("e","0005","Arthur",1988,5);
		Book b6= new Book("fff","0006","Arthur",1988,5);
		Book b7= new Book("g","0007","Arthur",1988,5);
		Book b8= new Book("h","0008","Arthur",1988,5);
		Book b9= new Book("i","0009","Arthur",1988,5);
		Book b10= new Book("j","0010","Arthur",1988,5);
		Book b11= new Book("k","0011","Arthur",1988,5);
		Book b12= new Book("l","0012","Arthur",1988,5);

		Tree t1=new Tree();
		
		t1.insert(b6);
		t1.insert(b3);
		t1.insert(b7);
		t1.insert(b9);
		t1.insert(b4);
		t1.insert(b2);
		t1.insert(b8);
		t1.insert(b10);
		t1.insert(b1);
		t1.insert(b5);
		t1.insert(b11);
		t1.insert(b12);

			int x=0;
		while(x!=5) {
			System.out.println("please insernt 1-5 value");
			System.out.println("(1) Insert a new link");
			System.out.println("(2) Delete a link");
			System.out.println("(3) Search a link");
			System.out.println("(4) print the tree in pre-order,in-order and post-order");
			System.out.println("(5) Exit");
			System.out.println("\n");
			x=in.nextInt();
		switch(x) {
			case 1:
				System.out.println("1- Insert a new link");
				System.out.println("Please insert the:\n");
				System.out.println(":Book name");
				String name, id, avtar;
				int year, copies;
					do{name=in.next();}
					while(name.length()>32);
				System.out.println(":Catalog number");
					do{id=in.next();}
					while(id.length()>12);
				System.out.println(":Authour");
					do{avtar=in.next();}
					while(avtar.length()>15);
				System.out.println(":Year");
					do{year=in.nextInt();}
					while(year<1900||year>2020);
				System.out.println(":Copies Awailable\n");
					do{copies=in.nextInt();}
					while(copies<1||copies>50);
				t1.insert(new Book(name,id,avtar,year,copies));
				System.out.println("thanks.\n\n");
			break;
			case 2:
				System.out.println("2- Delete link");
				System.out.println("Please insert the book name for delete:\n");
				String removedId=in.next();
				System.out.println("\"" +t1.find(removedId).book.getId() + "\" is deleted!");
				t1.delete(t1.find(removedId).book);
				System.out.println("thanks.\n\n");
			break;
			case 3:
				System.out.println("3- Search link");
				System.out.println("Please insert the book name for find it:\n");
				String findId=in.next();
				System.out.println("the requested \"" + findId + "\" bookId is: "+t1.find(findId).book.getId());
				System.out.println("thanks.\n");	    
			break;
			case 4:
				System.out.println("4- print the tree in pre-order,in-order and post-order");
				System.out.println("The all printed orders:\n");
				t1.preOreder();
				t1.inOreder();
				t1.postOreder();
				System.out.println("thanks.\n");	
			break;
		  default:;
		}
		
		}
		System.out.println("Good Bye \n");	
	}

}
