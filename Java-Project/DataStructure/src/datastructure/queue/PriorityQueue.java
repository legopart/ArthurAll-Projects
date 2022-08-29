package datastructure.queue;

import java.util.Arrays;

// [1, 7, 8] + 2
// [1, 2 , 7, 8]


public class PriorityQueue {
	private int[] items;
	private int front;
	private int rear;
	private final double extendBy = 2.0;
	
	public PriorityQueue() {
		items = new int[5];
		front = 0;
		rear = 0;
	}

	private void extendArray() {
		int[] array = new int[(int)(rear*extendBy)];
		int j=0;
		for(int i = front; i < rear; i++) {
			array[j] = items[i];
			j++;
		}
		front = 0;
		rear = j;
		items = array;
	}
	
	private boolean isEmpty() { return front == rear; }
	private boolean isFull() { return items.length == rear; }
	public void enqueue(int value) {
		if(isFull()) extendArray();
		items[rear] = value;
		rear++;
	}
	public int peek() {
		if(isEmpty()) throw new Error();
		return items[front];
	}
	public int dequeue() {
		int peek = peek();
		front++;
		return peek;
	}
	
	@Override
	public String toString() { return Arrays.toString( Arrays.copyOfRange(items, front, rear) ); }
}
