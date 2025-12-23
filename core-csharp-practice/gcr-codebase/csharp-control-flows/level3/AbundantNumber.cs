using System;
class AbundantNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sumOfDivisors = 0;

        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sumOfDivisors += i;
            }
        }

        if (sumOfDivisors > number)
        {
            Console.WriteLine(number + " is an Abundant Number.");
        }
        else
        {
            Console.WriteLine(number + " is not an Abundant Number.");
        }
    }
}