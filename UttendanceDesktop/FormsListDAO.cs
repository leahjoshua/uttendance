using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UttendanceDesktop
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting April 26, 2025.
    // NetID: jxy210012
    // Wrote the whole FormDAO class
    internal class FormsListDAO
    {
        private static readonly string connectionString = GlobalResource.CONNECTION_STRING;

        public DataTable getAllForms(string[] displayList, string netID)
        {
            DataTable dataTable = new DataTable();

            //Create the columns
            for (int i = 0; i < displayList.Length; i++)
            {
                dataTable.Columns.Add(displayList[i]);
            }

            var row = dataTable.NewRow();

            dataTable.Rows.Add(row);

            return dataTable;

        }
    }
}
