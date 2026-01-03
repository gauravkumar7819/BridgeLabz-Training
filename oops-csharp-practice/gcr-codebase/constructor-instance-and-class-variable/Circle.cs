using System;

class Circle
{
    double radius;

    // Default constructor
    public Circle()
    {
        radius = 1.0; // default radius
    }

    // Parameterized constructor (constructor chaining)
    public Circle(double radius) : this()
    {
        this.radius = radius;
    }

    public void Display()
    {
        Console.WriteLine("Radius: " + radius);
    }
}

class Program
{
    static void Main()
    {
        Circle c1 = new Circle();       // default
        Circle c2 = new Circle(5.5);    // user provided

        c1.Display();
        c2.Display();
    }
}
