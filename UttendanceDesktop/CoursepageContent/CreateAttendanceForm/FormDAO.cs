using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UttendanceDesktop.CoursepageContent.models;

namespace UttendanceDesktop.CoursepageContent.CreateAttendanceForm
{
    class FormDAO
    {
        private string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";

        public int GenerateNewPK(string PK, string tableName)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT MAX(@pk) FROM @tableName", connection);
            cmd.Parameters.AddWithValue("@pk", PK);
            cmd.Parameters.AddWithValue("@tableName", tableName);

            object result = cmd.ExecuteScalar();
            connection.Close();

            int newPK = 0;
            if (result != null)
            {
                newPK = Convert.ToInt32(result) + 1;
            }

            return newPK;
        }

        public int SaveForm(AttendanceForm form)
        {
            int formID = GenerateNewPK("FormID", "form");

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO form (FormID, PassWd, ReleaseDateTime, CloseDateTime, FK_CourseNum)" +
                "VALUES (@formID, @password, @release, @close, @courseNum)", connection);
            cmd.Parameters.AddWithValue("@formID", formID);
            cmd.Parameters.AddWithValue("@password", formID);
            object result = cmd.ExecuteScalar();

            return 0;
        }
    }
}
