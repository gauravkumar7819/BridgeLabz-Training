using System;

namespace ParcelTracker
{
    class ParcelUtility : IParcelService
    {
        private Parcel[] parcels = new Parcel[10];
        private int count = 0;

        // Add a new product
        public void AddProduct()
        {
            if (count >= parcels.Length)
            {
                Console.WriteLine("Product list full!");
                return;
            }

            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            parcels[count++] = new Parcel(name);
            Console.WriteLine("Product added successfully!");
        }

        // Add stage to a specific product at the end
        public void AddStage()
        {
            Parcel parcel = SelectProduct();
            if (parcel == null) return;

            Console.Write("Enter new stage: ");
            string stage = Console.ReadLine();

            ParcelStage temp = parcel.Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = new ParcelStage(stage);

            Console.WriteLine("Stage added at end.");
        }

        // Add checkpoint after a specific stage
        public void AddCheckpoint()
        {
            Parcel parcel = SelectProduct();
            if (parcel == null) return;

            Console.Write("Enter existing stage name to insert after: ");
            string existing = Console.ReadLine();

            Console.Write("Enter checkpoint name: ");
            string checkpoint = Console.ReadLine();

            ParcelStage temp = parcel.Head;
            while (temp != null)
            {
                if (temp.StageName.Equals(existing, StringComparison.OrdinalIgnoreCase))
                {
                    ParcelStage newNode = new ParcelStage(checkpoint);
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                    Console.WriteLine("Checkpoint added.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Stage not found!");
        }

        // Track a product
        public void TrackProduct()
        {
            Parcel parcel = SelectProduct();
            if (parcel == null) return;

            if (parcel.Head == null)
            {
                Console.WriteLine("Parcel is lost!");
                return;
            }

            Console.WriteLine("\nTracking stages for " + parcel.ProductName + ":");
            ParcelStage temp = parcel.Head;
            while (temp != null)
            {
                Console.Write(temp.StageName);
                if (temp.Next != null) Console.Write(" → ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        // Helper to select a product
        private Parcel SelectProduct()
        {
            if (count == 0)
            {
                Console.WriteLine("No products available!");
                return null;
            }

            Console.WriteLine("\nSelect Product:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {parcels[i].ProductName}");
            }
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice < 1 || choice > count)
            {
                Console.WriteLine("Invalid choice!");
                return null;
            }

            return parcels[choice - 1];
        }
    }
}
