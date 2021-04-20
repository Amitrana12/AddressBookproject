using System;
using System.Collections.Generic;
using System.Linq;
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
            bool duplicate = equals(first_name);
            if (!duplicate)
            {
                Contacts contact = new Contacts(first_name, LastName, address, city, state, zip, phone_number, email);
                contactList.Add(contact);
                Console.WriteLine("Contact added Successfully !\n---------------------");
            }
            else
                Console.WriteLine("Cannot add duplicate Contact first name\n----------------");
        }

        private bool equals(string first_name)
        {
            if (this.contactList.Any(e => e.first_name == first_name))
                return true;
            else
                return false;
        }
        public void EditContact(string first_name)
        {
            if (contactList.Count() > 0)
            {
                int thereExist = 1;
                foreach (Contacts contact in contactList)
                {
                    if (first_name.Equals(contact.first_name))
                    {
                        thereExist = 0;
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
                        Console.WriteLine("Contact Updated Successfully !\n-----------------------------");
                    }
                }
                    if (thereExist == 1)
                    {
                    Console.WriteLine($"Contact not found with first name '{first_name}'!\n------------------");
                }
            }
                else
                {
                    Console.WriteLine("This contact address book is empty. First add contact then try Editing");
                }
            }
        public void DeleteContact(string first_name)
        {

            if (contactList.Count() > 0)
            {               
                
                    int thereExist = 1;
                    foreach (Contacts contact in contactList)
                    {
                        if (first_name.Equals(contact.first_name))
                        {
                            thereExist = 0;
                            contactList.Remove(contact);
                            Console.WriteLine("Contact Deleted Successfully !");
                            break;
                        }
                    }
                    if (thereExist == 1)
                    {
                    Console.WriteLine($"Contact not found with first name '{first_name}'!\n----------");
                }
            }
                else
                {
                    Console.WriteLine("This contact address book is empty. First add contact then try Deleting");
                }
            }



        public void DisplayContacts()
        {
            if (contactList.Count() > 0)
            {
                foreach (Contacts contact in contactList)
                {
                    Console.WriteLine($"First Name : {contact.first_name}\nLast Name : {contact.last_name}\nAddress : {contact.address}\nCity : {contact.city}\nState : {contact.state}\nZip : {contact.zip}\nPhone Number : {contact.phone_number}\nEmail : {contact.email}\n--------------------------");
                }
            }
            else
            {
                Console.WriteLine("This contact address book is empty. First add contact then try Displaying");
            }
        }
    }
}
