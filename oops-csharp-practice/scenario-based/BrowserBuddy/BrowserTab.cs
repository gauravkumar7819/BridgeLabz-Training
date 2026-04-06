using System;

namespace BrowserBuddy
{
    class BrowserTab
    {
        private HistoryNode head;
        private HistoryNode current;

        public BrowserTab(string homepage)
        {
            head = new HistoryNode(homepage);
            current = head;
        }

        public void Visit(string url)
        {
            HistoryNode newNode = new HistoryNode(url);

            current.Next = newNode;
            newNode.Prev = current;

            current = newNode;
        }

        public void Back()
        {
            if (current.Prev != null)
            {
                current = current.Prev;
            }
            else
            {
                Console.WriteLine("No previous page available.");
            }
        }

        public void Forward()
        {
            if (current.Next != null)
            {
                current = current.Next;
            }
            else
            {
                Console.WriteLine("No forward page available.");
            }
        }

        public string GetCurrentPage()
        {
            return current.Url;
        }
    }
}
