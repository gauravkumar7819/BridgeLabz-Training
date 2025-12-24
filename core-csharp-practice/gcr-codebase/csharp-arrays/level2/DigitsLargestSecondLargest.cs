using System;
class DigitsLargestSecondLargest
{
    static void Main()
    {
        int[] digits = new int[5];
        Console.WriteLine("Enter 5 digits:");
        for (int i = 0; i < 5; i++)
        {
            digits[i] = Convert.ToInt32(Console.ReadLine());
        }

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        for (int i = 0; i < 5; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);
    }
}