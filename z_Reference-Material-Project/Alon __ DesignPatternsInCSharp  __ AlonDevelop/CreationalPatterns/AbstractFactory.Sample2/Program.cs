using System;
using System.Collections.Generic;

namespace AbstractFactory.Sample2;

class Program
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		public static void Main()
		{
			// Create and run the African animal world
			var africa = new AnimalWorld<Africa>();
			africa.RunFoodChain();

			// Create and run the American animal world
			var america = new AnimalWorld<America>();
			america.RunFoodChain();
		}
	}

