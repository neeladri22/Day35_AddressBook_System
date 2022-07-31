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

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddressBook.AddNewContact(); //Adding the new contact
                        break;
                    case 2:
                        AddressBook.EditExistingContact(); //Edit existing contact
                        break;
                    default:
                        Console.WriteLine("Pleasee select valid input");
                        break;
                }
            }
        }
    }
}
