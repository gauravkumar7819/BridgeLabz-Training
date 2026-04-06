using System;
class PowerCalculation
{
    static void Main()
    {
        double  Num = 2;
        double exponent = 3;

        double result = Math.Pow( Num, exponent);

        Console.WriteLine("Result of Power Calculation is: " + result);
    }
}