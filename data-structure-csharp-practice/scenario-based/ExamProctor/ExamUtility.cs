using System;
using System.Collections.Generic;

namespace ExamProctor
{
    class ExamUtility : IExamService
    {
        // Stack for navigation
        private Stack<int> questionStack = new Stack<int>();

        // Arrays to store answers
        private int[] questionIds = new int[20];
        private string[] answers = new string[20];
        private int count = 0;

        // Visit question
        public void VisitQuestion()
        {
            Console.Write("Enter Question ID: ");
            int qid = Convert.ToInt32(Console.ReadLine());

            questionStack.Push(qid);
            Console.WriteLine("Question visited.");
        }

        // Store answer
        public void AnswerQuestion()
        {
            Console.Write("Enter Question ID: ");
            int qid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Answer: ");
            string ans = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (questionIds[i] == qid)
                {
                    answers[i] = ans;
                    Console.WriteLine("Answer updated.");
                    return;
                }
            }

            questionIds[count] = qid;
            answers[count] = ans;
            count++;

            Console.WriteLine("Answer saved.");
        }

        // Submit exam
        public void SubmitExam()
        {
            int score = CalculateScore();
            Console.WriteLine("\nExam Submitted");
            Console.WriteLine("Your Score: " + score);
        }

        // Function for scoring
        private int CalculateScore()
        {
            int score = 0;

            for (int i = 0; i < count; i++)
            {
                if (!string.IsNullOrEmpty(answers[i]))
                {
                    score++;
                }
            }

            return score;
        }
    }
}
