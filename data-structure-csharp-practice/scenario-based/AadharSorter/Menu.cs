using System;

namespace AadharSorter
{
    class Menu
    {
        public static void Start()
        {
            IAadharService service = new AadharUtility();
            int choice;

            do
            {
                ShowMenu();
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddAadhar();
                        break;
                    case 2:
                        service.DisplayAadhar();
                        break;
                    case 3:
                        service.SortAadhar();
                        break;
                    case 4:
                        service.SearchAadhar();
                        break;
                    case 5:
                        Console.WriteLine("Exit...");
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }

            } while (choice != 5);
        }

        static void ShowMenu()
        {
            Console.WriteLine("\n=== AADHAR SORT MENU ===");
            Console.WriteLine("1. Add Aadhar");
            Console.WriteLine("2. Display Aadhar");
            Console.WriteLine("3. Sort Aadhar (Radix Sort)");
            Console.WriteLine("4. Search Aadhar (Binary Search)");
            Console.WriteLine("5. Exit");
            Console.Write("Choice: ");
        }
    }
}
