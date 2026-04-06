using System;
class SimpleInterest
{
    static void Main()
    {
        Console.Write("Enter amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time : ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
    }
}