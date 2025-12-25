using System;

class NumberCheckerV4
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

        Console.Write("Reversed Digits: ");
        int[] rev = ReverseArray(a);
        for (int i = 0; i < rev.Length; i++)
            Console.Write(rev[i] + " ");
        Console.WriteLine();

        Console.WriteLine("Is Palindrome: " + IsPalindrome(a, rev));
    }

    static int CountDigits(int n)
    {
        int c = 0;
        while (n > 0)
        {
            c++;
            n /= 10;
        }
        return c;
    }

    static int[] GetDigits(int n, int cnt)
    {
        int[] a = new int[cnt];
        for (int i = cnt - 1; i >= 0; i--)
        {
            a[i] = n % 10;
            n /= 10;
        }
        return a;
    }

    static int[] ReverseArray(int[] a)
    {
        int[] rev = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
            rev[i] = a[a.Length - 1 - i];
        return rev;
    }

    static bool IsPalindrome(int[] a, int[] rev)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != rev[i])
                return false;
        }
        return true;
    }
}
