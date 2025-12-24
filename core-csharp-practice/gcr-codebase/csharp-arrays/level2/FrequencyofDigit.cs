// Create a program to take a number as input find the frequency of each digit in the number using an array and display the frequency of each digit
// Hint => 
// Take the input for a number
// Find the count of digits in the number
// Find the digits in the number and save them in an array
// Find the frequency of each digit in the number. For this define a frequency array of size 10, Loop through the digits array, and increase the frequency of each digit
// Display the frequency of each digit in the number

using System;
class FrequencyofDigit
{
    static void Main()
    {
       int num=Convert.ToInt32(Console.ReadLine());
         int temp=num;
        int count = 0;
        while (temp != 0)
        {
            temp /= 10;
            count++;
        }   
        int[] digits = new int[count];
        int idx = 0;
        while (num != 0)
        {
            int digit = num % 10;
            digits[idx] = digit;
            idx++;
            num /= 10;
        }
        int[] frequency = new int[10];
        for (int i = 0; i < count; i++)
        {
            frequency[digits[i]]++;
        }

        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + " occurs " + frequency[i] + " times.");
            }
        }       
        

       

    }
}