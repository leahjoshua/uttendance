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
        private string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";

        // leah and parisa wrote this
        public Instructor login(string netID, string Password)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT INetID, IFName, ILName, IPassword FROM instructor WHERE INetID=@netID and IPassword=@password", connection);
            cmd.Parameters.AddWithValue("@netID", netID);
            cmd.Parameters.AddWithValue("@password", Password);

            Instructor currentInstructor = new Instructor();

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
        //leah
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
