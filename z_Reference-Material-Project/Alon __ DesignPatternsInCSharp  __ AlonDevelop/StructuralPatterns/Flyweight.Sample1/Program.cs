using System;
using System.Collections.Generic;

namespace Flyweight.Sample1;
class Program
{
	/// <summary>
	/// Entry point into console application.
	/// </summary>
	static void Main()
	{
		// Build a document with text
		string document = "AAZZBBZB";
		char[] chars = document.ToCharArray();

		var factory = new CharacterFactory();

		// extrinsic state
		int pointSize = 10;

		// For each character use a flyweight object
		foreach (char c in chars)
		{
			var character = factory[c];
			character.Display(++pointSize);
		}
	}
}

