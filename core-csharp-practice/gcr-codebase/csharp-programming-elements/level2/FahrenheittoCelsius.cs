using System;
class FahrenheittoCelsius
{
    static void Main()
    {
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine(celsiusResult + " Celsius");
    }
}