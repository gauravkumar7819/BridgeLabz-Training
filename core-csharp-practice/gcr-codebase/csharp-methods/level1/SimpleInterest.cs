using System;
class SimpleInterest
{
    static void Main(string[] args)
    {
      double principal = Convert.ToDouble(Console.ReadLine());
      double rate = Convert.ToDouble(Console.ReadLine());
      double time = Convert.ToDouble(Console.ReadLine());
            

        double interest = CalculateSimpleInterest(principal, rate, time);
        Console.WriteLine("Simple Interest: " + interest);
    }
    public static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }
}