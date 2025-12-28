using System;

class DateComparison
{
    static void Main()
    {
        Console.Write("Enter first date (yyyy-MM-dd): ");
        DateTime date1 = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Enter second date (yyyy-MM-dd): ");
        DateTime date2 = Convert.ToDateTime(Console.ReadLine());

        if (date1 < date2)
        {
            Console.WriteLine("First date is before second date.");
        }
        else if (date1 > date2)
        {
            Console.WriteLine("First date is after second date.");
        }
        else
        {
            Console.WriteLine("Both dates are the same.");
        }
    }
}
