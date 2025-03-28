using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
//parisa
namespace UttendanceDesktop
{
    internal class Class
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=kachowmeow;database=uttendance";

        public string AddClass(string name, string prefix, int number, int section, int classId)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO class 
                                   (CourseNum, SectionNum, ClassSubject, ClassNum, ClassName) 
                                   VALUES (@classId, @section, @prefix, @number, @name);
                                   SELECT LAST_INSERT_ID();";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@prefix", prefix);
                        cmd.Parameters.AddWithValue("@number", number);
                        cmd.Parameters.AddWithValue("@section", section);
                        cmd.Parameters.AddWithValue("@classId", classId);

                        object result = cmd.ExecuteScalar();
                        return $"Course added successfully!";
                    }
                }
            }
            catch (MySqlException ex)
            {
                return $"Database error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Unexpected error: {ex.Message}";
            }
        }
    }
}
