// 10. Write a program that takes your height in centimeters and converts it into feet and inches
// Hint: 1 foot = 12 inches and 1 inch = 2.54 cm
// I/P => height
// O/P => Your Height in cm is ___ while in feet is ___ and inches is ___
using System;
class CmtoFeet
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter your height in centimeters:");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        double inch = heightCm / 2.54;
        double feet = inch / 12;
        double remainingInches = inch % 12;

        Console.WriteLine("Your Height in cm is " + heightCm + " while in feet is " + (int)feet + " feet and " + remainingInches + " inches.");
    }
}