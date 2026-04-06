
using System;
class TotalPurchasePrice
{
    static void Main()
    {
        Console.Write("Enter the unit price of the item (in INR): ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        double price = unitPrice * quantity;

        Console.WriteLine("\nThe total purchase price is INR {price} if the quantity {quantity} and unit price is INR {unitPrice}");
    }
}