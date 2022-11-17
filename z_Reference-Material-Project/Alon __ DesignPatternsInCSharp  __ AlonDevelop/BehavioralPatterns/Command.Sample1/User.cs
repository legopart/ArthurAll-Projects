namespace Command.Sample1;

// The 'Invoker' class
class User
{
	private Calculator _calculator = new Calculator();
	private List<ICommand> _commands = new List<ICommand>();
	private int _current = 0;

	// Redo original commands
	public void Redo(int levels)
	{
		Console.WriteLine("\n---- Redo {0} levels ", levels);

		// Perform redo operations
		for (int i = 0; i < levels; i++)
		{
			if (_current < _commands.Count - 1)
			{
				_commands[_current++].Execute();
			}
		}
	}

	// Undo prior commands
	public void Undo(int levels)
	{
		Console.WriteLine("\n---- Undo {0} levels ", levels);

		// Perform undo operations
		for (int i = 0; i < levels; i++)
		{
			if (_current > 0)
			{
				_commands[--_current].Undo();
			}
		}
	}

	// Compute new value given operator and operand
	public void Compute(char @operator, int operand)
	{
		// Create command operation and execute it
		ICommand command = new CalculatorCommand(
									_calculator, @operator, operand);
		command.Execute();

		// Add command to undo list
		_commands.Add(command);
		_current++;
	}
}

