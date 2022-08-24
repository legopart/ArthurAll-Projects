package datastructure.stacks;

import java.util.Arrays;
import java.util.List;
import java.util.Stack;

public class BalancedExpression {
		//check how to do so in c#
	private final List<Character> leftBracket
		= Arrays.asList('(', '<', '{', '[');
	private final List<Character> rightBracket
		= Arrays.asList(')', '>', '}', ']');
	
	private boolean isLeftBracket(char ch) {
		return leftBracket.contains(ch);
	}
	private boolean isRightBracket(char ch) {
		return rightBracket.contains(ch);
	}
	private boolean bracketsMatch(char chLeft, char chRight ) {
		return leftBracket.indexOf(chLeft) == rightBracket.indexOf(chRight);
	}
	
	public boolean isBalanced(String input) {
		Stack<Character> stack = new Stack<>();
		for(char ch: input.toCharArray()) {
			if( isLeftBracket(ch)  ) stack.push(ch);
			else if ( isRightBracket(ch) ) {
				if(stack.empty()) return false;	//Edge case
				char oposite = stack.pop();
				if( bracketsMatch(ch, oposite) ) return true;
			}
// for single case ( )
//		Stack<Character> stack = new Stack<>();
//		for(char ch: input.toCharArray()) {
//			if (ch == '(') stack.push(')');
//			else if (ch == ')') {
//				if(stack.empty()) return false;	//Edge case
//				char oposite = stack.pop();
//				if ( ')' == oposite ) return true;
//			}
//		}
		}
		return stack.empty(); //boolean
	}
}
