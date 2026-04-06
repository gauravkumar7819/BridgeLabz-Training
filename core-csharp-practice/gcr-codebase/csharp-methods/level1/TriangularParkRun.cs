
using System;
class TriangularParkRun
{
    static void Main()
    {
        Console.Write("Enter the length of s 1 in meters: ");
        double s1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of s 2 in meters: ");
        double s2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of s 3 in meters: ");
        double s3 = Convert.ToDouble(Console.ReadLine());
double result =Print(s1, s2, s3);
        Console.WriteLine("The total number of rounds the athlete will run is " + result + " to complete 5 km");
       
    }
    public static double Print( double s1, double s2, double s3)
    {
        double perimeter = s1 + s2 + s3;
        double distanceToRun = 5000; // 5 km in meters
        double rounds = distanceToRun / perimeter;
        return rounds;

    }
}