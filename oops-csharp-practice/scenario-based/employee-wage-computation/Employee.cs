using System;
using System.Collections.Generic;
using System.Text;

namespace employee_wage_computation
{
	public class Employee
	{

		// Encapsulated fields
		private int employeeId;
		private string name;
		private double baseSalary;

		// Getters & Setters
		public int EmployeeId
		{
			get { return employeeId; }
			set { employeeId = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public double BaseSalary
		{
			get { return baseSalary; }
			set { baseSalary = value; }
		}

		// ToString only
		public override string ToString()
		{
			return "ID: " + EmployeeId +
				   ", Name: " + Name +
				   ", Base Salary: " + BaseSalary;
		}
	}

}
