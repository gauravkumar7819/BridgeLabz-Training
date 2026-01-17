using System;

namespace address_book_system
{
    class AddressBookMenu
    {
        public void Choice()
        {
            int ch;
            AddressBookManager manager = new AddressBookManager();
            AddressBookUtility addressBook = null;

            do
            {
                Console.WriteLine("\n------ ADDRESS BOOK SYSTEM ------");
                Console.WriteLine("1. Create Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Add Contact");
                Console.WriteLine("4. Display Contacts");
                Console.WriteLine("5. Edit Contact");
                Console.WriteLine("6. Delete Contact");
                Console.WriteLine("7. Add Multiple Contacts");
                Console.WriteLine("8. Search Person by City");
Console.WriteLine("9. Search Person by State");

Console.WriteLine("10. Count By city");
Console.WriteLine("11. Count By State");


                Console.WriteLine("12. Exit");

                Console.Write("Enter your choice: ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        manager.AddAddressBook();
                        break;

                    case 2:
                        addressBook = manager.SelectAddressBook();
                        break;

                    case 3:
                        if (addressBook != null)
                            addressBook.AddContact();
                        else
                            Console.WriteLine("Please select an Address Book first!");
                        break;

                    case 4:
                        if (addressBook != null)
                            addressBook.DisplayAll();
                        else
                            Console.WriteLine("Please select an Address Book first!");
                        break;

                    case 5:
                        if (addressBook != null)
                            addressBook.EditContact();
                        else
                            Console.WriteLine("Please select an Address Book first!");
                        break;

                    case 6:
                        if (addressBook != null)
                            addressBook.DeleteContact();
                        else
                            Console.WriteLine("Please select an Address Book first!");
                        break;

                    case 7:
                        if (addressBook != null)
                        {
                            Console.Write("Enter number of contacts: ");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            addressBook.AddMultipleContacts(limit);
                        }
                        else
                        {
                            Console.WriteLine("Please select an Address Book first!");
                        }
                        break;
                        case 8:
    Console.Write("Enter City: ");
    string city = Console.ReadLine();
   addressBook.SearchByCity(city);
    break;

case 9:
    Console.Write("Enter State: ");
    string state = Console.ReadLine();
    addressBook.SearchByState(state);
    break;
case 10:
    manager.CountByCity();
    break;
    case 11:
    manager.CountByState();
    break;

                    case 12:
                        Console.WriteLine("Exiting Program...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (ch != 13);
        }
    }
}
