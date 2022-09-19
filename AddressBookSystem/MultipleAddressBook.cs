using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class MultipleAddressBook:AddressBook
    {
        public static Dictionary<string, List<NewContact>> addressbooknames = new Dictionary<string, List<NewContact>>();
        public void AddressBookName()
        {
            Console.WriteLine("Enter the number of address books to be added to the system: ");
            int addressbooks = Convert.ToInt32(Console.ReadLine());
            int booksadded = 0;
            while (booksadded < addressbooks)
            {
                Console.WriteLine("Enter the address book name: ");
                string addressbookname = Console.ReadLine();
                ///obj creation
                AddressBook addressBook = new AddressBook();
                Console.WriteLine("Enter the no of contacts in the address book: ");
                int contatcs = Convert.ToInt32(Console.ReadLine());

                while (contatcs != 0)
                {
                    Console.WriteLine("Enter the details of contact to be added: ");
                    addressBook.Addressbook();
                    contatcs--;
                    Console.WriteLine(" ");
                   // addressBook.ListContactPeople();
                }
                Console.WriteLine("1.Modify Details \n2.delete a contact detail Press 2\n0.exit");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    addressBook.Modify();
                    Console.WriteLine(" ");
                    //addressBook.ListContactPeople();
                }
                else if (option == 2)
                {
                    addressBook.DeleteDetails();
                    Console.WriteLine(" ");
                    //addressBook.ListContactPeople();
                }


                if (addressbooknames.ContainsKey(addressbookname))
                {
                    Console.WriteLine("Existing address book name : {0} . Please retry!", addressbookname);
                    return;
                }
                else
                {

                    ///adding details to the dictionary
                    addressbooknames.Add(addressbookname,addressBook.contactList);
                }


                booksadded++;
            }
            //using keyvalue to get value of the key.
            foreach (KeyValuePair<string, List<NewContact>> kvp in addressbooknames)
            {
                Console.WriteLine("The address Books are:{0}", kvp.Key);

            }

        }
    }
    
}
