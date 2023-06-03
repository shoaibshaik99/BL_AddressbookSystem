namespace BL_AddressbookSystem
{
    internal class AddressBook
    {
        public List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact()
        {
            Console.WriteLine("Enter the contact's first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the contact's last name:");
            string lastName = Console.ReadLine();

            Contact existingContact = SearchContact(firstName, lastName);
            if (existingContact != null)
            {
                Console.WriteLine("A contact with the same first and last name already exists. Please try again with a different name.");
                return;
            }

            Console.WriteLine("Enter the contact's address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the contact's city:");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the contact's state:");
            string state = Console.ReadLine();
            Console.WriteLine("Enter the contact's zip code:");
            string zipCode = Console.ReadLine();
            Console.WriteLine("Enter the contact's phone number:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the contact's email:");
            string email = Console.ReadLine();

            Contact newContact = new Contact(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
            contacts.Add(newContact);
        }

        public void DisplayAllContacts()
        {
            if (contacts.Count > 0)
            {
                foreach (Contact person in contacts)
                {
                    Console.WriteLine($"\nFirst Name: {person.firstName}");
                    Console.WriteLine($"Last Name: {person.lastName}");
                    Console.WriteLine($"Address: {person.address}");
                    Console.WriteLine($"City: {person.city}");
                    Console.WriteLine($"State: {person.state}");
                    Console.WriteLine($"Zip Code: {person.zipCode}");
                    Console.WriteLine($"Phone Number: {person.phoneNumber}");
                    Console.WriteLine($"Email: {person.email}\n");
                }   
            }
            else
            {
                Console.Write("\nAddress Book is empty.\n");
            }
        }

        public void EditContact()
        {
            Console.WriteLine("Enter the first name of the contact you want to edit:");
            string firstNameToEdit = Console.ReadLine();
            Console.WriteLine("Enter the last name of the contact you want to edit:");
            string lastNameToEdit = Console.ReadLine();

            Contact contactToEdit = SearchContact(firstNameToEdit, lastNameToEdit);

            if (contactToEdit != null)
            {
                Console.WriteLine("Enter the contact's new first name:");
                string newFirstName = Console.ReadLine();
                Console.WriteLine("Enter the contact's new last name:");
                string newLastName = Console.ReadLine();
                Console.WriteLine("Enter the contact's new address:");
                string newAddress = Console.ReadLine();
                Console.WriteLine("Enter the contact's new city:");
                string newCity = Console.ReadLine();
                Console.WriteLine("Enter the contact's new state:");
                string newState = Console.ReadLine();
                Console.WriteLine("Enter the contact's new zip code:");
                string newZipCode = Console.ReadLine();
                Console.WriteLine("Enter the contact's new phone number:");
                string newPhoneNumber = Console.ReadLine();
                Console.WriteLine("Enter the contact's new email:");
                string newEmail = Console.ReadLine();

                contactToEdit.firstName = newFirstName;
                contactToEdit.lastName = newLastName;
                contactToEdit.address = newAddress;
                contactToEdit.city = newCity;
                contactToEdit.state = newState;
                contactToEdit.zipCode = newZipCode;
                contactToEdit.phoneNumber = newPhoneNumber;
                contactToEdit.email = newEmail;

                Console.WriteLine("Contact updated successfully.");
            }
            else
            {
                Console.WriteLine("No matching contact found to Edit.");
            }
        }

        public void DeleteContact()
        {
            Console.Write("Enter first name of person to delete: ");
            string firstNameToDelete = Console.ReadLine();

            Console.Write("Enter last name of person to delete: ");
            string lastNameToDelete = Console.ReadLine();

            Contact contactToDelete = SearchContact(firstNameToDelete, lastNameToDelete);

            if (contactToDelete != null)
            {
                contacts.Remove(contactToDelete);
                Console.WriteLine("\nDeleted Successfully!");
            }
            else
            {
                Console.WriteLine("\nNo matching contact fount to delete!");
            }
        }


        public Contact SearchContact(string firstName, string lastName)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.firstName == firstName && contact.lastName == lastName)
                {
                    return contact;
                }
            }
            return null;
        }
    }
}
