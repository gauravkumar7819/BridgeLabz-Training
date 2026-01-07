using System;
using System.Collections.Generic;
using System.Text;
using employee_wage_computation;

namespace employee_wage_computation
{
	internal class EmployeeUtilityIMPL : IEmployee
	{
		Employee[] employees = new Employee[2];
		public void AddEmployee()
		{
			for (int i = 0; i < employees.Length; i++)
			{
				employees[i] = new Employee();
				Console.WriteLine("Enter Employee " + (i + 1) + " ID:");
				employees[i].EmployeeId = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter Employee " + (i + 1) + " Name:");
				employees[i].Name = Console.ReadLine();
				Console.WriteLine("Enter Employee " + (i + 1) + " Base Salary:");
				employees[i].BaseSalary = Convert.ToDouble(Console.ReadLine());
			}
			Console.WriteLine("Employees added successfully!");


		}
		//UC 1
		public void CheckEmployeeAttendance()
		{
			Random random = new Random();
		

			for (int i = 0; i < employees.Length; i++)
			{
				int attendance = random.Next(0, 2);
				if (attendance == 1)
				{
					Console.WriteLine("Employee " + (i + 1) + " is Present");
				}
				else
				{
					Console.WriteLine("Employee " + (i + 1) + " is absent");
				}

			}

		}
	}
}
	

