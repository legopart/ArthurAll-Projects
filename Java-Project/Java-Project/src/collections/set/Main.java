package collections.set;


import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.Collections;
import java.util.HashSet;
import java.util.Set;

public class Main {

	public static void main(String[] args) {
		// set = collection, no duplicates = unique values
		//set not guaranty an order (not relay on the order!)
		Set<String> set1 = new HashSet<>();
		set1.add("sky");
		set1.add("is");
		set1.add("blue");
		set1.add("blue");
		System.out.println(set1);	//[sky, blue, is]
		
		//remove duplicates from a string
		Collection<String> collection = new ArrayList<>();
		Collections.addAll(collection, "a", "b", "c", "c");
		Set<String> set2 = new HashSet<>(collection);
		System.out.println(set2);	// [a, b, c]
		
		Set<String> set3 = new HashSet<>(Arrays.asList("a", "b", "e"));
		Set<String> set4 = new HashSet<>(Arrays.asList("b", "c", "d"));
		set1.addAll(set2);	//Union
		System.out.println(set1);	//[sky, a, b, c, blue, is]
		set1.retainAll(set4);//Intersect
		System.out.println(set1);	//[b, c]
		set1.removeAll(set3);//Difference
		System.out.println(set1);	//[c]
	}

}
