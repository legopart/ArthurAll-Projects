public class Book {
private	String name, id, avtar;
private	int year, copies;

//public Book() {}
public Book (String name,String  id,String  avtar, int year, int copies) {
	setName(name);
	setId(id);
	setAvtar(avtar);
	setYear(year);
	setCopies(copies);
}


//Setters
private boolean between(int x,int a,int b) {
	if(x>=a&&x<=b)
		return true;
	return false;
}
private boolean lenght(String string,int size) {
	if(string.length()<=size)
		return true;
	return false;
}

public void setName(String name) {
	if (lenght(name,32))
			this.name = name;
}
public void setId(String id) {
	if (lenght(id,12))
		this.id = id;
}
public void setAvtar(String avtar) {
	if (lenght(avtar,15))
		this.avtar = avtar;
}
public void setYear(int year) {
	if (between(year,1900,2020))
		this.year = year;
}
public void setCopies(int copies) {
	if (between(copies,1,5))
		this.copies = copies;
}


// Getters
public String getName() {return name;}
public String getId() {return id;}
public String getAvtar() {return avtar;}
public int getYear() {return year;}
public int getCopies() {return copies;}


}