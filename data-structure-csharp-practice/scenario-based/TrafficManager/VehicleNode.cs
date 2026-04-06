using System;

namespace TrafficManagerApp
{
    class VehicleNode
    {
        public string VehicleNumber;
        public VehicleNode Next;

        public VehicleNode(string vehicleNumber)
        {
            VehicleNumber = vehicleNumber;
            Next = null;
        }
    }
}
