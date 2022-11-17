namespace Observer.Sample1;

// The 'ConcreteSubject' class
class IBM : Stock
{
	// Constructor
	public IBM(string symbol, double price)
		: base(symbol, price)
	{
	}
}

