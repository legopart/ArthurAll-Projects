package datastructure.tree;

import javax.lang.model.type.NullType;

public class Tree {
	private class Node {
		private int value;
		private Node leftChild; // next
		private Node rightChild; // previus
		private Node(int value) { this.value = value; }
	}
	private Node root;
	
	private boolean isNull(Node node) {
		return node == null;
	}
	private boolean isLeaf(Node node) {
		return node.leftChild == null && node.rightChild == null;
	}
	private void traversePreOrder(Node node) {
		if(isNull(node)) return;	//base condition
		System.out.print(node.value + " ");
		traversePreOrder(node.leftChild);
		traversePreOrder(node.rightChild);
	}
	private void traverseInOrder(Node node) {
		if(isNull(node)) return;	//base condition
		traverseInOrder(node.leftChild);
		System.out.print(node.value + " ");	//Root
		traverseInOrder(node.rightChild);
	}
	private void traversePostOrder(Node node) {
		if(isNull(node)) return;	//base condition
		traversePostOrder(node.leftChild);
		traversePostOrder(node.rightChild);
		System.out.print(node.value + " ");	//Root
	}
	private int height(Node node) {
		if(isNull(node)) return Integer.MIN_VALUE;//-1;
		if(isLeaf(node)) return 0; // base condition
		return 1 + Math.max( height(node.leftChild), height(node.rightChild) );
	}
	private int min(Node node) { // O(n)
		if(isLeaf(node)) return node.value;	//base condition
		var left = min(node.leftChild);
		var right = min(node.rightChild);
		return Math.min( Math.min(left,right), node.value );
	}
	public void insert(int value) {
		if(isNull(root)) {root = new Node(value); return;}
		var current = root;
		while (true) {
			if(value < current.value) {
				if(isNull(current.leftChild)) {current.leftChild = new Node(value); break;}
				current = current.leftChild;
			} else if (value > current.value) {
				if(isNull(current.rightChild)) {current.rightChild = new Node(value); break;}
				current = current.rightChild;
			} else /*==*/ return;
		}
	}
	public boolean find(int value) {
		var current = root;
		while ( !isNull(current) ) {
			if(value < current.value) current = current.leftChild;
			else if(value > current.value) current = current.rightChild;
			else /*==*/ return true;
		}
		return false;
	}
	public void traversePreOrder() { traversePreOrder(root); System.out.println(""); } // Root, Left, Right
	public void traverseInOrder() { traverseInOrder(root); System.out.println(""); } // Left, Root, Right
	public void traversePostOrder() { traversePostOrder(root); System.out.println(""); } // Left, Right, Root
	public int height() { return height(root); }
	public int min() { return min(root); }
	public int min_binarySearchTree() { // O(log(n)) --> O(n)
		if(isNull(root)) throw new IllegalStateException();
		var current = root;
		while ( !isNull(current.leftChild) ) current = current.leftChild;
		return current.value;
	}
	
}
