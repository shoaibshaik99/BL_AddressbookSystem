namespace BL_AddressbookSystem
{
    internal class AddressBook
    {
        public Contact? contact;
        
        public void AddContact()
        {
            Console.WriteLine("Enter the contact's first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the contact's last name:");
            string lastName = Console.ReadLine();
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

            this.contact = new Contact(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
        }

        public void DisplayContact()
        {
            if (contact != null)
            {
                Console.WriteLine($"First Name: {contact.firstName}");
                Console.WriteLine($"Last Name: {contact.lastName}");
                Console.WriteLine($"Address: {contact.address}");
                Console.WriteLine($"City: {contact.city}");
                Console.WriteLine($"State: {contact.state}");
                Console.WriteLine($"Zip Code: {contact.zipCode}");
                Console.WriteLine($"Phone Number: {contact.phoneNumber}");
                Console.WriteLine($"Email: {contact.email}");
            }
        }

        public void EditContact()
        {
            Console.WriteLine("Enter the first name of the contact you want to edit:");
            string firstNameToEdit = Console.ReadLine();
            Console.WriteLine("Enter the last name of the contact you want to edit:");
            string lastNameToEdit = Console.ReadLine();

            if (contact != null && contact.firstName == firstNameToEdit && contact.lastName == lastNameToEdit)
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

                contact.firstName = newFirstName;
                contact.lastName = newLastName;
                contact.address = newAddress;
                contact.city = newCity;
                contact.state = newState;
                contact.zipCode = newZipCode;
                contact.phoneNumber = newPhoneNumber;
                contact.email = newEmail;

                Console.WriteLine("Contact updated successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public void DeleteContact()
        {
            if (contact != null)
            {
                Console.WriteLine("Enter the first name of the contact you want to delete:");
                string firstNameToEdit = Console.ReadLine();
                Console.WriteLine("Enter the last name of the contact you want to delete:");
                string lastNameToEdit = Console.ReadLine();

                if (contact != null && contact.firstName == firstNameToEdit && contact.lastName == lastNameToEdit)
                {
                    this.contact = null;
                    Console.Write("\nDeleted Successfully!\n");
                }
                else
                {
                    Console.Write("\nNo such person found!\n");
                }
            }
            else
            {
                Console.Write("\nNo such person found!\n");
            }
        }

    }
}