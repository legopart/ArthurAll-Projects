namespace Command.Sample1;

// The 'ConcreteCommand' class
class CalculatorCommand : ICommand
{
	public char Operator { get; private set; }
	public int Operand { get; private set; }

	private Calculator _calculator;

	// Constructor
	public CalculatorCommand(Calculator calculator, char @operator, int operand)
	{
		_calculator = calculator;
		Operator = @operator;
		Operand = operand;
	}

	// Execute command
	public void Execute()
	{
		_calculator.Operation(Operator, Operand);
	}

	// Undo command
	public void Undo()
	{
		_calculator.Operation(Undo(Operator), Operand);
	}

	// Return opposite operator for given operator
	private char Undo(char @operator)
	{
		switch (@operator)
		{
			case '+': return '-';
			case '-': return '+';
			case '*': return '/';
			case '/': return '*';
			default: throw new ArgumentException("@operator");
		}
	}
}

