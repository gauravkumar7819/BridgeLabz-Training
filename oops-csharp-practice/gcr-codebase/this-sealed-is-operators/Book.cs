using System;

class Book
{
    public static string LibraryName = "Central Library";

    public readonly string ISBN;
    public string Title;
    public string Author;

    public Book(string Title, string Author, string ISBN)
    {
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
    }

    public void DisplayDetails()
    {
        if (this is Book)
        {
            Console.WriteLine("Library: " + LibraryName);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("ISBN: " + ISBN);
        }
    }

    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: " + LibraryName);
    }

    static void Main()
    {
        Book.DisplayLibraryName();

        Book b1 = new Book("C# Basics", "Gaurav Kumar", "ISBN101");
        Book b2 = new Book("Java Advanced", "Anita Singh", "ISBN102");

        Console.WriteLine();
        b1.DisplayDetails();
        Console.WriteLine();
        b2.DisplayDetails();
    }
}
