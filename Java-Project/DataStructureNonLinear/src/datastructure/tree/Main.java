package datastructure.tree;
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("Non linear data structure");
		Tree tree = new Tree();
		tree.insert( 7 );
		tree.insert( 4 );
		tree.insert( 9 );
		tree.insert( 1 );
		tree.insert( 6 );
		tree.insert( 8 );
		tree.insert( 10 );
		System.out.println( tree.find( 10 ) );
		System.out.println( tree.find( 5 ));
		System.out.println("");
		// Pre-Order	Root, left, right
		// In-Order		left, Root, right
		// Post-Order	left, right, Root
		
		System.out.println( factorial_it(4) );
		System.out.println( factorial_re(5) );
		System.out.println("//////");
		System.out.println("");
		tree.traversePreOrder();
		tree.traverseInOrder();
		tree.traversePostOrder();
		System.out.println("//////");
		System.out.println("");
		System.out.println( tree.height() );
		System.out.println( tree.min() );
		System.out.println( tree.min_binarySearchTree() );
		
		
	}
	
	// 4! = 4 x 3 x 2 x 1
	// 3! = 3 x 2 x 1	
	public static int factorial_it(int n) { // iteration
		var factorial = 1;
		for (var i = n; i > 1; i--) factorial *= i;
		return factorial;
	}
	// 4! = 4 x 3!
	// 3! = 3 x 2!
	// n! = n x (n-1)!	// f(n) = n x f(n-1)
	public static int factorial_re(int n) { // recursion
		if(n == 1) return 1;	//base condition for recursion
		return n * factorial_re(n-1);
	}
}
