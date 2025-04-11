using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            string query = $"SELECT MAX({PK}) FROM `{tableName}`";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            object result = cmd.ExecuteScalar();
            connection.Close();


            int newPK = 1;
            if (result != DBNull.Value)
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
            cmd.Parameters.AddWithValue("@password", form.PassWd);
            cmd.Parameters.AddWithValue("@release", form.ReleaseDateTime);
            cmd.Parameters.AddWithValue("@close", form.CloseDateTime);
            cmd.Parameters.AddWithValue("@courseNum", form.CourseNum);

            cmd.ExecuteNonQuery();
            connection.Close();

            return formID;
        }

        public void SaveQuestions(List<Question> questions, int FormID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            int answerChoicePK = GenerateNewPK("AnswerID", "answerchoice");
            int questionPK = GenerateNewPK("QuestionID", "question");
            connection.Open();
            MySqlCommand cmd;

            for (int i = 0; i < questions.Count; i++)
            {
                cmd = new MySqlCommand("INSERT INTO question (QuestionID, ProblemStatement, FK_FormID)" +
                    "VALUES (@questionID, @problemStmt, @formID)", connection);
                cmd.Parameters.AddWithValue("@questionID", questionPK);
                cmd.Parameters.AddWithValue("@problemStmt", questions[i].ProblemStatement);
                cmd.Parameters.AddWithValue("@formID", FormID);
                cmd.ExecuteNonQuery();

                for (int j = 0; j < questions[i].AnswerChoices.Count; j++)
                {
                    cmd = new MySqlCommand("INSERT INTO answerchoice (AnswerID, AnswerStatement, IsCorrect, FK_QuestionID)" +
                        "VALUES (@answerID, @answerStmt, @isCorrect, @questionID)", connection);
                    cmd.Parameters.AddWithValue("@answerID", answerChoicePK);
                    cmd.Parameters.AddWithValue("@answerStmt", questions[i].AnswerChoices[j].AnswerStatement);
                    cmd.Parameters.AddWithValue("@isCorrect", questions[i].AnswerChoices[j].isCorrect);
                    cmd.Parameters.AddWithValue("@questionID", questionPK);

                    cmd.ExecuteNonQuery();
                    answerChoicePK++;
                }
                questionPK++;
            }
        }
    }
}
