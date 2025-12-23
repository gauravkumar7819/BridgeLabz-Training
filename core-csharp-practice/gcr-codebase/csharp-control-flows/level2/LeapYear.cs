using System;
class LeapYear
{
    static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (IsLeapYear(year))
        {
            Console.WriteLine(year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }

    static bool IsLeapYear(int year)
    {

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true; // Divisible by 400
                }
                return false; // Divisible by 100 but not by 400
            }
            return true; // Divisible by 4 but not by 100
        }
        return false; // Not divisible by 4
    }
}