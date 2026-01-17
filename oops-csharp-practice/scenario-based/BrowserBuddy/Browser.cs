using System;
using System.Collections.Generic;

namespace BrowserBuddy
{
    class Browser
    {
        private BrowserTab currentTab;
        private Stack<BrowserTab> closedTabs;

        public Browser()
        {
            closedTabs = new Stack<BrowserTab>();
        }

        public void OpenNewTab(string homepage)
        {
            currentTab = new BrowserTab(homepage);
            Console.WriteLine("New tab opened with: " + homepage);
        }

        public void CloseCurrentTab()
        {
            if (currentTab != null)
            {
                closedTabs.Push(currentTab);
                Console.WriteLine("Current tab closed.");
                currentTab = null;
            }
        }

        public void RestoreClosedTab()
        {
            if (closedTabs.Count > 0)
            {
                currentTab = closedTabs.Pop();
                Console.WriteLine("Closed tab restored.");
            }
            else
            {
                Console.WriteLine("No closed tabs to restore.");
            }
        }

        public BrowserTab GetCurrentTab()
        {
            return currentTab;
        }
    }
}
