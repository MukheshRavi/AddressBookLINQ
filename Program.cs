using System;

namespace AddressBookLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Linq");
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
            //addressBookDataTable.GetAllContacts();
            //addressBookDataTable.UpdateContact("Mukhesh", "Attuluri", "Address", "Vemakotavari Street");
            //addressBookDataTable.GetAllContacts();
            addressBookDataTable.RetrieveByCityOrState("ppm", "Ap");
            addressBookDataTable.CountByCityOrState("Ppm", "Ap");
        }
    }
}
