using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UttendanceDesktop.CoursepageContent.CreateAttendanceForm
{
    class FormDAO
    {
        private string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";

        public int GenerateNewPK()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return 0;
        }
    }
}
