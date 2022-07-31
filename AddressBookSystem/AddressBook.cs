using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {

        // Creating list for Storing the Contacts of Each Persons details
        public static List<Contact> AddressDetails = new List<Contact>();

        // /Creating the method for Adding new contact - Added AddressBookName and AddressBook 
        public static void AddNewContact()
        {
            Contact person = new Contact();

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

            Console.Write("Enter AddressBook Name: ");
            person.AddressBookName = Console.ReadLine();

            Console.Write("Enter AddressBook Type: ");
            person.AddressBookType = Console.ReadLine();

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
            Console.WriteLine("E-Mail :" + person.AddressBookName);
            Console.WriteLine("E-Mail :" + person.AddressBookType);
        }
        // Creating the method for editing the existing contact
        public static void EditExistingContact()
        {
            Console.WriteLine("Enter the First Name of the person you would like to Edit.");

            string firstName = Console.ReadLine();
            Contact person = AddressDetails.Where(FN => FN.FirstName.ToLower() == firstName.ToLower()).FirstOrDefault();
            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nDetails of the entered person is:\n");
            Console.WriteLine("\n************************************\n");
            PrintContact(person);
            Console.WriteLine("\n************************************\n");

            Console.WriteLine("\n");
            Console.WriteLine("Are you sure you want to Edit this person from your address book? (Y/N)");
            string c = Console.ReadLine().ToLower();
            if (c == "y")
            {
                AddressDetails.Remove(person);
            }
            AddressBook.AddNewContact();
            Console.WriteLine("Person details Edited Successfully. Press any key to continue.");
            Console.ReadKey();
        }

        // Creating the method for delete the contact using person's name
        public static void deleteContact()
        {
            Console.WriteLine("Enter the First Name of the person you would like to remove.");

            string firstName = Console.ReadLine();
            Contact person = AddressDetails.Where(FN => FN.FirstName.ToLower() == firstName.ToLower()).FirstOrDefault();
            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("\n************************************\n");
            PrintContact(person);
            Console.WriteLine("\n************************************\n");

            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            string d = Console.ReadLine().ToLower();

            if (d == "y")
            {
                AddressDetails.Remove(person);
                Console.WriteLine("\nPerson removed\n");
            }
        }
        //Serch the person by city name
        public static void SearchPersonInCity()
        {
            Console.WriteLine("Please enter the city name to search person: ");
            string city = Console.ReadLine();
            List<Contact> checkCity = AddressDetails.FindAll(C => (C.City == city));

            //Checking for Availability
            if (checkCity.Count == 0)
            {
                Console.WriteLine("No person found in the given City");
            }
            else
            {
                Console.WriteLine("Person details are: ");
                foreach (Contact contact in checkCity)
                {
                    Console.WriteLine("\nFirst Name is: " + contact.FirstName);
                }
            }
        }

        //Serch the person by state name
        public static void SearchPersonInState()
        {
            Console.WriteLine("Please enter the State name to search person: ");
            string state = Console.ReadLine();
            List<Contact> checkState = AddressDetails.FindAll(S => (S.State == state));

            //Checking for Availability
            if (checkState.Count == 0)
            {
                Console.WriteLine("No person found in the given State");
            }
            else
            {
                Console.WriteLine("Person details are: ");
                foreach (Contact contact in checkState)
                {
                    Console.WriteLine("\nFirst Name is: " + contact.FirstName);
                }
            }
        }

        //List of People Method
        public static void SizeOfAddressBook()
        {
            if (AddressDetails.Count == 0)
            {
                Console.WriteLine("Address Book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Address Book Size is : " + AddressDetails.Count);
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
        //Sort Persons Name for given city
        public static void SortPersonsANmeByCity()
        {
            Console.WriteLine("Please enter the city name: ");
            string city = Console.ReadLine();
            var SortPersonDetails = AddressDetails.FindAll(C => (C.City == city)).OrderBy(F => F.FirstName).ToList();
            Console.WriteLine("All the entrier in AddressBook Sorted Alphabetically :");
            foreach (var contact in SortPersonDetails)
            {
                Console.WriteLine("\nPerson Name : " + contact.FirstName +
                                    "\tCity : " + contact.City);
            }
        }

        //Number of Contact persons count by Addresstype 
        public static void NumberOfContactPersosCouyntByType()
        {
            Console.WriteLine("Number of Contact persons count by Addresstype: ");
            var type = AddressDetails.GroupBy(x => x.AddressBookType).Select(y => new { AddressBookType = y.Key, count = y.Count() });
            foreach (var contact in type)
            {
                Console.WriteLine("\nAddressBook Type :" + contact.AddressBookType +
                                    "\n Count : " + contact.count);
            }
        }
        // /Creating the method for Adding new contact - Add Person to Both Family and Friend
        public static void AddNewContact()
        {
            Contact person = new Contact();

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

            Console.Write("Enter AddressBook Name: ");
            person.AddressBookName = Console.ReadLine();

            Console.Write("Enter AddressBook Type: ");
            person.AddressBookType = Console.ReadLine();

            Console.WriteLine("\n************************************\n");
            PrintContact(person);
            Console.WriteLine("\n************************************\n");

            AddressDetails.Add(person);
        }
        //Ensure all retrieve queries are working with new table strature
    }


}
