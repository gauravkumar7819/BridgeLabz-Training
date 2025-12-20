using System;

class DistanceAndSpeedCalculator
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter starting city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter destination city: ");
        string toCity = Console.ReadLine();

        Console.Write("Distance from starting city to via city (miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Distance from via city to final city (miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Total time taken for journey (hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        Console.WriteLine();
        Console.WriteLine("Trip Summary");
        Console.WriteLine("------------");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Route: " + fromCity + " -> " + viaCity + " -> " + toCity);
        Console.WriteLine("Total Distance: " + totalDistance + " miles");
        Console.WriteLine("Time Taken: " + timeTaken + " hours");
        Console.WriteLine("Average Speed: " + averageSpeed + " miles/hour");
    }
}
