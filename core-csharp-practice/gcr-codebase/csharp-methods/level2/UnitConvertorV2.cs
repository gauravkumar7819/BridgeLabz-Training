using System;

class UnitConvertorV2
{
    static void Main()
    {
        Console.Write("Enter yards: ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(y + " yards = " + YardsToFeet(y) + " feet");

        Console.Write("Enter feet: ");
        double f = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(f + " feet = " + FeetToYards(f) + " yards");

        Console.Write("Enter meters: ");
        double m = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(m + " meters = " + MetersToInches(m) + " inches");

        Console.Write("Enter inches: ");
        double i = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(i + " inches = " + InchesToMeters(i) + " meters");

        Console.Write("Enter inches again: ");
        double icm = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(icm + " inches = " + InchesToCentimeters(icm) + " cm");
    }

    static double YardsToFeet(double y)
    {
        return y * 3;
    }

    static double FeetToYards(double f)
    {
        return f * 0.333333;
    }

    static double MetersToInches(double m)
    {
        return m * 39.3701;
    }

    static double InchesToMeters(double i)
    {
        return i * 0.0254;
    }

    static double InchesToCentimeters(double i)
    {
        return i * 2.54;
    }
}
