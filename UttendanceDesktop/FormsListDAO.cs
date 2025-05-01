/******************************************************************************
* FormsListDAO Class for the UttendanceDesktop application.
* This class is a database access object for the FormList class.
* It pulls form information for each class taught by a professor and creates a
* data table for FormList class to display.
* Written by Joanna Yang (jxy210012)
* for CS4485.0W1 at The University of Texas at Dallas starting April 26, 2025.
******************************************************************************/

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UttendanceDesktop
{
    internal class FormsListDAO
    {
        //Conection string to the database
        private static readonly string connectionString = GlobalResource.CONNECTION_STRING;

        /**************************************************************************
        * Create a table to display all of the professor's attendance forms
        * with the corresponding class information given the professors
        * Net-id as well as a list of the column header name
        **************************************************************************/
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

            //Get all the forms and corresponding class information
            //under the given instructor net-id
            MySqlCommand cmd = new MySqlCommand("SELECT c.*, f.* " +
                "FROM teaches t " +
                "JOIN class c ON t.FK_CourseNum=c.CourseNum " +
                "JOIN form f ON c.CourseNum=f.FK_CourseNum " +
                "WHERE t.FK_INetID=@instructorID " +
                "ORDER BY f.ReleaseDateTime DESC;", connection);
            cmd.Parameters.AddWithValue("@instructorID", netID);

            //Read result
            using (MySqlDataReader databaseReader = cmd.ExecuteReader())
            {
                //For each form
                while (databaseReader.Read())
                {
                    var row = dataTable.NewRow();

                    //Combine the class information
                    string classSubject = databaseReader["ClassSubject"].ToString();
                    string classNum = databaseReader["ClassNum"].ToString();
                    string classSection = databaseReader["SectionNum"].ToString();
                    classSection = classSection.PadLeft(3, '0');
                    string classInfo = classSubject + " " + classNum + "." + classSection;
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

            //Close database connection
            connection.Close();
            return dataTable;

        }
    }
}
