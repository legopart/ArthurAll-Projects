using System;
using System.Collections.Generic;

namespace Bridge.Sample1;

class Program
{
	/// <summary>
	/// Entry point into console application.
	/// </summary>
	static void Main()
	{
		// Create RefinedAbstraction
		var customers = new Customers();

		// Set ConcreteImplementor
		customers.DataObject = new CustomersData { City = "Chicago" };

		// Exercise the bridge
		customers.Show();
		customers.Next();
		customers.Show();
		customers.Next();
		customers.Show();

		customers.Add("Henry Velasquez");
		customers.ShowAll();
	}
}

