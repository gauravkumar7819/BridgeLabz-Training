using System;

class AreaOfTriangle
{
    static void Main()
    {
        Console.Write("Enter the base of the triangle (in inches): ");
        double baseLength = Convert.ToDouble(Console.ReadLine());   

        Console.Write("Enter the height of the triangle (in inches): ");
        double height = Convert.ToDouble(Console.ReadLine());     

        double areaInSqInches = 0.5 * baseLength * height;

        double areaInSqCentimeters = areaInSqInches * 6.4516; // 1 sq in = 6.4516 sq cm

        Console.WriteLine("Area = {areaInSqInches} square inches");
        Console.WriteLine("Area = {areaInSqCentimeters} square centimeters");
    }
}
