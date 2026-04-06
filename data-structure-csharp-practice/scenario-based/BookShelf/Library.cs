using System;
namespace BookShelf{
    class Library
    {
        // Genre → LinkedList of Books
        private Dictionary<string, LinkedList<Book>> catalog = new Dictionary<string, LinkedList<Book>>();

        // Optional: HashSet to prevent duplicates
        private HashSet<Book> allBooks = new HashSet<Book>();

        // Add book
        public void AddBook(string genre, Book book)
        {
            if (!allBooks.Add(book))
            {
                Console.WriteLine("Book already exists!");
                return;
            }

            if (!catalog.ContainsKey(genre))
            {
                catalog[genre] = new LinkedList<Book>();
            }

            catalog[genre].AddLast(book);
            Console.WriteLine($"Added {book} to {genre} genre.");
        }

        // Remove book
        public void RemoveBook(string genre, string title)
        {
            if (!catalog.ContainsKey(genre))
            {
                Console.WriteLine("Genre not found!");
                return;
            }

            LinkedList<Book> books = catalog[genre];
            LinkedListNode<Book> node = books.First;
            while (node != null)
            {
                if (node.Value.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    books.Remove(node);
                    allBooks.Remove(node.Value);
                    Console.WriteLine($"Removed {title} from {genre} genre.");
                    return;
                }
                node = node.Next;
            }

            Console.WriteLine("Book not found!");
        }

        // Display catalog
        public void DisplayCatalog()
        {
            Console.WriteLine("\nLibrary Catalog:");
            foreach (var genre in catalog.Keys)
            {
                Console.WriteLine($"\nGenre: {genre}");
                foreach (var book in catalog[genre])
                {
                    Console.WriteLine("  - " + book);
                }
            }
        }
    }
}