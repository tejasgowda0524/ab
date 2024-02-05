using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    public class AddressBook
    {
        List<ContactPerson> ls = new List<ContactPerson>();


        public void AddContact(ContactPerson c)
        {
            ls.Add(c);
            Console.WriteLine("Contact added successfully!");
        }

        public void EditContact(string firstName, string lastName)
        {
            ContactPerson cp = ls.Find(c => c.FirstName.Equals(firstName) && c.LastName.Equals(lastName));

            if (cp != null)
            {
                Console.WriteLine($"Editing contact: {firstName} {lastName}");

                Console.WriteLine("Contact updated successfully!");
            }
            else
            {
                Console.WriteLine($"Contact with name {firstName} {lastName} not found.");
            }
        }


        public void DeleteContact(string firstName, string lastName)
        {
            ContactPerson contact = ls.Find(c => c.FirstName.Equals(firstName) && c.LastName.Equals(lastName));

            if (contact != null)
            {
                ls.Remove(contact);
                Console.WriteLine($"Contact deleted successfully!");
            }
            else
            {
                Console.WriteLine($"Contact with name {firstName} {lastName} not found.");
            }
        }


        public void DisplayContacts()
        {
            Console.WriteLine("Address Book Contacts:");
            foreach (var contact in ls)
            {
                contact.DisplayDetails();
            }
        }
    }

}
