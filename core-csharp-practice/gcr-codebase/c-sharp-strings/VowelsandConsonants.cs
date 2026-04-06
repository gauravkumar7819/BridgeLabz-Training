using System;

class VowelsAndConsonants
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();

        int vowels = 0;
        int consonants = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (c >= 'a' && c <= 'z')
            {
                // C# 5 compatible vowel check
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine("Number of vowels: " + vowels);
        Console.WriteLine("Number of consonants: " + consonants);
    }
}
