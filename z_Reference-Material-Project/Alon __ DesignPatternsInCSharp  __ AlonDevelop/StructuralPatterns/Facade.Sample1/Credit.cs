namespace Facade.Sample1;

// The 'Subsystem ClassB' class
class Credit
{
	public bool HasGoodCredit(Customer c)
	{
		Console.WriteLine("Check credit for " + c.Name);
		return true;
	}
}

