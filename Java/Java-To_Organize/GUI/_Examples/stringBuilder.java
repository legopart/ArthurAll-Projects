package _Examples;


public class stringBuilder {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		StringBuilder b1=new StringBuilder("bb");
		StringBuilder b=new StringBuilder();
		b.append("aa");
		
		
		b.insert(1, b1);
		//b.delete(0, 5);
		System.out.println(b);
	}

}
