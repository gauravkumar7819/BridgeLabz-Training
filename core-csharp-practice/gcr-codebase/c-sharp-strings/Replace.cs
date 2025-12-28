
using System;
class Replace
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter the word to be replaced: ");
        string oldWord = Console.ReadLine();

        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();

        string result = ReplaceWord(sentence, oldWord, newWord);
        Console.WriteLine("Modified sentence: " + result);
    }

    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        return sentence.Replace(oldWord, newWord);
    }
}