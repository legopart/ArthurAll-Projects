namespace Bridge.Sample1;

// The 'RefinedAbstraction' class
class Customers : CustomersBase
{
	public override void ShowAll()
	{
		// Add separator lines
		Console.WriteLine();
		Console.WriteLine("------------------------");
		base.ShowAll();
		Console.WriteLine("------------------------");
	}
}

