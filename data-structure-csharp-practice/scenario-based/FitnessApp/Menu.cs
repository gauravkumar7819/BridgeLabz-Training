using System;

namespace FitnessApp
{
    class Menu
    {
        public static void Start()
        {
            IFitnessService service = new FitnessUtility();
            bool running = true;

            while (running)
            {
                ShowMenu();
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddUser();
                        break;

                    case 2:
                        service.UpdateSteps();
                        break;

                    case 3:
                        service.DisplayLeaderboard();
                        break;

                    case 4:
                        running = false;
                        Console.WriteLine("Thank you for using Fitness App!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("\n===== FITNESS APP MENU =====");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Update Steps");
            Console.WriteLine("3. Display Leaderboard");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
        }
    }
}
