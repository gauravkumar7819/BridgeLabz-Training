
using System;
class DateArithmetic
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a date");
        string input = Console.ReadLine();
        DateTime date;

        if (DateTime.TryParse(input, out date))
        {
            date = date.AddDays(7);
            date = date.AddMonths(1);
            date = date.AddYears(2);
            date = date.AddDays(-21); // Subtracting 3 weeks

            Console.WriteLine("Modified Date: " + date.ToString("yyyy-MM-dd"));
        }
        else
        {
            Console.WriteLine("Invalid date format.");
        }
    }
}