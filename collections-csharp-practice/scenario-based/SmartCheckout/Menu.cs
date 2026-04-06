using System;

namespace SmartCheckout
{
    class Menu
    {
        public static void Start()
        {
            ICheckoutService service = new CheckoutUtility();
            int choice;

            do
            {
                Console.WriteLine("\n=== SMART CHECKOUT MENU ===");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Process Customer");
                Console.WriteLine("3. Show Queue");
                Console.WriteLine("4. Exit");
                Console.Write("Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddCustomer();
                        break;
                    case 2:
                        service.ProcessCustomer();
                        break;
                    case 3:
                        service.ShowQueue();
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
    }
}
