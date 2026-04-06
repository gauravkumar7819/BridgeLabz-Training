using System;

public class Employee
{
    public int employeeID;
    protected string department;
    private double salary;

    public Employee(int employeeID, string department, double salary)
    {
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    public void UpdateSalary(double salary)
    {
        this.salary = salary;
    }

    public double GetSalary()
    {
        return salary;
    }

    static void Main()
    {
        Manager mgr = new Manager(501, "IT", 60000);

        mgr.DisplayDetails();

        mgr.UpdateSalary(75000);

        Console.WriteLine("Updated Salary: " + mgr.GetSalary());
    }
}

public class Manager : Employee
{
    public Manager(int employeeID, string department, double salary)
        : base(employeeID, department, salary)
    {
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
    }
}
