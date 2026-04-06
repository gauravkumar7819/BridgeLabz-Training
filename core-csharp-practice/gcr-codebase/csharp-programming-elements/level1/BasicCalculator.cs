
using System;
class BasicCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double add = num1 + num2;
        double sub = num1 - num2;
        double mul = num1 * num2;
        double div = num1 / num2;

        Console.WriteLine("The add of " + num1 + " and " + num2 + " is " + add);
        Console.WriteLine("The sub of " + num1 + " and " + num2 + " is " + sub);
        Console.WriteLine("The mul of " + num1 + " and " + num2 + " is " + mul);
        Console.WriteLine("The div of " + num1 + " and " + num2 + " is " + div);
    }
}