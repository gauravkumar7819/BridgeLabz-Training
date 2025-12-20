// 1. Write a program to take 2 numbers and print their quotient and remainder
// Hint: Use division operator (/) for quotient and modulus operator (%) for remainder
// I/P => a, b
// O/P => The Quotient is ___ and Remainder is ___ of two numbers ___ and ___
using System;
class QuotientRemainder
{
    static void Main()
    {
        Console.Write("Enter the first number  ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number  ");
        int b = Convert.ToInt32(Console.ReadLine());

        int quotient = a / b;
        int remainder = a % b;

        Console.WriteLine("The Quotient is "+quotient+" and Remainder is "+remainder +" of two numbers " +a+ " and "+b);
    }
}