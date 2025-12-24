using System;
class ReverseTheNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number to reverse:");
        string  num =Console.ReadLine();
        int n=num.Length;
        int reversedNumber = 0;
        int [] digits = new int[n];
        int number = Convert.ToInt32(num);
int idx=0;
        while (number != 0)
        {
            int digit = number % 10;
            digits[idx]=digit;
            idx++;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }
        Console.WriteLine(string.Join("",digits));

    }
}
