using System;

class EmployeeDetail
{
    // Private data members (Encapsulation)
    private int empId;
    private string empName;
    private double empSalary;

    // Public constructor
    public EmployeeDetail(int id, string name, double salary)
    {
        empId = id;
        empName = name;
        empSalary = salary;
    }

    // Public method to display data
    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + empId);
        Console.WriteLine("Employee Name: " + empName);
        Console.WriteLine("Employee Salary: " + empSalary);
    }

    static void Main(string[] args)
    {
        EmployeeDetail emp = new EmployeeDetail(101, "Gaurav", 55000.50);
        emp.DisplayDetails();
    }
}
