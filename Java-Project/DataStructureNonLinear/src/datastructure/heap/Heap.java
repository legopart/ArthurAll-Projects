package datastructure.heap;

import java.util.Arrays;

public class Heap {
	private int[] items;
	private int size;
	
	Heap() {
		items = new int[10];
		size = 0;
	}
	
	private boolean isFull() { return size == items.length; }
	public boolean isEmpty() { return size == 0; }
	
	public int remove() {
		if(isEmpty()) throw new IllegalStateException();
		int tmp = items[0];
		items[0] = items[size - 1];
		size --;
		bubbleDown();
		return tmp;
	}
	
	private void bubbleDown() {
		var index = 0;
		while(index <= size && !isValidParant(index) ) {
			var largerChildIndex =( leftChildIndex(index) >= size) ? index 
					: (rightChildIndex(index) >= size) ? leftChildIndex(index)
					: (leftChild(index) > rightChild(index)) ? leftChildIndex(index) : rightChildIndex(index);
			swap(index, largerChildIndex);
			index = largerChildIndex;
		}
	}
	
	private boolean isValidParant(int index) { 
		if(leftChildIndex(index) > size)  return true;	//no right one;
		if(rightChildIndex(index) > size) return items[index] >= leftChild(index);
		return items[index] >= leftChild(index) &&  items[index] >= rightChild(index);
	}
	private int leftChildIndex(int index) { return index * 2 + 1; }
	private int rightChildIndex(int index) { return index * 2 + 2; }
	private int leftChild(int index) { return items[leftChildIndex(index)]; }
	private int rightChild(int index) { return items[rightChildIndex(index)]; }
	
	
	public void insert(int value) {
		if(isFull()) throw new IllegalStateException();
		items[size] = value;
		size ++;
		bubbleUp();
	}
	
	private void bubbleUp() {
		var index = size - 1; //0 <= 1
		while(items[index] > items[parent(index)]) {
			swap(index, parent(index));
			index = parent(index);	//decrees index
		}
	}
	private int parent(int index) { return (index - 1) / 2; }
	
	
	private void swap(int first, int second) {
		var temp = items[first];
		items[first] = items[second];
		items[second] = temp;
	}
	
	@Override
	public String toString() {
		return Arrays.toString(Arrays.copyOfRange(items, 0, size));
	}
}
