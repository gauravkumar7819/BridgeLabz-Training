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

        Console.WriteLine("Is Duck Number: " + IsDuck(a));
        Console.WriteLine("Is Armstrong Number: " + IsArmstrong(a, cnt));

        int big = a[0], sBig = -1;
        int small = a[0], sSmall = int.MaxValue;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > big)
            {
                sBig = big;
                big = a[i];
            }
            else if (a[i] > sBig && a[i] != big)
            {
                sBig = a[i];
            }

            if (a[i] < small)
            {
                sSmall = small;
                small = a[i];
            }
            else if (a[i] < sSmall && a[i] != small)
            {
                sSmall = a[i];
            }
        }

        Console.WriteLine("Largest: " + big + " Second Largest: " + sBig);
        Console.WriteLine("Smallest: " + small + " Second Smallest: " + sSmall);
    }

    static int CountDigits(int n)
    {
        int c = 0;
        while (n > 0)
        {
            c++;
            n = n / 10;
        }
        return c;
    }

    static int[] GetDigits(int n, int cnt)
    {
        int[] a = new int[cnt];

        for (int i = cnt - 1; i >= 0; i--)
        {
            a[i] = n % 10;
            n = n / 10;
        }
        return a;
    }

    static bool IsDuck(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 0)
                return true;
        }
        return false;
    }

    static bool IsArmstrong(int[] a, int cnt)
    {
        int sum = 0;

        for (int i = 0; i < a.Length; i++)
        {
            int p = 1;
            for (int j = 0; j < cnt; j++)
                p = p * a[i];

            sum = sum + p;
        }

        int num = 0;
        for (int i = 0; i < a.Length; i++)
            num = num * 10 + a[i];

        return sum == num;
    }
}
