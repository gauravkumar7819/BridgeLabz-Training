using System;

namespace Loan_approval_automation
{
	internal class Menu
	{
		public void ChoiceMenu()
		{
			bool exit = false;

			while (!exit)
			{
				Console.WriteLine("\n=== Welcome to LoanBuddy ===");
				Console.WriteLine("1. Personal Loan");
				Console.WriteLine("2. Home Loan");
				Console.WriteLine("3. Auto Loan");
				Console.WriteLine("4. Exit");
				Console.Write("Enter your choice: ");

				int choice = Convert.ToInt32(Console.ReadLine());

				if (choice == 1)
					ApplyLoan("Personal");
				else if (choice == 2)
					ApplyLoan("Home");
				else if (choice == 3)
					ApplyLoan("Auto");
				else if (choice == 4)
				{
					exit = true;
					Console.WriteLine("Thank you for using LoanBuddy!");
				}
				else
					Console.WriteLine("Invalid choice! Try again.");
			}
		}

		private void ApplyLoan(string loanType)
		{
			// Get applicant details
			Console.Write("Name: ");
			string name = Console.ReadLine();

			Console.Write("Credit Score: ");
			int creditScore = Convert.ToInt32(Console.ReadLine());

			Console.Write("Income: ");
			double income = Convert.ToDouble(Console.ReadLine());

			Console.Write("Loan Amount: ");
			double loanAmount = Convert.ToDouble(Console.ReadLine());

			Applicant applicant = new Applicant(name, creditScore, income, loanAmount);

			Loan loan = null;

			// Simple if-else for loan type
			if (loanType == "Personal")
				loan = new PersonalLoan(loanAmount, 12);
			else if (loanType == "Home")
				loan = new HomeLoan(loanAmount, 240);
			else if (loanType == "Auto")
				loan = new AutoLoan(loanAmount, 60);

			if (loan != null)
			{
				if (loan.ApproveLoan(applicant))
				{
					Console.WriteLine("Loan Approved!");
					Console.WriteLine("EMI: " + loan.CalculateEMI());
				}
				else
				{
					Console.WriteLine("Loan Rejected!");
				}
			}
		}
	}
}
