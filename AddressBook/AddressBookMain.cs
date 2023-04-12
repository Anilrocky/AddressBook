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
