using System;

class Factors
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] fact = FindFactors(n);

        Console.WriteLine("Factors are:");
        for (int i = 0; i < fact.Length; i++)
        {
            Console.Write(fact[i] + " ");
        }

        Console.WriteLine("\nSum of factors = " + Sum(fact));
        Console.WriteLine("Product of factors = " + Product(fact));
        Console.WriteLine("Sum of squares of factors = " + SumOfSquares(fact));
    }

    static int[] FindFactors(int n)
    {
        int c = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                c++;
        }

        int[] fact = new int[c];
        int j = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                fact[j++] = i;
        }

        return fact;
    }

    static int Sum(int[] a)
    {
        int s = 0;
        for (int i = 0; i < a.Length; i++)
            s += a[i];

        return s;
    }

    static int Product(int[] a)
    {
        int p = 1;
        for (int i = 0; i < a.Length; i++)
            p *= a[i];

        return p;
    }

    static int SumOfSquares(int[] a)
    {
        int s = 0;
        for (int i = 0; i < a.Length; i++)
            s += a[i] * a[i];

        return s;
    }
}
