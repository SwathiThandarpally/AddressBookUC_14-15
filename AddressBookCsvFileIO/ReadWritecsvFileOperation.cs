using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookCsvFileIO
{
    public class ReadWritecsvFileOperation
    {
        public void ReadWriteOperation()
        {
            //Read Operation File Path
            string csvReadpath = @"C:\Users\sai\source\repos\RFP-244\AddressBookUC_14-15\AddressBookUC_14-15\AddressBookCsvFileIO\Addresses.csv";
            //Write Operation File Path
            string csvWritepath = @"C:\Users\sai\source\repos\RFP-244\AddressBookUC_14-15\AddressBookUC_14-15\AddressBookCsvFileIO\writeData.csv";
            //Json File Path
            string jsonFilepath = @"C:\Users\sai\source\repos\RFP-244\AddressBookUC_14-15\AddressBookUC_14-15\AddressBookCsvFileIO\Details.json";
            //Read Operation
            using (var reader = new StreamReader(csvReadpath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<ContactDetails>().ToList();
                //foreach (var details in records)
                //{
                //    Console.Write(details.FirstName);
                //    Console.Write("," + details.LastName);
                //    Console.Write("," + details.Address);
                //    Console.Write("," + details.City);
                //    Console.Write("," + details.State);
                //    Console.Write("," + details.PhoneNumber);
                //    Console.Write("," + details.Email);
                //    Console.Write("," + details.Zip);
                //    Console.WriteLine();
                //}
                ////Write Operation
                //using (var writer = new StreamWriter(csvWritepath))
                //using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                //{
                //    csvWriter.WriteRecords(records);
                //}
                //Json Operation
                JsonSerializer serializer = new JsonSerializer();
                using(var writer = new StreamWriter(jsonFilepath))
                using (var jsonWriter =new JsonTextWriter(writer))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonWriter, records);
                }
                Console.ReadKey();
               
            }
        }
    }
}
