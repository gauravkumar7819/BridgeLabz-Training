
using System;
class Intoperation
{
    static void Main()
    {
        Console.Write("Enter the value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int oper1 = a + b * c;
        int oper2 = a * b + c;
        int oper3 = c + a / b;
        int oper4 = a % b + c;

        Console.WriteLine("The results of Int opers are " + oper1 + ", " + oper2 + ", " + oper3 + ", and " + oper4);
    }
}