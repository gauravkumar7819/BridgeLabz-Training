using System;

namespace BrowserBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            Browser browser = new Browser();

            browser.OpenNewTab("google.com");
            BrowserTab tab = browser.GetCurrentTab();

            tab.Visit("github.com");
            tab.Visit("stackoverflow.com");

            Console.WriteLine("Current Page: " + tab.GetCurrentPage());

            tab.Back();
            Console.WriteLine("After Back: " + tab.GetCurrentPage());

            tab.Forward();
            Console.WriteLine("After Forward: " + tab.GetCurrentPage());

            browser.CloseCurrentTab();
            browser.RestoreClosedTab();

            Console.WriteLine("Restored Tab Page: " +
                browser.GetCurrentTab().GetCurrentPage());
        }
    }
}
