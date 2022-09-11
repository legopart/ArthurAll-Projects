import java.util.Arrays;

public class Main {

	public static void main(String[] args) {
		int[] numbers;
		numbers = new int[]{ 7, 3, 1, 4, 6, 2, 3 };
		BubbleSort.sort(numbers);
		System.out.println(Arrays.toString(numbers));
		numbers = new int[]{ 7, 3, 1, 4, 6, 2, 3 };
		BubbleSort.sort2(numbers);
		System.out.println(Arrays.toString(numbers));
		System.out.println("");
		
		numbers = new int[]{ 7, 3, 1, 4, 6, 2, 3 };
		SelectionSort.sort(numbers);
		System.out.println(Arrays.toString(numbers));
		numbers = new int[]{ 7, 3, 1, 4, 6, 2, 3 };
		SelectionSort.sort2(numbers);
		System.out.println(Arrays.toString(numbers));
		System.out.println("");
	}

}
