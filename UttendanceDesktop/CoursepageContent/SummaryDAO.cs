using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

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

            int formCount = 0;

            ////Create the columns
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Net-ID");
            dataTable.Columns.Add("UTD-ID");
            dataTable.Columns.Add("Unexcused Absences");

            DateTime localDate = DateTime.Now;
            //Get the closed forms for this class
            MySqlCommand cmd = new MySqlCommand("SELECT FormID, DATE(ReleaseDateTime) AS ReleaseDate FROM form WHERE FK_CourseNum=@fkcourseNum " +
                "AND CloseDateTime < @now ORDER BY ReleaseDateTime ASC", connection);
            cmd.Parameters.AddWithValue("@fkcourseNum", courseNum);
            cmd.Parameters.AddWithValue("@now", localDate);

            //Create column headers
            using (MySqlDataReader databaseReader = cmd.ExecuteReader())
            {
                while (databaseReader.Read())
                {
                    formCount++;
                    dataTable.Columns.Add("Form #" + formCount + "\r\n" + 
                        ((DateTime)databaseReader["ReleaseDate"]).ToString("MM/dd"));
                }
            }

            //Select student information from all students enrolled in the current class
            //as well as all of their attendance status for each form
            cmd = new MySqlCommand("SELECT s.*, f.FormID, DATE(ReleaseDateTime) AS ReleaseDate, sub.AttendanceStatus " +
                "FROM student s " +
                "JOIN attends a ON s.UTDID=a.FK_UTDID " +
                "JOIN form f ON a.FK_CourseNum=f.FK_CourseNum " +
                "LEFT JOIN submission sub ON sub.FK_FormID=f.FormID AND sub.FK_UTDID=s.UTDID " +
                "WHERE a.FK_CourseNum=@courseNum AND f.CloseDateTime < @today " +
                "ORDER BY s.SLName ASC, f.ReleaseDateTime ASC;", connection);
            cmd.Parameters.AddWithValue("@courseNum", courseNum);
            cmd.Parameters.AddWithValue("@today", localDate);

            //Read result
            using (MySqlDataReader databaseReader = cmd.ExecuteReader())
            {
                //For each student
                while (databaseReader.Read())
                {
                    var row = dataTable.NewRow();
                    //Fill in student information
                    row["Last Name"] = databaseReader["SLName"].ToString();
                    row["First Name"] = databaseReader["SFName"].ToString();
                    row["Net-ID"] = databaseReader["SNetID"].ToString();
                    row["UTD-ID"] = databaseReader["UTDID"].ToString();

                    var studentID = databaseReader["UTDID"].ToString();
                    //Fill in status for each form
                    int absenceCount = 0;
                    for (int i = 0; i < formCount; i++)
                    {
                        var status = databaseReader["AttendanceStatus"];
                        //If attendance status is null, then they don't have a submission for this form
                        //meaning they're absent
                        if (status == DBNull.Value)
                        {
                            absenceCount++;
                            status = "A";
                        }
                        //Add status to the appropriate form/column
                        row["Form #" + (i + 1) + "\r\n"
                            + ((DateTime)databaseReader["ReleaseDate"]).ToString("MM/dd")]
                            = status.ToString();
                        if (i < formCount - 1)
                        {
                            databaseReader.Read();
                        }
                    }
                    row["Unexcused Absences"] = absenceCount;

                    dataTable.Rows.Add(row);
                }
            }

            connection.Close();
            //Send data to data table

            return dataTable;
        }
    }
}
