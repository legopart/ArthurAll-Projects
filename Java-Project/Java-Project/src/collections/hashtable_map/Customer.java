package collections.hashtable_map;

public class Customer {
	private String name;
	private String email;
	
	public String getEmail() { return email; }


	public Customer(String name, String email) {
		this.name = name;
		this.email = email;
	}
	@Override
	public String toString() { return name + " " + email; }
}
