
using System;
class RandomValues
{
    static void Main()
    {
        Console.Write("Enter the number of random values to generate: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] randomValues = Generate4DigitRandomArray(size);
        double[] results = FindAverageMinMax(randomValues);

        Console.WriteLine("Average: " + results[0]);
        Console.WriteLine("Minimum: " + results[1]);
        Console.WriteLine("Maximum: " + results[2]);
    }

    public static int[] Generate4DigitRandomArray(int size)
    {
        Random rand = new Random();
        int[] randomNumbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            randomNumbers[i] = rand.Next(1000, 10000); // Generates a 4-digit number
        }
        return randomNumbers;
    }

    public static double[] FindAverageMinMax(int[] numbers)
    {
        int sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        foreach (int num in numbers)
        {
            sum += num;
            if (num < min) min = num;
            if (num > max) max = num;
        }

        double average = (double)sum / numbers.Length;
        return new double[] { average, min, max };
    }
}