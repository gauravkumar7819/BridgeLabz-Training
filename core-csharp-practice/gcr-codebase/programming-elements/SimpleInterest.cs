using System;
class SimpleInterest
{
    static void Main()
    {
        double p = 1000;
        double r = 5;
        double t = 3;

        double simpleInterest = (p * r * t) / 100;

        Console.WriteLine("Simple Interest is: " + simpleInterest);
    }
}