using System;

namespace employee_wage_computation
{
    sealed class EmployeeMenu
    {
        public void EmployeeChoice()
        {
            IEmployee employee = new EmployeeUtilityIMPL();
//uc-4 menu driven
//uc-4 menu driven
            Console.WriteLine("------ Employee Wage Computation ------");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Check Employee Attendance");
            Console.WriteLine("3. Calculate Daily Employee Wage");
            Console.WriteLine("4. Calculate Part Time Employee Wage");
            Console.WriteLine("Enter your choice:");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    employee.AddEmployee();
                    break;

                case 2:
                    employee.CheckEmployeeAttendance();
                    break;

                case 3:
                    employee.CalculateEmployeeWage();
                    break;

                case 4:
                    employee.CalculatePartTimeEmployeeWage();
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
