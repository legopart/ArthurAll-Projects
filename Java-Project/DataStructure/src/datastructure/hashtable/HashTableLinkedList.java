package datastructure.hashtable;

import java.util.LinkedList;

public class HashTableLinkedList {
	private class Entry{
		private int key;
		private String value;
		private Entry(int key, String value) { this.key = key; this.value = value; }
	}
	private LinkedList<Entry>[] entries;
	
	public HashTableLinkedList() {
		entries = new LinkedList[5];
	}
	
	
	private int hash(int key) {
		return key % entries.length;
	}
	
	public void put(int key, String value) {	// לחזור!
		var index = hash(key);
		var bucket = entries[index];
		if (bucket == null) entries[index] = new LinkedList<>();
		for(var entery: bucket) { if (entery.key == key) entery.value = value; return; }
		bucket.addLast( new Entry(key, value) );
	}
	
	
	
	
}
