using System;
class HandleBookDetails
{
    private string title;
    private string author;
    private double price;

    public HandleBookDetails(string t, string a, double pr)
    {
        title = t;
        author = a;
        price = pr;
    }

    public void DisplayBookDetails()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Book Details:");
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Author: ");
        string author = Console.ReadLine();
 
        Console.Write("Price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        HandleBookDetails book = new HandleBookDetails(title, author, price);

        book.DisplayBookDetails();
    }
}