using System;

class Anagrams
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        if (str1.Length != str2.Length)
        {
            Console.WriteLine("Strings are not anagrams");
            return;
        }

        int[] count = new int[256];

        for (int i = 0; i < str1.Length; i++)
        {
            count[str1[i]]++;
            count[str2[i]]--;
        }

        for (int i = 0; i < 256; i++)
        {
            if (count[i] != 0)
            {
                Console.WriteLine("Strings are not anagrams");
                return;
            }
        }

        Console.WriteLine("Strings are anagrams");
    }
}
