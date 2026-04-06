using System;

namespace FitnessApp
{
    class FitnessUtility : IFitnessService
    {
        private User[] users = new User[20];
        private int count = 0;

        public void AddUser()
        {
            if (count >= users.Length)
            {
                Console.WriteLine("User limit reached!");
                return;
            }

            Console.Write("Enter user name: ");
            string name = Console.ReadLine();

            Console.Write("Enter steps: ");
            int steps = Convert.ToInt32(Console.ReadLine());

            users[count++] = new User(name, steps);
            Console.WriteLine("User added successfully!");
        }

        public void UpdateSteps()
        {
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (users[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter new steps: ");
                    users[i].Steps = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Steps updated!");
                    return;
                }
            }

            Console.WriteLine("User not found!");
        }

        public void DisplayLeaderboard()
        {
            BubbleSort();

            Console.WriteLine("\n🏆 Leaderboard (Highest Steps First)");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {users[i].Name} - {users[i].Steps} steps");
            }
        }

        // Bubble Sort Logic
        private void BubbleSort()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (users[j].Steps < users[j + 1].Steps)
                    {
                        User temp = users[j];
                        users[j] = users[j + 1];
                        users[j + 1] = temp;
                    }
                }
            }
        }
    }
}
