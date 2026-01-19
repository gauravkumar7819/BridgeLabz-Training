using System;

namespace TrafficManagerApp
{
    class WaitingQueue
    {
        private string[] queue;
        private int front;
        private int rear;
        private int capacity;

        public WaitingQueue(int size)
        {
            capacity = size;
            queue = new string[capacity];
            front = -1;
            rear = -1;
        }

        public bool IsEmpty()
        {
            return front == -1;
        }

        public bool IsFull()
        {
            return rear == capacity - 1;
        }

        public void Enqueue(string vehicle)
        {
            if (IsFull())
            {
                Console.WriteLine("⚠ Queue Overflow: Waiting queue is full.");
                return;
            }

            if (front == -1)
                front = 0;

            queue[++rear] = vehicle;
            Console.WriteLine($"🚗 Vehicle {vehicle} added to waiting queue.");
        }

        public string Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("⚠ Queue Underflow: No vehicle waiting.");
                return null;
            }

            string vehicle = queue[front++];

            if (front > rear)
                front = rear = -1;

            return vehicle;
        }
    }
}
