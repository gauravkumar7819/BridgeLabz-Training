using System;
using System.Collections.Generic;

class ATMDispenser
{
    static void DispenseCash(int amount, int[] denominations)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();
        int remaining = amount;

        foreach (int note in denominations)
        {
            if (remaining >= note)
            {
                int count = remaining / note;
                remaining = remaining % note;
                result[note] = count;
            }
        }

        if (remaining == 0)
        {
            Console.WriteLine("\nCash Dispensed Successfully:");
            foreach (var item in result)
            {
                Console.WriteLine("Rs " + item.Key + " x " + item.Value);
            }
        }
        else
        {
            Console.WriteLine("\nExact amount cannot be dispensed.");
            Console.WriteLine("Remaining amount: Rs " + remaining);
        }
    }

    static void Main()
    {
        Console.Write("Enter amount to withdraw: ");
        int amount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of available denominations: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] denominations = new int[n];

        Console.WriteLine("Enter denominations in descending order:");
        for (int i = 0; i < n; i++)
        {
            denominations[i] = Convert.ToInt32(Console.ReadLine());
        }

        DispenseCash(amount, denominations);
    }
}

