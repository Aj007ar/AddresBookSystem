namespace AddressBookSystem
{
    internal class Program
    {
        public static void select()
        {
            Console.WriteLine("-------------> WELCOME TO ADDRESS BOOK SYSTEM <------------------------");
            Console.WriteLine("1: Add Contact\n2: Display Contact\n3: Edit Contact\n4: Delete Contact\n0: Exit");
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
            }
        }
        static void Main(string[] args)
        {
            select();
        }
    }
}