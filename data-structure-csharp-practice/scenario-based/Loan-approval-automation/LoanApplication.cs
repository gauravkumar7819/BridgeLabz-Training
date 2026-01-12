using System;
namespace Loan_approval_automation
{
	public class LoanApplication
	{
		public string LoanType { get; set; }
		public int Term { get; set; } // in months
		public double InterestRate { get; set; }

		public LoanApplication(string loanType, int term, double interestRate)
		{
			LoanType = loanType;
			Term = term;
			InterestRate = interestRate;
		}
	}
}