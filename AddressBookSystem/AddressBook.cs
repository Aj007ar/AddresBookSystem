using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {

        public static List<NewContact> contactList = new List<NewContact>();
        public void Addressbook()
        {
            NewContact newMember = new NewContact();
            Console.Write("Enter First Name: ");
            newMember.firstname = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            newMember.lastname = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            newMember.phonenumber = Console.ReadLine();
            Console.Write("Enter Address: ");
            newMember.Address = Console.ReadLine();
            Console.Write("Enter City: ");
            newMember.City = Console.ReadLine();
            Console.Write("Enter State: ");
            newMember.State = Console.ReadLine();
            Console.Write("Enter Pincode: ");
            newMember.pincode = Console.ReadLine();
            contactList.Add(newMember);
        }
        public static void DisplyContact(NewContact member)
        {
            Console.WriteLine("First Name: " + member.firstname);
            Console.WriteLine("Last Name: " + member.lastname);
            Console.WriteLine("Phone Number: " + member.phonenumber);
            Console.WriteLine("Address" + member.Address);
            Console.WriteLine("City: " + member.City);
            Console.WriteLine("State: " + member.State);
            Console.WriteLine("Pincode: " + member.pincode);
            Console.WriteLine("");
        }
        public void ListOfContact()
        {
            if (contactList.Count > 0)
            {
                Console.WriteLine("The Contact List : ");
                foreach (var member in contactList)
                {
                    DisplyContact(member);
                }

            }
            else
            {

                Console.WriteLine("Your address book is empty.");
                return;
            }
        }
    }
}
