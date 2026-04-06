using System;

class RodCutter
{
    private int rodLength;
    private int[] price;

    // Method to take input
    public void TakeInput()
    {
        Console.Write("Enter rod length: ");
        rodLength = Convert.ToInt32(Console.ReadLine());

        price = new int[rodLength];

        for (int i = 0; i < rodLength; i++)
        {
            Console.Write("Enter price for length " + (i + 1) + ": ");
            price[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

     public void CalculateMaxRevenue()
    {
        int bestPrice = 0;
        int bestLength = 1;

       
        for (int i = 0; i < rodLength; i++)
        {
            if (price[i] > bestPrice)
            {
                bestPrice = price[i];
                bestLength = i + 1;
            }
        }

        int remainingRod = rodLength;
        int maxRevenue = 0;

        while (remainingRod >= bestLength)
        {
            maxRevenue = maxRevenue + bestPrice;
            remainingRod = remainingRod - bestLength;
        }

        Console.WriteLine("Maximum Revenue (Multiple Cuts, No DP): " + maxRevenue);
    }
}

class Program
{
    static void Main()
    {
        RodCutter cutter = new RodCutter();
        cutter.TakeInput();
        cutter.CalculateMaxRevenue();
    }
}
