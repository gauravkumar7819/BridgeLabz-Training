using System;

public class Student
{
    public int rollNumber;
    protected string name;
    private double cgpa;

    public Student(int rollNumber, string name, double cgpa)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.cgpa = cgpa;
    }

    public void SetCGPA(double cgpa)
    {
        this.cgpa = cgpa;
    }

    public double GetCGPA()
    {
        return cgpa;
    }

    static void Main()
    {
        PostgraduateStudent pg = new PostgraduateStudent(101, "Amit Sharma", 8.2);

        pg.DisplayDetails();

        pg.SetCGPA(8.9);

        Console.WriteLine("Updated CGPA: " + pg.GetCGPA());
    }
}

class PostgraduateStudent : Student
{
    public PostgraduateStudent(int rollNumber, string name, double cgpa)
        : base(rollNumber, name, cgpa)
    {
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name);
    }
}
