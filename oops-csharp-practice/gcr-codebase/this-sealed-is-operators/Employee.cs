using System;

class Employee
{
    public static string CompanyName = "TechCorp";
    private static int totalEmployees = 0;

    public readonly int Id;
    public string Name;
    public string Designation;

    public Employee(string Name, int Id, string Designation)
    {
        this.Name = Name;
        this.Id = Id;
        this.Designation = Designation;
        totalEmployees++;
    }

    public void DisplayDetails()
    {
        if (this is Employee)
        {
            Console.WriteLine("Company: " + CompanyName);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Designation: " + Designation);
        }
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    static void Main()
    {
        Employee e1 = new Employee("Gaurav", 101, "Developer");
        Employee e2 = new Employee("Anita", 102, "Manager");

        e1.DisplayDetails();
        Console.WriteLine();
        e2.DisplayDetails();
        Console.WriteLine();

        Employee.DisplayTotalEmployees();
    }
}
