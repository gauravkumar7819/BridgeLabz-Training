using System;
using System.Collections.Generic;

namespace SmartCheckout
{
    class CheckoutUtility : ICheckoutService
    {
        Queue<Customer> queue = new Queue<Customer>();

        // HashMap: ItemName → Item
        Dictionary<string, Item> itemMap = new Dictionary<string, Item>();

        public CheckoutUtility()
        {
            // Preloaded items
            itemMap.Add("Milk", new Item("Milk", 50, 10));
            itemMap.Add("Bread", new Item("Bread", 40, 15));
            itemMap.Add("Rice", new Item("Rice", 60, 20));
        }

        public void AddCustomer()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();
            Customer customer = new Customer(name);

            Console.Write("How many items? ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter item name: ");
                customer.Items.Add(Console.ReadLine());
            }

            queue.Enqueue(customer);
            Console.WriteLine("Customer added to queue.");
        }

        public void ProcessCustomer()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("No customers in queue.");
                return;
            }

            Customer customer = queue.Dequeue();
            int total = 0;

            Console.WriteLine($"\nBilling for {customer.Name}");

            foreach (string itemName in customer.Items)
            {
                if (itemMap.ContainsKey(itemName) && itemMap[itemName].Stock > 0)
                {
                    total += itemMap[itemName].Price;
                    itemMap[itemName].Stock--;
                    Console.WriteLine($"{itemName} - ₹{itemMap[itemName].Price}");
                }
                else
                {
                    Console.WriteLine($"{itemName} - Out of Stock");
                }
            }

            Console.WriteLine($"Total Bill: ₹{total}");
        }

        public void ShowQueue()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine("\nCustomers in Queue:");
            foreach (var c in queue)
            {
                Console.WriteLine(c.Name);
            }
        }
    }
}
