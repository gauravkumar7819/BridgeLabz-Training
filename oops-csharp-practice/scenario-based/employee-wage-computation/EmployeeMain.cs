using System;
using System.Collections.Generic;
using System.Text;
using employee_wage_computation;

namespace employee_wage_computation
{
	internal class EmployeeMain
	{
		static void Main(string[] args)
		{

			EmployeeMenu _employee = new EmployeeMenu();
			_employee.EmployeeChoice();
			
		}
	}
}

