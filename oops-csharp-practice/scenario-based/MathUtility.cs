using System;

class MathUtility
{
    // Factorial
    static int Factorial(int n)
    {
        if (n < 0)
            return -1;

        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        return fact;
    }

    // Prime Check
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    // GCD
    static int GCD(int a, int b)
    {
        if (a < 0) a = -a;
        if (b < 0) b = -b;

        while (a != b)
        {
            if (a > b)
                a = a - b;
            else
                b = b - a;
        }
        return a;
    }

    // Fibonacci
    static int Fibonacci(int n)
    {
        if (n < 0)
            return -1;

        if (n == 0)
            return 0;
        if (n == 1)
            return 1;

        int a = 0, b = 1, c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }

    static void Main()
    {
        // Factorial
        Console.Write("Enter number for Factorial: ");
        int factNum = Convert.ToInt32(Console.ReadLine());
        int factResult = Factorial(factNum);
        Console.WriteLine("Factorial = " + factResult);

        // Prime
        Console.Write("\nEnter number to check Prime: ");
        int primeNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Is Prime: " + IsPrime(primeNum));

        // GCD
        Console.Write("\nEnter first number for GCD: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number for GCD: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("GCD = " + GCD(num1, num2));

        // Fibonacci
        Console.Write("\nEnter n for Fibonacci: ");
        int fibNum = Convert.ToInt32(Console.ReadLine());
        int fibResult = Fibonacci(fibNum);
        Console.WriteLine("Fibonacci number = " + fibResult);
    }
}
