using System;

class ToggleCase
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (char.IsUpper(c))
                result += char.ToLower(c);
            else if (char.IsLower(c))
                result += char.ToUpper(c);
            else
                result += c;
        }

        Console.WriteLine("Toggled string: " + result);
    }
}
