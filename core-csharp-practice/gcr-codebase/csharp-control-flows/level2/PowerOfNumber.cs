// 7.Create a program to find the power of a number.
// Hint => 
// Get integer input for two variables named number and power.
// Create a result variable with an initial value of 1.
// Run a for loop from i = 1 to i <= power.
// In each iteration of the loop, multiply the result with the number and assign the value to the result.
// Finally, print the result
using System;
class PowerOfNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter the base number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        Console.WriteLine("The result of " + number + " raised to the power of " + power + " is: " + result);
    }
}