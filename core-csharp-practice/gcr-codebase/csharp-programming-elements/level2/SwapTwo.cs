// 7. Create a program to swap two nums
// Hint:
// Create a variable num1 and take user input.
// Create a variable num2 and take user input.
// Swap num1 and num2 and print the swapped output.
// I/P => num1, num2
// O/P => The swapped nums are ___ and ___
using System;
class SwapTwo
{
    static void Main()
    {
        Console.WriteLine("Enter the first num:");
int num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second num:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Swapping the nums
        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("The swapped nums are " + num1 + " and " + num2);
    }
}