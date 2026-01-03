using System;

class Product
{
    public static double Discount = 10;

    public readonly int ProductID;
    public string ProductName;
    public double Price;
    public int Quantity;

    public Product(string ProductName, double Price, int Quantity, int ProductID)
    {
        this.ProductName = ProductName;
        this.Price = Price;
        this.Quantity = Quantity;
        this.ProductID = ProductID;
    }

    public void DisplayDetails()
    {
        if (this is Product)
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Product ID: " + ProductID);
            Console.WriteLine("Discount: " + Discount + "%");
        }
    }

    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
    }

    static void Main()
    {
        Product.UpdateDiscount(15);

        Product p1 = new Product("Laptop", 45000, 2, 101);
        Product p2 = new Product("Mouse", 500, 5, 102);

        p1.DisplayDetails();
        Console.WriteLine();
        p2.DisplayDetails();
    }
}
