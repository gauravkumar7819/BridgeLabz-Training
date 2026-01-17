using System;

namespace address_book_system
{
    class AddressBookUtility : IAddressBook
    {
        Contact[] contacts = new Contact[5];
        static int count = 0;

        // UC-2 Add Contact (with Duplicate Check)
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

            // UC-7 Duplicate Check using Equals()
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].Equals(contact))
                {
                    Console.WriteLine("Duplicate Contact Found! Cannot add.");
                    return;
                }
            }

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

        // UC-3 Edit Contact
        public void EditContact()
        {
            if (count == 0)
            {
                Console.WriteLine("No contacts available to edit!");
                return;
            }

            Console.Write("Enter First Name to Edit: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(name))
                {
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
                    return;
                }
            }

            Console.WriteLine("Contact not found!");
        }

        // UC-4 Delete Contact
        public void DeleteContact()
        {
            if (count == 0)
            {
                Console.WriteLine("No contacts to delete!");
                return;
            }

            Console.Write("Enter First Name to Delete: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(name))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }

                    contacts[--count] = null;
                    Console.WriteLine("Contact Deleted Successfully!");
                    return;
                }
            }

            Console.WriteLine("Contact not found!");
        }

        // UC-5 Display Contacts
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
                Console.WriteLine("----------------------");
            }
        }

        // UC-6 Add Multiple Contacts
        public void AddMultipleContacts(int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("\nEnter details of user " + (i + 1));
                AddContact();
            }
        }
    }
}
