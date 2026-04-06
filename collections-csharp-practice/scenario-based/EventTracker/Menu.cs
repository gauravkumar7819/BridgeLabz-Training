using System;

namespace EventTracker
{
    class Menu
    {
        public static void Start()
        {
            IAuditService service = new AuditUtility();
            int choice;

            do
            {
                Console.WriteLine("\n=== EVENT TRACKER MENU ===");
                Console.WriteLine("1. Generate Audit Logs");
                Console.WriteLine("2. Exit");
                Console.Write("Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.GenerateAuditLogs();
                        break;

                    case 2:
                        Console.WriteLine("Exit...");
                        break;

                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }

            } while (choice != 2);
        }
    }
}
