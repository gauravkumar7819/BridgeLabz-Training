class Bank
{
	public string BankName;
	public string BranchName;
	public string IFSC;

	private User[] users ;
	private int count;

	public Bank(string bankName, string branchName, string ifsc)
	{
		BankName = bankName;
		BranchName = branchName;
		IFSC = ifsc;
		users = new User[5]; // fixed size, no generics
		count = 0;
	}

	public void OpenAccount(User user)
	{
		if (user.Account.Balance < 1000)
		{
			Console.WriteLine("Minimum balance of 1000 required to open account");
			return;
		}

		if (count < users.Length)
		{
			users[count] = user;
			count++;
			Console.WriteLine("Account opened successfully for " + user.Name);
		}
		else
		{
			Console.WriteLine("Bank capacity full");
		}
	}

	public void ShowAllUsers()
	{
		Console.WriteLine("Bank Name: " + BankName + ", Branch: " + BranchName + ", IFSC: " + IFSC);
		Console.WriteLine("--------------------------------------------------");
		for (int i = 0; i < count; i++)
		{
			User u = users[i];
			Console.WriteLine(
				"User ID: " + u.UserId +
				", Name: " + u.Name +
				", Address: " + u.Address +
				", Account No: " + u.Account.AccountNumber +
				", Balance: " + u.Account.Balance
			);
		}
	}
}
