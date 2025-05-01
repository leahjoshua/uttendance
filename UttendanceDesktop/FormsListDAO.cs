using MySql.Data.MySqlClient;
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

        //Create a table to display all of the professor's attendance forms
        //With the corresponding class information
        public DataTable getAllForms(string[] displayList, string netID)
        {
            DataTable dataTable = new DataTable();

            //Create the columns
            for (int i = 0; i < displayList.Length; i++)
            {
                dataTable.Columns.Add(displayList[i]);
            }

            //Open database connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Get all the forms the under the given instructor net-id
            MySqlCommand cmd = new MySqlCommand("SELECT c.*, f.* " +
                "FROM teaches t " +
                "JOIN class c ON t.FK_CourseNum=c.CourseNum " +
                "JOIN form f ON c.CourseNum=f.FK_CourseNum " +
                "WHERE t.FK_INetID=@id " +
                "ORDER BY f.ReleaseDateTime DESC;", connection);
            cmd.Parameters.AddWithValue("@id", netID);

            //Read result
            using (MySqlDataReader databaseReader = cmd.ExecuteReader())
            {
                //For each form
                while (databaseReader.Read())
                {
                    var row = dataTable.NewRow();

                    //Combine the class information
                    string cSubject = databaseReader["ClassSubject"].ToString();
                    string cNum = databaseReader["ClassNum"].ToString();
                    string cSection = databaseReader["SectionNum"].ToString();
                    cSection = cSection.PadLeft(3, '0');
                    string classInfo = cSubject + " " + cNum + "." + cSection;
                    row["Class"] = classInfo;

                    row["Class Name"] = databaseReader["ClassName"].ToString();

                    //Get the release date and time
                    DateTime releaseDate = (DateTime)databaseReader["ReleaseDateTime"];
                    row["Date"] = releaseDate.Date.ToString("MM/dd");
                    row["Release"] = releaseDate.ToString("hh:mm tt");

                    //Get the close time
                    DateTime closeDate = (DateTime)databaseReader["CloseDateTime"];
                    row["Close"] = closeDate.ToString("hh:mm tt");

                    //Get the password
                    row["Password"] = databaseReader["PassWd"];

                    dataTable.Rows.Add(row);
                }
            }

            connection.Close();
            return dataTable;

        }
    }
}
