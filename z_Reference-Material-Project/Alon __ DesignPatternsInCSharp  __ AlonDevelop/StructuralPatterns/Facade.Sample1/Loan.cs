namespace Facade.Sample1;

// The 'Subsystem ClassC' class
class Loan
{
	public bool HasNoBadLoans(Customer c)
	{
		Console.WriteLine("Check loans for " + c.Name);
		return true;
	}
}

