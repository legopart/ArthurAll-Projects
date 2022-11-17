namespace State.Sample1;

// The 'Context' class
class Account
{
	private string _owner;

	// Constructor
	public Account(string owner)
	{
		// New accounts are 'Silver' by default
		this._owner = owner;
		this.State = new SilverState(0.0, this);
	}

	// Gets the balance
	public double Balance
	{
		get { return State.Balance; }
	}

	// Gets or sets state
	public State State { get; set; }

	public void Deposit(double amount)
	{
		State.Deposit(amount);
		Console.WriteLine("Deposited {0:C} --- ", amount);
		Display();
	}

	public void Withdraw(double amount)
	{
		State.Withdraw(amount);
		Console.WriteLine("Withdrew {0:C} --- ", amount);
		Display();
	}

	public void PayInterest()
	{
		State.PayInterest();
		Console.WriteLine("Interest Paid --- ");
		Display();
	}

	private void Display()
	{
		Console.WriteLine(" Balance = {0:C}", Balance);
		Console.WriteLine(" Status  = {0}\n", State.GetType().Name);
		//Console.WriteLine();
	}
}

