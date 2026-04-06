using System;
class FactorsofNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to find  factors:");
        int num = Convert.ToInt32(Console.ReadLine());
        int[] factors = new int[num];
        int count = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                factors[count] = i;
                count++;
            }
        }   

        Console.WriteLine("The factors of " + num + " are:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(factors[i]);
        }
    }
}