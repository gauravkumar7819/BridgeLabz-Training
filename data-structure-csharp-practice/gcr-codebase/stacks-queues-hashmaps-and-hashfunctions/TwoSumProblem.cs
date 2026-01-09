using System;
using System.Collections.Generic;

class TwoSumProblem
{
    static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int needed = target - nums[i];

            if (map.ContainsKey(needed))
                return new int[] { map[needed], i };

            map[nums[i]] = i;
        }
        return new int[] { -1, -1 };
    }

    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] nums = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            nums[i] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter target sum: ");
        int target = Convert.ToInt32(Console.ReadLine());

        int[] result = TwoSum(nums, target);
        Console.WriteLine("Indices: " + result[0] + ", " + result[1]);
    }
}
