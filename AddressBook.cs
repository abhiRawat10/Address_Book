using System;
using System.Collections.Generic;

namespace AddressBookSystem
{

    public class AddressBook
    {
        List<Contact> Book;
        public AddressBook()
        {
            Book = new List<Contact>();
        }
    

        public void add()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state");
            string state = Console.ReadLine();

            Console.WriteLine("Enter zip");
            string zip = Console.ReadLine();

            Console.WriteLine("Enter phone");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter email");
            string email = Console.ReadLine();

            Book.Add(new Contact(firstName, lastName, address, city, state, zip, phone, email));
        }   

        public static void edit(string name)
        {
            foreach (Contact contact in Book)
            {
                if (contact.FirstName == name)
                {
                    Console.WriteLine("Enter new first name");
                    contact.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter new last name");
                    contact.LastName = Console.ReadLine();
                    Console.WriteLine("Enter new address");
                    contact.Address = Console.ReadLine();
                    Console.WriteLine("Enter new city");
                    contact.City = Console.ReadLine();
                    Console.WriteLine("Enter new state");
                    contact.State = Console.ReadLine();
                    Console.WriteLine("Enter new zip");
                    contact.Zip = Console.ReadLine();
                    Console.WriteLine("Enter new phone");
                    contact.PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter new email");
                    contact.Email = Console.ReadLine();
                }
            }
        }
        public static void delete(string name)
        {
            foreach (Contact contact in Book)
            {
                if (contact.FirstName == name)
                {
                    Book.Remove(contact);
                    break;
                }
            }
        }
    }

}
