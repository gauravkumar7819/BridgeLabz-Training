using System;

class MaxOfThree
{
    static void Main()
    {
        int a = GetNumber("Enter first number: ");
        int b = GetNumber("Enter second number: ");
        int c = GetNumber("Enter third number: ");

        int max = FindMax(a, b, c);

        Console.WriteLine("Maximum number is: " + max);
    }

    static int GetNumber(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    static int FindMax(int x, int y, int z)
    {
        int max = x;

        if (y > max) max = y;
        if (z > max) max = z;

        return max;
    }
}
