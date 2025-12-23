// Rewrite the program 10 to find the sum until the user enters 0 or a negative number using while loop and break statement
// Hint => 
// Use infinite while loop as in while (true)
// Take the user entry and check if the user entered 0 or a negative number to break the loop using break;
using System;
class SumtoZero2
{
    static void Main()
    {
        int sum = 0;
        while (true)
        {
            int inpValue = Convert.ToInt32(Console.ReadLine());
            if (inpValue <= 0)
            {
                break;
            }
            sum += inpValue;
        }
        Console.WriteLine("The sum is:" + sum);
    }
}