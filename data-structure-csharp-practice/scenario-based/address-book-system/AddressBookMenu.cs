using System;

namespace address_book_system
{
    class AddressBookMenu
    {
        public void Choice()
        {
            int ch;

                IAddressBook addressBook=new AddressBookUtility();
            do
            {
                Console.WriteLine("\n1. Add Contact");
                Console.WriteLine("2. Display Contact");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                ch = Convert.ToInt32(Console.ReadLine());

                if (ch == 1)
                {
addressBook.AddContact();
                    Console.WriteLine("Add Contact selected");
                }
                else if (ch == 2)
                {
                    addressBook.DisplayAll();
                    Console.WriteLine("Display Contact selected");
                }
                else if (ch == 3)
                {
                    Console.WriteLine("Exiting Program...");
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }

            } while (ch != 3);
        }

        internal void DisplayAll()
        {
            throw new NotImplementedException();
        }
    }
}
