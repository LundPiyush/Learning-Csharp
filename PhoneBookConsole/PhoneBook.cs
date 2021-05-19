using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBookConsole
{
    class PhoneBook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: { contact.Name},{contact.Number}");
        }
        public void DisplayContactsDeatils(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }
        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number );
            if (contact == null){
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }
        public void DisplayAllContact()
        {
            DisplayContactsDeatils(_contacts);
        }
        public void DisplayMatchingContacts(string searchPhrase)
        {
            //name :Bill ; search pharse :ll
            var matchingContacts = _contacts.Where(c => c.Name.Contains( searchPhrase)).ToList();
            DisplayContactsDeatils(matchingContacts);
        }

    }
}
