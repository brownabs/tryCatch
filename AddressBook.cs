using System;
using System.Collections.Generic;

namespace TryCatch
{
    class AddressBook {
        public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();
        public void AddContact(Contact contact) {
            try
            {
            Contacts.Add(contact.Email, contact); //give me contact.Email/ value associated with Big E email
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Sorry, contact already exists for {contact.Email}.");
            }
        }
        public Contact GetByEmail(string email) {
            return Contacts[email]; //search for a key of contact that is the same string as the email
        }
    }
}