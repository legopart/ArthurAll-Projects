package datastructure.heap;

public class MaxHeap {
	public static void heapify(int[] array) {
		for(var i = 0; i < array.length; i++) heapify(array, i);
	}
	private static void heapify(int[] array, int index) {
		var largerIndex = index;
	}
}
