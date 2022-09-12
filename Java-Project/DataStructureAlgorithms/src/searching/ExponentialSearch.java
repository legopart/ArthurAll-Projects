package searching;

import java.util.Arrays;

public class ExponentialSearch {
	public static int search(int[] array, int target) {
		int bound = 1;
		while(bound < array.length && array[bound] < target) bound *= 2;
		int[] newArray = Arrays.copyOfRange(array, bound/2, Math.min(bound, array.length));
		return bound/2 + BinarySearch.searchRecursion(newArray, target);
	}
}
