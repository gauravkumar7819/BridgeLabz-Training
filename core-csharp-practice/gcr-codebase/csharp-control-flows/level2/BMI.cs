using System;
class BMI
{
    static void Main(string[] args)
    {
        Console.Write("Enter weight in kilograms: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height in meters: ");
        double height = Convert.ToDouble(Console.ReadLine());
double bmi = weight / (height * height);
        Console.WriteLine("Your BMI is: " + bmi);  

        if (bmi < 18.5)
        {
            Console.WriteLine("You are underweight.");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("You have a normal weight.");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("You are overweight.");
        }
        else
        {
            Console.WriteLine("You are obese.");
        }
}}