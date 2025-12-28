using System;

class NumberGuessingGame
{
    static void Main()
    {
        int low = 1, high = 100;
        string feedback = "";

        Console.WriteLine("Think of a number between 1 and 100.");
        Console.WriteLine("Enter feedback: high / low / correct");

        while (feedback != "correct")
        {
            int guess = GenerateGuess(low, high);
            Console.WriteLine("Computer guesses: " + guess);

            feedback = GetFeedback();

            if (feedback == "high")
                high = guess - 1;
            else if (feedback == "low")
                low = guess + 1;
        }

        Console.WriteLine("Computer guessed your number correctly!");
    }

    static int GenerateGuess(int low, int high)
    {
        return (low + high) / 2;
    }

    static string GetFeedback()
    {
        return Console.ReadLine().ToLower();
    }
}
