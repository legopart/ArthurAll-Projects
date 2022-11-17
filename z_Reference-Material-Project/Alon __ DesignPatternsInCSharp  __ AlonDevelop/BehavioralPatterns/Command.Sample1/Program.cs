using System;
using System.Collections.Generic;

namespace Command.Sample1;
class Program
{
	/// <summary>
	/// Entry point into console application.
	/// </summary>
	static void Main()
	{
		// Create user and let her compute
		var user = new User();

		// Issue several compute commands
		user.Compute('+', 100);
		user.Compute('-', 50);
		user.Compute('*', 10);
		user.Compute('/', 2);

		// Undo 4 commands
		user.Undo(4);

		// Redo 3 commands
		user.Redo(3);

		Console.WriteLine();
	}
}

