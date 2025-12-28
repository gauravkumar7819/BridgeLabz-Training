using System;

class FactorialRecursion
{
    static void Main()
    {
        int number = GetNumber();
        int result = Factorial(number);
        ShowResult(result);
    }

    static int GetNumber()
    {
        Console.Write("Enter a number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static int Factorial(int n)
    {
        if (n == 0)
            return 1;

        return n * Factorial(n - 1);
    }

    static void ShowResult(int result)
    {
        Console.WriteLine("Factorial is: " + result);
    }
}
