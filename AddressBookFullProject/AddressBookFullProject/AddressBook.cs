﻿using System;
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
        /// <summary>
        /// Adding contact object into contact list
        /// </summary>
        public void AddContact(string first_name, string LastName, string address, string city, string state, int zip, long phone_number, string email)
        {
            Contacts contact = new Contacts(first_name, LastName, address, city, state, zip, phone_number, email);
            contactList.Add(contact);
            Console.WriteLine("Thankyou!! (^_^) Contact added Successfully !");
        }

        public void EditContact(string first_name)
        {
            foreach (Contacts contact in contactList)
            {
                if (first_name.Equals(contact.first_name))
                {
                    Console.WriteLine("Enter Last Name : ");
                    contact.last_name = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    contact.address = Console.ReadLine();
                    Console.WriteLine("Enter City : ");
                    contact.city = Console.ReadLine();
                    Console.WriteLine("Enter State : ");
                    contact.state = Console.ReadLine();
                    Console.WriteLine("Enter Zip code : ");
                    contact.zip = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number : ");
                    contact.phone_number = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter Email : ");
                    contact.email = Console.ReadLine();
                    Console.WriteLine("Contact Updated Successfully !");
                }
                else
                {
                    Console.WriteLine("Contact not found with first name '{0}'!", first_name);
                }
            }
        }
    }
}
