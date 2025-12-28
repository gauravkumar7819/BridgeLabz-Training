
using System;
class SpecificCharacter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        Console.WriteLine("Enter the character to remove:");
        char charToRemove = Console.ReadLine()[0];

        string result = RemoveCharacter(input, charToRemove);
        Console.WriteLine("Modified String: " + result);
    }

    static string RemoveCharacter(string str, char charToRemove)
    {
        string result = "";
        foreach (char c in str)
        {
            if (c != charToRemove)
            {
                result += c;
            }
        }
        return result;
    }
}