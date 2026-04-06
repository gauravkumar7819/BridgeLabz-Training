
using System;
class PositiveEven
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter number " + (i + 1) + ":");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i] + " is a positive even number.");
                }
                else
                {
                    Console.WriteLine(numbers[i] + " is a positive odd number.");
                }
            }
            else if (numbers[i] < 0)
            {
                Console.WriteLine(numbers[i] + " is a negative number.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        if (numbers[0] == numbers[4])
        {
            Console.WriteLine("The first and last elements are equal.");
        }
        else if (numbers[0] > numbers[4])
        {
            Console.WriteLine("The first element is greater than the last element.");
        }
        else
        {
            Console.WriteLine("The first element is less than the last element.");
        }
    }
}