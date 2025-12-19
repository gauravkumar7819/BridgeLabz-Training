using System;
class ProfinandLoss
{
    static void Main()
    {
        double cP = 129.0;
        double sP = 191.0;

        if (sP > cP)
        {
            double profit = sP - cP;
            double profitPercent = (profit / cP) * 100;
            Console.WriteLine("Profit: INR " + profit);
            Console.WriteLine("Profit Percentage: " + profitPercent + "%");
        }
        else if (cP > sP)
        {
            double loss = cP - sP;
            double lossPercent = (loss / cP) * 100;
            Console.WriteLine("Loss: INR " + loss);
            Console.WriteLine("Loss Percentage: " + lossPercent + "%");
        }
        else
        {
            Console.WriteLine("No Profit No Loss");
        }
    }
}