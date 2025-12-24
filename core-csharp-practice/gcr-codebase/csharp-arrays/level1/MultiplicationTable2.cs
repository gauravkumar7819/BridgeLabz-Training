using System;

class MultiplicationTable2
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Multiplication Table of " + number + " from 6 to 9 is:");
        for (int i = 6; i <= 9; i++)
        {

            
            Console.WriteLine(number + " x " + i + " = " + (number * i));
        }
    }
}
