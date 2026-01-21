using System;

namespace EduResults
{
    class Menu
    {
        public static void Start()
        {
            IResultService service = new ResultUtility();
            int choice;

            do
            {
                Console.WriteLine("\n=== EDU RESULTS MENU ===");
                Console.WriteLine("1. Add District List");
                Console.WriteLine("2. Generate Final Rank List");
                Console.WriteLine("3. Display Final Rank List");
                Console.WriteLine("4. Exit");
                Console.Write("Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddDistrictList();
                        break;
                    case 2:
                        service.GenerateFinalRankList();
                        break;
                    case 3:
                        service.DisplayRankList();
                        break;
                    case 4:
                        Console.WriteLine("Exit...");
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
                }

            } while (choice != 4);
        }
    }
}
