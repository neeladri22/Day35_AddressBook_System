using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        public static Contact person = new Contact();

        // Creating list for Storing the Contacts of Each Persons details
        public static List<Contact> AddressDetails = new List<Contact>();

        // /Creating the method for Adding new contact
        public static void AddNewContact()
        {
            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            person.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            person.City = Console.ReadLine();

            Console.Write("Enter State: ");
            person.State = Console.ReadLine();

            Console.Write("Enter Zip Code: ");
            person.ZipCode = int.Parse(Console.ReadLine());

            Console.Write("Enter Mobile Number: ");
            person.MobileNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter E-Mail: ");
            person.Email = Console.ReadLine();

            Console.WriteLine("\n************************************\n");
            PrintContact(person);
            Console.WriteLine("\n************************************\n");

            AddressDetails.Add(person);
        }

        // Display the Person Details
        public static void PrintContact(Contact person)
        {
            Console.WriteLine("First Name :" + person.FirstName);
            Console.WriteLine("Last Name :" + person.LastName);
            Console.WriteLine("Address :" + person.Address);
            Console.WriteLine("City :" + person.City);
            Console.WriteLine("State :" + person.State);
            Console.WriteLine("Zip Code :" + person.ZipCode);
            Console.WriteLine("Mobile Number :" + person.MobileNumber);
            Console.WriteLine("E-Mail :" + person.Email);
        }
    }
}
