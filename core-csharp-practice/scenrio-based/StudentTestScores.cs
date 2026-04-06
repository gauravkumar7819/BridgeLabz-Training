using System;

class StudentTestScores
{
    static void Main()
    {
        int[] scores = null;
        bool dataEntered = false;

        while (true)
        {
            Console.WriteLine("\n---- Student Score Menu ----");
            Console.WriteLine("1. Enter Student Scores");
            Console.WriteLine("2. Display Average Score");
            Console.WriteLine("3. Display Highest & Lowest Score");
            Console.WriteLine("4. Display Scores Above Average");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice!");
                continue;
            }

            switch (choice)
            {
                case 1:
                    scores = ReadScores();
                    dataEntered = true;
                    break;

                case 2:
                    if (CheckData(dataEntered))
                        Console.WriteLine("Average Score: " + FindAverage(scores));
                    break;

                case 3:
                    if (CheckData(dataEntered))
                        DisplayMinMax(scores);
                    break;

                case 4:
                    if (CheckData(dataEntered))
                        DisplayAboveAverage(scores);
                    break;

                case 5:
                    Console.WriteLine("Program Exited");
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static int[] ReadScores()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] scores = new int[n];

        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write("Enter score of student " + (i + 1) + ": ");

                int score;
                if (int.TryParse(Console.ReadLine(), out score) && score >= 0)
                {
                    scores[i] = score;
                    break;
                }
                Console.WriteLine("Invalid input! Enter a non-negative number.");
            }
        }
        return scores;
    }

    static bool CheckData(bool status)
    {
        if (!status)
        {
            Console.WriteLine("Please enter scores first!");
            return false;
        }
        return true;
    }

    static double FindAverage(int[] scores)
    {
        int sum = 0;
        foreach (int score in scores)
            sum += score;

        return (double)sum / scores.Length;
    }

    static void DisplayMinMax(int[] scores)
    {
        int max = scores[0], min = scores[0];

        foreach (int score in scores)
        {
            if (score > max) max = score;
            if (score < min) min = score;
        }

        Console.WriteLine("Highest Score: " + max);
        Console.WriteLine("Lowest Score: " + min);
    }

    static void DisplayAboveAverage(int[] scores)
    {
        double avg = FindAverage(scores);

        Console.WriteLine("Scores above average:");
        foreach (int score in scores)
        {
            if (score > avg)
                Console.WriteLine(score);
        }
    }
}
