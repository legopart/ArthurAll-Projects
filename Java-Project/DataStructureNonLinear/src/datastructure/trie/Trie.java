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
		Node getChildArray(char ch) { var index = ch - 'a'; return childrenArray[index]; }
		boolean hasChildArray(char ch) { return getChildArray(ch) != null; }
		void addChildArray(char ch) { var index = ch - 'a'; childrenArray[index] = new Node(ch); }
		
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
}
