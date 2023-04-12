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
                Console.WriteLine("\nChoose option to perform \n1.Create contacts in address book \n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        address.AddContact();
                        Console.WriteLine("Enter first name");
                        address.Display();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }           
        }
    }
}