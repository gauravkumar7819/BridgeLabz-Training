using System;

class LibraryManagementSystem
{
  static string[] titles = { 
    "Bhagavad Gita", 
    "Ramayana", 
    "Mahabharata", 
    "Gitanjali", 
    "Godan", 
    "Malgudi Days", 
    "Train to Pakistan" 
};

static string[] authors = { 
    "Vyasa", 
    "Valmiki", 
    "Vyasa", 
    "Rabindranath Tagore", 
    "Munshi Premchand", 
    "R.K. Narayan", 
    "Khushwant Singh" 
};

static bool[] status = { 
    true, 
    true, 
    false, 
    true, 
    true, 
    false, 
    true 
}; // true = Available


    static void Main()
    {
        DisplayBooks();

        Console.Write("\nEnter partial title to search: ");
        string search = Console.ReadLine();
        SearchBook(search);

        Console.Write("\nEnter exact title to checkout: ");
        string checkout = Console.ReadLine();
        CheckoutBook(checkout);

        Console.WriteLine("\nUpdated Book List:");
        DisplayBooks();
    }

    // Method to display all books
    static void DisplayBooks()
    {
        Console.WriteLine("\nLibrary Books:");
        for (int i = 0; i < titles.Length; i++)
        {
            Console.WriteLine(titles[i] + " | " + authors[i] + " | " +
                (status[i] ? "Available" : "Checked Out"));
        }
    }

    // Method to search book by partial title
    static void SearchBook(string search)
    {
        bool found = false;
        for (int i = 0; i < titles.Length; i++)
        {
            if (titles[i].ToLower().Contains(search.ToLower()))
            {
                Console.WriteLine("Found: " + titles[i] + " by " + authors[i]);
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("Book not found");
    }

    // Method to checkout a book
    static void CheckoutBook(string title)
    {
        for (int i = 0; i < titles.Length; i++)
        {
            if (titles[i].Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                if (status[i])
                {
                    status[i] = false;
                    Console.WriteLine("Book checked out successfully");
                }
                else
                {
                    Console.WriteLine("Book already checked out");
                }
                return;
            }
        }
        Console.WriteLine("Book not found");
    }
}
