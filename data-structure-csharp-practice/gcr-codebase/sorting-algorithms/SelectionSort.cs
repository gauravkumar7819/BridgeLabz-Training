using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] scores = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter score: ");
            scores[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[min])
                    min = j;
            }

            // Manual swap (C# 5 compatible)
            int temp = scores[i];
            scores[i] = scores[min];
            scores[min] = temp;
        }

        Console.WriteLine("Sorted Scores:");
        foreach (int s in scores)
            Console.Write(s + " ");
    }
}
