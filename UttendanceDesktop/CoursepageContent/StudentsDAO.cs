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
    // Written by Joanna Yang for CS4485.0w1, Uttendance, starting April 13, 2025.
    // NetID: jxy210012
    internal class StudentsDAO
    {
        private static readonly string connectionString = GlobalResource.CONNECTION_STRING;
        private static string[] attributeList = { "SLName", "SFNAME", "SNetID", "UTDID" };

        //Updates the UTD-ID for a student given their new and old id
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

        //Updates the student's information given their UTD-ID and the new value
        public void updateStudentInfo(int studentID, int columnToUpdate, string newInfo)
        {
            //Open database connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE student SET " + attributeList[columnToUpdate]
                    + "=@newInfo WHERE UTDID=@utdID;", connection);
            cmd.Parameters.AddWithValue("@newInfo", newInfo);
            cmd.Parameters.AddWithValue("@utdID", studentID);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //Remove a student from a specific class given their UTD-ID
        public void removeStudentsFromClass(string id, int courseNum)
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

        //Pulls the list of all students enrolled in the current class and displays it on the data grid
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

        //Returns true if the given student is already added to the student database
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

            return count != 0;
        }

        //Returns true if the given student is already enrolled in the given class
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

            return count != 0;
        }

        //Reads the given CSV file and adds the student information to the database and enrolls them into the given class
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
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
