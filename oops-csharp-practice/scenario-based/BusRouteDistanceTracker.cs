using System;

class BusRouteDistanceTracker
{
    static void Main()
    {
        int totalDistance = 0;
        int distancePerStop = 2;
        string choice = "no";

        while (choice.ToLower() != "yes")
        {
            totalDistance += distancePerStop;

            Console.WriteLine("Bus reached a stop.");
            Console.WriteLine("Distance covered till now: " + totalDistance + " km");

            Console.Write("Do you want to get off here? (yes/no): ");
            choice = Console.ReadLine();
        }

        Console.WriteLine("Passenger got off.");
        Console.WriteLine("Total distance travelled: " + totalDistance + " km");
    }
}
