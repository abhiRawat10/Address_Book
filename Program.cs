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

            //adding new contact
            Contact contact1 = new Contact("John", "Doe", "123 Main ", "Springfield", "NY", "62701", "217-555-1234", "john@gmai.com");
            AddressBook.add(contact1);
            Console.WriteLine("new contact added");
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