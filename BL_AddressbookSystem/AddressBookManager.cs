namespace BL_AddressbookSystem
{
    internal class AddressBookManager
    {

        //currently deleting address book isn't supported.

        public Dictionary<string, AddressBook> addressBooks;

        public AddressBookManager()
        {
            addressBooks = new Dictionary<string, AddressBook>();
        }

        public void AddAddressBook(string name)
        {
            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine($"An address book with the name '{name}' already exists. Please try again with a different name.");
                return;
            }

            AddressBook newAddressBook = new AddressBook();
            addressBooks.Add(name, newAddressBook);
            Console.WriteLine($"Address book '{name}' added successfully.");
        }

        public void DisplayAllAddressBooks()
        {
            if (addressBooks.Count > 0)
            {
                Console.WriteLine("Address books:");
                foreach (string name in addressBooks.Keys)
                {
                    Console.WriteLine($"- {name}");
                }
            }
            else
            {
                Console.WriteLine("No address books found.");
            }
        }

        public AddressBook GetAddressBook(string name)
        {
            if (addressBooks.ContainsKey(name))
            {
                return addressBooks[name];
            }
            else
            {
                Console.WriteLine($"No address book found with the name '{name}'.");
                return null;
            }
        }
    }
}