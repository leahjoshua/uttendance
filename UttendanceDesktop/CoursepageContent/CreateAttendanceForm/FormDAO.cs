/******************************************************************************
* FormDAO for the UttendanceDesktop application.
* 
* This is a Data Access Object which interacts with the form, question, and
* answerchoice table. It performs operations such as adding forms and questions,
* selecting them, etc.
*
* Written by Leah Joshua (lej210003) 
* and Aendri Singh (axs210369) 
* for CS4485.0W1 at The University of Texas at Dallas
* starting April 3, 2025.
******************************************************************************/

using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
        private string connectionString = GlobalResource.CONNECTION_STRING;

        /**************************************************************************
        * Finds the maximum primary key value in the table given by the parameters
        * and returns +1, to use as a new PK for rows being added.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        private int GenerateNewPK(string PK, string tableName)
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

        /**************************************************************************
        * Saves a form to the form table.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        public int SaveForm(AttendanceForm form)
        {
            int formID = GenerateNewPK("FormID", "form");

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO form (FormID, PassWd, ReleaseDateTime, CloseDateTime, FK_CourseNum) " +
                "VALUES (@formID, @password, @release, @close, @courseNum) ", connection);
            cmd.Parameters.AddWithValue("@formID", formID);
            cmd.Parameters.AddWithValue("@password", form.PassWd);
            cmd.Parameters.AddWithValue("@release", form.ReleaseDateTime);
            cmd.Parameters.AddWithValue("@close", form.CloseDateTime);
            cmd.Parameters.AddWithValue("@courseNum", form.CourseNum);

            cmd.ExecuteNonQuery();
            connection.Close();

            return formID;
        }

        /**************************************************************************
        * Saves questions and their answer choices to the question and 
        * answerchoice tables respectively. Uses the has table to represent their
        * relationship.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        public void SaveQuestions(List<QuestionItem.QuestionItem> questions, int FormID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            int questionPK = GenerateNewPK("QuestionID", "question");
            connection.Open();
            MySqlCommand cmd;

            // inserts each question in the list
            for (int i = 0; i < questions.Count; i++)
            {
                // only inserts a new row if the question isn't part of a question bank
                if (!questions[i].IsBankQuestion)
                {
                    cmd = new MySqlCommand("INSERT INTO question (QuestionID, ProblemStatement)" +
                    "VALUES (@questionID, @problemStmt)", connection);
                    cmd.Parameters.AddWithValue("@questionID", questionPK);
                    cmd.Parameters.AddWithValue("@problemStmt", questions[i].QuestionValue);
                    cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand("INSERT INTO has (FK_FormID, FK_QuestionID)" +
                        "VALUES (@formID, @questionID)", connection);
                    cmd.Parameters.AddWithValue("@formID", FormID);
                    cmd.Parameters.AddWithValue("@questionID", questionPK);
                    cmd.ExecuteNonQuery();

                    // adds answerchoices for each question, using the current question PK for the FK
                    for (int j = 0; j < questions[i].AnswerList.Length; j++)
                    {
                        cmd = new MySqlCommand("INSERT INTO answerchoice (AnswerStatement, IsCorrect, FK_QuestionID)" +
                            "VALUES (@answerStmt, @isCorrect, @questionID)", connection);
                        cmd.Parameters.AddWithValue("@answerStmt", questions[i].AnswerList[j].AnswerValue);
                        cmd.Parameters.AddWithValue("@isCorrect", questions[i].AnswerList[j].IsCorrect);
                        cmd.Parameters.AddWithValue("@questionID", questionPK);

                        cmd.ExecuteNonQuery();
                    }
                    questionPK++;
                }
                // question bank questions are linked to a form via the has table
                else
                {
                    try
                    {
                        cmd = new MySqlCommand("INSERT INTO has (FK_FormID, FK_QuestionID) " +
                        "VALUES (@formID, @questionID)", connection);
                        cmd.Parameters.AddWithValue("@formID", FormID);
                        cmd.Parameters.AddWithValue("@questionID", questions[i].QuestionID);
                        int rows = cmd.ExecuteNonQuery();
                        //Console.WriteLine();
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
                cmd.Parameters.AddWithValue("@INetId", GlobalResource.INetID);
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
        // Deletes the given question bank items
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

        // Aendri 4/25/2025
        // Deletes the given question and its answer choices
        public bool DeleteQuestionFromBank(Question questionData)
        {
            // Open Connection to Database
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            String query;


            try
            {
                connection.Open();

                // Check if question is already in use
                query =
                    "SELECT * " +
                    "FROM has " +
                    "WHERE FK_QuestionID = @QuestionID ";
                // Run query
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@QuestionID", questionData.QuestionID);
                int result = cmd.ExecuteNonQuery();

                // QUESTION IN USE
                if (result > 0)
                {
                    // Remove question bank foreign keys
                    query =
                        "UPDATE question " +
                        "SET FK_BankID = NULL " +
                        "WHERE QuestionID = @QuestionID ";
                    // Run query
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@QuestionID", questionData.QuestionID);
                    result = cmd.ExecuteNonQuery();
                }
                // QUESTION UNUSED
                else
                {
                    // Delete Answers
                    query =
                        "DELETE " +
                        "FROM answerchoice " +
                        "WHERE AnswerID IN (";

                    for (int i = 0; i < questionData.AnswerChoices.Count; i++)
                    {
                        query += questionData.AnswerChoices[i].AnswerID + ",";
                    }

                    query = query.Substring(0, query.Length - 1);
                    query += ")";
                    // Run query
                    cmd = new MySqlCommand(query, connection);
                    result = cmd.ExecuteNonQuery();

                    // Delete Question
                    query =
                        "DELETE " +
                        "FROM question " +
                        "WHERE QuestionID = " + questionData.QuestionID;
                    // Run query
                    cmd = new MySqlCommand(query, connection);
                    result = cmd.ExecuteNonQuery();
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

        // Aendri 4/25/2025
        // Deletes the given question and its answer choices
        public bool DeleteQuestionFromForm(Question questionData, int formID)
        {
            // Open Connection to Database
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            String query;

            try
            {
                connection.Open();

                // Remove question bank foreign keys
                query =
                    "DELETE " +
                    "FROM has " +
                    "WHERE FK_QuestionID = @QuestionID " +
                    "AND FK_FormID = @FormID";
                // Run query
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@QuestionID", questionData.QuestionID);
                cmd.Parameters.AddWithValue("@FormID", formID);
                int result = cmd.ExecuteNonQuery();

                // Check if question is used by other forms
                query =
                    "SELECT * " +
                    "FROM has " +
                    "WHERE FK_QuestionID = @QuestionID ";
                // Run query
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@QuestionID", questionData.QuestionID);
                cmd.Parameters.AddWithValue("@FormID", formID);
                result = cmd.ExecuteNonQuery();

                // QUESTION NOT IN USE, remove question
                if (result == 0)
                {
                    // Delete Answers
                    query =
                        "DELETE " +
                        "FROM answerchoice " +
                        "WHERE AnswerID IN (";

                    for (int i = 0; i < questionData.AnswerChoices.Count; i++)
                    {
                        query += questionData.AnswerChoices[i].AnswerID + ",";
                    }

                    query = query.Substring(0, query.Length - 1);
                    query += ")";
                    // Run query
                    cmd = new MySqlCommand(query, connection);
                    result = cmd.ExecuteNonQuery();

                    // Delete Question
                    query =
                        "DELETE " +
                        "FROM question " +
                        "WHERE QuestionID = " + questionData.QuestionID;
                    // Run query
                    cmd = new MySqlCommand(query, connection);
                    result = cmd.ExecuteNonQuery();
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
                // Get release time
                cmd = new MySqlCommand(
                    "SELECT ReleaseDateTime " +
                    "FROM form " +
                    "WHERE FormID=@FormID "
                    , connection);
                cmd.Parameters.AddWithValue("@FormID", formID);
                reader = cmd.ExecuteReader();
                reader.Read();

                DateTime releaseTime = Convert.ToDateTime(reader[0]);
                bool isReleased = releaseTime <= DateTime.Now;

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

                int totalSubmissions = Convert.ToInt32(reader[0]);
                reader.Close();


                // Get a list of all questions associated with the bank
                cmd = new MySqlCommand(
                    "SELECT QuestionID, ProblemStatement, FK_BankID " +
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
                    currItem.QuestionID = Convert.ToInt32(reader[0]); // Question ID

                    // Problem Statement
                    if (reader[1] != null) { currItem.QuestionValue = reader[1].ToString(); }
                    else { currItem.QuestionValue = ""; }

                    // Is Bank Question?
                    if (reader[2] != null)
                    {
                        currItem.IsBankQuestion = !DBNull.Value.Equals(reader[2]);
                        currItem.IsEditable = DBNull.Value.Equals(reader[2]); //Bank questions can't be edited
                    }

                    // Answer choices
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

            try { 
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
                        // prevents error if the question value is null
                        if (reader[1] != null) { currItem.QuestionValue = reader[1].ToString(); }
                        else { currItem.QuestionValue = ""; }
                        // pulling answers for the QuestionItem
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

        // 4/18/2025 Aendri
        // Create a new question and save to a question bank
        public void CreateNewQuestion(Question questionData, int bankID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            MySqlDataReader reader;

            int questionID;

            try
            {
                connection.Open();

                // Add question and get QuestionID
                cmd = new MySqlCommand(
                    "INSERT INTO question (ProblemStatement, FK_BankID)" +
                    "VALUES (@Problem, @FK_BankID);" +
                    "SELECT LAST_INSERT_ID();"
                    , connection);
                cmd.Parameters.AddWithValue("@Problem", questionData.ProblemStatement);
                cmd.Parameters.AddWithValue("@FK_BankID", bankID);

                reader = cmd.ExecuteReader();
                reader.Read();

                questionID = Convert.ToInt32(reader[0]);

                reader.Close();

                // Add answer choices 
                for (int j = 0; j < questionData.AnswerChoices.Count; j++)
                {
                    cmd = new MySqlCommand(
                        "INSERT INTO answerchoice (AnswerStatement, IsCorrect, FK_QuestionID) " +
                        "VALUES (@answerStmt, @isCorrect, @questionID)",
                        connection);
                    cmd.Parameters.AddWithValue("@answerStmt", questionData.AnswerChoices[j].AnswerStatement);
                    cmd.Parameters.AddWithValue("@isCorrect", questionData.AnswerChoices[j].isCorrect);
                    cmd.Parameters.AddWithValue("@questionID", questionID);

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: FormDAO/CreateNewQuestion: " + ex.ToString());
            }
            connection.Close();
        }

        // 4/18/2025 Aendri
        // Create a new attendance bank, return the new BankID
        public int CreateNewBank(String bankTitle)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            MySqlDataReader reader;

            int bankID = -1;

            try
            {
                connection.Open();

                // Look for any question bank entries with the same title
                cmd = new MySqlCommand(
                    "INSERT INTO qbank (BankTitle, FK_INetID)" +
                    "VALUES (@BankTitle, @FK_INetID);" +
                    "SELECT LAST_INSERT_ID();"
                    , connection);
                cmd.Parameters.AddWithValue("@BankTitle", bankTitle);
                cmd.Parameters.AddWithValue("@FK_INetID", GlobalResource.INetID);

                reader = cmd.ExecuteReader();
                reader.Read();

                bankID = Convert.ToInt32(reader[0]);

                reader.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: FormDAO/CreateNewBank: " + ex.ToString());
            }
            connection.Close();

            return bankID;

        }

        /**************************************************************************
        * Updates the date and password of an existing form.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        public int UpdateForm(DateTime releaseTime, DateTime closeTime, string password, int id)
        {
            int rowsAffected = -1;

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;

            try
            {
                connection.Open();

                // Set close and release times and password of form
                cmd = new MySqlCommand(
                    "UPDATE form " +
                    "SET ReleaseDateTime = @releaseTime, " +
                        "CloseDateTime = @closeTime, " +
                        "PassWd = @pwd " +
                    "WHERE FormID = @formID;"
                    , connection);
                cmd.Parameters.AddWithValue("@releaseTime", releaseTime);
                cmd.Parameters.AddWithValue("@closeTime", closeTime);
                cmd.Parameters.AddWithValue("@pwd", password);
                cmd.Parameters.AddWithValue("@formID", id);

                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: FormDAO/UpdateForm: " + ex.ToString());
            }
            connection.Close();

            return rowsAffected;
        }

        /**************************************************************************
        * Gets the start and end time of a specific class.
        * 
        * Written by Leah Joshua.
        **************************************************************************/
        public List<TimeSpan> GetTimes(int classID)
        {
            List<TimeSpan> times = new List<TimeSpan>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;
            MySqlDataReader reader;

            try
            {
                connection.Open();

                // selecting times of a specific class
                cmd = new MySqlCommand(
                    "SELECT ClassStartTime, ClassEndTime " +
                    "FROM class " +
                    "WHERE CourseNum=@courseID "
                    , connection);
                cmd.Parameters.AddWithValue("@courseID", classID);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    times.Add(reader.GetTimeSpan(0));
                    times.Add(reader.GetTimeSpan(1));
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: FormDAO/GetTimes: " + ex.ToString());
            }
            connection.Close();

            return times;
        }

        // 4/18/2025 Aendri
        // Updates the given attendance bank with the given title
        public void UpdateBank(int bankID, String bankTitle)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;

            try
            {
                connection.Open();

                // Look for any question bank entries with the same title
                cmd = new MySqlCommand(
                    "UPDATE qbank " +
                    "SET BankTitle = @BankTitle " +
                    "WHERE BankID = @BankID"
                    , connection);
                cmd.Parameters.AddWithValue("@BankTitle", bankTitle);
                cmd.Parameters.AddWithValue("@BankID", bankID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: FormDAO/UpdateBank: " + ex.ToString());
            }
            connection.Close();

        }

        // 4/25/2025 Aendri
        // Updates the given question and answer choices in the database
        // Adds and removes answer choices as necessary
        public void UpdateQuestion(Question questionData)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd;

            try
            {
                connection.Open();

                // Update question statement
                cmd = new MySqlCommand(
                    "UPDATE question " +
                    "SET ProblemStatement = @ProblemStatement " +
                    "WHERE QuestionID = @QuestionID"
                    , connection);
                cmd.Parameters.AddWithValue("@ProblemStatement", questionData.ProblemStatement);
                cmd.Parameters.AddWithValue("@QuestionID", questionData.QuestionID);
                cmd.ExecuteNonQuery();

                // Update answer choices
                for (int i = 0; i < questionData.AnswerChoices.Count; i++)
                {
                    // Answer exists
                    if (questionData.AnswerChoices[i].AnswerID >= 0)
                    {
                        // Update answer statement:
                        // If empty, delete answer
                        if (string.IsNullOrWhiteSpace(questionData.AnswerChoices[i].AnswerStatement))
                        {
                            cmd = new MySqlCommand(
                               "DELETE " +
                               "FROM answerchoice " +
                               "WHERE AnswerID = @AnswerID"
                               , connection);
                            cmd.Parameters.AddWithValue("@AnswerID", questionData.AnswerChoices[i].AnswerID);
                        }
                        // Otherwse, update
                        else
                        {
                            cmd = new MySqlCommand(
                                "UPDATE answerchoice " +
                                "SET AnswerStatement = @AnswerStatement, IsCorrect = @IsCorrect " +
                                "WHERE AnswerID = @AnswerID"
                                , connection);
                            cmd.Parameters.AddWithValue("@AnswerStatement", questionData.AnswerChoices[i].AnswerStatement);
                            cmd.Parameters.AddWithValue("@AnswerID", questionData.AnswerChoices[i].AnswerID);
                            cmd.Parameters.AddWithValue("@IsCorrect", questionData.AnswerChoices[i].isCorrect);
                        }
                        cmd.ExecuteNonQuery();
                    }
                    // New Answer (non empty)
                    else if (!string.IsNullOrWhiteSpace(questionData.AnswerChoices[i].AnswerStatement))
                    {
                        cmd = new MySqlCommand(
                            "INSERT INTO answerchoice (AnswerStatement, IsCorrect, FK_QuestionID)" +
                            "VALUES (@answerStmt, @isCorrect, @questionID)", connection);

                        cmd.Parameters.AddWithValue("@answerStmt", questionData.AnswerChoices[i].AnswerStatement);
                        cmd.Parameters.AddWithValue("@isCorrect", questionData.AnswerChoices[i].isCorrect);
                        cmd.Parameters.AddWithValue("@questionID", questionData.QuestionID);
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: FormDAO/UpdateBank: " + ex.ToString());
            }
            connection.Close();
        }
    }
}