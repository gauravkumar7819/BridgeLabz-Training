
using System;
class CalculatorSwitch
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double second = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /): ");
        string op = Console.ReadLine();

        double result;

        switch (op)
        {
            case "+":
                result = first + second;
                Console.WriteLine("Result: " + result);
                break;
            case "-":
                result = first - second;
                Console.WriteLine("Result: " + result);
                break;
            case "*":
                result = first * second;
                Console.WriteLine("Result: " + result);
                break;
            case "/":
               
                    result = first / second;
                    Console.WriteLine("Result: " + result);
                
               
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
