using System;
using System.Collections.Generic;
using System.Text;

namespace employee_wage_computation
{
	sealed class EmployeeMenu
	{
		
		public void EmployeeChoice()
		{
			IEmployee employee = new EmployeeUtilityIMPL();
			
			
			
					employee.AddEmployee();
					
			employee.CheckEmployeeAttendance();
employee.CalculateEmployeeWage();


		}
		}


	}

