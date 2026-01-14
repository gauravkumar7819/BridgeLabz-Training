using System;

namespace address_book_system
{
    class AddressBookUtility : IAddressBook
    {
        Contact[] contacts = new Contact[5];
        static int count = 0;

        // Add Contact
        public void AddContact()
        {
            if (count >= contacts.Length)
            {
                Console.WriteLine("Address Book is Full!");
                return;
            }

            Contact contact = new Contact();

            Console.Write("Enter First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter State: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            contact.Email = Console.ReadLine();

            contacts[count++] = contact;
            Console.WriteLine("Contact Added Successfully!");
        }

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
// /UC-3
        public void EditContact()
        {
            if (count == 0)
            {
                Console.WriteLine("No contacts available to edit!");
                return;
            }

            Console.Write("Enter First Name to Edit: ");
            string name = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(name))
                {
                    Console.WriteLine("Contact Found! Enter new details:");

                    Console.Write("Enter New Last Name: ");
                    contacts[i].LastName = Console.ReadLine();

                    Console.Write("Enter New Address: ");
                    contacts[i].Address = Console.ReadLine();

                    Console.Write("Enter New City: ");
                    contacts[i].City = Console.ReadLine();

                    Console.Write("Enter New State: ");
                    contacts[i].State = Console.ReadLine();

                    Console.Write("Enter New Zip: ");
                    contacts[i].Zip = Console.ReadLine();

                    Console.Write("Enter New Phone Number: ");
                    contacts[i].PhoneNumber = Console.ReadLine();

                    Console.Write("Enter New Email: ");
                    contacts[i].Email = Console.ReadLine();

                    Console.WriteLine("Contact Updated Successfully!");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Contact not found!");
            }
        }
    }
}
