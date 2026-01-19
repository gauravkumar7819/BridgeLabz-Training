using System;

namespace FlashDealz
{
    class SortUtility : IProductSort
    {
        private Product[] products = new Product[10];
        private int count = 0;

        // -------- ADD --------
        public void AddProduct()
        {
            if (count >= products.Length)
            {
                Console.WriteLine("Product list is full!");
                return;
            }

            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter discount: ");
            int discount = Convert.ToInt32(Console.ReadLine());

            products[count++] = new Product(name, discount);
            Console.WriteLine("Product added successfully.");
        }

       
        public void SortProducts()
        {
            if (count == 0)
            {
                Console.WriteLine("No products to sort.");
                return;
            }

            QuickSort(products, 0, count - 1);
            Console.WriteLine("Products sorted by discount (High → Low).");
        }

        private void QuickSort(Product[] products, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(products, low, high);
                QuickSort(products, low, pi - 1);
                QuickSort(products, pi + 1, high);
            }
        }

        private int Partition(Product[] products, int low, int high)
        {
            int pivot = products[high].GetDiscount();
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (products[j].GetDiscount() > pivot)
                {
                    i++;
                    Swap(products, i, j);
                }
            }

            Swap(products, i + 1, high);
            return i + 1;
        }

        private void Swap(Product[] products, int i, int j)
        {
            Product temp = products[i];
            products[i] = products[j];
            products[j] = temp;
        }

        // -------- DISPLAY --------
        public void DisplayProducts()
        {
            if (count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            Console.WriteLine("\nTop Discounted Products:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(
                    products[i].GetName() + " - " +
                    products[i].GetDiscount() + "%"
                );
            }
        }

    }
}
