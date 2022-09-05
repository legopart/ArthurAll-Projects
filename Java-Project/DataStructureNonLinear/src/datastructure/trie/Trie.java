package datastructure.trie;

import java.util.HashMap;
import java.util.concurrent.ConcurrentHashMap;

import datastructure.heap.MaxHeap;

public class Trie {
//	private static final int ALPHABET_SIZE = 26; //A..Z	//array
	private class Node{
		char value;
//		Node[] children;
		HashMap<Character, Node> children;
		boolean isEndOfWord;
		Node(char value){
			this.value = value;
//			children = new Node[ALPHABET_SIZE];	//array
			children = new HashMap();
			isEndOfWord = false;
		}
		@Override
		public String toString() { return "value=" + value; }
	}
	private Node root;
	public Trie() { root = new Node(' '); }
	
	private boolean isNull(Node node) {
		return node == null;
	}
	public void insert(String word) {
		var current = root;
		for(var ch : word.toLowerCase().toCharArray()) {
//			var index = ch - 'a';	//array
//			if (isNull(current.children[index])) current.children[index] = new Node(ch);	//array
			if (isNull(current.children.get(ch))) current.children.put(ch, new Node(ch));
//			current = current.children[index];	//array
			current = current.children.get(ch);
		}
		current.isEndOfWord = true;
	}
}
