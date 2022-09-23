namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            select();
        }
        public static Dictionary<string, List<NewContact>> addressbooknames = new Dictionary<string, List<NewContact>>();
        public static Dictionary<string, List<NewContact>> cities = new Dictionary<string, List<NewContact>>();
        public static Dictionary<string, List<NewContact>> states = new Dictionary<string, List<NewContact>>();
        public static List<NewContact> cityname;
        public static List<NewContact> statename;

        public static void select()
        {
            Console.WriteLine("-------------> WELCOME TO ADDRESS BOOK SYSTEM <------------------------");
            Console.WriteLine("1: Add Contact\n2: Display Contact\n3: Edit Contact\n4: Delete Contact\n5.Add Multiple Address Book\n6.Check Duplicate Entry\n7.Search By City on State\n8.Sort by city state\n9.IOOpertion\n10.CSV Operation\n0: Exit");
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
                case 8:
                    Console.WriteLine("Enter 1 to search the contacts based on city name and state");
                    Console.WriteLine("Enter 2 to print contact list based on city name and states");
                    Console.WriteLine("Enter 3 to print contact list based on sorting contacts");
                    string options = Console.ReadLine();
                    if (options == "1")
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
                    else if (options == "2")
                    {
                        //print the data based on city name using group by and lambda function
                        AddressBook address = new AddressBook();
                        foreach (KeyValuePair<string, List<NewContact>> kvp in addressbooknames)
                        {
                            var result = kvp.Value.GroupBy(mem => mem.City.ToLower());
                            if (result != null)
                            {
                                foreach (var val in result)
                                {
                                    foreach (NewContact member in val)
                                    {
                                        if (cities.ContainsKey(member.City.ToLower()))
                                        {
                                            foreach (KeyValuePair<string, List<NewContact>> key in cities)
                                            {
                                                if (key.Key.ToLower() == member.City.ToLower())
                                                {
                                                    key.Value.Add(member);

                                                }
                                            }

                                        }
                                        else
                                        {
                                            Program program = new Program();
                                            cityname.Add(member);
                                            cities.Add(member.City.ToLower(), cityname);

                                        }
                                    }
                                }


                            }
                            else
                            {
                                Console.WriteLine("No Contacts");
                            }

                        }
                        select();
                       
                    }
                    break;
                case 9:IOOperation iOOperation = new IOOperation();
                    iOOperation.GetDictionary(addressbooknames);
                    select();
                    break;
                case 10:
                    IOOperation iOperation = new IOOperation();
                    iOperation.CSVOperations(addressbooknames);
                    select();
                    break;
            }
        }
    }
}