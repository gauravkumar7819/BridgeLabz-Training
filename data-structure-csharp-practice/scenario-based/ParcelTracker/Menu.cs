using System;

namespace ParcelTracker
{
    class Menu
    {
        public static void Start()
        {
            IParcelService service = new ParcelUtility();
            int choice;

            do
            {
                ShowMenu();
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddProduct();
                        break;
                    case 2:
                        service.AddStage();
                        break;
                    case 3:
                        service.AddCheckpoint();
                        break;
                    case 4:
                        service.TrackProduct();
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
            Console.WriteLine("\n=== PARCEL TRACKER MENU ===");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Add Stage to Product");
            Console.WriteLine("3. Add Checkpoint to Product");
            Console.WriteLine("4. Track Product");
            Console.WriteLine("5. Exit");
            Console.Write("Choice: ");
        }
    }
}
