using System;
using System.Runtime.Remoting;

namespace Proxy.Sample1
{
	class Program
	{
		static void Main()
		{
			// Create math proxy
			IMath math = MathFactory.GetMath();

			// Do the math
			Console.WriteLine("4 + 2 = " + math.Add(4, 2));
			Console.WriteLine("4 - 2 = " + math.Sub(4, 2));
			Console.WriteLine("4 * 2 = " + math.Mul(4, 2));
			Console.WriteLine("4 / 2 = " + math.Div(4, 2));
		}
	}
}

