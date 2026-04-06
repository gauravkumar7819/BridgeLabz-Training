

using System;
class LeapYear
{
    static void Main()
    {
        Console.Write("Enter the year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        string result = CheckLeapYear(year);
        Console.WriteLine(result);
    }
    public static string CheckLeapYear(int year)
    {
        if (year >= 1582)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return "The Year is a Leap Year";
            }
            else
            {
                return "The Year is not a Leap Year";
            }
        }
        else
        {
            return "Please enter a year greater than or equal to 1582";
        }
    }
}