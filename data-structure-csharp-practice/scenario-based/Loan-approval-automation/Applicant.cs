using System;
namespace Loan_approval_automation
{
	public class Applicant
	{
		public string Name { get; set; }
		private int creditScore;
		public double Income { get; set; }
		public double LoanAmount { get; set; }

		public Applicant(string name, int creditScore, double income, double loanAmount)
		{
			Name = name;
			this.creditScore = creditScore;
			Income = income;
			LoanAmount = loanAmount;
		}

		// Encapsulated getter for creditScore
		public int GetCreditScore()
		{
			return creditScore;
		}
	}
}