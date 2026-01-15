using System;
namespace address_book_system
{ interface IAddressBook
    {
        void AddContact();
        void EditContact();
        void DisplayAll();
        void DeleteContact();       
        
    }
}