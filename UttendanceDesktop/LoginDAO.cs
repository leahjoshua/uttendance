/******************************************************************************
* LoginDAO
* 
* This is a Data Access Object which interacts with the Instructor table. Used
* to help log in to the application.
*
* Written by Leah Joshua (lej210003) 
* and Parisa Nawar (pxn210032) at The University of Texas at Dallas
* starting August 18, 2016.
******************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UttendanceDesktop
{
    internal class LoginDAO
    {
        private string connectionString = GlobalResource.CONNECTION_STRING;

        /**************************************************************************
        * Search the instructor table for the instructor logging in based on their
        * NetID and password. Returns an Instructor object with the relevant
        * information.
        * 
        * Written by Leah Joshua, updated by Parisa Nawar.
        **************************************************************************/
        public Instructor login(string netID, string Password)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Create SQL command to select the NetID, First Name, and Last Name of the professor
            MySqlCommand cmd = new MySqlCommand("SELECT INetID, IFName, ILName, IPassword FROM instructor WHERE INetID=@netID and IPassword=@password", connection);
            cmd.Parameters.AddWithValue("@netID", netID);
            cmd.Parameters.AddWithValue("@password", Password);

            Instructor currentInstructor = new Instructor();

            // Pulls all the columns from the selected data and puts them in an instructor object
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    currentInstructor = new Instructor
                    {
                        INetID = reader.GetString(0),
                        IFName = reader.GetString(1),
                        ILName = reader.GetString(2)
                    };
                }
            }

            connection.Close();

            return currentInstructor;
        }

        /**************************************************************************
        * Search the instructor table for the instructor logging in based on their
        * NetID and password. Returns an Instructor object with the relevant
        * information.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        public int createAccount(Instructor instructor, string IPassword)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO instructor (INetID, IFName, ILName, IPassword)" +
                "VALUES (@netID, @fName, @lName, @password)", connection);
            cmd.Parameters.AddWithValue("@netID", instructor.INetID);
            cmd.Parameters.AddWithValue("@fName", instructor.IFName);
            cmd.Parameters.AddWithValue("@lName", instructor.ILName);
            cmd.Parameters.AddWithValue("@password", IPassword);

            int newRows = cmd.ExecuteNonQuery();
            connection.Close();

            return newRows;
        }
    }
}
