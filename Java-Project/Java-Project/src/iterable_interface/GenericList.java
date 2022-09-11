package iterable_interface;

import java.util.Iterator;

public class GenericList<T> implements Iterable<T> {
	private T[] items;
	private int count;
	public GenericList() {
		items = (T[]) new Object[10];
		count = 0;
	}
	
	public void add(T item) {
		items[count] = item;
		count ++;
	}
	
	public T get(int index) { return items[index]; }
	
	@Override
	public Iterator<T> iterator() {
		return new MyListIterator(this);
	}
	
	private class MyListIterator implements Iterator<T>{
		private GenericList<T> list;
		private int index;
		public MyListIterator(GenericList<T> list) {
			this.list = list;
			index = 0;
			//have access to: list.items : private T[]
		}
		@Override
		public boolean hasNext() {
			return (index < list.count);
		}

		@Override
		public T next() {
			T item = list.items[index];
			index ++;
			return item;
		}
		
		
	}

}
