namespace AddressBookSystem
{
    internal class Program
    {
        public static void select()
        {
            Console.WriteLine("-------------> WELCOME TO ADDRESS BOOK SYSTEM <------------------------");
            Console.WriteLine("1: Add Contact\n0: Exit");
            //Calls by Default constructor
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("Enter your Choice");
            int choice = Convert.ToInt32(Console.ReadLine());
 
            switch (choice)
            {
                case 1:
                    //Call by Method
                    addressBook.CreateContact("Ajay", "Rathod", "Yavatmal", "Yavatmal", "MH", 445207, 7622093382, "aj007@gmail.com");
                    addressBook.CreateContact("vijay", "Nayak", "Yavatmal", "Yavatmal", "MH", 445207, 7622093382, "aj007@gmail.com");
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