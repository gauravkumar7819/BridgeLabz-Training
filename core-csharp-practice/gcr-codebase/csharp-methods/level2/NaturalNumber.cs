
using System;
class NaturalNumber 
{
    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("The number is not a natural number. Exiting.");
            return;
        }

        int sumRecursive = CalculateNaturalNumberSum(n);
        Console.WriteLine("Sum of first " + n + " natural numbers using recursion: " + sumRecursive);

        int sumFormula = n * (n + 1) / 2;
        Console.WriteLine("Sum of first " + n + " natural numbers using formula: " + sumFormula);

        if (sumRecursive == sumFormula)
        {
            Console.WriteLine("Both methods give the same result.");
        }
        else
        {
            Console.WriteLine("The results do not match.");
        }
    }
    public static int CalculateNaturalNumberSum(int n)
    {
        if (n == 1)
            return 1;
        return n + CalculateNaturalNumberSum(n - 1);
    }
}