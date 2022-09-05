package datastructure.trie;

import java.util.HashMap;
import java.util.concurrent.ConcurrentHashMap;

import datastructure.heap.MaxHeap;

public class Trie {
	private static final int ALPHABET_SIZE = 26; //A..Z	//array
	private class Node{
		char value;
		Node[] childrenArray;
		HashMap<Character, Node> children;
		boolean isEndOfWord;
		Node(char value){
			this.value = value;
			childrenArray = new Node[ALPHABET_SIZE];//array
			children = new HashMap();
			isEndOfWord = false;
		}
		@Override
		public String toString() { return "value=" + value; }
		Node getChild(char ch) { return children.get(ch); }
		boolean hasChild(char ch) { return children.containsKey(ch); }
		void addChild(char ch) { children.put(ch, new Node(ch)); }
		
		//array
//		Node getChildArray(char ch) { var index = ch - 'a'; return childrenArray[index]; }
//		boolean hasChildArray(char ch) { return getChildArray(ch) != null; }
//		void addChildArray(char ch) { var index = ch - 'a'; childrenArray[index] = new Node(ch); }
		
		Node[] getChildren() {
			return children.values().toArray(new Node[0]);
		}
		
		boolean hasChildren() { return !children.isEmpty(); }
		
		void removeChild(char ch) {
			children.remove(ch);
		}
		
	}
	private Node root;
	public Trie() { root = new Node(' '); }

	private boolean isNull(Node node) {
		return node == null;
	}
	public void insert(String word) {
		var current = root;
		for(var ch : word.toLowerCase().toCharArray()) {
			if (!current.hasChild(ch)) current.addChild(ch);
			current = current.getChild(ch);
		}
		current.isEndOfWord = true;
	}
	
	public boolean contains(String word) {
		if(word == null) return false;  
		var current = root;
		for(var ch : word.toLowerCase().toCharArray()) {
			if (!current.hasChild(ch)) return false;
			else current = current.getChild(ch);
		}
		return current.isEndOfWord;// == true;
	}
	
	public void traverse_PreOrder() { traverse_PreOrder(root); }
	
	private void traverse_PreOrder(Node node) {
		System.out.print(node.value);
		for(var ch: node.getChildren()) traverse_PreOrder(ch);
		System.out.print(" ");	
	}
	public void traverse_PostOrder() { traverse_PostOrder(root); }
	private void traverse_PostOrder(Node node) { 
		System.out.print(" ");
		for(var ch: node.getChildren()) traverse_PostOrder(ch);
		System.out.print(node.value);	
	}
	
	public void remove(String word) { if(word == null) return; remove(root, word, 0); }
	private void remove(Node node, String word, int index) { // לחזור
		// לסיים הסרה
		if(index == word.length()) { /*last char*/ // we need preLast child + no -1 because 1st time remove applied on ' ' 
			node.isEndOfWord = false;
			System.out.println("last:" + node.value);
			return; 
		} //
		var ch = word.charAt(index);
		var child = node.getChild( ch );
		if(isNull(child)) return;
		remove(child, word, index + 1);
		if(!child.hasChildren() && !child.isEndOfWord) node.removeChild(ch);
		
		System.out.println("0:" + node.value);
	}
	
	
}
