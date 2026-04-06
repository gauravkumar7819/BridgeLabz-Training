using System;

class Student
{
    public static string UniversityName = "Global University";
    private static int totalStudents = 0;

    public readonly int RollNumber;
    public string Name;
    public string Grade;

    public Student(string Name, int RollNumber, string Grade)
    {
        this.Name = Name;
        this.RollNumber = RollNumber;
        this.Grade = Grade;
        totalStudents++;
    }

    public void DisplayDetails()
    {
        if (this is Student)
        {
            Console.WriteLine("University: " + UniversityName);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Roll Number: " + RollNumber);
            Console.WriteLine("Grade: " + Grade);
        }
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + totalStudents);
    }

    static void Main()
    {
        Student s1 = new Student("Gaurav", 101, "A");
        Student s2 = new Student("Anita", 102, "B+");

        s1.DisplayDetails();
        Console.WriteLine();
        s2.DisplayDetails();
        Console.WriteLine();

        Student.DisplayTotalStudents();
    }
}
