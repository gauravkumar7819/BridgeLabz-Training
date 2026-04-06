using System;

namespace Loan_approval_automation
{
	public class HomeLoan : Loan
	{
		public HomeLoan(double amount, int term) : base(amount, term, 7.5)
		{
		}

		public override bool ApproveLoan(Applicant applicant)
		{
			bool eligible = applicant.GetCreditScore() >= 700 && applicant.Income >= LoanAmount / 3;
			SetLoanStatus(eligible);
			return eligible;
		}

		public override double CalculateEMI()
		{
			return base.CalculateEMI();
		}
	}
}