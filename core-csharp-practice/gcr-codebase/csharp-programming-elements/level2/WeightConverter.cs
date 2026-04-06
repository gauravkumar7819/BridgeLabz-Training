
using System;
class WeightConverter
{
    static void Main()
    {
        Console.Write("Enter the weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        double weightInKg = weightInPounds / 2.2; // 1 pound = 2.2 kg

        Console.WriteLine("The weight of the person in pounds is"+weightInPounds+"+ and in kg is "+weightInKg+" kg");
    }
}