using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookLINQ
{
    public class AddressBookDataTable
    {
        // UC 1 Create a new DataTable
        DataTable table = new DataTable("AddressBook");

        /// <summary>
        /// UC2
        /// creating constructor
        /// Adding columns by invoking constructor
        /// </summary>
        public AddressBookDataTable()
        {
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Email", typeof(string));
            ///UC3 Inserting Data into Table
            table.Rows.Add("Mukhesh", "Attuluri", "8-47", "Ppm", "Ap", "535501", "8978496720", "mkh.com");
            table.Rows.Add("Ram", "Bantu", "Sun nagar", "Vizag", "Ap", "546489", "8570456737", "ram.com");
            table.Rows.Add("Ravi", "Kumar", "Rain colony", "Hyd", "Telangana", "546362", "9878678593", "ravi.com");
            table.Rows.Add("Srinu", "Rao", "WhiteField", "Banglore", "Karnataka", "125445", "7206326427", "srinu.com");
        }
        /// <summary>
        /// This method prints all contacts in DataTable
        /// </summary>
        public void GetAllContacts()
        {
            foreach (DataRow dr in table.AsEnumerable())
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:- " + dr.Field<string>("FirstName"));
                Console.WriteLine("lastName:- " + dr.Field<string>("LastName"));
                Console.WriteLine("Address:- " + dr.Field<string>("Address"));
                Console.WriteLine("City:- " + dr.Field<string>("City"));
                Console.WriteLine("State:- " + dr.Field<string>("State"));
                Console.WriteLine("zip:- " + dr.Field<string>("Zip"));
                Console.WriteLine("phoneNumber:- " + dr.Field<string>("phoneNumber"));
                Console.WriteLine("eMail:- " + dr.Field<string>("Email"));
            }

        }
        /// <summary>
        /// UC4
        /// Updates Existing contact
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="columnName"></param>
        /// <param name="newValue"></param>
        public void UpdateContact(string firstName, string lastName, string columnName, string newValue)
        {
            DataRow updateContact = table.Select("FirstName = '" + firstName + "' and LastName = '" + lastName + "'").FirstOrDefault();
            updateContact[columnName] = newValue;
            Console.WriteLine("Updated Contact");
        }
        /// <summary>
        /// UC 5 
        /// Deletes a specific contact.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public void DeleteContact(string firstName, string lastName)
        {
            DataRow deleteContact = table.Select("FirstName = '" + firstName + "' and LastName = '" + lastName + "'").FirstOrDefault();
            table.Rows.Remove(deleteContact);
        }
        /// <summary>
        /// UC 6 Retrieves the state or city.
        /// </summary>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        public void RetrieveByCityOrState(string city, string state)
        {
            ArrayList list = new ArrayList ();
            var contact = from c in table.AsEnumerable()
                          where c.Field<string>("City") == city || c.Field<string>("State") == state
                          select c;
            foreach (DataRow dr in contact)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:- " + dr.Field<string>("FirstName"));
                Console.WriteLine("lastName:- " + dr.Field<string>("LastName"));
                Console.WriteLine("Address:- " + dr.Field<string>("Address"));
                Console.WriteLine("City:- " + dr.Field<string>("City"));
                Console.WriteLine("State:- " + dr.Field<string>("State"));
                Console.WriteLine("zip:- " + dr.Field<string>("Zip"));
                Console.WriteLine("phoneNumber:- " + dr.Field<string>("phoneNumber"));
                Console.WriteLine("eMail:- " + dr.Field<string>("Email"));
            }
        }
        /// <summary>
        /// UC 7 
        /// Count by state or city
        /// </summary>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        public void CountByCityOrState(string city, string state)
        {
            var contact = from c in table.AsEnumerable()
                          where c.Field<string>("City") == city && c.Field<string>("State") == state
                          select c;

            Console.WriteLine("Count of contacts in City:{0} and  State:{1} is {2}", city, state, contact.Count());
        }
        /// <summary>
        /// UC 8 Gets all by city.
        /// </summary>
        /// <param name="city">The city.</param>
        public void GetAllByCityOrderByName(string city)
        {
            var contact = from c in table.AsEnumerable()
                          where c.Field<string>("City") == city
                          orderby c.Field<string>("FirstName"), c.Field<string>("LastName")
                          select c;
            foreach (DataRow dr in contact)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:- " + dr.Field<string>("FirstName"));
                Console.WriteLine("lastName:- " + dr.Field<string>("LastName"));
                Console.WriteLine("Address:- " + dr.Field<string>("Address"));
                Console.WriteLine("City:- " + dr.Field<string>("City"));
                Console.WriteLine("State:- " + dr.Field<string>("State"));
                Console.WriteLine("zip:- " + dr.Field<string>("Zip"));
                Console.WriteLine("phoneNumber:- " + dr.Field<string>("phoneNumber"));
                Console.WriteLine("eMail:- " + dr.Field<string>("Email"));
            }


        }
    }
}