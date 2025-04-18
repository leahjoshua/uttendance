using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UttendanceDesktop.CoursepageContent.models;
using UttendanceDesktop.CoursepageContent.QuestionItem;
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

            MySqlCommand cmd = new MySqlCommand("INSERT INTO form (PassWd, ReleaseDateTime, CloseDateTime, FK_CourseNum)" +
                "VALUES (@password, @release, @close, @courseNum)", connection);
            //cmd.Parameters.AddWithValue("@formID", formID);
            cmd.Parameters.AddWithValue("@password", form.PassWd);
            cmd.Parameters.AddWithValue("@release", form.ReleaseDateTime);
            cmd.Parameters.AddWithValue("@close", form.CloseDateTime);
            cmd.Parameters.AddWithValue("@courseNum", form.CourseNum);

            cmd.ExecuteNonQuery();
            connection.Close();

            return formID;
        }

        public void SaveQuestions(List<QuestionItem.QuestionItem> questions, int FormID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            //int answerChoicePK = GenerateNewPK("AnswerID", "answerchoice");
            int questionPK = GenerateNewPK("QuestionID", "question");
            connection.Open();
            MySqlCommand cmd;

            for (int i = 0; i < questions.Count; i++)
            {
                if (!questions[i].IsBankQuestion)
                {
                    cmd = new MySqlCommand("INSERT INTO question (QuestionID, ProblemStatement)" +
                    "VALUES (@questionID, @problemStmt)", connection);
                    cmd.Parameters.AddWithValue("@questionID", questionPK);
                    cmd.Parameters.AddWithValue("@problemStmt", questions[i].QuestionValue);
                    //cmd.Parameters.AddWithValue("@formID", FormID);
                    cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand("INSERT INTO has (FK_FormID, FK_QuestionID)" +
                        "VALUES (@formID, @questionID)", connection);
                    cmd.Parameters.AddWithValue("@formID", FormID);
                    cmd.Parameters.AddWithValue("@questionID", questionPK);
                    cmd.ExecuteNonQuery();

                    for (int j = 0; j < questions[i].AnswerList.Length; j++)
                    {
                        cmd = new MySqlCommand("INSERT INTO answerchoice (AnswerStatement, IsCorrect, FK_QuestionID)" +
                            "VALUES (@answerStmt, @isCorrect, @questionID)", connection);
                        //cmd.Parameters.AddWithValue("@answerID", answerChoicePK);
                        cmd.Parameters.AddWithValue("@answerStmt", questions[i].AnswerList[j].AnswerValue);
                        cmd.Parameters.AddWithValue("@isCorrect", questions[i].AnswerList[j].IsCorrect);
                        cmd.Parameters.AddWithValue("@questionID", questionPK);

                        cmd.ExecuteNonQuery();
                        //answerChoicePK++;
                    }
                    questionPK++;
                }
                else
                {
                    try
                    {
                        cmd = new MySqlCommand("INSERT INTO has (FK_FormID, FK_QuestionID) " +
                        "VALUES (@formID, @questionID)", connection);
                        cmd.Parameters.AddWithValue("@formID", FormID);
                        cmd.Parameters.AddWithValue("@questionID", questions[i].QuestionID);
                        int rows = cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        System.Diagnostics.Debug.WriteLine("ERROR: FormDAO.cs/SaveQuestions()");
                    }
                }
                
            }
            connection.Close();
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

        // 4/14/2025 Aendri 
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

        // 4/16/2025 Aendri
        // Returns a list of Questions (as QuestionItems) for the given attendance form
        public QuestionItem.QuestionItem[] GetFormQuestionList(int formID)
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
                    "FROM question, has " +
                    "WHERE FK_FormID=@FormID " +
                    "AND FK_QuestionID = QuestionID "
                    , connection);
                cmd.Parameters.AddWithValue("@FormID", formID);
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
                System.Diagnostics.Debug.WriteLine("ERROR: FormDAO/GetFormQuestionList: " + ex.ToString());
            }
            connection.Close();
            return questionItemList.ToArray();
        }

        // 4/14/2025 Aendri 
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

        // 4/16/2025 Aendri 
        // Returns detailed information on the given attendance form 
        public AttendanceForm GetFormData(int formID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            MySqlDataReader reader;

            AttendanceForm formData = new AttendanceForm();
            formData.FormID = formID;

            // Return if invalid form id
            if (formID < 0)
            {
                formData.FormID = -1;
                return formData;
            }

            try
            {
                connection.Open();

                // Form Data:
                cmd = new MySqlCommand(
                    "SELECT PassWd, ReleaseDateTime, CloseDateTime " +
                    "FROM form " +
                    "WHERE FormID=@FormID "
                    , connection);
                cmd.Parameters.AddWithValue("@FormID", formID);
                reader = cmd.ExecuteReader();
                reader.Read();

                // Check if any results found, return with error if not found
                if (!reader.HasRows)
                {
                    formData.FormID = -1;
                    connection.Close();
                    return formData;
                }

                formData.PassWd = reader[0].ToString();
                formData.ReleaseDateTime = Convert.ToDateTime(reader[1]);
                formData.CloseDateTime = Convert.ToDateTime(reader[2]);
                reader.Close();

                // Submission Data:
                cmd = new MySqlCommand(
                    "SELECT COUNT(DISTINCT FK_UTDID) " +
                    "FROM submission " +
                    "WHERE FK_FormID=@FormID "
                    , connection);
                cmd.Parameters.AddWithValue("@FormID", formID);
                reader = cmd.ExecuteReader();
                reader.Read();

                formData.TotalSubmissions = Convert.ToInt32(reader[0]);
                reader.Close();

                // Student Data:
                cmd = new MySqlCommand(
                    "SELECT COUNT(DISTINCT FK_UTDID) " +
                    "FROM attends " +
                    "WHERE FK_CourseNum=@CourseNum "
                    , connection);
                cmd.Parameters.AddWithValue("@CourseNum", GlobalResource.CURRENT_CLASS_ID);
                reader = cmd.ExecuteReader();
                reader.Read();

                formData.TotalStudents = Convert.ToInt32(reader[0]);
                reader.Close();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: FormDAO/GetFormItem: " + ex.ToString());
                formData.FormID = -1;
            }
            connection.Close();

            return formData;
        }
        // Lee
        // 4/18/2025
        // This function doesn't assign QuestionNumbers
        public List<QuestionItem.QuestionItem> SelectQuestions(List<int> IDs)
        {
            List<QuestionItem.QuestionItem> questionItemList = new List<QuestionItem.QuestionItem>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            MySqlDataReader reader;

            try
            {
                for (int i = 0; i < IDs.Count; i++)
                {
                    cmd = new MySqlCommand(
                    "SELECT QuestionID, ProblemStatement " +
                    "FROM question" +
                    "WHERE QuestionID=@QuestionID"
                    , connection);
                    cmd.Parameters.AddWithValue("@QuestionID", IDs[i]);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        QuestionItem.QuestionItem currItem = new QuestionItem.QuestionItem();
                        currItem.QuestionID = Convert.ToInt32(reader[0]);
                        if (reader[1] != null) { currItem.QuestionValue = reader[1].ToString(); }
                        else { currItem.QuestionValue = ""; }
                        currItem.AnswerList = GetQuestionAnswerList(currItem.QuestionID);
                        questionItemList.Add(currItem);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: FormDAO.cs/SelectQuestions: " + ex.ToString());
            }
            return questionItemList;
        }
    }
}
