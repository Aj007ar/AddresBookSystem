using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class IOOperation
    {
        const string filepath = @"D:\BL\LinuxBatch-560\LFP-183-DotNet\AdressBookSystem\AddresBookSystem\AddressBook.txt";
        public static List<string> list;
        //file writes the addressbook in a file
        public void GetDictionary(Dictionary<string, List<NewContact>> addressbooknames)
        {
            File.WriteAllText(filepath, string.Empty);
            foreach (KeyValuePair<string, List<NewContact>> kvp in addressbooknames)
            {
                list = new List<string>();
                list.Add("The address book name is: " + kvp.Key);
                foreach (var member in kvp.Value)
                {
                    list.Add(member.ToString());
                }
                try
                {
                    File.AppendAllLines(filepath, list);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            try
            {
                string[] text = File.ReadAllLines(filepath);
                Console.WriteLine("The Content written in the file");
                foreach (var mem in text)
                    Console.WriteLine(mem);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ReadAddressBook()
        {
            string[] text = File.ReadAllLines(filepath);
            foreach (var mem in text)
                Console.WriteLine(mem);
        }
    }
}
