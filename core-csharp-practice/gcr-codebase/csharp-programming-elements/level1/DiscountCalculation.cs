
using System;
class DiscountCalculation
{
    static void Main()
    {
        int fee = 125000;
        int disPercent = 10;

        double disAmount = 0.1*fee;
        double disPrice = fee - disAmount;

        Console.WriteLine("Discount Amount: INR " + disAmount);
        Console.WriteLine("Price after Discount: INR " + disPrice);}
}