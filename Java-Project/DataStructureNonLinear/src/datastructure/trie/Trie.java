package datastructure.trie;

import java.util.concurrent.ConcurrentHashMap;

public class Trie {
	private static final int ALPHABET_SIZE = 26; //A..Z
	private class Node{
		char value;
		Node[] childre;
		boolean isEndOfWord;
		Node(char value){
			this.value = value;
			childre = new Node[ALPHABET_SIZE]; 
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
			var index = ch - 'a';
			if (isNull(current.childre[index])) current.childre[index] = new Node(ch);
			current = current.childre[index];
		}
		current.isEndOfWord = true;
	}
}
