package collections.compator_interface.copy;

public class Customer implements Comparable<Customer> {
	private String name;
	private String email;
	
	public String getEmail() { return email; }


	public Customer(String name, String email) {
		this.name = name;
		this.email = email;
	}



	@Override
	public int compareTo(Customer other) {
		//this < other  -1
		//this = other  0
		//this > other  1
		// if(name < o.name) WRONG, Only for numbers
		return name.compareTo(other.name);
	}

	@Override
	public String toString() { return name + " " + email; }

	
	
}
