
using System;
class Trigonometric
{
    static void Main(string[] args)
    {
        Console.Write("Enter the angle in degrees: ");
        double angleInDegrees = Convert.ToDouble(Console.ReadLine());
        double[] results = CalculateTrigonometricFunctions(angleInDegrees);

        Console.WriteLine("Sine: " + results[0]);
        Console.WriteLine("Cosine: " + results[1]);
        Console.WriteLine("Tangent: " + results[2]);
    }

    public static double[] CalculateTrigonometricFunctions(double angleInDegrees)
    {
        double angleInRadians = angleInDegrees * (Math.PI / 180);
        double sine = Math.Sin(angleInRadians);
        double cosine = Math.Cos(angleInRadians);
        double tangent = Math.Tan(angleInRadians);

        return new double[] { sine, cosine, tangent };
    }
}
