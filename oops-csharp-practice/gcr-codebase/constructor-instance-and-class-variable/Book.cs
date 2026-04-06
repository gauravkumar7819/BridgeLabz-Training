using System;

public class Book
{
    public string ISBN;
    protected string title;
    private string author;

    public Book(string ISBN, string title, string author)
    {
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }

    public void SetAuthor(string author)
    {
        this.author = author;
    }

    public string GetAuthor()
    {
        return author;
    }

    static void Main()
    {
        EBook eb = new EBook("978-0131103627", "C# Programming", "John Doe");

        eb.DisplayDetails();

        eb.SetAuthor("Robert Martin");

        Console.WriteLine("Author: " + eb.GetAuthor());
    }
}

public class EBook : Book
{
    public EBook(string ISBN, string title, string author)
        : base(ISBN, title, author)
    {
    }

    public void DisplayDetails()
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);
    }
}
