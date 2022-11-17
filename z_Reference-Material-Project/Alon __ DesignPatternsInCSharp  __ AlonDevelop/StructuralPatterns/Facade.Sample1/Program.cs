using System;

namespace Facade.Sample1;

class Program
{
	/// <summary>
	/// Entry point into console application.
	/// </summary>
	static void Main()
	{
		// Facade
		var mortgage = new Mortgage();

		// Evaluate mortgage eligibility for customer
		var customer = new Customer { Name = "Bart Simpson" };
		bool eligible = mortgage.IsEligible(customer, 125000);

		Console.WriteLine("\n{0} has been {1}", customer.Name, (eligible ? "Approved" : "Rejected"));
	}
}

