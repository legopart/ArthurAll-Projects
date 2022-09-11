package collections.queue;

import java.util.ArrayDeque;
import java.util.Queue;

public class Main {

	public static void main(String[] args) {
		// queue = order of values
		Queue<String> queue = new ArrayDeque<>();
		queue.add("c");
		queue.add("b");
		queue.add("a");		//throws exception if full
		
		// b -> a -> c
		queue.offer("d");	//return false if full
		// b -> a -> c -> d
		var c = queue.peek();		//return null if empty
		var c2 = queue.element();	//throws exception if empty
		var c3 = queue.remove();//throws exception if empty
		var a = queue.poll();	//return null if empty
		System.out.println(queue);
	}

}
