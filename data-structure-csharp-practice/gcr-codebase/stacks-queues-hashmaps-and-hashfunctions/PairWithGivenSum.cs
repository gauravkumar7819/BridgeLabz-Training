using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    static bool HasPair(int[] arr, int target)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in arr)
        {
            if (set.Contains(target - num))
                return true;

            set.Add(num);
        }
        return false;
    }

    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter target sum: ");
        int target = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(HasPair(arr, target));
    }
}
