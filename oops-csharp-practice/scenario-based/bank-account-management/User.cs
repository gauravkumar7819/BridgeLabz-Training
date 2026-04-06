class User
{
	public int UserId;
	public string Name;
	public string Address;
	public Account Account;

	public User(int userId, string name, string address, string accountNumber, double initialBalance)
	{
		UserId = userId;
		Name = name;
		Address = address;
		Account = new Account(accountNumber, initialBalance);
	}
}
