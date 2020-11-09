using System;
using System.Collections.Generic;
using System.Data;
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
            table.Rows.Add("Mukhesh", "Attuluri", "8-47", "Ppm", "Ap", "535501", "8978496720","mkh.com");
            table.Rows.Add("Ram", "Bantu", "Sun nagar", "Vizag", "Ap", "546489", "8570456737", "ram.com");
            table.Rows.Add("Ravi", "Kumar", "Rain colony", "Hyd", "Telangana", "546362", "9878678593", "ravi.com");
            table.Rows.Add("Srinu", "Rao", "WhiteField", "Banglore", "Karnataka", "125445", "7206326427", "srinu.com");
        }

    }
}
