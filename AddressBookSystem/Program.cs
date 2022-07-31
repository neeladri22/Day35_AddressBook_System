using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book System Problem");

            while (true)
            {
                Console.WriteLine("\nEnter 1 \tAdd New Contact ");
                Console.WriteLine("\nEnter 2 \tEdit Existing Contact");
                Console.WriteLine("\nEnter 3 \tDelete Contact");
                Console.WriteLine("\nEnter 4 \tRetrive person Belongs to City");
                Console.WriteLine("\nEnter 5 \tRetrive person Belongs to State");
                Console.WriteLine("\nEnter 6 \tSize of AddressBook");
                Console.WriteLine("\nEnter 7 \tSort Person's Name Alphabetically");
                Console.WriteLine("\nEnter 8 \tContact persons count by Addresstype");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddressBook.AddNewContact(); //Adding the new contact
                        break;
                    case 2:
                        AddressBook.EditExistingContact(); //Edit existing contact
                        break;
                    case 3:
                        AddressBook.deleteContact(); //Delete contact
                        break;
                    case 4:
                        AddressBook.SearchPersonInCity(); //Retrive person Belongs to City
                        break;
                    case 5:
                        AddressBook.SearchPersonInState(); //Retrive person Belongs to State
                        break;
                    case 6:
                        AddressBook.SizeOfAddressBook(); //Size of AddressBook
                        break;
                    case 7:
                        AddressBook.SortPersonsANmeByCity(); //Sort Persons Name for given city
                        break;
                    case 8:
                        AddressBook.NumberOfContactPersosCouyntByType(); //Number of Contact persons count by Addresstype
                        break;
                    default:
                        Console.WriteLine("Pleasee select valid input");
                        break;
                }
            }


        }
    }
}
