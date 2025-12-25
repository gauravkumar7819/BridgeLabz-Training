using System;

class NumberChecker
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int cnt = CountDigits(n);
        Console.WriteLine("Count of digits: " + cnt);

        int[] a = GetDigits(n, cnt);

        Console.Write("Digits are: ");
        for (int i = 0; i < a.Length; i++)
            Console.Write(a[i] + " ");
        Console.WriteLine();

        Console.WriteLine("Sum of digits: " + Sum(a));
        Console.WriteLine("Sum of squares of digits: " + SumOfSquares(a));
        Console.WriteLine("Is Harshad Number: " + IsHarshad(n, a));

        int[,] freq = Frequency(a);
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < freq.GetLength(0); i++)
        {
            Console.WriteLine("Digit: " + freq[i, 0] + " Frequency: " + freq[i, 1]);
        }
    }

    public static int CountDigits(int n)
    {
        int c = 0;
        while (n > 0)
        {
            c++;
            n = n / 10;
        }
        return c;
    }

    public static int[] GetDigits(int n, int cnt)
    {
        int[] a = new int[cnt];
        for (int i = cnt - 1; i >= 0; i--)
        {
            a[i] = n % 10;
            n = n / 10;
        }
        return a;
    }

    static int Sum(int[] a)
    {
        int s = 0;
        for (int i = 0; i < a.Length; i++)
            s += a[i];
        return s;
    }

    static int SumOfSquares(int[] a)
    {
        int s = 0;
        for (int i = 0; i < a.Length; i++)
            s += a[i] * a[i];
        return s;
    }

    static bool IsHarshad(int n, int[] a)
    {
        int s = Sum(a);
        return n % s == 0;
    }

    static int[,] Frequency(int[] a)
    {
        int[,] f = new int[10, 2]; // 0-digit, 1-count

        for (int i = 0; i < 10; i++)
        {
            f[i, 0] = i;
            f[i, 1] = 0;
        }

        for (int i = 0; i < a.Length; i++)
        {
            f[a[i], 1]++;
        }

        return f;
    }
}
