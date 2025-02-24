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
    }

    internal class Contact
    {

        string firstName { get; set; }
        string lastName { get; set; }
        string address { get; set; }
        string city { get; set; }
        string state { get; set; }
        string zip { get; set; }
        string phone { get; set; }
        string email { get; set; }

        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phone, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone = phone;
            this.email = email;
        }
    }

}