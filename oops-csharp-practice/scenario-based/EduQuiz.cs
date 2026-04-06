using System;

class EduQuiz
{
    static int score = 0;

    // Method to check score
    static void CheckScore(string[] studentAnswers, string[] correctAnswers)
    {
        for (int i = 0; i < 10; i++)
        {
            if (studentAnswers[i].Equals(correctAnswers[i]))
            {
                score++;
            }
        }
    }

    static void Main()
    {
        string[] correctAnswers = {
            "A", "A", "A", "C", "B",
            "B", "C", "B", "C", "C"
        };

        string[] studentAnswers = new string[10];

        string[] questions = {
            "1. What is the capital of India?",
            "2. Which language is used for Android development?",
            "3. What does CPU stand for?",
            "4. Which keyword is used to create an object in C#?",
            "5. Which symbol is used for single-line comments in C#?",
            "6. What is the size of int data type in C#?",
            "7. Which company developed C#?",
            "8. What does RAM stand for?",
            "9. Which loop is guaranteed to run at least once?",
            "10. Which method is the entry point of a C# program?"
        };

        string[] options = {
            "A. Delhi  B. Mumbai  C. Kolkata  D. Chennai",
            "A. Java  B. Swift  C. Python  D. Ruby",
            "A. Central Processing Unit  B. Computer Personal Unit  C. Central Program Unit  D. Control Processing Unit",
            "A. class  B. object  C. new  D. create",
            "A. /* */  B. //  C. ##  D. <!-- -->",
            "A. 2 bytes  B. 4 bytes  C. 8 bytes  D. 16 bytes",
            "A. Google  B. Apple  C. Microsoft  D. Amazon",
            "A. Read Access Memory  B. Random Access Memory  C. Run Access Memory  D. Real Access Memory",
            "A. for  B. while  C. do-while  D. foreach",
            "A. Start()  B. Run()  C. Main()  D. Execute()"
        };

        Console.WriteLine("=== EduQuiz : Student Quiz ===\n");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(questions[i]);
            Console.WriteLine(options[i]);
            Console.Write("Your Answer: ");
            studentAnswers[i] = Console.ReadLine();
            Console.WriteLine();
        }

        CheckScore(studentAnswers, correctAnswers);

        int percentage = score * 10;

        Console.WriteLine("\nTotal Score: " + score + "/10");
        Console.WriteLine("Percentage: " + percentage + "%");

        // Pass / Fail
        if (percentage >= 50)
        {
            Console.WriteLine("Result: PASS");
        }
        else
        {
            Console.WriteLine("Result: FAIL");
        }
    }
}
