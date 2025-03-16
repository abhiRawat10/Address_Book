using System;
using System.Collections.Generic;
namespace AddressBookSystem
{
    internal class Program
    {
        static Dictionary<string, AddressBook> addressBook = new Dictionary<string, AddressBook>();
<
        static Dictionary>string,Contact> cityDictionary = new Dictionary<string, List<Contact>>();

        static Dictionary<string, Contact> stateDictionary = new Dictionary<string,List<Contact>>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book system...");



            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add new Address Book");
                Console.WriteLine("2. Add new Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Display Contacts");
                Console.WriteLine("6. To Search in a particular city");
                Console.WriteLine("7. To Search in a particular state");
                
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DisplayAllAddressBooks();
                        Console.WriteLine("Enter the name of the address book");
                        string name = Console.ReadLine();
                        addressBook.Add(name, new AddressBook());
                        break;

                    case 2:
                        DisplayAllAddressBooks();
                        Console.WriteLine("Enter the name of the address book in which you want to add  :");
                        string addressBookName = Console.ReadLine();
                        if (addressBook.ContainsKey(addressBookName))
                        {
                            addressBook[addressBookName].Add();

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

                    case 0:
                        return;

                    case 6:
                        {
                        Console.WriteLine("Enter city");
                        string city = Console.ReadLine();

                        Console.WriteLine("Enter person firstname");
                        string fn = Console.ReadLine();

                        Console.WriteLine("Enter person lastname");
                        string ln = Console.ReadLine();

                        foreach(var kp in addressBook)
                        {
                            foreach(var contact in kp.Value.Book)
                            {
                                if (contact.City == city && contact.FirstName == fn &&         contact.LastName == ln)
                                {
                                    Console.WriteLine(contact);
                                }
                            }
                        }
                            break;
                        }


                    case 7:
                        {
                            Console.WriteLine("Enter state");
                            string st = Console.ReadLine();

                            Console.WriteLine("Enter firstname");
                            string fn = Console.ReadLine();

                            Console.WriteLine("Enter lastname");
                            string ln = Console.ReadLine();

                            foreach (var kp in addressBook)
                            {
                                foreach (var contact in kp.Value.Book)
                                {
                                    if (contact.State == st && contact.FirstName == fn      && contact.LastName == ln)
                                    {
                                        Console.WriteLine(contact);
                                    }
                                }
                            }

                            break;
                        }

                    default:
                        Console.WriteLine("Invalid choice");
                        break;



                }
            }

        }

        public static void DisplayAllAddressBooks()
        {
            foreach (var adb in addressBook)
            {
                Console.WriteLine(adb.Key);
            }
        }

        public static void DisplayByCity()
        {
            foreach (var city in cityDictionary)
            {
                Console.WriteLine(city.Key);
            }
        }

        public static void DisplayByState()
        {
            foreach (var state in stateDictionary)
            {
                Console.WriteLine(state.Key);
            }
        }

    }

}