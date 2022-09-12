import java.util.Arrays;

public class Main {

	public static void main(String[] args) {
		int[] numbers;
		numbers = new int[]{ 7, 3, 1, 4, 6, 2, 3 };
		BubbleSort.sort(numbers);
		System.out.println("BubbleSort.sort" + Arrays.toString(numbers));
		numbers = new int[]{ 7, 3, 1, 4, 6, 2, 3 };
		BubbleSort.sort2(numbers);
		System.out.println("BubbleSort.sort2" + Arrays.toString(numbers));
		System.out.println("");
		
		numbers = new int[]{ 7, 3, 1, 4, 6, 2, 3 };
		SelectionSort.sort(numbers);
		System.out.println("SelectionSort.sort" + Arrays.toString(numbers));
		numbers = new int[]{ 7, 3, 1, 4, 6, 2, 3 };
		SelectionSort.sort2(numbers);
		System.out.println("SelectionSort.sort2" + Arrays.toString(numbers));
		System.out.println("");
		
		numbers = new int[]{ 7, 3, 1, 4, 6, 2, 3 };
		InsertionSort.sort(numbers);
		System.out.println("InsertionSort.sort" + Arrays.toString(numbers));
		System.out.println("");
		
		numbers = new int[]{ 7, 3, 1, 4, 6, 2, 3 };
		MergeSort.sort(numbers);
		System.out.println("MergeSort.sort" + Arrays.toString(numbers));
		System.out.println("");
	}

}
