public class Link {
	public Book book;
	public Link L, R, P; //left right parant
	
	public Link() {}
	public Link(Book book) {
		this.book=book;
		this.P=null;
		this.L=null;
		this.R=null;
	}
}
