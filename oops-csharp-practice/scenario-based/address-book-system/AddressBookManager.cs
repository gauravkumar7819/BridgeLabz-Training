using System;
using System.Collections.Generic;

namespace address_book_system
{
    //uc-6
    class AddressBookManager
    {
        private Dictionary<string, AddressBookUtility> addressBooks
            = new Dictionary<string, AddressBookUtility>();

public void CountByState()
{
    Console.Write("Enter State Name: ");
    string state = Console.ReadLine();

    int totalCount = 0;

    foreach (var book in addressBooks.Values)
    {
        Contact[] contacts = book.GetContacts();
        int count = book.GetCount();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i] != null &&
                contacts[i].State.Equals(state))
            {
                totalCount++;
            }
        }
    }

    Console.WriteLine("Total persons in state " + state + " = " + totalCount);
}


public void CountByCity()
{
    Console.Write("Enter City Name: ");
    string city = Console.ReadLine();

    int totalCount = 0;

    foreach (var book in addressBooks.Values)
    {
        Contact[] contacts = book.GetContacts();
        int count = book.GetCount();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i] != null &&
                contacts[i].City.Equals(city))
            {
                totalCount++;
            }
        }
    }

    Console.WriteLine("Total persons in city " + city + " = " + totalCount);
}
        public void AddAddressBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Address Book already exists!");
                return;
            }

            addressBooks.Add(name, new AddressBookUtility());
            Console.WriteLine("Address Book '" + name + "' created successfully!");
        }

        public AddressBookUtility SelectAddressBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                return addressBooks[name];
            }

            Console.WriteLine("Address Book not found!");
            return null;
        }

        public void DisplayAddressBooks()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("No Address Books available!");
                return;
            }

            Console.WriteLine("Available Address Books:");
            foreach (string name in addressBooks.Keys)
            {
                Console.WriteLine("- " + name);
            }
        }
    }
}
