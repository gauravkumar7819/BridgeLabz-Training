using System;

class UnitConverter
{
    static void Main()
    {
        Console.Write("Enter value in km: ");
        double km = Convert.ToDouble(Console.ReadLine());
        double miles = KmToMiles(km);
        Console.WriteLine(km + " km = " + miles + " miles");

        Console.Write("Enter value in miles: ");
        double milesInput = Convert.ToDouble(Console.ReadLine());
        double kmValue = MilesToKm(milesInput);
        Console.WriteLine(milesInput + " miles = " + kmValue + " km");

        Console.Write("Enter value in meter: ");
        double meter = Convert.ToDouble(Console.ReadLine());
        double feet = MeterToFeet(meter);
        Console.WriteLine(meter + " meter = " + feet + " feet");

        Console.Write("Enter value in feet: ");
        double feetInput = Convert.ToDouble(Console.ReadLine());
        double meterValue = FeetToMeter(feetInput);
        Console.WriteLine(feetInput + " feet = " + meterValue + " meter");
    }

    static double KmToMiles(double km)
    {
        return km * 0.621371;
    }

    static double MilesToKm(double miles)
    {
        return miles * 1.60934;
    }

    static double MeterToFeet(double meter)
    {
        return meter * 3.28084;
    }

    static double FeetToMeter(double feet)
    {
        return feet * 0.3048;
    }
}
