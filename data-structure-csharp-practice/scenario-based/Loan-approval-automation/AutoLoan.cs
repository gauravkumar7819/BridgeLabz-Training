using System;
namespace Loan_approval_automation
{
	public class AutoLoan : Loan
	{
		public AutoLoan(double amount, int term) : base(amount, term, 9.0)
		{
		}

		public override bool ApproveLoan(Applicant applicant)
		{
			bool eligible = applicant.GetCreditScore() >= 680 && applicant.Income >= LoanAmount * 0.4;
			SetLoanStatus(eligible);
			return eligible;
		}

		public override double CalculateEMI()
		{
			// Auto loan EMI normal
			return base.CalculateEMI();
		}
	}
}