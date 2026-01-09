using System;
using System.Collections.Generic;

class QueueUsingStacks
{
    private Stack<int> inputStack = new Stack<int>();
    private Stack<int> outputStack = new Stack<int>();

    // Enqueue operation
    public void Enqueue(int value)
    {
        inputStack.Push(value);
        Console.WriteLine("Enqueued: " + value);
    }

    // Dequeue operation
    public int Dequeue()
    {
        if (outputStack.Count == 0)
        {
            if (inputStack.Count == 0)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }

            while (inputStack.Count > 0)
            {
                outputStack.Push(inputStack.Pop());
            }
        }

        return outputStack.Pop();
    }

    // Peek front element
    public int Peek()
    {
        if (outputStack.Count == 0)
        {
            while (inputStack.Count > 0)
            {
                outputStack.Push(inputStack.Pop());
            }
        }

        if (outputStack.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }

        return outputStack.Peek();
    }

    // Check if queue is empty
    public bool IsEmpty()
    {
        return inputStack.Count == 0 && outputStack.Count == 0;
    }
}

class Program
{
    static void Main()
    {
        QueueUsingStacks queue = new QueueUsingStacks();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine("Dequeued: " + queue.Dequeue());
        Console.WriteLine("Front Element: " + queue.Peek());
        Console.WriteLine("Dequeued: " + queue.Dequeue());
        Console.WriteLine("Dequeued: " + queue.Dequeue());
        Console.WriteLine("Is Queue Empty: " + queue.IsEmpty());
    }
}
