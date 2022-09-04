package datastructure.heap;

import java.awt.HeadlessException;

public class PriorityQueueWithHeap {
	private Heap heap;
	PriorityQueueWithHeap(){ heap = new Heap(); }
	public void enqueue(int item) {	//add
		heap.insert(item);
	}
	public int dequeue() {
		return heap.remove();
	}
	public boolean isEmpty() {
		return heap.isEmpty();
	}
}
