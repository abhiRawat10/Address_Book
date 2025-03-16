using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookSystem
{

    public class AddressBook
    {
        public List<Contact> Book;
        public AddressBook()
        {
            this.Book = new List<Contact>();
        }


        public void Add()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            if (Book.Any(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                              c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Duplicate entry! A contact with this name already exists.");
                return;
            }

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

            this.Book.Add(new Contact(firstName, lastName, address, city, state, zip, phone, email));


            //adding to city dictionary
            if (Program.cityDictionary.ContainsKey(city))
            {
                Program.cityDictionary[city].Add(new Contact(firstName, lastName, address, city, state, zip, phone, email));
            }
            else
            {
                Program.cityDictionary.Add(city, new List<Contact> { new Contact(firstName, lastName, address, city, state, zip, phone, email) });
            }

            //adding to state dictionary
            if (Program.stateDictionary.ContainsKey(state))
            {
                Program.stateDictionary[state].Add(new Contact(firstName, lastName, address, city, state, zip, phone, email));
            }
            else
            {
                Program.stateDictionary.Add(state, new List<Contact> { new Contact(firstName, lastName, address, city, state, zip, phone, email) });

            }
            Console.WriteLine("Contact added successfully.");
        }


        public void edit(string name)
        {
            foreach (Contact contact in this.Book)
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
                    contact.Phone = Console.ReadLine();
                    Console.WriteLine("Enter new email");
                    contact.Email = Console.ReadLine();
                }
            }
        }
        public void delete(string name)
        {
            foreach (Contact contact in this.Book)
            {
                if (contact.FirstName == name)
                {
                    this.Book.Remove(contact);
                    break;
                }
            }
        }
        public void display()
        {
            foreach (Contact contact in this.Book)
            {
                Console.WriteLine("First name: " + contact.FirstName);
                Console.WriteLine("Last name: " + contact.LastName);
                Console.WriteLine("Address: " + contact.Address);
                Console.WriteLine("City: " + contact.City);
                Console.WriteLine("State: " + contact.State);
                Console.WriteLine("Zip: " + contact.Zip);
                Console.WriteLine("Phone: " + contact.Phone);
                Console.WriteLine("Email: " + contact.Email);
            }
        }
    }

}
