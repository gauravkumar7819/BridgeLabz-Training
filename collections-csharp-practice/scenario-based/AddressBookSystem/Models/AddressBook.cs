using System.Collections.Generic;
namespace AddressBookSystem{
internal class AddressBook
{
    public string Name { get; private set; }
    public List<Contact> Contacts { get; }

    public AddressBook(string name)
    {
        Name = name;
        Contacts = new List<Contact>();
    }
}
}