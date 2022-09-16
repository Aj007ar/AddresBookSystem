using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        //instance variables 
        public string firstName;
        public string lastName;
        public string Address;
        public string city;
        public string state;
        public int zip;
        public long phoneNumber;
        public string email;
        public AddressBook[] ContactArray;
        int i = 0;

        //Parameterised Constructor
        public AddressBook(string firstName, string lastName, string Address, string city, string state, int zip, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Address = Address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;

        }
        //Default Contructor
        public AddressBook()
        {
            this.ContactArray = new AddressBook[10];
        }

        //To add Contact to Address Book
        public void CreateContact(string firstName, string lastName, string Address, string city, string state, int zip, long phoneNumber, string email)
        {

            ContactArray[this.i] = new AddressBook(firstName, lastName, Address, city, state, zip, phoneNumber, email);
            Console.WriteLine("\tFirst name: {0}\tLast name: {1}\nAddress: {2}\nCity: {3}\nZip: {4}\nState: {5}\nPhone Number: {6}\nEmail: {7} \n", ContactArray[i].firstName, ContactArray[i].lastName, ContactArray[i].Address, ContactArray[i].city, ContactArray[i].zip, ContactArray[i].state, ContactArray[i].phoneNumber, ContactArray[i].email);
        }
    }
}
