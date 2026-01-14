using System;

namespace address_book_system
{
    class AddressBookUtility : IAddressBook
    {
        Contact[] contacts = new Contact[5];
        static int count = 0;

        // Add Contact

        // Display Contacts
        public void DisplayAll()
        {
            if (count == 0)
            {
                Console.WriteLine("No contacts found!");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(contacts[i]);
            }
        }

    }}
