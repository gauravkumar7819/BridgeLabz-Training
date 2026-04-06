using System;

class UnitConvertorV3
{
    static void Main()
    {
        Console.Write("Enter Fahrenheit: ");
        double f = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(f + " F = " + FahrenheitToCelsius(f) + " C");

        Console.Write("Enter Celsius: ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(c + " C = " + CelsiusToFahrenheit(c) + " F");

        Console.Write("Enter pounds: ");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(p + " pounds = " + PoundsToKilograms(p) + " kg");

        Console.Write("Enter kilograms: ");
        double k = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(k + " kg = " + KilogramsToPounds(k) + " pounds");

        Console.Write("Enter gallons: ");
        double g = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(g + " gallons = " + GallonsToLiters(g) + " liters");

        Console.Write("Enter liters: ");
        double l = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(l + " liters = " + LitersToGallons(l) + " gallons");
    }

    static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    static double PoundsToKilograms(double p)
    {
        return p * 0.453592;
    }

    static double KilogramsToPounds(double k)
    {
        return k * 2.20462;
    }

    static double GallonsToLiters(double g)
    {
        return g * 3.78541;
    }

    static double LitersToGallons(double l)
    {
        return l * 0.264172;
    }
}
