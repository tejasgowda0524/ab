namespace b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook ab = new AddressBook();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Display Contacts");
                Console.WriteLine("5. Exit");

                
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                      
                        Console.Write("Enter First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Enter Last Name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Enter Address: ");
                        string address = Console.ReadLine();
                        Console.Write("Enter City: ");
                        string city = Console.ReadLine();
                        Console.Write("Enter Zip: ");
                        string zip = Console.ReadLine();
                        Console.Write("Enter Phone Number: ");
                        string phoneNumber = Console.ReadLine();
                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine();

                        ContactPerson newContact = new ContactPerson(firstName, lastName, address, city, zip, phoneNumber, email);

                        
                        ab.AddContact(newContact);
                        break;

                    case 2:
                        
                        Console.Write("Enter First Name of Contact to Edit: ");
                        string editFirstName = Console.ReadLine();
                        Console.Write("Enter Last Name of Contact to Edit: ");
                        string editLastName = Console.ReadLine();

                        ab.EditContact(editFirstName, editLastName);
                        break;

                    case 3:
                        Console.Write("Enter First Name of Contact to Delete: ");
                        string deleteFirstName = Console.ReadLine();
                        Console.Write("Enter Last Name of Contact to Delete: ");
                        string deleteLastName = Console.ReadLine();

                        ab.DeleteContact(deleteFirstName, deleteLastName);
                        break;

                    case 4:
                        ab.DisplayContacts();
                        break;

                    case 5:
                        
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter the valid choice.");
                        break;
                }
            }
        }

    }
}
