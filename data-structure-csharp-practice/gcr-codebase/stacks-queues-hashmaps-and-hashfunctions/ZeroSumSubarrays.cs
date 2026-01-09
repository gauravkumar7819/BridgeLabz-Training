using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    static void FindSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int sum = 0;

        map[0] = new List<int> { -1 };

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (map.ContainsKey(sum))
            {
                foreach (int start in map[sum])
                {
                    Console.WriteLine("Subarray: " + (start + 1) + " to " + i);
                }
                map[sum].Add(i);
            }
            else
            {
                map[sum] = new List<int> { i };
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        FindSubarrays(arr);
    }
}
