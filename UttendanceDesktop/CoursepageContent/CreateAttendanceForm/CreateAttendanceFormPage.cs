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

namespace UttendanceDesktop.CoursepageContent
{
    public partial class CreateAttendanceFormPage : Form
    {
        //private CreateFormQuestion createQMod = new CreateFormQuestion();
        private List<Question> questions = new List<Question>();
        private List<QuestionUserControl> questionListings = new List<QuestionUserControl>();

        public CreateAttendanceFormPage()
        {
            InitializeComponent();
            releaseTimePicker.MinDate = DateTime.Now;
            closeTimePicker.MinDate = DateTime.Now;
            PopulateQuestions();
            /*var og = new QuestionUserControl();
            questionsListingPanel.Controls.Add(og);
            var test = new QuestionUserControl();
            test.Location = new Point(
                test.Location.X,
                test.Location.Y + og.Height + 5
            );
            questionsListingPanel.Controls.Add(test);*/
        }
        public void PopulateQuestions()
        {
            var questionUserControls = createFormPanel.Controls.OfType<QuestionUserControl>().ToList();

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
            }
        }

        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            using (CreateFormQuestion createQMod = new CreateFormQuestion())
            {
                if (createQMod.ShowDialog() == DialogResult.OK)
                {
                    questions.Add(createQMod.question);
                    defaultQuestionsTxt.Visible = false;
                    PopulateQuestions();
                }
            }
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
        }
    }
}
