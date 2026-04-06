// 7. Write a Program to compute the volume of Earth in km^3 and miles^3
// Hint: Volume of a Sphere is (4/3) * pi * r^3 and radius of earth is 6378 km
// O/P => The volume of earth in cubic kilometers is ____ and cubic miles is ____
using System;
class VolumeofEarth
{
    static void Main()
    {
        double radiusKm = 6378;
        double pi = 3.14;
        double volumeKm3 = (4.0 / 3.0) * pi * Math.Pow(radiusKm, 3);
        double volumeMiles3 = volumeKm3 * 0.239912; // 1 km^3 = 0.239912 miles^3
        Console.WriteLine("The volume of earth in cubic kilometers is " + volumeKm3 + " and cubic miles is " + volumeMiles3);
    }
}