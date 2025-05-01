/******************************************************************************
* StudentsDAO Class for the UttendanceDesktop application.
* This class serves as a database access object for Students, StudentAddModal,
* and Student, ImportModal. It accesses database information and updates information.
* Written by Joanna Yang(jxy210012) 
* for CS4485.0W1 at The University of Texas at Dallas starting April 13, 2025.
******************************************************************************/
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static UttendanceDesktop.GlobalResource;

namespace UttendanceDesktop.CoursepageContent
{
    internal class StudentsDAO
    {
        //Connection string to the database
        private static readonly string connectionString = GlobalResource.CONNECTION_STRING;
        //List of attribute names for the student table
        private static string[] attributeList = { "SLName", "SFNAME", "SNetID", "UTDID" };

        /**************************************************************************
        * Updates the UTD-ID for a student given their new and old
        * UTD-ID. Performs checks to prevent errors
        * Written by Joanna Yang
        **************************************************************************/
        public bool updateStudentID(int oldID, int newID)
        {
            //Open database connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Check if the new UTD-ID already exists in the table
            if(checkIfStudentExists(newID, connection))
            {
                return false;
            }

            //Update student's UTD-ID
            MySqlCommand cmd = new MySqlCommand("UPDATE student SET UTDID=@newID WHERE UTDID=@oldID;", connection);
            cmd.Parameters.AddWithValue("@newID", newID);
            cmd.Parameters.AddWithValue("@oldID", oldID);
            cmd.ExecuteNonQuery();
            connection.Close();

            return true;
        }

        /**************************************************************************
        * Updates the student's information given their UTD-ID and the new value
        * UTD-ID.
        * Written by Joanna Yang
        **************************************************************************/
        public void updateStudentInfo(int studentID, int columnToUpdate, string newInfo)
        {
            //Open database connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //Update the student entry
            MySqlCommand cmd = new MySqlCommand("UPDATE student SET " + attributeList[columnToUpdate]
                    + "=@newInfo WHERE UTDID=@utdID;", connection);
            cmd.Parameters.AddWithValue("@newInfo", newInfo);
            cmd.Parameters.AddWithValue("@utdID", studentID);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /**************************************************************************
        * Remove a student from a specific class given their UTD-ID. Also
        * removes the student's submissions for the corresponding class.
        * Calls removeStudentFromDB to clean up the database if the student
        * is not enrolled in any other class.
        * Written by Joanna Yang
        **************************************************************************/
        public void removeStudentFromClass(string id, int courseNum)
        {
            //Open database connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Remove all submissions by the student for this class
            MySqlCommand cmd = new MySqlCommand("DELETE submission FROM submission " +
                "JOIN form on form.FormID = submission.FK_FormID " +
                "WHERE FK_UTDID=@fkUtdID2 AND form.FK_CourseNum=@courseNum2;", connection);
            cmd.Parameters.AddWithValue("@fkUtdID2", id);
            cmd.Parameters.AddWithValue("@courseNum2", courseNum);
            cmd.ExecuteNonQuery();

            //Remove student from the attends table
            cmd = new MySqlCommand("DELETE FROM attends WHERE FK_UTDID=@fkUtdID AND FK_CourseNum=@courseNum;", connection);
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

        /**************************************************************************
        * Removes a student from the student table in the database
        * Written by Joanna Yang
        **************************************************************************/
        private void removeStudentFromDB(string id)
        {
            //Open connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Remove student from the student table
            MySqlCommand cmd = new MySqlCommand("DELETE FROM student WHERE UTDID=@utdID;", connection);
            cmd.Parameters.AddWithValue("@utdID", id);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        /**************************************************************************
        * Pulls the information of all of the students enrolled in the given class 
        * and creates a table to return.
        * Written by Joanna Yang
        **************************************************************************/
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
            MySqlCommand cmd = new MySqlCommand("SELECT student.* FROM student " +
                "INNER JOIN attends ON student.UTDID=attends.FK_UTDID " +
                "WHERE attends.FK_CourseNum=@courseNum ORDER BY student.SLName;", connection);
                cmd.Parameters.AddWithValue("@courseNum", courseNum);
            //Read result
            using (MySqlDataReader databaseReader = cmd.ExecuteReader())
            {
                //Add the student information to the table for each entry
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

        /**************************************************************************
        * Returns true if the given student ID is already added to the student table database
        * Written by Joanna Yang
        **************************************************************************/
        private bool checkIfStudentExists(int id, MySqlConnection connection)
        {
            //Check if the new UTD-ID does not already exist in the table
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM student WHERE UTDID=@utdID;", connection);
            cmd.Parameters.AddWithValue("@utdID", id);

            //Read result
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = reader.GetInt32(0);
            reader.Close();

            //Return true if an entry exists
            return count != 0;
        }

        /**************************************************************************
        * Returns true if the given student ID is already enrolled in the given class
        * Written by Joanna Yang
        **************************************************************************/
        private bool checkIfStudentAttends(int id, int courseNum, MySqlConnection connection)
        {
            //Check if the new UTD-ID does not already exist in the table
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM attends " +
                "WHERE FK_UTDID=@fk_utdID AND FK_CourseNum=@fk_courseNum;", connection);
            cmd.Parameters.AddWithValue("@fk_utdID", id);
            cmd.Parameters.AddWithValue("@fk_courseNum", courseNum);

            //Read result
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = reader.GetInt32(0);
            reader.Close();

            //Return true if an entry exists
            return count != 0;
        }

        /**************************************************************************
        * Adds student to database, returns true if student was successfully added.
        * Perform checks before adding to database to prevent errors.
        * Returns a boolean on whether or not the operation was a success.
        * Written by Joanna Yang
        **************************************************************************/
        public bool addStudent(Student student, int courseNum)
        {
            //Open database connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Ignore if student already exists in student table
            if (!checkIfStudentExists(student.SUTDID.Value, connection))
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO student (SLName, SFName, SNetID, UTDID) \n"
                    + "VALUES(@lName, @fName, @netID, @utdID);", connection);
                cmd.Parameters.AddWithValue("@lName", student.SLName);
                cmd.Parameters.AddWithValue("@fName", student.SFName);
                cmd.Parameters.AddWithValue("@netID", student.SNetID);
                cmd.Parameters.AddWithValue("@utdID", student.SUTDID);

                cmd.ExecuteNonQuery();
            }

            //Ignore if student is already in the class
            if (!checkIfStudentAttends(student.SUTDID.Value, courseNum, connection))
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO attends (`FK_UTDID`, `FK_CourseNum`) \n"
                    + "VALUES(@utdID, @courseNum);", connection);
                cmd.Parameters.AddWithValue("@utdID", student.SUTDID);
                cmd.Parameters.AddWithValue("@courseNum", courseNum);

                cmd.ExecuteNonQuery();
            }
            else
            {
                return false;
            }

