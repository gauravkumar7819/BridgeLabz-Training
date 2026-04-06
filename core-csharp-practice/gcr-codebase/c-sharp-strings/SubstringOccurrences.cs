using System;

class SubstringOccurrences
{
    static void Main()
    {
        Console.Write("Enter main string: ");
        string mainStr = Console.ReadLine();

        Console.Write("Enter substring: ");
        string subStr = Console.ReadLine();

        int count = 0;

        for (int i = 0; i <= mainStr.Length - subStr.Length; i++)
        {
            if (mainStr.Substring(i, subStr.Length) == subStr)
            {
                count++;
            }
        }

        Console.WriteLine("Substring occurs " + count + " times");
    }
}
