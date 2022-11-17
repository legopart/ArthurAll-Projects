namespace Observer.Sample1;

// The 'ConcreteObserver' class
class Investor : IInvestor
{
	public string Name { get; set; }
	public Stock? Stock { get; set; }

	// Constructor
	public Investor(string name)
	{
		Name = name;
	}

	public void Update(Stock stock)
	{
		Console.WriteLine("Notified {0} of {1}'s " +
			 "change to {2:C}", Name, stock.Symbol, stock.Price);
	}
}

