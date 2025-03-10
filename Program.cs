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
            AddressBook.Add(contact1);
            Console.WriteLine("new contact added");
        }
    }


}