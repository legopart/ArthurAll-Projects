﻿namespace AbstractFactory.Sample2;

/// <summary>
/// The 'ProductB1' class
/// </summary>
class Lion : ICarnivore
	{
		public void Eat(IHerbivore h)
		{
			// Eat Wildebeest
			Console.WriteLine(this.GetType().Name +
				 " eats " + h.GetType().Name);
		}
	}

