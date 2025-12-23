using System;
class Armstrong
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int originalNumber = number;
        int sum = 0;
        int digits = number.ToString().Length;

        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, digits);
            number /= 10;
        }

        if (sum == originalNumber)
        {
            Console.WriteLine(originalNumber + " is an Armstrong Number.");
        }
        else
        {
            Console.WriteLine(originalNumber + " is not an Armstrong Number.");
        }
    }
} 