package datastructure.arraylist;
import java.util.ArrayList;


public class Main {
	public static void main(String args[]) {
		
		// Vector : increased by 100%, synchronized, only for 1 core
		// ArrayList: increased by 50%
		ArrayList<Integer> list = new ArrayList<>(); //byte
		list.add(10);
		list.add(20);
		list.add(30);
		list.remove(0);
		
		System.out.println( list );
		System.out.println( list.indexOf(20) );
		System.out.println( list.lastIndexOf(20) );
		System.out.println( list.size() );
		Object[] arr = list.toArray();
	}
}
