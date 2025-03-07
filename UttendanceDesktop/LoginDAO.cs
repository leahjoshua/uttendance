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
        string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";

        // leah and parisa wrote this
        public Instructor login(String netID, String Password)
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
    }
}
