public class Link {
	public int number1;
	public String category;
	public Link back, next; //איברים משמאל ומימין
	
	//public Link() {}
	public Link() {
		//this.data=;
		this.back=null;
		this.next=null;
	}
	
	public Link(int number1) {
		this.number1=number1;
		this.back=null;
		this.next=null;
	}
	
	public Link(int number1, String category) {
		this.number1=number1;
		if (category.length()<=12) {this.category=category;}
		this.back=null;
		this.next=null;
	}
	
}

