using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static UttendanceDesktop.GlobalResource;

namespace UttendanceDesktop.CoursepageContent
{
    //started 4/13/2025
    internal class StudentsDAO
    {
        private static readonly string connectionString = GlobalResource.CONNECTION_STRING;

        //Remove a student from a specific class given their UTD-ID
        public void removeStudentsFromClass(string id, int courseNum)
        {
            //Open database connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Remove student from the attends table
            MySqlCommand cmd = new MySqlCommand("DELETE FROM attends WHERE FK_UTDID=@fkUtdID AND FK_CourseNum=@courseNum;", connection);
            cmd.Parameters.AddWithValue("@fkUtdID", id);
            cmd.Parameters.AddWithValue("@courseNum", courseNum);
            cmd.ExecuteNonQuery();

            //Check if the student is enrolled in any other classes
            cmd = new MySqlCommand("SELECT COUNT(*) FROM attends WHERE FK_UTDID=@fkUtdID2;", connection);
            cmd.Parameters.AddWithValue("@fkUtdID2", id);
            //Read result
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = reader.GetInt32(0);
            reader.Close();
            connection.Close();

            //If not, then remove them from the student table
            if (count == 0)
            {
                removeStudentFromDB(id);
            }

        }

        //Removes a student from the student table in the database
        private void removeStudentFromDB(string id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM student WHERE UTDID=@utdID;", connection);
            cmd.Parameters.AddWithValue("@utdID", id);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public DataTable getAllStudentInfo(string[] displayList, int courseNum)
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
            //Select all student information from all students enrolled in the current class
            var query = "SELECT student.* FROM student " +
                "INNER JOIN attends ON student.UTDID=attends.FK_UTDID " +
                "WHERE attends.FK_CourseNum=" + GlobalResource.CURRENT_CLASS_ID +
                " ORDER BY student.SLName;";

            //Execute query
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Read result
            using (MySqlDataReader databaseReader = cmd.ExecuteReader())
            {
                while (databaseReader.Read())
                {
                    var row = dataTable.NewRow();

                    row[displayList[0]] = databaseReader["SLName"].ToString();
                    row[displayList[1]] = databaseReader["SFName"].ToString();
                    row[displayList[2]] = databaseReader["SNetID"].ToString();
                    row[displayList[3]] = databaseReader["UTDID"].ToString();

                    dataTable.Rows.Add(row);
                }

            }

            connection.Close();
            //Send data to data table
            return dataTable;
        }

    }
}
