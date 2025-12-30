using System;
class AreaOfCircle
{
    private double radius;
    private const double pi = 3.14;
    public AreaOfCircle(double r)
    {
        radius = r;

    }

    public double CalculateArea()
    {
        return pi * radius * radius;}
    static void Main(string[] args)
    {
        Console.WriteLine("Enter radius of circle:");
        double radius = Convert.ToDouble(Console.ReadLine());
        
       AreaOfCircle     area = new AreaOfCircle(radius);
        double result = area.CalculateArea();
        Console.WriteLine("Area of Circle: " + result);
    }
}