package collections.comparable_interface;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.List;

public class Main {

	public static void main(String[] args) {
		List<Customer> customers = new ArrayList<>();
		customers.add(new Customer("b"));
		customers.add(new Customer("a"));
		customers.add(new Customer("c"));
		System.out.println(customers);
		
		Collections.sort(customers);
		System.out.println(customers);
	}

}
