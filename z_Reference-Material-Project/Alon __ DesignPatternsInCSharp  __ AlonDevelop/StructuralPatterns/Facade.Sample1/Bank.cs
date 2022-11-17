namespace Facade.Sample1;

// The 'Subsystem ClassA' class
class Bank
{
	public bool HasSufficientSavings(Customer c, int amount)
	{
		Console.WriteLine("Check bank for " + c.Name);
		return true;
	}
}

