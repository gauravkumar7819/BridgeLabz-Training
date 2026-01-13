using System;
using System.Net;

namespace book_buddy
{
    class Menu
    {
        IBookManager bookUtility = new BookUtility();

        public void Choice()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== BookBuddy – Digital Bookshelf =====");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display All Books");
                Console.WriteLine("3. Sort Books Alphabetically");
                Console.WriteLine("4. Search By Author");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bookUtility.AddBook();
                        break;

                    case 2:
                        ((BookUtility)bookUtility).DisplayAll();
                        break;

                    case 3:
                        bookUtility.SortBooksAlphabetically();
                        break;

                    
case 4:
bookUtility.SearchByAuthor();
break;
                    case 5:
                        Console.WriteLine("Exiting BookBuddy...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 4);
        }
    }
}
