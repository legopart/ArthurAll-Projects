package collections.hashtable_map;

import java.util.HashMap;
import java.util.Map;
import java.util.WeakHashMap;

public class Main {

	public static void main(String[] args) {
		//linkedList is not scalable, O(n)
		// Java: Maps
		// C#: Dictionary
		// Python: Dictionary
		// JavaScript: Object
		Map<String, Customer> map = new HashMap<>();
		var c1 = new Customer("a", "e1");
		var c2 = new Customer("b", "e2");
		var unknownC = new Customer("Unknown", "");
		map.put(c1.getEmail(), c1);
		map.put(c2.getEmail(), c2);
		System.out.println( map.get("e1") );
		System.out.println( map.getOrDefault("e10", unknownC) ); //return unknown
		System.out.println( map.containsKey("e10") );
		map.replace("e1", new Customer("a++", "e1"));
		System.out.println( map.get("e1") );
		for(var key : map.keySet())System.out.print(key +" ");
		System.out.println("");
		for(var value : map.values())System.out.print(value +" ");
		System.out.println("");
		for(var entry : map.entrySet())System.out.print("(" + entry.getKey() + ")" + entry.getValue() + " ");
		System.out.println("");
	}

}
