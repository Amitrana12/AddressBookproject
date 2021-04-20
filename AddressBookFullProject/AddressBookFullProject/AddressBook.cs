using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookFullProject
{
    class AddressBook
    {
        List<Contacts> contactList;
        public AddressBook()
        {
            this.contactList = new List<Contacts>();
        }
        public void AddContact(string first_name, string LastName, string address, string city, string state, int zip, long phone_number, string email)
        {
            Contacts contact = new Contacts(first_name, LastName, address, city, state, zip, phone_number, email);
            contactList.Add(contact);
            Console.WriteLine("Thankyou!! (^_^) Contact added Successfully !");
        }
    }
}
