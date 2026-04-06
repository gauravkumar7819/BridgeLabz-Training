using System;
class HarshadNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sumOfDigits = 0;
        int temp = number;

        while (temp != 0)
        {
            sumOfDigits += temp % 10;
            temp /= 10;
        }

        if (number % sumOfDigits == 0)
        {
            Console.WriteLine(number + " is a Harshad Number.");
        }
        else
        {
            Console.WriteLine(number + " is not a Harshad Number.");
        }
    }
}