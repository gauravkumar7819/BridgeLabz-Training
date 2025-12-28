using System;
class Reverse
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to reverse:");
        string input = Console.ReadLine();
        char[] charArray = input.ToCharArray();
        int left = 0;
        int right = charArray.Length - 1;

        while (left < right)
        {
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;

            left++;
            right--;
        }

        string reversedString = new string(charArray);
        Console.WriteLine("Reversed string: " + reversedString);
    }
}