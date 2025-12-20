
using System;
class TriangularParkRun
{
    static void Main()
    {
        Console.Write("Enter the length of side 1 in meters: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2 in meters: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3 in meters: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        double distanceToRun = 5000; // 5 km in meters
        double rounds = distanceToRun / perimeter;

        Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km");
    }
}