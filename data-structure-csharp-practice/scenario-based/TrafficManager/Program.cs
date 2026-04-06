using System;

namespace TrafficManagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficManager manager = new TrafficManager(3);

            manager.VehicleArrives("KA01");
            manager.VehicleArrives("DL05");
            manager.VehicleArrives("MH12");
            manager.VehicleArrives("UP32");   // Queue Overflow

            manager.AllowVehicleEntry();
            manager.AllowVehicleEntry();

            manager.ShowStatus();

            manager.VehicleExit();
            manager.ShowStatus();

            Console.ReadLine();
        }
    }
}
