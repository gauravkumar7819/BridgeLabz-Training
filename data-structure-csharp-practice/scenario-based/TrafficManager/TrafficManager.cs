using System;

namespace TrafficManagerApp
{
    class TrafficManager
    {
        private Roundabout roundabout;
        private WaitingQueue waitingQueue;

        public TrafficManager(int queueSize)
        {
            roundabout = new Roundabout();
            waitingQueue = new WaitingQueue(queueSize);
        }

        public void VehicleArrives(string vehicle)
        {
            waitingQueue.Enqueue(vehicle);
        }

        public void AllowVehicleEntry()
        {
            string vehicle = waitingQueue.Dequeue();
            if (vehicle != null)
            {
                roundabout.AddVehicle(vehicle);
            }
        }

        public void VehicleExit()
        {
            roundabout.RemoveVehicle();
        }

        public void ShowStatus()
        {
            roundabout.PrintRoundabout();
        }
    }
}