            return true;
        }

        /**************************************************************************
        * Reads the given CSV file and adds the student information to the database 
        * and enrolls them into the given class. Perform checks before adding to
        * to database to prevent errors. Returns a boolean on whether or not
        * the operation was a success.
        * Written by Joanna Yang
        **************************************************************************/
        public bool importStudentsFromCSV(string path, int courseNum)
        {
            try
            {
                //Open database connection
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                //Open and read the file
                StreamReader fileReader = new StreamReader(File.OpenRead(path));
                int lineNum = 0;
                while (!fileReader.EndOfStream)
                {
                    //Read each line
                    var line = fileReader.ReadLine();
                    var values = line.Split(',');
                    int length = values.Length;

                    //Ignore the heading & check if input has the correct number of columns
                    if (lineNum != 0 && length == 4)
                    {
                        MySqlCommand cmd;

                        //Get values
                        var lName = values[0].ToString();
                        var fName = values[1].ToString();
                        var netID = values[2].ToString();
                        var tryStudentID = values[3].ToString();

                        //Make sure UTDID is an integer
                        if (int.TryParse(tryStudentID, out int studentID))
                        {
                            //Check if UTD-ID doesn't exists in the student table yet
                            if (!checkIfStudentExists(studentID, connection))
                            {
                                //Add student to student table id database
                                cmd = new MySqlCommand("INSERT INTO student (SLName, SFName, SNetID, UTDID) " +
                                    "VALUES (@lName, @fName, @netID, @utdID);", connection);
                                cmd.Parameters.AddWithValue("@lName", lName);
                                cmd.Parameters.AddWithValue("fName", fName);
                                cmd.Parameters.AddWithValue("@netID", netID);
                                cmd.Parameters.AddWithValue("@utdID", studentID);
                                cmd.ExecuteNonQuery();
                            }

                            //Check if student isn't enrolled in the class yet
                            if(!checkIfStudentAttends(studentID, courseNum, connection))
                            {
                                cmd = new MySqlCommand("INSERT INTO attends (FK_CourseNum, FK_UTDID) " +
                                    "VALUES (@fk_courseNum, @fk_utdID);", connection);
                                cmd.Parameters.AddWithValue("@fk_utdID", studentID);
                                cmd.Parameters.AddWithValue("@fk_courseNum", courseNum);
                                cmd.ExecuteNonQuery();
                            }

                        }
                        else
                        {
                            return false;
                        }
                    }
                    lineNum++;
                }

                //Close connection
                fileReader.Close();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
