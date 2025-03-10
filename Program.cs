using System;
using System.Collections.Generic;
namespace AddressBook
{
    internal class Program
    {
        static List<Contact> AddressBook;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book system...");
            AddressBook = new List<Contact>();

            Console.WriteLine("Press 1 to exit \n press 2 to add new contact ");
            switch(Console.ReadLine())
            {
                case "1":
                    return;
                case "2":
                    add();
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            
        }

        //method to add new contact
        static public void add()
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

            AddressBook.Add(new Contact(firstName, lastName, address, city, state, zip, phone, email));
        }

        public static void edit(string name)
        {
            foreach (Contact contact in AddressBook)
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
    }

}