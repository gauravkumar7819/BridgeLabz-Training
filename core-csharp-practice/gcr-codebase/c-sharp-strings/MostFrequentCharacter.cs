using System;

class MostFrequentCharacter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int[] count = new int[256];
        char result = input[0];
        int max = 0;

        for (int i = 0; i < input.Length; i++)
        {
            count[input[i]]++;

            if (count[input[i]] > max)
            {
                max = count[input[i]];
                result = input[i];
            }
        }

        Console.WriteLine("Most Frequent Character: " + result);
    }
}
