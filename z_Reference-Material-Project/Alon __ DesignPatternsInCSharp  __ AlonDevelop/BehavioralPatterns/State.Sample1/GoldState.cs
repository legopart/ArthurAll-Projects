namespace State.Sample1;

/// <summary>
/// A 'ConcreteState' class
/// <remarks>
/// Gold incidates interest bearing state
/// </remarks>
/// </summary>
class GoldState : State
{
	// Overloaded constructors
	public GoldState(State state)
		: this(state.Balance, state.Account)
	{
	}

	public GoldState(double balance, Account account)
	{
		Balance = balance;
		Account = account;
		Initialize();
	}

	private void Initialize()
	{
		// Should come from a database
		interest = 0.05;
		lowerLimit = 1000.0;
		upperLimit = 10000000.0;
	}

	public override void Deposit(double amount)
	{
		Balance += amount;
		StateChangeCheck();
	}

	public override void Withdraw(double amount)
	{
		Balance -= amount;
		StateChangeCheck();
	}

	public override void PayInterest()
	{
		Balance += interest * Balance;
		StateChangeCheck();
	}

	private void StateChangeCheck()
	{
		if (Balance < 0.0)
		{
			Account.State = new RedState(this);
		}
		else if (Balance < lowerLimit)
		{
			Account.State = new SilverState(this);
		}
	}
}

