package searching;

import java.util.Arrays;

import sorting.BubbleSort;

public class Main {

	public static void main(String[] args) {
		int index;
		int[] numbers;
		numbers = new int[]{ 7, 3, 1, 4, 6, 2, 3 };
		index = LinearSearch.search(numbers, 4);
		System.out.println("LinearSearch.search \t" + index);
		System.out.println("");
	}

}
