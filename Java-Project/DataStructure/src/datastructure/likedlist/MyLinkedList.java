package datastructure.likedlist;

import java.util.NoSuchElementException;

public class MyLinkedList {
	
	private class Node {
		private int value;
		private Node next;
		private Node(int value) { //constructor
			this.value = value;
		}
	}

	private Node first; //head
	private Node last; //tail
	private int size;
	
	public MyLinkedList() {
		resetList();
	}
	
	private boolean isEmpty() {
		return first == null;
	}
	private void resetList() {
		first = null;
		last = null;
		size = 0;
	}
	private Node getPrevius(Node node) {	//n-1	n=last
		var current = first;
		while (current != null) {
			if(current.next == node) return current;
			current = current.next;
		}
		return null;
	}
	
	public void addLast(int item) {
		Node node = new Node(item);
		if (isEmpty()) {first = node; last = node;}
		else {last.next = node; last = node;}
		size++;
	}
	public void addFirst(int item) {
		Node node = new Node(item);
		if (isEmpty()) {first = node; last = node;}
		else {node.next = first; first = node;}	
		size++;
	}
	public int indexOf(int item) {
		int index = 0;
		var current = first;
		while (current != null) {
			if(current.value == item) return index;
			current = current.next;
			index ++;
		}
		return -1;
	}
	public boolean contains(int item) {
		return indexOf(item) != -1;
	}
	public void removeFirst() {
		if(isEmpty()) throw new NoSuchElementException();
		if(first == last) {resetList(); return;} //1 element only;
		//[10 20 -> 30]
		var second = first.next;
		first.next = null;
		first = second;
		size--;
	}
	public void removeLast() {
		//edge cases:
		if(isEmpty()) throw new NoSuchElementException();
		if(first == last) {resetList(); return;}
		//[10 -> 20  30]
		var previus = getPrevius(last);
		last = previus;
		last.next = null;
		size--;
	}
	public int size() {
		return size;
	}
	
//	public String toString(){}
	
	
}


// methods to apply:
// addFirst
// addLast
// deleteFirst
// deleteLast
// contains
// indexOf