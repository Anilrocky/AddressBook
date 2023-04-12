using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contacts> addressList = new List<Contacts>();
        public AddressBookMain()
        {
            Contacts contact1 = new Contacts()
            {
                FirstName = "Anil",
                LastName = "Kumar",
                Address = "Bangalore",
                City = "Bangalore",
                State = "Karnataka",
                ZIP = "563123",
                PhoneNumber = "6789012345",
                Email = "a@gamil.com"
            };
            Contacts contact2 = new Contacts()
            {
                FirstName = "Soma",
                LastName = "Shekar",
                Address = "Bangalore",
                City = "Bangalore",
                State = "Karnataka",
                ZIP = "563123",
                PhoneNumber = "6789012345",
                Email = "s@gamil.com"
            };
            addressList.Add(contact1);
            addressList.Add(contact2);
        }
        public void AddContact()
        {
            Contacts contact = new Contacts()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                ZIP = Console.ReadLine(),
                PhoneNumber = Console.ReadLine(),
                Email = Console.ReadLine(),
            };
            addressList.Add(contact);
        }
        public void EditContact(string name)
        {
            foreach (var data in addressList)
            {
                if (data.FirstName.ToLower().Equals(name.ToLower()))
                {
                    Console.WriteLine("\nChoose option to edit contact \n1.Last name \n2.Address \n3.City \n4.State \n5.ZIP \n6.Phone number \n7.E-Mail");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            data.LastName = Console.ReadLine();
                            break;
                        case 2:
                            data.Address = Console.ReadLine();
                            break;
                        case 3:
                            data.City = Console.ReadLine();
                            break;
                        case 4:
                            data.State = Console.ReadLine();
                            break;
                        case 5:
                            data.ZIP = Console.ReadLine();
                            break;
                        case 6:
                            data.PhoneNumber = Console.ReadLine();
                            break;
                        case 7:
                            data.Email = Console.ReadLine();
                            break;
                    }
                }
            }
        }
        public void DeleteContact(string name)
        {
            Contacts contact = new Contacts();
            foreach (var data in addressList)
            {
                if (data.FirstName.ToLower() == name.ToLower())
                {
                    contact = data;
                }
            }
            if (contact == null)
                Console.WriteLine("No contact exists with respect to first name");
            else
                addressList.Remove(contact);
        }
        public void Display()
        {
            foreach (var data in addressList)
            {
                Console.WriteLine("First name: " + data.FirstName + "\n" + "Last name: " + data.LastName + "\n" +
                      "Address: " + data.Address + "\n" + "City: " + data.City + "\n" + "State: " + data.State + "\n" +
                    "ZIP: " + data.ZIP + "\n" + "Phone number: " + data.PhoneNumber + "\n" + "E-Mail: " + data.Email);
            }
        }
    }
}
