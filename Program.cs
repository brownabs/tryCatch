/*
    1. Add the required classes to make the following code compile.
       HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.
    2. Run the program and observe the exception.
    3. Add try/catch blocks in the appropriate locations to prevent the program from crashing
       Print meaningful error messages in the catch blocks.
*/

using System;
using System.Collections.Generic;

namespace TryCatch
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Create Contacts for address book 
            Contact Abbey = new Contact() {
                FirstName = "Abbey", LastName = "Brown",
                Email = "abbey.brown@email.com",
                Address = "1900 Lowlands, Nashville, TN 37216"
            };
            Contact Rupert = new Contact() {
                FirstName = "Rupert", LastName = "Jones",
                Email = "rupertPjones@email.com",
                Address = "9832 Harding Place, Nashville, TN 37207"
            };
            Contact Katerina = new Contact() {
                FirstName = "Katerina", LastName = "Freeman",
                Email = "numberOnePredsFan@email.com",
                Address = "000 Who Knows, WhiteHouse, TN 37072"
            };


            // Create an AddressBook and add Contacts to it
            AddressBook tacoAddressBook = new AddressBook();
            tacoAddressBook.AddContact(Abbey);
            tacoAddressBook.AddContact(Rupert);
            tacoAddressBook.AddContact(Katerina);

            // Try to add a contact a second time
            tacoAddressBook.AddContact(Abbey);


            // Create a list of emails that match our Contacts
            List<string> emails = new List<string>() {
                "abbey.brown@email.com",
                "rupertPjones@email.com",
                "numberOnePredsFan@email.com",
            };

            // Insert an email that does NOT match a Contact (insert method)
            //Takes the argument of index you want to insert and the list item value
            emails.Insert(3, "notallowedbadboy@email.com");


            //  Search AddressBook by email and print the information about each Contact
            foreach (string email in emails)
            {
                try
                {
                    Contact contact = tacoAddressBook.GetByEmail(email);
                    Console.WriteLine("----------------------------");
                    Console.WriteLine($"Name: {contact.FullName}");
                    Console.WriteLine($"Email: {contact.Email}");
                    Console.WriteLine($"Address: {contact.Address}");
                }
                catch (KeyNotFoundException ex)
                {
                                    Console.WriteLine($@"
                ----------------------------
                Unable to find {email} in Address Book.
                ----------------------------
                Developer ERROR Message: {ex.Message}
                "
                );
                }
            }
        }
    }
}
