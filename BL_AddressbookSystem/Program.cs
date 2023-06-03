namespace BL_AddressbookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program!");
            AddressBookManager addressBookManager = new AddressBookManager();

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add an address book");
                Console.WriteLine("2. Display all address books");
                Console.WriteLine("3. Manage an address book");
                Console.WriteLine("4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the name of the new address book:");
                        string name = Console.ReadLine();
                        addressBookManager.AddAddressBook(name);
                        break;
                    case 2:
                        addressBookManager.DisplayAllAddressBooks();
                        break;
                    case 3:
                        Console.WriteLine("Enter the name of the address book you want to manage:");
                        string nameToManage = Console.ReadLine();
                        AddressBook addressBookToManage = addressBookManager.GetAddressBook(nameToManage);
                        if (addressBookToManage != null)
                        {
                            ManageAddressBook(addressBookToManage);
                        }
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void ManageAddressBook(AddressBook addressBook)
        {
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add a contact");
                Console.WriteLine("2. Display all contacts");
                Console.WriteLine("3. Edit a contact");
                Console.WriteLine("4. Delete a contact");
                Console.WriteLine("5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        addressBook.AddContact();
                        break;
                    case 2:
                        addressBook.DisplayAllContacts();
                        break;
                    case 3:
                        addressBook.EditContact();
                        break;
                    case 4:
                        addressBook.DeleteContact();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}