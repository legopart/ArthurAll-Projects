using System;

namespace State.Sample1;
class Program
{
	static void Main()
	{
		// Open a new account
		var account = new Account("Jim Johnson");

		// Apply financial transactions
		account.Deposit(500.0);
		account.Deposit(300.0);
		account.Deposit(550.0);
		account.PayInterest();
		account.Withdraw(2000.00);
		account.Withdraw(1100.00);
	}
}

