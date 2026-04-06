using System;
class AgeCalculation
{
    static void Main()
    {
        Console.WriteLine("Enter your birth year:");
        int birthYear=Convert.ToInt32(Console.ReadLine());
        int currYear=2024;
        int age = currYear - birthYear;
        Console.WriteLine(" Now you are  " + age+" years old");
       
    }
}