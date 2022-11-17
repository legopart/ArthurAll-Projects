namespace Observer.Sample1;

// The 'Subject' abstract class
abstract class Stock
{
	private double _price;
	private List<IInvestor> _investors = new List<IInvestor>();

	// Constructor
	public Stock(string symbol, double price)
	{
		Symbol = symbol;
		_price = price;
	}

	public void Attach(IInvestor investor)
	{
		_investors.Add(investor);
	}

	public void Detach(IInvestor investor)
	{
		_investors.Remove(investor);
	}

	public void Notify()
	{
		foreach (IInvestor investor in _investors)
		{
			investor.Update(this);
		}
		Console.WriteLine();
	}

	// Gets or sets the price
	public double Price
	{
		get { return _price; }
		set
		{
			if (_price != value)
			{
				_price = value;
				Notify();
			}
		}
	}

	public string Symbol { get; private set; }
}

