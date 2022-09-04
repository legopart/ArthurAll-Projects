
package datastructure.heap;

import java.util.Arrays;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("Heap");
		Heap heap2 = new Heap();
		heap2.insert(10);
		heap2.insert(5);
		heap2.insert(17);
		heap2.insert(4);
		heap2.insert(22);
		heap2.remove();
		System.out.println("");
		System.out.println(heap2);
		
		int[] numbers = {5, 3, 10, 1, 4, 2};
		Heap heap = new Heap();
		//Heap Sort >
		for(var number: numbers) heap.insert(number);
		for(var i = 0 ; i < numbers.length ; i++) numbers[i] = heap.remove();
		System.out.println(Arrays.toString(numbers));
		//Heap Sort <
		for(var number: numbers) heap.insert(number);
		for(var i = numbers.length - 1; i >= 0 ; i--) numbers[i] = heap.remove();
		System.out.println(Arrays.toString(numbers));
	}
	

}
