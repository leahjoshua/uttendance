using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//parisa made this
namespace UttendanceDesktop
{
    public partial class AddCourse : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            object CourseName = null;
            object ClassPrefix = null;
            object ClassNumber = null;
            object SectionNumber = null;
            object ClassID = null;
            
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    CourseName = reader.GetString(0);
                    ClassPrefix = reader.GetString(1);
                    ClassNumber = reader.GetString(2);
                    SectionNumber = reader.GetString(3);
                    ClassID = reader.GetString(4);
                }
            }

            MySqlCommand cmd = new MySqlCommand("INSERT INTO class(CourseNum, SectionNum, ClassSubject, ClassNum, ClassName, FK_ImageID) VALUES( ");


        }
    }
}
