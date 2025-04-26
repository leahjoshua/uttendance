using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UttendanceDesktop.CoursepageContent.Controls.QuestionItem;
using UttendanceDesktop.CoursepageContent.CreateAttendanceForm;
using UttendanceDesktop.CoursepageContent.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UttendanceDesktop.CoursepageContent
{
    public partial class AttendanceForms_Details : Form
    {
        private AttendanceForm formData = new AttendanceForm();
        private QuestionItem.QuestionItem[] questionList;
        private FormDAO DB = new FormDAO();
        private bool isEditMode = false;

        public AttendanceForms_Details()
        {
            InitializeComponent();
        }

        public AttendanceForms_Details(int formID)
        {
            InitializeComponent();
            formData.FormID = formID;

            UpdatePage();
        }

        // Updated 4/16/2025 by Aendri
        // Updates page elements from the database
        private void UpdatePage()
        {
            // Get updated form data:
            formData = DB.GetFormData(formData.FormID);

            // Check for error:
            if (formData.FormID < 0)
            {
                MessageBox.Show("No Attendance Form Data Found!");
                return;
            }

            // Update TITLE
            formTitleLabel.Text =
                formData.ReleaseDateTime.ToString("MM/dd/yy") +
                " Attendance Form (" + formData.ReleaseDateTime.ToString("hh:mm tt") + ")";

            // Update DATE

            // Update SUBMISSION DATA

            // Update Question Bank
            PopulateQuestionList();
        }

        // Aendri 4/16/2025
        // Populates the list of questions
        private void PopulateQuestionList()
        {
            // Get list of Bank Questions
            questionList = DB.GetFormQuestionList(formData.FormID);

            // Add questions to page:
            flowLayoutPanel.Controls.Clear();
            if (questionList != null)
            {
                for (int i = 0; i < questionList.Length; i++)
                {
                    questionList[i].OnClickEdit += new EventHandler(child_question_OnSelectEdit);
                    flowLayoutPanel.Controls.Add(questionList[i]);
                }
            }

        }

        // Aendri 4/17/2025
        // Receive event from child question item when edit is clicked.
        // Open edit question module
        void child_question_OnSelectEdit(object sender, EventArgs e)
        {
            QuestionItem.QuestionItem questionItem = (QuestionItem.QuestionItem)sender;

            // GET ANSWER CHOICES
            List<AnswerChoice> answerChoiceList = new List<AnswerChoice>();
            for (int i = 0; i < questionItem.AnswerList.Length; i++)
            {
                answerChoiceList.Add(new AnswerChoice
                {
                    AnswerID = questionItem.AnswerList[i].AnswerID,
                    isCorrect = questionItem.AnswerList[i].IsCorrect,
                    AnswerStatement = questionItem.AnswerList[i].AnswerValue
                });
            }
            // GET QUESTION DATA
            Question questionData = new Question
            {
                QuestionID = questionItem.QuestionID,
                AnswerChoices = answerChoiceList,
                ProblemStatement = questionItem.QuestionValue
            };

            // OPEN MODAL
            using (EditQuestionModal createBank = new EditQuestionModal(questionData, formData.FormID))
            {
                DialogResult result = createBank.ShowDialog();
                if (result != DialogResult.Cancel)
                {
                    PopulateQuestionList();
                }
            }
        }

        // Aendri 4/18/2025
        // On click...
        // Edit Mode: Enable editing
        // Save Mode: Save changes
        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            // EDIT MODE
            if (isEditMode)
            {
                saveEditBtn.BackColor = GlobalStyle.GREEN;
                saveEditBtn.Text = "Save";
            }
            // SAVE MODE
            else
            {
                saveEditBtn.BackColor = GlobalStyle.BURNT_ORANGE;
                saveEditBtn.Text = "Edit";
            }

            isEditMode = !isEditMode;
        }

        private void pwdTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
