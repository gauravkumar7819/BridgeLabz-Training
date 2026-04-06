using System;

namespace book_buddy
{
    class BookUtility : IBookManager
    {
        Book[] books = new Book[3];
        int count = 0;

        // Add book
        public void AddBook()
        {
            if (count >= books.Length)
            {
                Console.WriteLine("Bookshelf is full.");
                return;
            }

            Book b = new Book();

            Console.Write("Enter Book Title: ");
            b.BookName = Console.ReadLine();

            Console.Write("Enter Author Name: ");
            b.AutherName = Console.ReadLine();

            books[count++] = b;
            Console.WriteLine("Book added successfully!");
        }

        // Search by author
        public void SearchByAuthor()
        {
            string author=Console.ReadLine();
            
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (books[i].AutherName
                    .Contains(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(books[i]);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No books found for this author.");
            }
        }

        // Sort books alphabetically by title
        public void SortBooksAlphabetically()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (string.Compare(
                        books[i].BookName,
                        books[j].BookName,
                        StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        // swap
                        Book temp = books[i];
                        books[i] = books[j];
                        books[j] = temp;
                    }
                }
            }

            Console.WriteLine("Books sorted alphabetically.");
        }

        // Display all books
        public void DisplayAll()
        {
            if (count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(books[i]);
            }
        }

        
    }
}
