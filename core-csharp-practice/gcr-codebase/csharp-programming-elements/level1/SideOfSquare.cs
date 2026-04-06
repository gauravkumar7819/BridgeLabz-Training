using System;
class SideOfSquare
{
    static void Main()
    {
        Console.Write("Enter the perimeter of the square (in units): ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        double sideLength = perimeter / 4;

        Console.WriteLine("\n---------------------------");
        Console.WriteLine("The length of the side is {sideLength} units whose perimeter is {perimeter} units");
        Console.WriteLine("---------------------------");
    }
}
