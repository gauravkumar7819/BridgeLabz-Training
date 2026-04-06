using System;
class FizzBuzz
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Enter number ");
        int num=Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[num];
        for (int i = 0; i < num; i++)
        {
            numbers[i] = i + 1;
        }

        for (int i = 0; i < num; i++)
        {
            if (numbers[i] % 3 == 0 && numbers[i] % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (numbers[i] % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (numbers[i] % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}