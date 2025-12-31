//using System;

//class Program
//{
//	static void Main()
//	{
//		Console.WriteLine("--- Bank Account Management System ---\n");

//		// Bank details
//		Console.Write("Enter Bank Name: ");
//		string bankName = Console.ReadLine();
//		Console.Write("Enter Bank Branch/Place: ");
//		string bankPlace = Console.ReadLine();
//		Console.Write("Enter Bank IFSC Code: ");
//		string bankIfsc = Console.ReadLine();

//		Bank bank = new Bank(bankName, bankPlace, bankIfsc);

//		// Create a user and open account
//		Console.WriteLine("\n--- Opening Account ---");
//		Console.Write("Enter User Name: ");
//		string userName = Console.ReadLine();
//		Console.Write("Enter User Place: ");
//		string userPlace = Console.ReadLine();
//		Console.Write("Enter User ID: ");
//		string userId = Console.ReadLine();
//		Console.Write("Enter Initial Deposit: ");
//		int initialDeposit = int.Parse(Console.ReadLine());

//		User user = new User(1, userName, userPlace, userId, initialDeposit);
//		bank.OpenAccount(user);

//		bool exit = false;
//		while (!exit)
//		{
//			Console.WriteLine("\n--- Main Menu ---");
//			Console.WriteLine("1. Deposit");
//			Console.WriteLine("2. Withdraw");
//			Console.WriteLine("3. Check Balance");
//			Console.WriteLine("4. Show User Details");
//			Console.WriteLine("5. Exit");
//			Console.Write("Enter your choice: ");
//			int choice = int.Parse(Console.ReadLine());

//			switch (choice)
//			{
//				case 1:
//					Console.Write("Enter amount to deposit: ");
//					int depAmount = int.Parse(Console.ReadLine());
//					user.Account.Deposit(depAmount);
//					break;

//				case 2:
//					Console.Write("Enter amount to withdraw: ");
//					int withAmount = int.Parse(Console.ReadLine());
//					user.Account.Withdraw(withAmount);
//					break;

//				case 3:
//					user.Account.CheckBalance();
//					break;

//				case 4:
//					bank.ShowAllUsers();
//					break;

//				case 5:
//					exit = true;
//					Console.WriteLine("Exiting system. Goodbye!");
//					break;

//				default:
//					Console.WriteLine("Invalid choice! Try again.");
//					break;
//			}
//		}
//	}
//}
