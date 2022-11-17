using System;

namespace Chain.Sample1;

class Program
{
	/// <summary>
	/// Entry point into console application.
	/// </summary>
	static void Main()
	{
		// Setup Chain of Responsibility
		Approver larry = new Director();
		Approver sam = new VicePresident();
		Approver tammy = new President();

		larry.Successor = sam;
		sam.Successor = tammy;

		// Generate and process purchase requests
		var purchase = new Purchase { Number = 2034, Amount = 350.00, Purpose = "Supplies" };
		larry.ProcessRequest(purchase);

		purchase = new Purchase { Number = 2035, Amount = 32590.10, Purpose = "Project X" };
		larry.ProcessRequest(purchase);

		purchase = new Purchase { Number = 2036, Amount = 122100.00, Purpose = "Project Y" };
		larry.ProcessRequest(purchase);
	}
}

