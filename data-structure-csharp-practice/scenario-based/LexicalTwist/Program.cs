using System;
using System.Text;
using System.Collections.Generic;

namespace LexicalTwist
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first String");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter the Second String");
            string s2 = Console.ReadLine();

            Console.WriteLine(CheckLexical(s1, s2));
        }

        private static string CheckLexical(string s1, string s2)
        {
            string reversedS1 = Reverse(s1);

            // CASE 1: s2 is reversed version of s1
            if (reversedS1.Equals(s2, StringComparison.OrdinalIgnoreCase))
            {
                StringBuilder sb = new StringBuilder(reversedS1.ToLower());

                for (int i = 0; i < sb.Length; i++)
                {
                    if ("aeiou".Contains(sb[i]))
                    {
                        sb[i] = '@';
                    }
                }

                return sb.ToString();
            }

            // CASE 2: s2 is NOT reverse
            string combined = (s1 + s2).ToUpper();

            int[] counts = CountVowelsAndConsonants(combined);
            int vowelCount = counts[0];
            int consonantCount = counts[1];

            if (vowelCount == consonantCount)
            {
                return "Vowels and consonants are equal";
            }

            return GetTwoLetters(combined, vowelCount, consonantCount);
        }

        private static int[] CountVowelsAndConsonants(string input)
        {
            int vowels = 0, consonants = 0;
            input = input.ToUpper();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if ("AEIOU".Contains(c))
                        vowels++;
                    else
                        consonants++;
                }
            }

            return new int[] { vowels, consonants };
        }

        private static string GetTwoLetters(string combined, int vowels, int consonants)
        {
            HashSet<char> result = new HashSet<char>();

            foreach (char c in combined)
            {
                if (result.Count == 2) break;

                if (vowels > consonants && "AEIOU".Contains(c))
                {
                    result.Add(c);
                }
                else if (consonants > vowels && char.IsLetter(c) && !"AEIOU".Contains(c))
                {
                    result.Add(c);
                }
            }

            return string.Join("", result);
        }

        private static string Reverse(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
