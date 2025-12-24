using System;
class SaveOddandEven
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the limit");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];
        int[] oddNumbers = new int[n];
        int[] evenNumbers = new int[n];
        int j = 0;
        int k = 0;

        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            if (numbers[i] % 2 == 0)
            {
                evenNumbers[k] = numbers[i];
                k++;
            }
            else
            {
                oddNumbers[j] = numbers[i];
                j++;
            }
        }

        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < j; i++)
        {
            Console.WriteLine(oddNumbers[i]);
        }

        Console.WriteLine("Even Numbers:");
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine(evenNumbers[i]);
        }
    }
}