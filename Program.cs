using System;
using System.Collections.Generic;
namespace AddressBookSystem
{
    internal class Program
    {
        Dictionary<string, AddressBook> addressBook = new Dictionary<string, AddressBook>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book system...");



            while (true)
            {
                Console.WriteLine("1. Add new Address Book");
                Console.WriteLine("2. Add new Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Display Contacts");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the name of the address book");
                        string name = Console.ReadLine();
                        AddressBookSystem.Add(name, new AddressBook());
                        break;

                    case 2:
                        DisplayAllAddressBooks();
                        Console.WriteLine("Enter the name of the address book :");
                        string addressBookName = Console.ReadLine();
                        if (addressBook.ContainsKey(addressBookName))
                        {
                            addressBook[addressBookName].add();
                        }
                        else
                        {
                            Console.WriteLine("Address book not found");
                        }
                        break;

                    case 3:
                        DisplayAllAddressBooks();
                        Console.WriteLine("Enter the name of the address book");
                        string addressBookName1 = Console.ReadLine();
                        if (addressBook.ContainsKey(addressBookName1))
                        {
                            Console.WriteLine("Enter the first name of the contact to edit");
                            string name1 = Console.ReadLine();
                            addressBook[addressBookName1].edit(name1);
                        }
                        else
                        {
                            Console.WriteLine("Address book not found");
                        }
                        break;

                    case 4:
                        DisplayAllAddressBooks();
                        Console.WriteLine("Enter the name of the address book");
                        string addressBookName2 = Console.ReadLine();
                        if (addressBook.ContainsKey(addressBookName2))
                        {
                            Console.WriteLine("Enter the first name of the contact to delete");
                            string name2 = Console.ReadLine();
                            addressBook[addressBookName2].delete(name2);
                        }
                        else
                        {
                            Console.WriteLine("Address book not found");
                        }
                        break;

                    case 5:
                        DisplayAllAddressBooks();
                        Console.WriteLine("Enter the name of the address book");
                        string addressBookName3 = Console.ReadLine();
                        if (addressBook.ContainsKey(addressBookName3))
                        {
                            addressBook[addressBookName3].display();
                        }
                        else
                        {
                            Console.WriteLine("Address book not found");
                        }
                        break;



                }
            }

        }

        public static void DisplayAllAddressBooks()
        {
            foreach (var addressBook in addressBook)
            {
                Console.WriteLine(addressBook.Key);
            }
        }

        //method to add new contact
    }

}