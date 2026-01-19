using System;
using System.Collections.Generic;

namespace BookShelf
{
    // Book class


    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("The Alchemist", "Paulo Coelho");
            Book book2 = new Book("Harry Potter", "J.K. Rowling");
            Book book3 = new Book("1984", "George Orwell");

            library.AddBook("Fiction", book1);
            library.AddBook("Fantasy", book2);
            library.AddBook("Fiction", book3);

            library.DisplayCatalog();

            library.RemoveBook("Fiction", "1984");
            library.DisplayCatalog();

            // Trying to add duplicate book
            library.AddBook("Fiction", book1);
        }
    }
}
