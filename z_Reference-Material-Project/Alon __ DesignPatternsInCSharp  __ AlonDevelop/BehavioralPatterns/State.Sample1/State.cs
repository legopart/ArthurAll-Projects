namespace State.Sample1;

// The 'State' abstract class
abstract class State
{
	protected double interest;
	protected double lowerLimit;
	protected double upperLimit;

	// Gets or sets the account
	public Account Account { get; set; }

	// Gets or sets the balance
	public double Balance { get; set; }

	public abstract void Deposit(double amount);
	public abstract void Withdraw(double amount);
	public abstract void PayInterest();
}

