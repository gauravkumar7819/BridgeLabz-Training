using System;

namespace RotateList
{
    internal class Node
    {
        public Node Next;
        public int val;

        public Node(int val)
        {
            this.val = val;
            Next = null;
        }
    }

    internal class LinkedList
    {
        Node head;
        Node tail;

        public void AddLast(int val)
        {
            Node node = new Node(val);

            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }

        public void ReverseKNodes(int k)
        {
            head = ReverseKNodesUtil(head, k);
        }

        private Node ReverseKNodesUtil(Node head, int k)
        {
            Node current = head;
            Node prev = null;
            Node next = null;
            int count = 0;

            while (current != null && count < k)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
                count++;
            }

            if (next != null)
            {
                head.Next = current;
            }

            return prev;
        }

        public void PrintList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.val + "-->");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }
    }
}
