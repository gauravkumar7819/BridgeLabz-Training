
using System;
class DistanceConverter
{
    static void Main()
    {
        Console.Write("Enter the distance in feet: ");
        double disinFeet = Convert.ToDouble(Console.ReadLine());

        double disinYards = disinFeet / 3; // 1 yard = 3 feet
        double disinMiles = disinYards / 1760; // 1 mile = 1760 yards

        Console.WriteLine("Distance in Yards: {disinYards} yards");
        Console.WriteLine("Distance in Miles: {disinMiles} miles");
    }
}