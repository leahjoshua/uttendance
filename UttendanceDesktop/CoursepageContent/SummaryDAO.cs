using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UttendanceDesktop.CoursepageContent
{
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting April 13, 2025.
    // NetID: jxy210012
    internal class SummaryDAO
    {
        private static readonly string connectionString = GlobalResource.CONNECTION_STRING;

        //Gets the count of the total number of closed forms
        public int getClosedFormCount(int courseNum)
        {
            //Open database connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            DateTime localDate = DateTime.Now;
            //Get the count closed forms for this class
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM form WHERE FK_CourseNum=@fkcourseNum " +
                "AND CloseDateTime < @now", connection);
            cmd.Parameters.AddWithValue("@fkcourseNum", courseNum);
            cmd.Parameters.AddWithValue("@now", localDate);
            //Read result
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = reader.GetInt32(0);
            reader.Close();
            connection.Close();

            return count;
        }

        public DataTable getSummaryInfo(int courseNum)
        {
            DataTable dataTable = new DataTable();
            //Open database connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            ArrayList formList = new ArrayList();

            ////Create the columns
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Net-ID");

            DateTime localDate = DateTime.Now;
            //Get the count closed forms for this class
            MySqlCommand cmd = new MySqlCommand("SELECT FormID, DATE(ReleaseDateTime) AS ReleaseDate FROM form WHERE FK_CourseNum=@fkcourseNum " +
                "AND CloseDateTime < @now ORDER BY ReleaseDateTime", connection);
            cmd.Parameters.AddWithValue("@fkcourseNum", courseNum);
            cmd.Parameters.AddWithValue("@now", localDate);
            //Read result
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = reader.GetInt32(0);
            reader.Close();

            using (MySqlDataReader databaseReader = cmd.ExecuteReader())
            {
                int currNum = 0;
                while (databaseReader.Read())
                {
                    currNum++;
                    dataTable.Columns.Add("Form #" + currNum + "\r\n" + 
                        ((DateTime)databaseReader["ReleaseDate"]).ToString("MM/dd/yy"));
                    formList.Add(databaseReader["FormID"].ToString());
                }
            }

            //Select student information from all students enrolled in the current class
            cmd = new MySqlCommand("SELECT student.* FROM student " +
                "INNER JOIN attends ON student.UTDID=attends.FK_UTDID " +
                "WHERE attends.FK_CourseNum=@courseNum ORDER BY student.SLName;", connection);
            cmd.Parameters.AddWithValue("@courseNum", courseNum);

            ////Execute query
            //MySqlCommand cmd = new MySqlCommand(query, connection);
            ////Read result
            //using (MySqlDataReader databaseReader = cmd.ExecuteReader())
            //{
            //    while (databaseReader.Read())
            //    {
            //        var row = dataTable.NewRow();

            //        row["Last Name"] = databaseReader["SLName"].ToString();
            //        row["First Name"] = databaseReader["SFName"].ToString();

            //        dataTable.Rows.Add(row);
            //    }
            //}

            //connection.Close();
            ////Send data to data table

            return dataTable;
        }
    }
}
