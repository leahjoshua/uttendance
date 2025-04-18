using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UttendanceDesktop
{
    internal class Login
    {
        string connectionString = GlobalResource.CONNECTION_STRING;

        // leah wrote this (and parisa)
        public String login(String netID, String Password)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT INetID, IPassword FROM instructor WHERE INetID=@netID and IPassword=@password", connection);
            cmd.Parameters.AddWithValue("@netID", netID);
            cmd.Parameters.AddWithValue("@password", Password);
            //object resultNetID = cmd.ExecuteScalar();
            object netID1 = null;
            object password1 = null;

            using(MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    netID1 = reader.GetString(0);
                    password1 = reader.GetString(1);
                }
            }
            connection.Close();

            if (netID1 != null)
            {
                return netID1.ToString();
            }
            else
            {
                return "Incorrect NetID";
            }
        }
    }
}
