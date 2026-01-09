using System;
using System.Collections.Generic;

class StockSpan
{
    public static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
            stack.Push(i);
        }

        return span;
    }

    static void Main()
    {
        Console.Write("Enter number of days: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] prices = new int[n];
        Console.WriteLine("Enter stock prices:");

        for (int i = 0; i < n; i++)
        {
            prices[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] result = CalculateSpan(prices);

        Console.WriteLine("\nStock Spans:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}
