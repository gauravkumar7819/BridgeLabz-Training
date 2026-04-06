using System;

namespace address_book_system
{
    class AddressBookUtility : IAddressBook
    {
        Contact[] contacts = new Contact[5];
        int count = 0;   // ❗ NOT static

        // UC-2 + UC-7 Add Contact with Duplicate Check
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

            // Duplicate check by Name (UC-7)
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
            Console.Write("Enter First Name to Edit: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(name))
                {
                    Console.Write("Enter New City: ");
                    contacts[i].City = Console.ReadLine();

                    Console.Write("Enter New State: ");
                    contacts[i].State = Console.ReadLine();

                    Console.WriteLine("Contact Updated Successfully!");
                    return;
                }
            }

            Console.WriteLine("Contact not found!");
        }

        // UC-4 Delete Contact
        public void DeleteContact()
        {
            Console.Write("Enter First Name to Delete: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(name))
                {
                    for (int j = i; j < count - 1; j++)
                        contacts[j] = contacts[j + 1];

                    contacts[--count] = null;
                    Console.WriteLine("Contact Deleted Successfully!");
                    return;
                }
            }

            Console.WriteLine("Contact not found!");
        }

        // UC-5 Display
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
                Console.WriteLine("-------------------");
            }
        }

        // UC-6 Add Multiple Contacts
        public void AddMultipleContacts(int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                AddContact();
            }
        }

        // UC-8 Search by City
        public void SearchByCity(string city)
        {
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].City.Equals(city))
                {
                    Console.WriteLine(contacts[i]);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No contact found in city " + city);
        }

        // UC-8 Search by State
        public void SearchByState(string state)
        {
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].State.Equals(state))
                {
                    Console.WriteLine(contacts[i]);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No contact found in state " + state);
        }

        // Needed for UC-10 (called from AddressBookMain)
        public Contact[] GetContacts()
        {
            return contacts;
        }

        public int GetCount()
        {
            return count;
        }
    }
}
