using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UttendanceDesktop.CoursepageContent.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
                cmd = new MySqlCommand("INSERT INTO question (QuestionID, ProblemStatement)" +
                    "VALUES (@questionID, @problemStmt)", connection);
                cmd.Parameters.AddWithValue("@questionID", questionPK);
                cmd.Parameters.AddWithValue("@problemStmt", questions[i].ProblemStatement);
                //cmd.Parameters.AddWithValue("@formID", FormID);
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("INSERT INTO has (FK_QuizID, FK_QuestionID)" +
                    "VALUES (@formID, @questionID)", connection);
                cmd.Parameters.AddWithValue("@formID", FormID);
                cmd.Parameters.AddWithValue("@questionID", questionPK);
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

        // Aendri 4/4/2025 (Updated 4/15/2025)
        // Returns a list of question bank list items
        public QuestionBankItem[] GetBankList()
        {
            // Open Connection to Database
            MySqlConnection connection = new MySqlConnection(GlobalResource.CONNECTION_STRING);
            MySqlCommand cmd;
            MySqlDataReader reader;
            List<QuestionBankItem> bankQuestionList = new List<QuestionBankItem>();

            try
            {
                connection.Open();

                // Get a list of all question banks associated with this course
                // along with their id, title, and question count
                cmd = new MySqlCommand(
                    "SELECT BankID, BankTitle, COUNT(QuestionID) " +
                    "FROM qbank left join question ON qbank.BankID = question.FK_BankID " +
                    "WHERE FK_INetID = @INetId " +
                    "GROUP BY BankID "
                    , connection);
                cmd.Parameters.AddWithValue("@INetId", GlobalResource.INETID);
                reader = cmd.ExecuteReader();

                // Process results
                int i = 0;
                while (reader.Read())
                {
                    QuestionBankItem currItem = new QuestionBankItem();

                    currItem.BankID = Convert.ToInt32(reader[0]);

                    if (reader[1] != null) { currItem.Title = reader[1].ToString(); }
                    else { currItem.Title = ""; }

                    currItem.Count = Convert.ToInt32(reader[2]);

                    bankQuestionList.Add(currItem);
                    i++;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(
                    "ERROR: AttendanceForms_QuestionBank.cs/PopulateBankList() : " + ex.ToString());
            }

            connection.Close();
            return bankQuestionList.ToArray();
        }

        // Aendri 4/4/2025 (Update 4/15/2025)
        // Deletes the selected items by updating the database and repopulating the list 
        public bool DeleteBankItems(QuestionBankItem[] bankListItems, int numItemsToDelete)
        {
            // If no items to delete, exit
            if (numItemsToDelete == 0) { return false; }

            // Open Connection to Database
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            DialogResult warnResult;

            try
            {
                connection.Open();

                // Build deleted items query:
                String deleteQuery =
                    "DELETE " +
                    "FROM qbank " +
                    "WHERE BankID IN (";

                // Build warning message
                String dialog = "Removing " + numItemsToDelete + " question banks(s):\n";

                for (int j = 0; j < bankListItems.Length; j++)
                {
                    if (bankListItems[j].Selected)
                    {
                        deleteQuery += bankListItems[j].BankID + ",";
                        dialog += bankListItems[j].Title + ", ";
                    }
                }
                //Remove last comma:
                deleteQuery = deleteQuery.Substring(0, deleteQuery.Length - 1);
                deleteQuery += ")";

                dialog = dialog.Substring(0, dialog.Length - 2);
                dialog += "\nAll associated questions will be deleted!";

                // Prompt user to verify deletion
                warnResult = MessageBox.Show(dialog, "Remove Question Bank(s)", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (warnResult != DialogResult.OK)
                {
                    return false;
                } // EXIT if user cancels!

                // Run deletion query
                cmd = new MySqlCommand(deleteQuery, connection);
                int result = cmd.ExecuteNonQuery();

                // Error check:
                if (result <= 0)
                {
                    System.Diagnostics.Debug.WriteLine("ERROR: AttendanceForms_Listings.cs/DeleteItems(): NOTHING DELETED!");
                    return false;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("DELETED THINGS!!!!");
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(
                    "ERROR: AttendanceForms_QuestionBank.cs/DeleteItems(): " + ex.ToString());
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        // 4/14/2025
        // Returns a list of Questions (as QuestionItems) for the given question bank
        public QuestionItem.QuestionItem[] GetBankQuestionList(int bankID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            MySqlDataReader reader;

            List<QuestionItem.QuestionItem> questionItemList = new List<QuestionItem.QuestionItem>();

            try
            {
                connection.Open();

                // Get a list of all questions associated with the bank
                cmd = new MySqlCommand(
                    "SELECT QuestionID, ProblemStatement " +
                    "FROM question " +
                    "WHERE FK_BankID=@BankID "
                    , connection);
                cmd.Parameters.AddWithValue("@BankID", bankID);
                reader = cmd.ExecuteReader();

                // Get Answers for each question
                int i = 0;

                while (reader.Read())
                {
                    QuestionItem.QuestionItem currItem = new QuestionItem.QuestionItem();

                    currItem.QuestionNumber = i + 1;
                    currItem.QuestionID = Convert.ToInt32(reader[0]);

                    if (reader[1] != null) { currItem.QuestionValue = reader[1].ToString(); }
                    else { currItem.QuestionValue = ""; }

                    currItem.AnswerList = GetQuestionAnswerList(currItem.QuestionID);

                    questionItemList.Add(currItem);
                    i++;
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: FormDAO/GetBankQuestionList: " + ex.ToString());
            }
            connection.Close();
            return questionItemList.ToArray();
        }

        // 4/14/2025
        // Returns a list of answers (as QuestionAnswerItems) for the given question
        public QuestionItem.QuestionAnswerItem[] GetQuestionAnswerList(int questionID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            MySqlDataReader reader;

            List<QuestionItem.QuestionAnswerItem> questionItemList = new List<QuestionItem.QuestionAnswerItem>();

            try
            {
                connection.Open();

                // Get a list of all answer choices associated with the bank
                cmd = new MySqlCommand(
                    "SELECT AnswerID, AnswerStatement, IsCorrect " +
                    "FROM answerchoice " +
                    "WHERE FK_QuestionID=@FK_QuestionID "
                    , connection);
                cmd.Parameters.AddWithValue("@FK_QuestionID", questionID);
                reader = cmd.ExecuteReader();

                // Get Answers for each question
                int i = 0;
                while (reader.Read())
                {
                    QuestionItem.QuestionAnswerItem currItem = new QuestionItem.QuestionAnswerItem();

                    // Answer ID
                    currItem.AnswerID = Convert.ToInt32(reader[0]);
                    // Answer Statement
                    if (reader[1] != null) { currItem.AnswerValue = reader[1].ToString(); }
                    else { currItem.AnswerValue = ""; }
                    // Is Correct
                    currItem.IsCorrect = (Convert.ToInt32(reader[2]) == 1);
                    // Answer Choice Letter (increment from A)
                    currItem.ChoiceLetter = (Char)(Convert.ToUInt16('A') + i);

                    questionItemList.Add(currItem);
                    i++;
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: FormDAO/GetQuestionAnswerList: " + ex.ToString());
            }
            connection.Close();

            return questionItemList.ToArray();
        }
    }
}
