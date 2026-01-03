using System;

class BookBorrow
{
    string title;
    string author;
    double price;
    bool available;

    // Parameterized constructor (name matches class)
    public BookBorrow(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.available = true;
    }

    public void BorrowBook()
    {
        if (available)
        {
            available = false;
            Console.WriteLine("Book borrowed successfully.");
        }
        else
        {
            Console.WriteLine("Sorry, book is already borrowed.");
        }
    }

    public void Display()
    {
        Console.WriteLine("Title: " + title +
                          ", Author: " + author +
                          ", Price: " + price +
                          ", Available: " + available);
    }

    // Main method
    static void Main()
    {
        // Use correct class name
        BookBorrow b1 = new BookBorrow("C# Basics", "John Smith", 450);

        b1.Display();
        b1.BorrowBook();
        b1.BorrowBook();
        b1.Display();
    }
}
