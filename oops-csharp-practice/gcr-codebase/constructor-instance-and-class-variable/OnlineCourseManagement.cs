using System;

class OnlineCourseManagement
{
    // Instance Variables
    string courseName;
    int duration;
    double fee;

    // Class Variable
    static string instituteName = "Default Institute";

    // Constructor (name must match the class)
    public OnlineCourseManagement(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance Method
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration: " + duration + " months");
        Console.WriteLine("Fee: " + fee);
        Console.WriteLine("Institute: " + instituteName);
    }

    // Class Method
    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
    }

    // Main method
    static void Main()
    {
        OnlineCourseManagement c1 = new OnlineCourseManagement("C# Advanced", 6, 12000);
        OnlineCourseManagement c2 = new OnlineCourseManagement("Java Basics", 4, 8000);

        Console.WriteLine("Before updating institute name:");
        c1.DisplayCourseDetails();
        Console.WriteLine();
        c2.DisplayCourseDetails();

        // Update class variable
        OnlineCourseManagement.UpdateInstituteName("Tech Academy");

        Console.WriteLine("\nAfter updating institute name:");
        c1.DisplayCourseDetails();
        Console.WriteLine();
        c2.DisplayCourseDetails();
    }
}
