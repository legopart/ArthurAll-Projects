public class Tree {

protected	Link root;
	
public		Tree() {
				root= null;
			}
	
	
public		void insert(Book book) {
				if (root==null) root=new Link(book);
				else insert(book, root);
			}
private		void insert(Book book, Link current) {
				if (book.getId().compareTo(current.book.getId())<0) 
					if(current.L==null) {
						current.L=new Link(book);
						current.L.P=current;
						}
					else insert(book, current.L);
				
				if (book.getId().compareTo(current.book.getId())>0) 
					if(current.R==null) {
						current.R=new Link(book);
						current.R.P=current;
					}
					else insert(book, current.R);
			}

public		void delete(Book book) {
				delete(book, root);
			}
private		void delete(Book book, Link current) {
				if (current.book.getId().equals(book.getId())) {		
					if (current.R==null&&current.L==null) {			
						if (current==root) {}
						else if(current.P.L==current) current.P.L=null;
						else if(current.P.R==current) current.P.R=null;
					}
					if (current.R==null) {
						if (current==root) {root=root.L;}
						else if(current.P.L==current) current.P.L=current.L;
						else if(current.P.R==current) current.P.R=current.L;
					}
					if (current.L==null) {
						if (current==root) {root=root.R;}
						else if(current.P.L==current) current.P.L=current.R;
						else if(current.P.R==current) current.P.R=current.R;
					}		
					else { //מקרה קיצוני בו יש לו גם R ו L
						//נחפש מספר מקסימלי שקטן ממנו כלומר מקסימום בעמודה השמאלית ממנו
						Link c2=current.L;
						while(c2.R!=null) {
							c2=c2.R;
						}
						if (c2.L!=null) c2.P.R=c2.L;
						c2.R=current.R;
						c2.L=current.L;
						
						if(current==root) {
							root=c2;
						}
						else {
							if(current.P.L==current) current.P.L=c2;
							if(current.P.R==current) current.P.R=c2;
						}
						c2=null;
					}
					current=null;
				}
				else { // Loop ! לולאה מכוננת
						if(current.L!=null) delete(book, current.L);
						if(current.R!=null) delete(book, current.R);
					}
			}

private		Link findHelper=null;
public		Link find(String name) {
				findHelper=null;
				find(name, root);
				return findHelper;
		}
private		void find(String name, Link current) {
				if(current.book.getName().contains(name)){findHelper=current;}
				if(current.R!=null)  find(name, current.R);
				if(current.L!=null)  find(name, current.L);
		}

public		void preOreder() {
				System.out.print("preOreder: ");
				preOreder(root);
				System.out.print("\n");
			}
private		void preOreder(Link current) {
				System.out.print(current.book.getId() +", ");
				if(current.L!=null)  preOreder(current.L);
				if(current.R!=null)  preOreder(current.R);
			}


public		void inOreder() {
				System.out.print("inOreder: ");
				inOreder(root);
				System.out.print("\n");
			}
private		void inOreder(Link current) {
				if(current.L!=null)  inOreder(current.L);
				System.out.print(current.book.getId() +", ");
				if(current.R!=null)  inOreder(current.R);
			}


public		void postOreder() {
				System.out.print("postOreder: ");
				postOreder(root);
				System.out.print("\n");
			}
private		void postOreder(Link current) {
				if(current.L!=null)  postOreder(current.L);
				if(current.R!=null)  postOreder(current.R);
				System.out.print(current.book.getId() +", ");
			}


}



