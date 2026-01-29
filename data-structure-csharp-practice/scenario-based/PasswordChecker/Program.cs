using System;

class Program
{
    static bool found = false;

    static void Crack(char[] chars, string current, int n, string password)
    {
        if (found) return;

        if (current.Length == n)
        {
            Console.WriteLine(current);

            if (current.Equals(password))
            {
                Console.WriteLine("\nPassword Cracked: " + current);
                found = true;
            }
            return;
        }

        foreach (char ch in chars)
        {
            Crack(chars, current + ch, n, password);
        }
    }

    static void Main()
    {
        char[] characters = { 'a', 'b' };
        int length = 3;
        string password = "bab";

        Crack(characters, "", length, password);
    }
}
