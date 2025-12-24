using System;

class UptoTen
{
    static void Main(string[] args)
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int count = 0;

        while (true)
        {
            Console.WriteLine("Enter a number (0 or negative to stop):");
            double input = Convert.ToDouble(Console.ReadLine());

            if (input <= 0 || count >= 10)
            {
                break;
            }

            numbers[count] = input;
            count++;
        }

        Console.WriteLine("The numbers entered are:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }

        Console.WriteLine("The sum of all numbers is: " + total);
    }
}
