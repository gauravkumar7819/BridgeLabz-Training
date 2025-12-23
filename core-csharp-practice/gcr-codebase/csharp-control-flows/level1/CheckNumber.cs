using System;
class CheckNumber
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            Console.WriteLine("The number " + number + " is positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number " + number + " is negative");
        }
        else
        {
            Console.WriteLine("The number is zero");
        }
    }
}