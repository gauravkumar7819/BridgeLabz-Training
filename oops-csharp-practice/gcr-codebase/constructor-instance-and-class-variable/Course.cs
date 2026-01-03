using System;

class Course
{
    // Instance variables
    string courseName;
    int duration;   // in months
    double fee;

    // Class variable
    static string instituteName = "ABC Institute";

    // Constructor
    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Institute: " + instituteName);
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration: " + duration + " months");
        Console.WriteLine("Fee: ₹" + fee);
        Console.WriteLine();
    }

    // Class (static) method
    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
    }



    static void Main()
    {
        Course c1 = new Course("C# Basics", 3, 5000);
        Course c2 = new Course("Java Advanced", 4, 7000);

        Console.WriteLine("Before Institute Update:\n");
        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();

        Course.UpdateInstituteName("XYZ Academy");  // Static method call

        Console.WriteLine("After Institute Update:\n");
        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();
    }

}