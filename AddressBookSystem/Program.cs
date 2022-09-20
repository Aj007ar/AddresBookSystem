namespace AddressBookSystem
{
    internal class Program
    {
        private static readonly IEnumerable<KeyValuePair<string, List<NewContact>>> addressbooknames;

        public static void select()
        {
            Console.WriteLine("-------------> WELCOME TO ADDRESS BOOK SYSTEM <------------------------");
            Console.WriteLine("1: Add Contact\n2: Display Contact\n3: Edit Contact\n4: Delete Contact\n5.Add Multiple Address Book\n6.Check Duplicate Entry\n7.Search By City on State\n0: Exit");
            //Calls by Default constructor
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("Enter your Choice");
            int choice = Convert.ToInt32(Console.ReadLine());
 
            switch (choice)
            {
                case 1:
                    addressBook.Addressbook();
                    select();
                    break;
                case 2:
                    addressBook.ListOfContact();
                    select();
                    break;
                case 3:
                    addressBook.Modify();
                    select();
                    break;
                case 4:
                    addressBook.DeleteDetails();
                    select();
                    break;
                case 5:
                    MultipleAddressBook multipleAddressBook = new MultipleAddressBook();
                    multipleAddressBook.AddressBookName();
                    addressBook.ListOfContact();
                    select();
                    break;
                case 6:
                    addressBook.Addressbook();
                    select();
                    break;
                case 7:
                    Console.WriteLine("Enter 1 to search the contacts based on city name and state");
                    if (Console.ReadLine() == "1")
                    {
                        Console.WriteLine("Enter City name");
                        string cityname = Console.ReadLine();
                        Console.WriteLine("Enter state name");
                        string state = Console.ReadLine();
                        //using keyvalue to get value of the key.
                        foreach (KeyValuePair<string, List<NewContact>> kvp in addressbooknames)
                        {
                            Console.WriteLine("The address Books is:{0}", kvp.Key);
                            Console.WriteLine("The Contact List from {0} or {1}", cityname, state);
                            addressBook.Search(kvp.Value, cityname, state);
                        }
                    }
                    select();
                    break;
            }
        }
        static void Main(string[] args)
        {
            select();
        }
    }
}