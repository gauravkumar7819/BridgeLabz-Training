using System;

namespace Loan_approval_automation
{
	// Abstract base class for all loans
	public abstract class Loan : IApprovable
	{
		protected double LoanAmount;
		protected int Term; // in months
		protected double InterestRate;
		private bool loanStatus; // Encapsulated

		// Constructor
		public Loan(double loanAmount, int term, double interestRate)
		{
			LoanAmount = loanAmount;
			Term = term;
			InterestRate = interestRate;
			loanStatus = false;
		}

		public virtual double CalculateEMI()
		{
			double r = InterestRate / 12 / 100; // monthly rate
			double emi = (LoanAmount * r * Math.Pow(1 + r, Term)) /
						 (Math.Pow(1 + r, Term) - 1);
			return Math.Round(emi, 2); // round to 2 decimals
		}

		public abstract bool ApproveLoan(Applicant applicant);

		protected void SetLoanStatus(bool status)
		{
			loanStatus = status;
		}

		public bool GetLoanStatus()
		{
			return loanStatus;
		}
	}
}
