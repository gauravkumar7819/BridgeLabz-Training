using System;
using System.Collections.Generic;

namespace address_book_system
{
    //uc-6
    class AddressBookManager
    {
        private Dictionary<string, AddressBookUtility> addressBooks
            = new Dictionary<string, AddressBookUtility>();

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
