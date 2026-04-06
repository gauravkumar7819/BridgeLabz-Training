using System;
class NaturalNumberSum
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = CalculateNaturalNumberSum(n);
        Console.WriteLine("Sum of first " + n + " natural numbers: " + sum);
    }
    public static int CalculateNaturalNumberSum(int n)
    {
       for (int i = 1; i <= n; i++)
        {
            n += i;
        }
        return n;
    }
}