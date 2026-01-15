using System;

namespace address_book_system
{
    class AddressBookMenu
    {
        public void Choice()
        {
            int ch;
            IAddressBook addressBook = new AddressBookUtility();

            do
            {
                Console.WriteLine("\n1. Add Contact");
                Console.WriteLine("2. Display Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        addressBook.AddContact();
                        Console.WriteLine("Add Contact selected");
                        break;

                    case 2:
                        addressBook.DisplayAll();
                        Console.WriteLine("Display Contact selected");
                        break;

                    case 3:
                        addressBook.EditContact();
                        Console.WriteLine("Edit Contact selected");
                        break;

                    case 4:
                        addressBook.DeleteContact();
                        Console.WriteLine("Delete Contact selected");
                        break;

                    case 5:
                        Console.WriteLine("Exiting Program...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (ch != 5);
        }
    }
}
