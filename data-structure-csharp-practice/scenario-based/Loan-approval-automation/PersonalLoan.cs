using System;
namespace Loan_approval_automation
{
	public class PersonalLoan : Loan
	{
		public PersonalLoan(double amount, int term) : base(amount, term, 12.0) // 12% interest
		{
		}

		public override bool ApproveLoan(Applicant applicant)
		{
			// Simple rule: creditScore >= 650 and income >= half of loan
			bool eligible = applicant.GetCreditScore() >= 650 && applicant.Income >= LoanAmount / 2;
			SetLoanStatus(eligible);
			return eligible;
		}

		public override double CalculateEMI()
		{
			// Personal loan EMI calculation can be slightly higher
			double emi = base.CalculateEMI() * 1.02; // +2% extra handling fee
			return Math.Round(emi, 2);
		}
	}
}