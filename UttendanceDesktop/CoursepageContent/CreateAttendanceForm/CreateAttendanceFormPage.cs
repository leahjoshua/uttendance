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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UttendanceDesktop.CoursepageContent
{
    public partial class CreateAttendanceFormPage : Form
    {
        //private CreateFormQuestion createQMod = new CreateFormQuestion();
        private List<Question> questions = new List<Question>();
        private List<QuestionUserControl> questionListings = new List<QuestionUserControl>();

        private List<QuestionItem.QuestionItem> questionList = new List<QuestionItem.QuestionItem>();
        private FormDAO DB = new FormDAO();

        public CreateAttendanceFormPage()
        {
            InitializeComponent();
            releaseTimePicker.MinDate = DateTime.Now;
            closeTimePicker.MinDate = DateTime.Now;
            PopulateQuestions();
        }

        // (Updated 4/15/25 by Aendri)
        // Populates the list of question items and displays on the page.
        public void PopulateQuestions()
        {
            flowLayoutPanel.Controls.Clear();
            if (questionList != null)
            {
                for (int i = 0; i < questionList.Count; i++)
                {
                    questionList[i].QuestionNumber = i + 1;
                    flowLayoutPanel.Controls.Add(questionList[i]);
                }
            }

            /*var questionUserControls = createFormPanel.Controls.OfType<QuestionUserControl>().ToList();
            foreach (var control in questionUserControls)
            {
                createFormPanel.Controls.Remove(control);
            }

            // Add questions to page:
            //questionsListingPanel.Controls.Clear();

            for (int i = 0; i < questionList.Count; i++)
            {
                questionList[i].QuestionNumber = i + 1; // Number the questions

                // Set location
                questionList[i].Location = new Point(
                    questionsListingPanel.Location.X,
                    questionsListingPanel.Location.Y + (i * questionList[i].Height)
                );
                createFormPanel.Controls.Add(questionList[i]);
            }*/

            /*var questionUserControls = createFormPanel.Controls.OfType<QuestionUserControl>().ToList();

            foreach (var control in questionUserControls)
            {
                createFormPanel.Controls.Remove(control);
            }

            for (int i = 0; i < questions.Count; i++)
            {
                var questionAdding = new QuestionUserControl(questions[i]);
                questionAdding.QuestionNumberText = i + 1 + " of " + questions.Count;
                questionAdding.Location = new Point(
                    questionsListingPanel.Location.X,
                    questionsListingPanel.Location.Y + (i * questionAdding.Height)
                );

                questionAdding.ChoiceA = "A. " + questions[i].AnswerChoices[0].AnswerStatement;
                questionAdding.ChoiceB = "B. " + questions[i].AnswerChoices[1].AnswerStatement;
                if (questions[i].AnswerChoices.Count >= 3)
                {
                    questionAdding.ChoiceC = "C. " + questions[i].AnswerChoices[2].AnswerStatement;
                }
                if (questions[i].AnswerChoices.Count == 4)
                {
                    questionAdding.ChoiceD = "D. " + questions[i].AnswerChoices[3].AnswerStatement;
                }
                questionAdding.ProblemStatement = questions[i].ProblemStatement;

                createFormPanel.Controls.Add(questionAdding);
            }*/
        }

        // Lee
        // (Updated 4/15/25 by Aendri)
        // Opens the module for adding a new question and saves the question to be displayed
        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            addQuestionBtn.Visible = true;
            importQuestionBtn.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pwdTxtBox.Text))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            var todaysDate = DateTime.Now;
            if (releaseTimePicker.Value < todaysDate || closeTimePicker.Value < todaysDate)
            {
                MessageBox.Show("Dates/Times cannot be in the past.");
                return;
            }

            if (closeTimePicker.Value < closeTimePicker.Value)
            {
                MessageBox.Show("Close time cannot be before Release time.");
                return;
            }

            AttendanceForm newForm = new AttendanceForm
            {
                PassWd = pwdTxtBox.Text,
                ReleaseDateTime = releaseTimePicker.Value,
                CloseDateTime = closeTimePicker.Value,
                CourseNum = GlobalResource.CURRENT_CLASS_ID
            };

            FormDAO formSaver = new FormDAO();
            int FormID = formSaver.SaveForm(newForm);
            if (questions.Count > 0)
            {
                formSaver.SaveQuestions(questions, FormID);
            }
            MessageBox.Show("Attendance Form saved.");
            GlobalResource.COURSEPAGE.loadForm(new AttendanceForms_Listings(GlobalResource.CURRENT_CLASS_ID));
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalResource.COURSEPAGE.loadForm(new AttendanceForms_Listings(GlobalResource.CURRENT_CLASS_ID));
            this.Close();
        }

        private void addQuestionBtn_Click_1(object sender, EventArgs e)
        {
            addQuestionBtn.Visible = false;
            importQuestionBtn.Visible = false;
            using (CreateFormQuestion createQMod = new CreateFormQuestion())
            {
                if (createQMod.ShowDialog() == DialogResult.OK)
                {
                    questions.Add(createQMod.question);

                    questionList.Add(new QuestionItem.QuestionItem(
                        createQMod.questionItem.QuestionValue,
                        createQMod.questionItem.AnswerList
                        ));

                    defaultQuestionsTxt.Visible = false;
                    PopulateQuestions();
                }
            }
        }

        private void importQuestionBtn_Click(object sender, EventArgs e)
        {
            addQuestionBtn.Visible = false;
            importQuestionBtn.Visible = false;
            using (ImportQuestionModal importQMod = new ImportQuestionModal())
            {
                if (importQMod.ShowDialog() == DialogResult.OK)
                {
                   
                }
            }
        }
    }
}
