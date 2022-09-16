namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------> WELCOME TO ADDRESS BOOK SYSTEM <------------------------");
            //Calls by Default constructor
            AddressBook addressBook = new AddressBook();

            //Call by Method
            addressBook.CreateContact("Ajay", "Rathod", "Yavatmal", "Yavatmal", "MH", 445207, 7622093382, "aj007@gmail.com");
        }
    }
}