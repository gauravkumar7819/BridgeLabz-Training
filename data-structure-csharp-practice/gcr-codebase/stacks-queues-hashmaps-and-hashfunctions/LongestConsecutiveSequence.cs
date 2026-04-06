using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    static int FindLongest(int[] arr)
    {
        HashSet<int> set = new HashSet<int>(arr);
        int longest = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int current = num;
                int count = 1;

                while (set.Contains(current + 1))
                {
                    current++;
                    count++;
                }

                longest = Math.Max(longest, count);
            }
        }
        return longest;
    }

    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Longest Consecutive Length: " + FindLongest(arr));
    }
}
