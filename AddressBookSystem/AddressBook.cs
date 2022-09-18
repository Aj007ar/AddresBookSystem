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
        public void Modify()
        {
            if (contactList.Count > 0)
            {
                Console.WriteLine("Enter the First name of the contact to modify:");
                string target = Console.ReadLine();
                foreach (var member in contactList)
                {
                    if (member.firstname.ToLower() == target.ToLower())
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the option to modify the property: ");
                            Console.WriteLine("Enter 1 to Change First name ");
                            Console.WriteLine("Enter 2 to Change Last name ");
                            Console.WriteLine("Enter 3 to Change Phone Number ");
                            Console.WriteLine("Enter 4 to Change Address ");
                            Console.WriteLine("Enter 5 to Change City ");
                            Console.WriteLine("Enter 6 to Change State ");
                            Console.WriteLine("Enter 7 to Change Pincode ");
                            Console.WriteLine("Enter 8 to Exit ");
                            int option = Convert.ToInt32(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    Console.WriteLine("Enter the New First Name: ");
                                    member.firstname = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the New Last Name: ");
                                    member.lastname = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the New Phone Number: ");
                                    member.phonenumber = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the New Address: ");
                                    member.Address = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the New City: ");
                                    member.City = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the New State: ");
                                    member.State = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the New Pin Code: ");
                                    member.pincode = Console.ReadLine();
                                    break;
                                case 8:
                                    return;

                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("Please enter the valid name!");
                    }

                }


            }
            else
            {
                Console.WriteLine("Your Address Book is empty!");
            }

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
