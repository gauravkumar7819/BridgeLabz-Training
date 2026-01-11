using System;

class CountingSort
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] ages = new int[n];
        int minAge = 10;
        int maxAge = 18;
        int[] count = new int[maxAge + 1];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter age (10-18): ");
            int age = int.Parse(Console.ReadLine());

            if (age >= minAge && age <= maxAge)
            {
                ages[i] = age;
                count[age]++;
            }
            else
            {
                Console.WriteLine("Invalid age! Enter between 10 and 18.");
                i--; // repeat input
            }
        }

        Console.WriteLine("Sorted Ages:");
        for (int i = minAge; i <= maxAge; i++)
        {
            while (count[i] > 0)
            {
                Console.Write(i + " ");
                count[i]--;
            }
        }
    }
}
