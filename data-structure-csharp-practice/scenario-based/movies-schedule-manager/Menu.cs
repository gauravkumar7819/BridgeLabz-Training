using System;

namespace movies_scheduler_manager
{
    class Menu
    {
        IMovieManager movieUtility = new MovieUtility();

        public void Choice()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== Movie Schedule Manager =====");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Display All Movies");
                Console.WriteLine("3. Search Movie");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
 
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Movie Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Show Time: ");
                        string time = Console.ReadLine();

                        movieUtility.AddMovie(name, time);
                        Console.WriteLine("Movie added successfully!");
                        break;
                    case 2:
                       ((MovieUtility)movieUtility).DisplayAll();
                        break;

                    case 3:
                        Console.Write("Enter keyword to search: ");
                        string keyword = Console.ReadLine();

                        movieUtility.SearchMovie(keyword);
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 4);
        }
    }
}
