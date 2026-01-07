using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
		//UC 2
		public void CalculateEmployeeWage()
			{
				const int WAGE_PER_HOUR = 20;
				const int FULL_DAY_HOURS = 8;
			for (int i = 0; i < employees.Length; i++)
			{
				Random random = new Random();
				int attendance = random.Next(0, 2); // 0 = Absent, 1 = Present

				if (attendance == 1)
				{
					Console.WriteLine("Employee " + (i + 1) + " Daily Wage: " + (FULL_DAY_HOURS * WAGE_PER_HOUR));

				}
				else
				{
					Console.WriteLine("Employee " + (i + 1) + " Daily Wage: 0");
				}
			}
			}
		//UC 3
		public void  CalculatePartTimeEmployeeWage()
		{
			const int WAGE_PER_HOUR = 20;
			const int PART_TIME_HOURS = 8;
			for (int i = 0; i < employees.Length; i++)
			{
				Random random = new Random();
				int attendance = random.Next(0, 2); // 0 = Absent, 1 = Present

				if (attendance == 1)
				{
					Console.WriteLine("Employee " + (i + 1) + " Daily Wage: " + (PART_TIME_HOURS * WAGE_PER_HOUR));

				}
				else
				{
					Console.WriteLine("Employee " + (i + 1) + " Daily Wage: 0");
				}
			}
		}



	}

}
	

