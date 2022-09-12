package string;

import java.util.Arrays;
import java.util.Collections;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;
import java.util.Set;

public class Main {

	public static void main(String[] args) {
		System.out.println("countVowels: \t\t" +	countVowels("Hello World") );
		System.out.println("reverseString: \t\t" +	reverseString("Hello World") );
		System.out.println("reverseWords: \t\t" +	reverseWords("Hello World") );
		System.out.println("isRotation: \t\t" + 	isRotation("Hello World", "rldHello Wo") );
		System.out.println("isRotation: \t\t" + 	isRotation("Hello World", "Hello Wogfufg") );
		System.out.println("removeDuplicates: \t" +	removeDuplicates("Hello World") );
		System.out.println("removeDuplicates: \t" +	getMaxOccuringChar("Hello World") );
		System.out.println("capitalize: \t\t" + 	capitalize("hELLO       wORLD") );
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
	// אפשר לעשות עם ch בנפרד
	
	public static String removeDuplicates(String str) { 
		if(str == null) return "";
		StringBuilder output = new StringBuilder();
		Set<Character> seen = new HashSet<>();
		for(var ch : str.toCharArray()) {
			if( !seen.contains(ch) ) {
				seen.add(ch);
				output.append(ch);
			}
		}
		return output.toString();
	}
	
	public static char getMaxOccuringChar(String str) { 
//		Map<Character, Integer> frequencies = new HashMap<>();	//hashtable
//		for(var ch : str.toLowerCase().toCharArray()) {
//			if(frequencies.containsKey(ch)) 
//				frequencies.replace(ch, frequencies.get(ch) + 1);
//			else frequencies.put(ch, 1);
//		}
		//Ascii
		if(str.isEmpty() || str == null) throw new IllegalArgumentException();
		final int ASCII_SIZE = 256;
		int[] frequencies = new int[ASCII_SIZE];
		for(var ch : str.toLowerCase().toCharArray()) frequencies[ch]++;
		char result = ' ';
		int max = 0;
		for(var i = 0; i < frequencies.length; ++i) 
			if(frequencies[i] > max) { 
				max = frequencies[i];
				result = (char) i ;
			}
		return result;
	}
	
	public static String capitalize(String sentence) { 
		if(sentence == null || sentence.trim().isEmpty()) return "";
		String[] words = sentence.replaceAll(" +", " ").split(" ");
		for(var i = 0; i < words.length; i++) 
			words[i] = words[i].substring(0, 1).toUpperCase() + words[i].substring(1).toLowerCase();
		return String.join(" ", words);
	}
	
	
}
