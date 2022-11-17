namespace Command.Sample1;

// The 'Receiver' class
class Calculator
{
	private int _current = 0;

	// Perform operation for given operator and operand
	public void Operation(char @operator, int operand)
	{
		switch (@operator)
		{
			case '+': _current += operand; break;
			case '-': _current -= operand; break;
			case '*': _current *= operand; break;
			case '/': _current /= operand; break;
		}
		Console.WriteLine(
			 "Current value = {0,3} (following {1} {2})",
			 _current, @operator, operand);
	}
}

