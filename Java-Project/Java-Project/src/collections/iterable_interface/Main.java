package collections.iterable_interface;
public class Main {

	public static void main(String[] args) {
		var list = new GenericList<>();
		list.add(5);
		list.add(6);
		var iterator = list.iterator();
		//	[a, b, c]
		//	 ^
		//	    ^		next
		while(iterator.hasNext()) {
			var current = iterator.next();
			System.out.println(current);
		}
		System.out.println( );
		//Synthetic sugar
		for(var current: list) {
			System.out.println(current);
		}
		
	}

}
