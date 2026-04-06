using System;

class Palindrome
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        text = text.Replace(" ", "").ToLower();

        string reverse = "";

        for (int i = text.Length - 1; i >= 0; i--)
        {
            reverse += text[i];
        }

        if (text == reverse)
            Console.WriteLine("It is a palindrome");
        else
            Console.WriteLine("It is not a palindrome");
    }
}
