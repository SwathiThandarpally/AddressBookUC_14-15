namespace AddressBookCsvFileIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Csv File I/O To The AddressBook Problem");
            ReadWritecsvFileOperation readWritecsvFile = new ReadWritecsvFileOperation();
            readWritecsvFile.ReadWriteOperation();
        }
    }
}