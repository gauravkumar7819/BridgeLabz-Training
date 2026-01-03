using System;

class ProductInventory
{
    // Instance variables
    string productName;
    double price;

    // Class variable (shared)
    static int totalProducts = 0;

    // Constructor (name must match the class)
    public ProductInventory(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;   // increment count for each object
    }

    // Instance method
    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: ₹" + price);
        Console.WriteLine();
    }

    // Class (static) method
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products Created: " + totalProducts);
    }
}

class Program
{
    static void Main()
    {
        // Use correct class name for objects
        ProductInventory p1 = new ProductInventory("Laptop", 55000);
        ProductInventory p2 = new ProductInventory("Mobile", 20000);
        ProductInventory p3 = new ProductInventory("Headphones", 2500);

        p1.DisplayProductDetails();
        p2.DisplayProductDetails();
        p3.DisplayProductDetails();

        ProductInventory.DisplayTotalProducts(); // class method call
    }
}
