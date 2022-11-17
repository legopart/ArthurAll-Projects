namespace Observer.Sample1;
class Program
{
	static void Main()
	{
		// Create IBM stock and attach investors
		var ibm = new IBM("IBM", 120.0);
		ibm.Attach(new Investor("Sorros"));
		ibm.Attach(new Investor("Berkshire"));

		// Fluctuating prices will notify investors
		ibm.Price = 120.10;
		ibm.Price = 121.00;
		ibm.Price = 120.50;
		ibm.Price = 120.75;

	}
}

