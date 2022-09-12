package string;

import java.util.Arrays;
import java.util.Collections;

public class Main {

	public static void main(String[] args) {
		System.out.println( countVowels("Hello World") );
		System.out.println( reverseString("Hello World") );
		System.out.println( reverseWords("Hello World") );
		System.out.println( isRotation("ABCD", "BCDA") );
		System.out.println( isRotation("ABCD", "BCDE") );
		
		
	}
	
	public static int countVowels(String str) {
		if(str == null) return 0;
		int count = 0;
		final String vowels = "aeiou";
		for (var ch : str.toLowerCase().toCharArray()) 
			if(vowels.indexOf(ch) != -1) count ++;
		return count;
	}
	
	public static String reverseString(String str) {
		if(str == null) return "";
		StringBuilder reversed = new StringBuilder();
		for (var ch : str.toCharArray()) reversed.insert(0, ch); // reversed = ch + reversed;
		// for(var i = str.length() - 1; i >= 0; i--) reversed += str.charAt(i);
			// O(n) * O(n)
		// for(var i = str.length() - 1; i >= 0; i--) reversed.appent(ch)
			// O(n)
		return reversed.toString();
	}
	
	public static String reverseWords(String sentence) {
		if(sentence == null) return "";
		String[] words = sentence.trim().split(" ");
		StringBuilder reversed = new StringBuilder(); //String reversed = "";
//		for (var word : words) reversed.insert(0, word + " "); // reversed = word + " " + reversed;
//		return reversed.toString().trim();
		
//		for(var i = words.length - 1; i >= 0; i--) reversed.append(words[i] + " ");
//		return reversed.toString().trim();

		Collections.reverse(Arrays.asList(words));
		return String.join(" ", words);
	}
	
	public static boolean isRotation(String str1, String str2) {
		if(str1 == null || str2 == null) return false;
		else if(str1.length() != str2.length()) return false;
		String newString = str1 + str1;
		if(newString.contains(str2)) return true;
		return false;
	}
	// אפשר לעשות עם ch
	public static boolean removeDuplicates(String str ) {
		if(str1 == null || str2 == null) return false;
		else if(str1.length() != str2.length()) return false;
		String newString = str1 + str1;
		if(newString.contains(str2)) return true;
		return false;
	}
	
}
