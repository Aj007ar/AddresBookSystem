using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
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
        public void CSVOperations(Dictionary<string, List<NewContact>> addressbooknames)
        {
            string export = @"D:\BL\LinuxBatch-560\LFP-183-DotNet\AdressBookSystem\AddresBookSystem\AddressBookSystem\AddressBook.csv";

            foreach (KeyValuePair<string, List<NewContact>> kvp in addressbooknames)
            {
                //normal config
                var config = new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
                foreach (var mem in kvp.Value)
                {
                    List<NewContact> list = new List<NewContact>();
                    list.Add(mem);
                    //Opening file open with append mode
                    using (var stream = File.Open(export, FileMode.Append))
                    using (var writer = new StreamWriter(stream))
                    using (var csvWriter = new CsvWriter(writer, config))
                    {
                        //writes the data next row
                        csvWriter.WriteRecords(list);
                    }
                    //header config for not printing
                    config = new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)
                    {
                        HasHeaderRecord = false,
                    };

                }



            }
            //Reads from CSV
            using (var reader = new StreamReader(export))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<NewContact>().ToList();
                foreach (NewContact member in records)
                {
                    if (member.firstname == "firstname")
                    {
                        Console.WriteLine(" ");
                        continue;
                    }
                    Console.WriteLine(member.ToString());
                }

            }



        }
    }
}
