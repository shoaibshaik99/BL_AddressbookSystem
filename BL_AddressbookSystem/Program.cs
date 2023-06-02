namespace BL_AddressbookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program!");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact();
            addressBook.DisplayContact();
            addressBook.EditContact();
            addressBook.DisplayContact();
        }
    }
}