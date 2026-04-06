using System;

class Smallestandlargest
{
    static void Main()
    {
        Console.Write("Enter how many numbers: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        int small = a[0];
        int large = a[0];

        for (int i = 1; i < n; i++)
        {
            if (a[i] < small)
                small = a[i];

            if (a[i] > large)
                large = a[i];
        }

        Console.WriteLine("Smallest number: " + small);
        Console.WriteLine("Largest number: " + large);
    }
}
