namespace BL_AddressbookSystem
{
    internal class AddressBook
    {
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

            Contact contact = new Contact(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
        }
    }
}
