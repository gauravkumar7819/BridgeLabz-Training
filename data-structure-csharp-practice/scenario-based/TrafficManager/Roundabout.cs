using System;

namespace TrafficManagerApp
{
    class Roundabout
    {
        private VehicleNode last;

        public Roundabout()
        {
            last = null;
        }

        public void AddVehicle(string vehicle)
        {
            VehicleNode newNode = new VehicleNode(vehicle);

            if (last == null)
            {
                last = newNode;
                last.Next = last;
            }
            else
            {
                newNode.Next = last.Next;
                last.Next = newNode;
                last = newNode;
            }

            Console.WriteLine($"✅ Vehicle {vehicle} entered the roundabout.");
        }

        public void RemoveVehicle()
        {
            if (last == null)
            {
                Console.WriteLine("⚠ Roundabout is empty.");
                return;
            }

            if (last.Next == last)
            {
                Console.WriteLine($"❌ Vehicle {last.VehicleNumber} exited roundabout.");
                last = null;
                return;
            }

            VehicleNode first = last.Next;
            last.Next = first.Next;
            Console.WriteLine($"❌ Vehicle {first.VehicleNumber} exited roundabout.");
        }

        public void PrintRoundabout()
        {
            if (last == null)
            {
                Console.WriteLine("🔁 Roundabout is empty.");
                return;
            }

            VehicleNode temp = last.Next;
            Console.Write("🔄 Roundabout State: ");

            do
            {
                Console.Write(temp.VehicleNumber + " -> ");
                temp = temp.Next;
            }
            while (temp != last.Next);

            Console.WriteLine("(back to start)");
        }
    }
}
