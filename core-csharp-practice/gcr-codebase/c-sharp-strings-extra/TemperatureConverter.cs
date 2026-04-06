using System;

class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Choose option: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter temperature: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (choice == 1)
            Console.WriteLine("Result: " + CelsiusToFahrenheit(temp));
        else if (choice == 2)
            Console.WriteLine("Result: " + FahrenheitToCelsius(temp));
        else
            Console.WriteLine("Invalid choice");
    }

    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
}
