using System;

namespace FlashDealz
{
    class Menu
    {
        private IProductSort utility = new SortUtility();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- FlashDealz Menu ---");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Sort Products by Discount");
                Console.WriteLine("3. Display Products");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddProduct();
                        break;
                    case 2:
                        utility.SortProducts();
                        break;
                    case 3:
                        utility.DisplayProducts();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
