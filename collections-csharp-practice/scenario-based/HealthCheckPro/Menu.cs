using System;

namespace HealthCheckPro
{
    class Menu
    {
        public static void Start()
        {
            IApiAuditService service = new ApiAuditUtility();
            int choice;

            do
            {
                Console.WriteLine("\n=== HEALTH CHECK PRO MENU ===");
                Console.WriteLine("1. Generate API Documentation");
                Console.WriteLine("2. Exit");
                Console.Write("Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.GenerateApiDocumentation();
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
