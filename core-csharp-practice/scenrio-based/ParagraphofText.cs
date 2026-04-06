using System;

class ParagraphOfText
{
    static void Main()
    {
        Console.WriteLine("Enter a paragraph of text:");
        string text = Console.ReadLine();

        Console.WriteLine("Enter word to be replaced:");
        string oldWord = Console.ReadLine();

        Console.WriteLine("Enter new word:");
        string newWord = Console.ReadLine();

        int wordCount = WordCounter(text);
        string longest = LongestWord(text);
        string replacedText = ReplaceWord(text, oldWord, newWord);

        Console.WriteLine("\nWord Count: " + wordCount);
        Console.WriteLine("Longest Word: " + longest);
        Console.WriteLine("After Replacement: " + replacedText);
    }

    // Word count using character-based logic
    static int WordCounter(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return 0;

        int count = 0;
        bool inWord = false;

        foreach (char c in str)
        {
            if (char.IsWhiteSpace(c))
            {
                inWord = false;
            }
            else
            {
                if (!inWord)
                {
                    count++;
                    inWord = true;
                }
            }
        }

        return count;
    }

    // Find longest word
    static string LongestWord(string str)
    {
        string[] words = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        string longest = "";

        foreach (string word in words)
        {
            if (word.Length > longest.Length)
                longest = word;
        }

        return longest;
    }

    // Replace all occurrences of a word (case-insensitive)
    static string ReplaceWord(string str, string oldWord, string newWord)
    {
        string[] words = str.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (string.Equals(words[i], oldWord, StringComparison.OrdinalIgnoreCase))
                words[i] = newWord;
        }

        return string.Join(" ", words);
    }
}
