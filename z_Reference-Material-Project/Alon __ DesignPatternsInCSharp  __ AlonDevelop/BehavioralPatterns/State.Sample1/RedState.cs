namespace State.Sample1;

// A 'ConcreteState' class
// Red state indicates account is overdrawn 
class RedState : State
{
	private double _serviceFee;

	// Constructor
	public RedState(State state)
	{
		Balance = state.Balance;
		Account = state.Account;
		Initialize();
	}

	private void Initialize()
	{
		// Should come from a datasource
		interest = 0.0;
		lowerLimit = -100.0;
		upperLimit = 0.0;
		_serviceFee = 15.00;
	}

	public override void Deposit(double amount)
	{
		Balance += amount;
		StateChangeCheck();
	}

	public override void Withdraw(double amount)
	{
		amount = amount - _serviceFee;
		Console.WriteLine("No funds available for withdrawal!");
	}

	public override void PayInterest()
	{
		// No interest is paid
	}

	private void StateChangeCheck()
	{
		if (Balance > upperLimit)
		{
			Account.State = new SilverState(this);
		}
	}
}

