﻿/******************************************************************************
* SummaryDAO Class for the UttendanceDesktop application.
* This class serves as a database access object for the Summary page. It
* can retrieve the student information and submission information. It can
* also update the attendance status for a student.
* Written by Joanna Yang(jxy210012) 
* for CS4485.0W1 at The University of Texas at Dallas starting April 13, 2025.
******************************************************************************/
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
    internal class SummaryDAO
    {
        //Connection string to the database
        private static readonly string connectionString = GlobalResource.CONNECTION_STRING;

        /**************************************************************************
        * Gets the count of the total number of closed attendance forms
        * for the given class
        * Written by Joanna Yang
        **************************************************************************/
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

        /**************************************************************************
        * Returns the IP Address for a submission given the student id and form id
        * Written by Joanna Yang
        **************************************************************************/
        public string getIPAddress(int formID, int studentID)
        {
            //Open database connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Check if submissionID exists
            MySqlCommand cmd = new MySqlCommand("SELECT IPAddress FROM submission " +
               "WHERE submission.FK_FormID=@checkformID AND submission.FK_UTDID=@checkUtdID;", connection);
            cmd.Parameters.AddWithValue("@checkformID", formID);
            cmd.Parameters.AddWithValue("@checkUtdID", studentID);

            //Read IP Address
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    var ip = reader["IPAddress"];
                    if (ip == DBNull.Value)
                        return "NULL";
                    return ip.ToString();
                }
                else
                {
                    //Return "NULL" if there is no submission
                    return "NULL";
                }
            }
        }

        /**************************************************************************
        * Updates the attendance status for a submission given the student ID,
        * form ID, and new value for the status.
        * Written by Joanna Yang
        **************************************************************************/
        public void updateStatus(int studentID, int formID, string newValue)
        {
            //Open database connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Check if submissionID exists
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM submission " +
               "WHERE submission.FK_FormID=@checkformID AND submission.FK_UTDID=@checkUtdID;", connection);
            cmd.Parameters.AddWithValue("@checkformID", formID);
            cmd.Parameters.AddWithValue("@checkUtdID", studentID);

            //Read count
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = reader.GetInt32(0);
            reader.Close();

            //If is no submission by the student
            if (count == 0)
            {
                //Insert row into table
                cmd = new MySqlCommand("INSERT INTO submission (AttendanceStatus, IPAddress, DateTime, FK_FormID, FK_UTDID)" +
                    "VALUES (@status, NULL, NULL, @formID, @utdID);", connection);
                cmd.Parameters.AddWithValue("@status", newValue);
                cmd.Parameters.AddWithValue("@formID", formID);
                cmd.Parameters.AddWithValue("@utdID", studentID);
                cmd.ExecuteNonQuery();
            }
            else
            {
                //Update the entry in the table
                cmd = new MySqlCommand("UPDATE submission SET AttendanceStatus=@status " +
                    "WHERE submission.FK_FormID=@formID AND submission.FK_UTDID=@utdID;", connection);
                cmd.Parameters.AddWithValue("@status", newValue);
                cmd.Parameters.AddWithValue("@formID", formID);
                cmd.Parameters.AddWithValue("@utdID", studentID);
                cmd.ExecuteNonQuery();
            }
            //Close connection
            connection.Close();
        }

        /**************************************************************************
        * Creates a DataTable for the summary table in Summary page, displaying 
        * the information and submission details for every student in the class.
        * Written by Joanna Yang
        **************************************************************************/
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
            dataTable.Columns.Add("Abs.");
            dataTable.Columns.Add("IP Address");

            DateTime localDate = DateTime.Now;
            //Get the closed forms for this class ordere by release date
            MySqlCommand cmd = new MySqlCommand("SELECT FormID, DATE(ReleaseDateTime) AS ReleaseDate FROM form WHERE FK_CourseNum=@fkcourseNum " +
                "AND CloseDateTime < @now ORDER BY ReleaseDateTime ASC", connection);
            cmd.Parameters.AddWithValue("@fkcourseNum", courseNum);
            cmd.Parameters.AddWithValue("@now", localDate);

            int colNum = 6;
            //Create column headers for forms
            using (MySqlDataReader databaseReader = cmd.ExecuteReader())
            {
                //For each form, add a column header in the table
                while (databaseReader.Read())
                {
                    formCount++;
                    dataTable.Columns.Add("Form #" + formCount + "\r\n" +
                        ((DateTime)databaseReader["ReleaseDate"]).ToString("MM/dd"));
                    //Add form id to the column
                    dataTable.Columns[colNum].ExtendedProperties["FormID"] = databaseReader["FormID"].ToString();
                    colNum++;
                }
            }

            //Select student information from all students enrolled in the current class
            //as well as all of their attendance status for each form
            cmd = new MySqlCommand("SELECT s.*, DATE(ReleaseDateTime) AS ReleaseDate, sub.AttendanceStatus " +
                "FROM student s " +
                "JOIN attends a ON s.UTDID=a.FK_UTDID " +
                "JOIN form f ON a.FK_CourseNum=f.FK_CourseNum " +
                "LEFT JOIN submission sub ON sub.FK_FormID=f.FormID AND sub.FK_UTDID=s.UTDID " +
                "WHERE a.FK_CourseNum=@courseNum AND f.CloseDateTime < @today " +
                "ORDER BY s.UTDID ASC, f.ReleaseDateTime ASC;", connection);
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

                    row["IP Address"] = "";

                    var studentID = databaseReader["UTDID"].ToString();
                    //Fill in status for each form
                    int absenceCount = 0;
                    for (int i = 0; i < formCount; i++)
                    {
                        var status = databaseReader["AttendanceStatus"];
                        //If attendance status is null, then they don't have a submission for this form
                        //meaning they're absent
                        if (status == DBNull.Value || status.ToString() == "A")
                        {
                            absenceCount++;
                            status = "A";
                        }
                        //Add status to the appropriate form/column
                        row["Form #" + (i + 1) + "\r\n"
                            + ((DateTime)databaseReader["ReleaseDate"]).ToString("MM/dd")]
                            = status.ToString();

                        //Read the attendance status for the next form
                        if (i < formCount - 1)
                        {
                            databaseReader.Read();
                        }
                    }
                    //Set the unexcused absence count
                    row["Abs."] = absenceCount;

                    dataTable.Rows.Add(row);
                }
            }

            //Close database connection
            connection.Close();
            return dataTable;
        }
    }
}