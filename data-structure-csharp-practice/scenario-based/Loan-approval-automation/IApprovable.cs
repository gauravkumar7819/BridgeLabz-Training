
namespace Loan_approval_automation
{
	public interface IApprovable
	{
		bool ApproveLoan(Applicant applicant);
		double CalculateEMI();
	}
}