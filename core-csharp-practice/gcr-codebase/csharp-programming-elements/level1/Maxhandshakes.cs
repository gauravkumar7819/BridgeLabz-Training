
using System;
class Maxhandshakes
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numOfStu = Convert.ToInt32(Console.ReadLine());

        int maxhand = (numOfStu * (numOfStu - 1)) / 2;

        Console.WriteLine("\nThe maximum number of handshakes among {numOfStu} students is {maxhand}");
    }
}