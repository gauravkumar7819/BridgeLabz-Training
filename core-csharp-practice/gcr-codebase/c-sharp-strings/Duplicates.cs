using System;

class Duplicates
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            // Convert char to string for C# 5 compatibility
            if (!result.Contains(input[i].ToString()))
            {
                result += input[i];
            }
        }

        Console.WriteLine("After removing duplicates: " + result);
    }
}
