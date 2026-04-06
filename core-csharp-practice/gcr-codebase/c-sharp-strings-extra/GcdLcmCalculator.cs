using System;

class GcdLcmCalculator
{
    static void Main()
    {
        int a = GetNumber("Enter first number: ");
        int b = GetNumber("Enter second number: ");

        int gcd = FindGCD(a, b);
        int lcm = FindLCM(a, b, gcd);

        Console.WriteLine("GCD: " + gcd);
        Console.WriteLine("LCM: " + lcm);
    }

    static int GetNumber(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    static int FindGCD(int x, int y)
    {
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        return x;
    }

    static int FindLCM(int x, int y, int gcd)
    {
        return (x * y) / gcd;
    }
}
