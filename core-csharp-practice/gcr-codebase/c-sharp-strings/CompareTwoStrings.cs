using System;

class CompareTwoStrings
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        int result = string.Compare(str1, str2);

        if (result < 0)
            Console.WriteLine(str1 + " comes before " + str2);
        else if (result > 0)
            Console.WriteLine(str1 + " comes after " + str2);
        else
            Console.WriteLine("Both strings are equal");
    }
}
