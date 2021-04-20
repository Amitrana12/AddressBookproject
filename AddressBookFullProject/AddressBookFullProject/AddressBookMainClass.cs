﻿using System;

namespace AddressBookFullProject
{
    class AddressBookMainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcomr to my Address Book Full project by Amit Rana ");
            AddressBook addressBook = new AddressBook();
            string isRepeat = "yes";
            do
            {
                Console.WriteLine("Choose option to procced further \n1.Add Contact \n2.Edit Contact \n3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Enter First Name : ");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Enter Last Name : ");
                            string lastName = Console.ReadLine();
                            Console.WriteLine("Enter Address : ");
                            string address = Console.ReadLine();
                            Console.WriteLine("Enter City : ");
                            string city = Console.ReadLine();
                            Console.WriteLine("Enter State : ");
                            string state = Console.ReadLine();
                            Console.WriteLine("Enter Zip : ");
                            int zip = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Phone Number : ");
                            long phoneNumber = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter Email id :");
                            string email = Console.ReadLine();
                            addressBook.AddContact(firstName, lastName, address, city, state, zip, phoneNumber, email);
                            Console.WriteLine("---------------------------------");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Zip and Phone number must be integers only");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Enter first name of person whoes details you want to edit ");
                        string editPersonDetails = Console.ReadLine();
                        addressBook.EditContact(editPersonDetails);
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 3:
                        isRepeat = "no";
                        Console.WriteLine("--------------Thankyou---------------");
                        break;
                    default:
                        Console.WriteLine("Please inter valid integer option only ");
                        break;
                }
            } while (isRepeat != "no");
        }
    }
}
