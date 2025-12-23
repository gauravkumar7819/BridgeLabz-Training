// 8.Create a program to find the factors of a number taken as user input.
// Hint => 
// Get the input value for a variable named number.
// Run a for loop from i = 1 to i < number.
// In each iteration of the loop, check if number is perfectly divisible by i.
// If true, print the value of i.
using System;
class Factors   
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Factors of " + number + " are:");

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
