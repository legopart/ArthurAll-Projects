import java.util.*; 

public class Link {
	public int id;
	List<Link> list; 
	int level;

	
	//public Link() {}
	public Link(int id) {
		this.id=id;
		list = new ArrayList<Link> (); 
		level=0;
	}
	

	
}