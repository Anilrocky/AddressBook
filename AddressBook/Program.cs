using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book problem");
            AddressBookMain address = new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Create contacts in address book \n2.Add contact \n3.Edit contact \n4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        address.Display();
                        break;
                    case 2:
                        Console.WriteLine("Enter first name");
                        address.AddContact();
                        address.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter first name to edit");
                        string name = Console.ReadLine();
                        address.EditContact(name);
                        address.Display();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }           
        }
    }
}