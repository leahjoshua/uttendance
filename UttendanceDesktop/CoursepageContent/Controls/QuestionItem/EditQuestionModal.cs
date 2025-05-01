using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UttendanceDesktop.CoursepageContent.CreateAttendanceForm;
using UttendanceDesktop.CoursepageContent.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UttendanceDesktop.CoursepageContent.Controls.QuestionItem
{
    public partial class EditQuestionModal : Form
    {
        private Question questionData;
        private int formID;
        private bool isFormQuestion = false;

        private FormDAO DB = new FormDAO();

        // Answer choice data
        private System.Windows.Forms.TextBox[] answerStatmentList;
        private RadioButton[] answerSelectList;
        private int[] answerIDList;

        private const int QUESTION_STATEMENT_MAX_SIZE = 200;
        private const int ANSWER_STATEMENT_MAX_SIZE = 50;
        private const int ANSWER_MIN_COUNT = 2;

        public EditQuestionModal(Question data)
        {
            InitializeComponent();
            questionData = data;

            // Initialize Answer Choice Arrays:
            answerStatmentList = new[] { choiceATextbox, choiceBTextbox, choiceCTextbox, choiceDTextbox };
            answerSelectList = new[] { correctABtn, correctBBtn, correctCBtn, correctDBtn };
            answerIDList = new int[answerStatmentList.Length];
            Array.Fill(answerIDList, -1); //Set IDs to -1

            FillQuestionData();
        }

        // Constructor for attendance form questions
        public EditQuestionModal(Question data, int formID)
        {
            InitializeComponent();
            questionData = data;
            this.formID = formID;
            isFormQuestion = true;

            // Initialize Answer Choice Arrays:
            answerStatmentList = new[] { choiceATextbox, choiceBTextbox, choiceCTextbox, choiceDTextbox };
            answerSelectList = new[] { correctABtn, correctBBtn, correctCBtn, correctDBtn };
            answerIDList = new int[answerStatmentList.Length];
            Array.Fill(answerIDList, -1); //Set IDs to -1

            FillQuestionData();
        }

        // Aendri 4/25/2025
        // Updates the modal to display the question data
        private void FillQuestionData()
        {
            problemStmtTextbox.Text = questionData.ProblemStatement;

            // Answer Choices:
            for (int i = 0; i < questionData.AnswerChoices.Count; i++)
            {
                answerIDList[i] = questionData.AnswerChoices[i].AnswerID;
                answerStatmentList[i].Text = questionData.AnswerChoices[i].AnswerStatement;
                answerSelectList[i].Checked = questionData.AnswerChoices[i].isCorrect;
            }
        }

        // Aendri 4/25/2025
        // Updates the modal to display the question data
        // Returns true if successful, false otherwise
        private bool UpdateQuestionData()
        {
            List<AnswerChoice> answerChoiceList = new List<AnswerChoice>();

            // Answer Choices:
            for (int i = 0; i < answerStatmentList.Length; i++)
            {
                //If answer choice is NOT valid, return
                if (!VerifyAnswerChoice(i)){
                    return false;
                } 

                //Add Answer
                answerChoiceList.Add(new AnswerChoice
                    {
                        AnswerID = answerIDList[i],
                        isCorrect = answerSelectList[i].Checked,
                        AnswerStatement = answerStatmentList[i].Text
                    });
            }

            // Question statement:
            bool isQuestionValid = VerifyQuestion(problemStmtTextbox.Text);
            bool isAnswerListValid = (answerChoiceList.Count >= ANSWER_MIN_COUNT);


            if (!isAnswerListValid)
            {
                MessageBox.Show("Must have at least " + ANSWER_MIN_COUNT + " answers!", "Invalid Answer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!isQuestionValid) { return false; }
            // Question and Answers are Valid!!
            else {
                questionData.ProblemStatement = problemStmtTextbox.Text;
                questionData.AnswerChoices = answerChoiceList;
                return true;
            }

        }

        // Aendri 4/25/2025
        // Returns true if the given answer choice is valid, otherwise displays error messages and returns false
        private bool VerifyAnswerChoice(int i)
        {
            char choice = (char)(65 + i); //Convert to ASCII letter

            // Null or white space check
            if (string.IsNullOrWhiteSpace(answerStatmentList[i].Text))
            {
                // If answer choice is empty but checked, error
                if (answerSelectList[i].Checked)
                {
                    MessageBox.Show("Answer " + choice + " cannot be empty and selected!", "Invalid Answer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else {  return true;  }
                
            }
            // Answer is too large check
            if (answerStatmentList[i].Text.Length > ANSWER_STATEMENT_MAX_SIZE)
            {
                MessageBox.Show("Answer " + choice + " is too large! Max is " + ANSWER_STATEMENT_MAX_SIZE, "Invalid Answer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Duplicate answers check
            for (int j = 0; j < answerStatmentList.Length; j++)
            {
                if (answerStatmentList[j].Text.Equals(answerStatmentList[i].Text) && j != i)
                {
                    MessageBox.Show("Answer " + choice + " is a duplicate of " + (char)(65 + j),
                        "Invalid Answer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        // Aendri 4/25/2025
        // Returns true if the given question is valid, otherwise displays error messages and returns false
        private bool VerifyQuestion(String statement)
        {

            // Null or white space check
            if (string.IsNullOrWhiteSpace(statement))
            {
                MessageBox.Show("Question statement cannot be empty!", "Invalid Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Statement is too large check
            if (statement.Length > QUESTION_STATEMENT_MAX_SIZE)
            {
                MessageBox.Show("Question statement is too large! Max is " + QUESTION_STATEMENT_MAX_SIZE, "Invalid Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // ************ EVENTS ************* //
        // Cancel the update/create
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Set the dialog result to Cancel so the parent form knows it was cancled
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Delete the question and answers
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Warn User
            String dialog = "Are you sure you want to delete the following question? \n";
            dialog += "\"" + questionData.ProblemStatement + "\"";

            DialogResult warnResult = MessageBox.Show(dialog, "Remove Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // EXIT if user cancels!
            if (warnResult != DialogResult.OK) { return; }

            // Attendance Form Delete
            if (isFormQuestion)
            {
                DB.DeleteQuestionFromForm(questionData, formID);
            }
            // Question bank Delete
            else
            {
                DB.DeleteQuestionFromBank(questionData);
            }
                
            // Set the dialog result to No so the parent form knows it was deleted
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        // Save changes
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Update data if valid
            if (UpdateQuestionData())
            {
                DB.UpdateQuestion(questionData);
                // Set the dialog result to Yes so the parent form knows it was updated
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }
    }
}
