using System;
using System.Collections.Generic;

namespace Interpreter.Sample1;
class Program
{
	/// <summary>
	/// Entry point into console application.
	/// </summary>
	static void Main()
	{
		// Construct the 'parse tree'
		var tree = new List<Expression> {
				new ThousandExpression(),
				new HundredExpression(),
				new TenExpression(),
				new OneExpression()
		 };

		// Create the context (i.e. roman value)
		string roman = "MCMXXVIII";
		var context = new Context { Input = roman };

		// Interpret
		tree.ForEach(e => e.Interpret(context));
		Console.WriteLine("{0} = {1}", roman, context.Output);
		Console.WriteLine();
	}
}

