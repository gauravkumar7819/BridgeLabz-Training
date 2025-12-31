class Account
{
	public string AccountNumber;
	public double Balance;

	public Account(string accountNumber, double initialBalance)
	{
		AccountNumber = accountNumber;
		Balance = initialBalance;
	}

	public void Deposit(double amount)
	{
		if (amount > 0)
		{
			Balance += amount;
			Console.WriteLine("Deposited: " + amount);
		}
		else
		{
			Console.WriteLine("Invalid deposit amount");
		}
	}

	public void Withdraw(double amount)
	{
		if (amount <= 0)
		{
			Console.WriteLine("Invalid withdraw amount");
		}
		else if (Balance >= amount)
		{
			Balance -= amount;
			Console.WriteLine("Withdrawn: " + amount);
		}
		else
		{
			Console.WriteLine("Insufficient balance! Overdraft not allowed.");
		}
	}

	public void CheckBalance()
	{
		Console.WriteLine("Account No: " + AccountNumber + ", Balance: " + Balance);
	}
}
