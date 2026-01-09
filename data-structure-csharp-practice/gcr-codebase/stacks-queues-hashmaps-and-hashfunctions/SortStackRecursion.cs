using System;
using System.Collections.Generic;

class SortStackRecursion
{
    // Sort the stack using recursion
    public static void SortStack(Stack<int> stack)
    {
        if (stack.Count <= 1)
            return;

        int top = stack.Pop();
        SortStack(stack);
        InsertSorted(stack, top);
    }

    // Insert element in sorted order
    private static void InsertSorted(Stack<int> stack, int value)
    {
        if (stack.Count == 0 || stack.Peek() <= value)
        {
            stack.Push(value);
            return;
        }

        int temp = stack.Pop();
        InsertSorted(stack, value);
        stack.Push(temp);
    }

    // Print stack
    public static void PrintStack(Stack<int> stack)
    {
        foreach (int item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Stack<int> stack = new Stack<int>();

        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter stack elements:");
        for (int i = 0; i < n; i++)
        {
            int value = Convert.ToInt32(Console.ReadLine());
            stack.Push(value);
        }

        Console.WriteLine("\nOriginal Stack:");
        PrintStack(stack);

        SortStack(stack);

        Console.WriteLine("Sorted Stack (Ascending):");
        PrintStack(stack);
    }
}
