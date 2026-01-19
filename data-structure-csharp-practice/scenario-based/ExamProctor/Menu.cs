using System;

namespace ExamProctor
{
    class Menu
    {
        public static void Start()
        {
            IExamService service = new ExamUtility();
            int choice;

            do
            {
                ShowMenu();
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.VisitQuestion();
                        break;

                    case 2:
                        service.AnswerQuestion();
                        break;

                    case 3:
                        service.SubmitExam();
                        break;

                    case 4:
                        Console.WriteLine("Exit...");
                        break;

                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }

            } while (choice != 4);
        }

        static void ShowMenu()
        {
            Console.WriteLine("\n=== EXAM PROCTOR MENU ===");
            Console.WriteLine("1. Visit Question");
            Console.WriteLine("2. Answer Question");
            Console.WriteLine("3. Submit Exam");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
        }
    }
}
