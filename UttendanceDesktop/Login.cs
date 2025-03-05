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
        string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";

        // leah wrote this
        public String login(String netID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT INetID FROM instructor WHERE INetID=@netID", connection);
            cmd.Parameters.AddWithValue("@netID", netID);
            object resultNetID = cmd.ExecuteScalar();
            connection.Close();

            if (resultNetID != null)
            {
                return resultNetID.ToString();
            }
            else
            {
                return "Incorrect NetID";
            }
        }
    }
}
